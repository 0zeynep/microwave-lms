﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microwave_v1._0.Forms;
using Microwave_v1._0.Model;

namespace Microwave_v1._0
{
    /* NOTE:
     * Book Info class shows information taken form Book Class's objects to user.
     * It is iherited from C# UserControl class.
     */

    public enum INFO_COLOR_MODE
    {
        NORMAL,ID, NAME, AUTHOR, PUBLISHER, CATEGORY, SHELF, SURNAME, GENDER, EMAIL, AGE
    }

    public partial class Book_Info : UserControl
    {
        private Book_List main_list = null;
        private Book_List search_list = null;
        private Book_Tag main_tag = null;
        private AddBook edit_form = null;
        private Detail detail_form = null;
        private Panel main_panel = null;

        private string description;
        private string name;
        private string author;
        private string pic_path_file;
        private string shelf;
        private string category;
        private int book_id;
        private int shelf_id;
        private bool chosen = false;
        private INFO_COLOR_MODE color_mode;

        public int Book_id { get => book_id; set => book_id = value; }
        public bool Chosen { get => chosen; set => chosen = value; }

        public Book_Info(Book_List main_list, Book_List search_list, Book_Tag main_tag, Panel pnl)
        {
            InitializeComponent();
            this.main_list = main_list;
            this.search_list = search_list;
            this.main_panel = pnl;
            this.main_tag = main_tag;
            if(main_tag == null)
                this.Scale_All();
            this.btn_edit.Hide();
            this.btn_remove.Hide();
        }
        public void Initialize_Book_Info(int book_id, int shelf_id, string name, string author, string publisher, string category, string shelf, string date, int count, string description, string pic_path_file, INFO_COLOR_MODE mode)
        {
            this.book_id = book_id;
            this.shelf_id = shelf_id;
            this.lbl_id.Text = book_id.ToString(); ;
            this.lbl_name.Text = name;
            this.lbl_author.Text = author;
            this.lbl_publisher.Text = publisher;
            this.lbl_category.Text = category;
            this.lbl_shelf.Text = shelf;
            this.lbl_date.Text = date;
            this.lbl_count.Text = count.ToString();
            this.description = description;
            this.author = author;
            this.name = name;
            this.shelf = shelf;
            this.category = category;
            this.pic_path_file = pic_path_file;
            this.color_mode = mode;

            Color new_color = Color.FromArgb(59, 180, 193);

            if(mode == INFO_COLOR_MODE.ID)
                this.pnl_id.BackColor = new_color;
            else if (mode == INFO_COLOR_MODE.NAME)
                this.pnl_name.BackColor = new_color;
            else if (mode == INFO_COLOR_MODE.AUTHOR)
                this.pnl_author.BackColor = new_color;
            else if (mode == INFO_COLOR_MODE.PUBLISHER)
                this.pnl_publisher.BackColor = new_color;
            else if (mode == INFO_COLOR_MODE.CATEGORY)
                this.pnl_category.BackColor = new_color;
            else if (mode == INFO_COLOR_MODE.SHELF)
                this.pnl_shelf.BackColor = new_color;


        }
        public void Draw_Book_Obj(ref int y)
        {
            if(main_tag != null)
            {
                main_panel.Controls.Add(this);
                this.Location = new System.Drawing.Point(0, y);
                y += 45;
            }
            else
            {
                main_panel.Controls.Add(this);
                this.Controls.Remove(btn_edit);
                this.Controls.Remove(btn_remove);
                this.Location = new System.Drawing.Point(-3, y);
                y += 35;
            }

        }
        public void Hide_Info()
        {
            main_panel.Controls.Remove(this);
        }
        private void BookInfo_Click(object sender, MouseEventArgs e)
        {
            main_list.Deselect_All_Infos();
            search_list.Deselect_All_Infos();
            this.Select_Book_Info();
        }
        public void Select_Book_Info()
        {
            chosen = true;
         
            Color back_color = Color.FromArgb(33, 37, 48);
            if(main_tag != null)
                main_tag.Edit_Book_Tag(name, description, author, book_id.ToString());
            this.pnl_author.BackColor = back_color;
            this.pnl_name.BackColor = back_color;
            this.pnl_date.BackColor = back_color;
            this.pnl_count.BackColor = back_color;
            this.pnl_publisher.BackColor = back_color;
            this.pnl_id.BackColor = back_color;
            this.pnl_shelf.BackColor = back_color;
            this.pnl_category.BackColor = back_color;

            Color new_color = Color.FromArgb(4, 137, 152);

            if (color_mode == INFO_COLOR_MODE.ID)
                this.pnl_id.BackColor = new_color;
            else if (color_mode == INFO_COLOR_MODE.NAME)
                this.pnl_name.BackColor = new_color;
            else if (color_mode == INFO_COLOR_MODE.AUTHOR)
                this.pnl_author.BackColor = new_color;
            else if (color_mode == INFO_COLOR_MODE.PUBLISHER)
                this.pnl_publisher.BackColor = new_color;
            else if (color_mode == INFO_COLOR_MODE.CATEGORY)
                this.pnl_category.BackColor = new_color;
            else if (color_mode == INFO_COLOR_MODE.SHELF)
                this.pnl_shelf.BackColor = new_color;

            this.btn_edit.Show();
            this.btn_remove.Show();

        }
        public void Deselect_Book_Info()
        {
            chosen = false;
            Color back_color = System.Drawing.Color.FromArgb(55, 57, 68); // light gray
            this.pnl_author.BackColor = back_color;
            this.pnl_name.BackColor = back_color;
            this.pnl_date.BackColor = back_color;
            this.pnl_count.BackColor = back_color;
            this.pnl_publisher.BackColor = back_color;
            this.pnl_id.BackColor = back_color;
            this.pnl_shelf.BackColor = back_color;
            this.pnl_category.BackColor = back_color;

            Color new_color = Color.FromArgb(59, 180, 193);

            if (color_mode == INFO_COLOR_MODE.ID)
                this.pnl_id.BackColor = new_color;
            else if (color_mode == INFO_COLOR_MODE.NAME)
                this.pnl_name.BackColor = new_color;
            else if (color_mode == INFO_COLOR_MODE.AUTHOR)
                this.pnl_author.BackColor = new_color;
            else if (color_mode == INFO_COLOR_MODE.PUBLISHER)
                this.pnl_publisher.BackColor = new_color;
            else if (color_mode == INFO_COLOR_MODE.CATEGORY)
                this.pnl_category.BackColor = new_color;
            else if (color_mode == INFO_COLOR_MODE.SHELF)
                this.pnl_shelf.BackColor = new_color;

            this.btn_edit.Hide();
            this.btn_remove.Hide();
        }

        private void Btn_edit_Click(object sender, EventArgs e)
        {
            Microwave main_page = (Microwave)Application.OpenForms["Microwave"];
            string message = "Do you want to edit this book?";
            main_page.Create_Warning_Form(message, Color.DarkBlue);
            if (main_page.Warning_form.Result)
                Edit();

            main_page.Warning_form.Refresh_Form();
        }
        private void Btn_remove_Click(object sender, EventArgs e)
        {
            Microwave main_page = (Microwave)Application.OpenForms["Microwave"];
            string message = "Do you want to delete this book?";
            main_page.Create_Warning_Form(message, Color.DarkRed);
            if(main_page.Warning_form.Result)
                Remove();

            main_page.Warning_form.Refresh_Form();

            main_page.Pnl_book_list.VerticalScroll.Value = 0;
            main_page.Book_search_list.Delete_All_List();
            main_page.Main_book_list.Draw_All_Books();
            main_page.Book_searched_already = false;
    }
        public void Remove(bool delete_picture = true)
        {
            Microwave main_page = (Microwave)Application.OpenForms["Microwave"];
            Shelf shelf = main_page.Main_shelf_list.Find_Shelf_By_ID(shelf_id);
            Book current = shelf.Book_list.Find_Book_By_ID(book_id);
            current.Book_shelf_info.Remove();

            main_page.Remove_Image_From_Cover_List(book_id);
            main_page.Book_tag.Edit_Book_Tag("Select A Book to Show", "Select A Book to Show", "", "0");
            main_list.Delete_Book_from_List(book_id, delete_picture);
            this.Dispose();


            main_page.Pnl_book_list.VerticalScroll.Value = 0;
            Book.point_y = 5;
            main_list.Draw_All_Books();
        }
        private void Edit()
        {
            Book current = main_list.Find_Book_By_ID(book_id);
            // Don't delete the picture from file
            Create_Add_Book_Form_With_Book(current);
        }


        private void Create_Add_Book_Form_With_Book(Book book)
        {
            
            if(edit_form == null)
            {
                edit_form = new AddBook(book);
                edit_form.Show();
            }
            else
            {
                try
                {
                    edit_form.Show();
                }
                catch(Exception)
                {
                    edit_form = new AddBook(book);
                    edit_form.Show();
                }
            }
        }
        private void Create_Book_Detail_Form(Book book)
        {

            if (detail_form == null)
            {
                detail_form = new Detail(book);
                detail_form.Show();
            }
            else
            {
                try
                {
                    detail_form.Show();
                }
                catch (Exception)
                {
                    detail_form = new Detail(book);
                    detail_form.Show();
                }
            }
        }

        public void Scale_All()
        {
            SizeF s_gen = new SizeF();
            s_gen.Width = (float)0.8;
            s_gen.Height = (float)0.8;

            this.Scale(s_gen);
            this.lbl_id.Font = new Font("Microsof Sans Serif", 7);
            this.lbl_name.Font = new Font("Microsof Sans Serif", 7);
            this.lbl_author.Font = new Font("Microsof Sans Serif", 7);
            this.lbl_publisher.Font = new Font("Microsof Sans Serif", 7);
            this.lbl_category.Font = new Font("Microsof Sans Serif", 7);
            this.lbl_shelf.Font = new Font("Microsof Sans Serif", 7);
            this.lbl_date.Font = new Font("Microsof Sans Serif", 7);
            this.lbl_count.Font = new Font("Microsof Sans Serif", 7);
            this.btn_edit.Visible = false;
            this.btn_remove.Visible = false;
        }


        // CHANGE!!!
        public void Hover()
        {
            if (!chosen)
            {
                Color back_color = Color.FromArgb(43, 47, 58);

                this.pnl_author.BackColor = back_color;
                this.pnl_name.BackColor = back_color;
                this.pnl_date.BackColor = back_color;
                this.pnl_count.BackColor = back_color;
                this.pnl_publisher.BackColor = back_color;
                this.pnl_id.BackColor = back_color;
                this.pnl_shelf.BackColor = back_color;
                this.pnl_category.BackColor = back_color;

                Color new_color = Color.FromArgb(49,170,183);

                if (color_mode == INFO_COLOR_MODE.ID)
                    this.pnl_id.BackColor = new_color;
                else if (color_mode == INFO_COLOR_MODE.NAME)
                    this.pnl_name.BackColor = new_color;
                else if (color_mode == INFO_COLOR_MODE.AUTHOR)
                    this.pnl_author.BackColor = new_color;
                else if (color_mode == INFO_COLOR_MODE.PUBLISHER)
                    this.pnl_publisher.BackColor = new_color;
                else if (color_mode == INFO_COLOR_MODE.CATEGORY)
                    this.pnl_category.BackColor = new_color;
                else if (color_mode == INFO_COLOR_MODE.SHELF)
                    this.pnl_shelf.BackColor = new_color;

            }
        }
        private void Book_Info_Enter(object sender, EventArgs e)
        {
            Hover();
        }
        public void Mouse_Leave()
        {
            if (!chosen)
            {
                Color back_color = System.Drawing.Color.FromArgb(55, 57, 68); // light gray
                this.pnl_author.BackColor = back_color;
                this.pnl_name.BackColor = back_color;
                this.pnl_date.BackColor = back_color;
                this.pnl_count.BackColor = back_color;
                this.pnl_publisher.BackColor = back_color;
                this.pnl_id.BackColor = back_color;
                this.pnl_shelf.BackColor = back_color;
                this.pnl_category.BackColor = back_color;

                Color new_color = Color.FromArgb(59, 180, 193);

                if (color_mode == INFO_COLOR_MODE.ID)
                    this.pnl_id.BackColor = new_color;
                else if (color_mode == INFO_COLOR_MODE.NAME)
                    this.pnl_name.BackColor = new_color;
                else if (color_mode == INFO_COLOR_MODE.AUTHOR)
                    this.pnl_author.BackColor = new_color;
                else if (color_mode == INFO_COLOR_MODE.PUBLISHER)
                    this.pnl_publisher.BackColor = new_color;
                else if (color_mode == INFO_COLOR_MODE.CATEGORY)
                    this.pnl_category.BackColor = new_color;
                else if (color_mode == INFO_COLOR_MODE.SHELF)
                    this.pnl_shelf.BackColor = new_color;

            }
        }
        private void BookInfo_MouseLeave(object sender, EventArgs e)
        {
            Mouse_Leave();
        }
        private void Book_Info_DoubleClick(object sender, EventArgs e)
        {
            Book current = main_list.Find_Book_By_ID(book_id);
            Create_Book_Detail_Form(current);

        }
    }
}
