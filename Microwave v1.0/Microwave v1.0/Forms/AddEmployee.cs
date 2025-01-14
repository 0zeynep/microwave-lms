﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SQLite;
using Microwave_v1._0.Classes;
using Microwave_v1._0.Model;
using Microwave_v1._0.Forms;
using Microwave_v1._0.UserControls;
using Microwave_v1._0.Properties;
using System.Configuration;

namespace Microwave_v1._0.Forms
{
    public partial class AddEmployee : Form
    {
        private string name;
        private string surname;
        private string email;
        private string gender;
        private string password;
        private int department_id;
        Microwave_v1._0.Forms.ShowEmployee main_page;

        Picture_Events picture_event;
        private string picture_default_file = ConfigurationManager.AppSettings["def_em_path"];
        private string pic_dest_path = ConfigurationManager.AppSettings["em_dest_path"];
        private string pic_new_source_path = "";

        private string datasource = ConfigurationManager.AppSettings["data_source"];

        private bool is_edit = false;
        private bool change_image = false;
        private Employee employee_to_edit = null;

        public AddEmployee(Department dprt)
        {
            InitializeComponent();

            rdo_female.Checked = true;
            main_page = (Microwave_v1._0.Forms.ShowEmployee)Application.OpenForms["ShowEmployee"];
            System.IO.Directory.CreateDirectory(pic_dest_path);
            picture_event = new Picture_Events(pic_dest_path, picture_default_file, ref this.pic_employee);
            pic_new_source_path = picture_event.Pic_source_file;
            this.lbl_message.Text = "";

            Fill_Comboboxes();


            if (dprt != null)
            {
                this.cb_department.SelectedIndex = cb_department.Items.IndexOf(dprt.Name);
                this.cb_department.Enabled = false;
            }
            else
            {
                this.cb_department.SelectedIndex = 0;
                this.cb_department.Enabled = true;
            }

            this.BringToFront();
        }
        public AddEmployee(Employee employee)
        {
            InitializeComponent();



            main_page = (Microwave_v1._0.Forms.ShowEmployee)Application.OpenForms["ShowEmployee"];
            System.IO.Directory.CreateDirectory(pic_dest_path);
            picture_event = new Picture_Events(pic_dest_path, picture_default_file, ref this.pic_employee);
            this.lbl_message.Text = "";

            employee_to_edit = employee;


            Fill_Comboboxes();

            this.cb_department.SelectedIndex = this.cb_department.Items.IndexOf(employee.Deparment_name);

            this.tb_name.Text = employee.Name;
            this.tb_name.ForeColor = Color.LightGray;
            this.tb_surname.Text = employee.Surname;
            this.tb_surname.ForeColor = Color.LightGray;
            this.tb_email.Text = employee.Email;
            this.tb_email.ForeColor = Color.LightGray;
            this.dtp_time.Value = employee.Birth_date_dt;

            if (employee.Gender == "Female")
            {
                rdo_female.Checked = true;
            }
            else
            {
                rdo_male.Checked = true;
            }




            pic_new_source_path = picture_event.Pic_source_file = employee.Cover_path_file;
            pic_employee.Image = Picture_Events.Get_Copy_Image_Bitmap(pic_new_source_path);

            is_edit = true;

            this.BringToFront();



        }
        private void Add_Click_Func(bool is_edit)
        {
            name = tb_name.Text.Replace('\'', ' ');
            surname = tb_surname.Text;
            email = tb_email.Text;

            department_id = int.Parse(cb_department.SelectedIndex.ToString());
            password = Generate_Auto_Password();


            lbl_message.Text = "";


            if (tb_name.Text.Trim() == "Employee's Name" || tb_name.Text.Trim() == "")
            {
                lbl_message.Text = "* Please enter name.";
                lbl_message.ForeColor = Color.Red;
                tb_name.Focus();
                return;
            }
            if (tb_surname.Text.Trim() == "Employee's Surname" || tb_surname.Text.Trim() == "")
            {
                lbl_message.Text = "* Please enter surname.";
                lbl_message.ForeColor = Color.Red;
                tb_surname.Focus();
                return;
            }
            if (tb_email.Text.Trim() == "Employee's E-mail" || tb_email.Text.Trim() == "")
            {
                lbl_message.Text = "* Please enter e-mail.";
                lbl_message.ForeColor = Color.Red;
                tb_name.Focus();
                return;
            }
            if (!is_a_valid_email(email))
                return;

            if (rdo_male.Checked)
            {
                gender = "Male";
            }
            else if (rdo_female.Checked)
            {
                gender = "Female";
            }
            else
            {
                lbl_message.Text = "*Please select gender";
                lbl_message.ForeColor = Color.Red;
                return;
            }


            if (is_edit == false)
            {
                if (picture_event.Pic_source_file != null && picture_event.Pic_source_file != picture_default_file)
                {
                    picture_event.Copy_The_Picture(name);
                    pic_new_source_path = picture_event.Pic_source_file;
                }
                else
                    pic_new_source_path = picture_default_file;


                if(Employee.Contains_Email(email) != -1)
                {
                    lbl_message.Text = "*That email is used by another employee";
                    lbl_message.ForeColor = Color.Red;
                    return;
                }


                lbl_message.Text = "*Employee added successfully";
                lbl_message.ForeColor = Color.Green;

                Employee employee = new Employee(0, department_id, name, surname, password, email, gender, dtp_time.Value, pic_new_source_path);
                employee.Add();



                Clear();
            }
            else
            {

                if(Employee.Contains_Email(email) != employee_to_edit.Employee_id && Employee.Contains_Email(email) != -1)
                {
                    lbl_message.Text = "*That email is used by another employee";
                    lbl_message.ForeColor = Color.Red;
                    return;
                }

                if (change_image)
                {
                    if (employee_to_edit.Cover_path_file != picture_default_file)
                        Picture_Events.Delete_The_Picture(employee_to_edit.Cover_path_file);

                    picture_event.Copy_The_Picture(name);
                    pic_new_source_path = picture_event.Pic_source_file;
                    change_image = false;
                }

                lbl_message.Text = "*Employee changed successfully";
                lbl_message.ForeColor = Color.LightGreen;

                employee_to_edit.Name = name;
                employee_to_edit.Surname = surname;
                employee_to_edit.Gender = gender;
                employee_to_edit.Email = email;
                employee_to_edit.Department_id = department_id;
                employee_to_edit.Cover_path_file = picture_event.Pic_source_file;
                employee_to_edit.Birth_date_dt = dtp_time.Value;

                employee_to_edit.Edit();

                main_page.Pnl_employee_list.VerticalScroll.Value = 0;
                main_page.Main_employee_list.Delete_All_List();
                Employee.Show_All_Employees(main_page.Department);
                main_page.Main_tag.lbl_author.Text = " ";
                main_page.Main_tag.lbl_bookname.Text = " ";
                main_page.Main_tag.pic_book.Visible = false;
                main_page.Main_tag.lbl_description.Text = " ";

            }
        }

        public void Clear()
        {
            this.cb_department.SelectedIndex = 0;
            this.cb_department.ForeColor = Color.Gray;
            tb_name.Text = "Employee's Name";
            tb_surname.Text = "Employee's Surname";
            tb_email.Text = "Employee's E-mail";
            tb_name.ForeColor = Color.Gray;
            tb_surname.ForeColor = Color.Gray;
            tb_email.ForeColor = Color.Gray;

        }

        private void Fill_Comboboxes()
        {
            SQLiteConnection con = new SQLiteConnection(datasource);
            SQLiteCommand cmd = null;
            SQLiteDataReader reader = null;
            string query = "";

            con.Open();
            query = string.Format("SELECT Department.NAME FROM Department");
            cmd = new SQLiteCommand(query, con);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                cb_department.Items.Add(reader.GetString(0));
            }
            cmd.Dispose();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            Add_Click_Func(is_edit);
        }

        private void btn_add_pic_Click(object sender, EventArgs e)
        {
            change_image = true;
            picture_event.Choose_Image();
        }
        private bool is_a_valid_email(string email)
        {
            string[] invalid_ends = { ".", "_", "-", "!", "\"", "é", "'", "^", "+", "%",
                                       "&", "/", "(", ")",  "=", "?", ",", ";", ":", "<",
                                       ">", "|", "`", "#",  "$", "½", "{", "}", "[", "]",
                                       "\\", "ç", "Ç", "~", "ş", "Ş", "ğ", "Ğ", "İ", "ü",
                                       "Ü" , "ö", "Ö", "ı", "æ", "ß", "´", "₺", "€", "@",
                                        " "};

            string[] invalid_chars = { "!", "\"", "é","^", "+", "%","&", "/", "(", ")",
                                       "=", "?", ",", ";", ":", "<",">", "|", "`", "#",
                                       "$", "½", "{", "}", "[", "]","\\","ç", "Ç", "~",
                                       "ş", "Ş", "ğ", "Ğ", "İ", "ü","Ü" ,"ö", "Ö", "ı",
                                       "æ", "ß", "´", "₺", "€", "@", " "};

            string[] invalid_chars_all = {"_", "-", "!", "\"", "é", "'", "^", "+", "%",
                                            "&", "/", "(", ")",  "=", "?", ",", ";", ":", "<",
                                         ">", "|", "`", "#",  "$", "½", "{", "}", "[", "]",
                                         "\\", "ç", "Ç", "~", "ş", "Ş", "ğ", "Ğ", "İ", "ü",
                                         "Ü" , "ö", "Ö", "ı", "æ", "ß", "´", "₺", "€", "@",
                                        " "};

            string message = "Please enter a valid email.";
            lbl_message.ForeColor = Color.Red;
            int index_of_at = email.IndexOf('@');

            // Checking for '@'
            if (index_of_at == -1)
            {
                lbl_message.Text = message;
                return false;
            }

            // Substringing email
            string head_email = email.Substring(0, index_of_at);
            string tail_email = email.Substring(index_of_at + 1, email.Length - index_of_at - 1);

            // Checking for invalid chars
            for (int i = 0; i < invalid_chars.Length; i++)
            {
                if (!(head_email.IndexOf(invalid_chars[i]) == -1))
                {
                    lbl_message.Text = message;
                    return false;
                }
            }
            // Checking for invalid end
            if (head_email.EndsWith("."))
            {
                lbl_message.Text = message;
                return false;
            }


            // Checking for '.' after '@'
            bool contains_dot = false;
            int[] indexes_of_dots = new int[20];

            int j = 0;
            for (int i = 0; i < tail_email.Length; i++)
            {
                if (tail_email[i] == '.')
                {
                    indexes_of_dots[j] = i;
                    j++;
                }
            }


            // Checking for if the dots are next to each other
            for (int i = 1; i < indexes_of_dots.Length; i++)
            {
                int a = indexes_of_dots[i - 1];
                int b = indexes_of_dots[i];

                if (b - a == 1)
                {
                    lbl_message.Text = message;
                    return false;
                }
            }

            // Checking for if there is a dot or starts with dot
            if (indexes_of_dots[0] == 0)
            {
                contains_dot = false;
            }
            else
                contains_dot = true;

            if (!contains_dot)
            {
                lbl_message.Text = message;
                return false;
            }

            // Checking for invalid chars - tail email - after dot
            for (int i = 0; i < invalid_chars.Length; i++)
            {
                if (!(tail_email.IndexOf(invalid_chars_all[i]) == -1))
                {
                    lbl_message.Text = message;
                    return false;
                }
            }
            // Checking for invalid ends
            for (int i = 0; i < invalid_ends.Length; i++)
            {
                if (tail_email.EndsWith(invalid_ends[i]))
                {
                    lbl_message.Text = message;
                    return false;
                }
            }

            return true;

        }
        private string Generate_Auto_Password()
        {
            Random r = new Random();

            string pass = "";
            pass += (char)r.Next(65, 90);
            pass += (char)r.Next(97, 122);
            pass += (char)r.Next(65, 90);
            pass += (char)r.Next(97, 122);
            pass += r.Next(1001, 9998);


            return pass;
        }

        private void AddEmployee_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                Add_Click_Func(is_edit);
            }

        }

        private void AddEmployee_FormClosed(object sender, FormClosedEventArgs e)
        {
            main_page.Btn_add.Enabled = true;
        }

        private void AddEmployee_FormClosing(object sender, FormClosingEventArgs e)
        {
            main_page.Btn_add.Enabled = true;
        }

        private void tb_name_Enter(object sender, EventArgs e)
        {
            if (tb_name.Text == "Name")
            {
                tb_name.Text = "";
                tb_name.ForeColor = Color.LightGray;
            }
        }

        private void tb_name_Leave(object sender, EventArgs e)
        {
            if (tb_name.Text == "")
            {
                tb_name.Text = "Name";
                tb_name.ForeColor = Color.DimGray;
            }
        }

        private void tb_surname_Enter(object sender, EventArgs e)
        {
            if (tb_surname.Text == "Surname")
            {
                tb_surname.Text = "";
                tb_surname.ForeColor = Color.LightGray;
            }
        }

        private void tb_surname_Leave(object sender, EventArgs e)
        {
            if (tb_surname.Text == "")
            {
                tb_surname.Text = "Surname";
                tb_surname.ForeColor = Color.DimGray;
            }
        }

        private void tb_email_Enter(object sender, EventArgs e)
        {
            if (tb_email.Text == "Employee's E-mail")
            {
                tb_email.Text = "";
                tb_email.ForeColor = Color.LightGray;
            }
        }

        private void tb_email_Leave(object sender, EventArgs e)
        {
            if (tb_email.Text == "")
            {
                tb_email.Text = "Employee's E-mail";
                tb_email.ForeColor = Color.DimGray;
            }
        }
    }
}
