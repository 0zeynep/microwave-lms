﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Windows.Forms;
using Microwave_v1._0.Classes;
using System.Data;
using Microwave_v1._0.Model;

namespace Microwave_v1._0
{
    public class User
    {

        private int user_id;
        private string name;
        private string surname;
        private string gender;
        private string password;
        private string email;
        private string date;
        private int book_count;
        private int age;
        private int fee;
        private UserInfo info;

        public static int point_y = 5;
        static private Microwave main_page = null;
        private static string data_source = System.Configuration.ConfigurationManager.AppSettings["data_source"];


        // Getters and setters
        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public string Gender { get => gender; set => gender = value; }
        public int Age { get => age; set => age = value; }
        public string Email { get => email; set => email = value; }
        public int User_id { get => user_id; set => user_id = value; }
        public string Date { get => date; set => date = value; }
        public UserInfo Info { get => info; set => info = value; }
        public string Password { get => password; set => password = value; }
        public int Book_count { get => book_count; set => book_count = value; }
        public int Fee { get => fee; set => fee = value; }

        // Constructors

        public User()
        {

        }

        public User(int user_id, string name, string surname, string gender, int age, string email, string password, string date, int fee)
        {
            main_page = (Microwave)Application.OpenForms["Microwave"];
            this.user_id = user_id;
            this.name = name;
            this.surname = surname;
            this.gender = gender;
            this.age = age;
            this.email = email;
            this.password = password;
            this.date = date;
            this.fee = fee;
        }


        // Methods
        public void Add()
        {
            string title  = "Insert Into Users(NAME, SURNAME, GENDER, AGE, EMAIL, PASSWORD, DATE, FEE) ";
            string values = string.Format("Values('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}')", name, surname, gender, age, email, password, date, fee);
            string query = string.Concat(title, values);

            int result = DataBaseEvents.ExecuteNonQuery(query, data_source);
            
            if(result <= 0)
            {
                MessageBox.Show("Invalid insertion event");
                return;
            }

            info = new UserInfo();
            Take_Id_From_Database();
            info.Initialize_User_Info(user_id, name, surname, gender, age, email, date, INFO_COLOR_MODE.NORMAL);
            main_page.Main_user_list.Add_User_to_List(this);
            main_page.Pnl_user_list.VerticalScroll.Value = 0;
            info.Draw_User_Obj(ref User.point_y);
            info.Select_User_Info();

        }
        public void Edit()
        {
            string title = "Update Users ";
            string query = title + string.Format("Set NAME = '{0}', SURNAME = '{1}', GENDER = '{2}', " +
                "AGE = '{3}', EMAIL = '{4}' Where Users.USER_ID = '{5}'", name, surname, gender, age, email, user_id);

            int result = DataBaseEvents.ExecuteNonQuery(query, data_source);
            if(result <= 0)
            {
                MessageBox.Show("Invalid update event");
                return;
            }

            info.Initialize_User_Info(user_id, name, surname, gender, age, email, date, INFO_COLOR_MODE.NORMAL);
            info.Select_User_Info();
        }
        public void Delete()
        {
            string query;
            int result;

            query = "Delete From Receipt Where Receipt.USER_ID = " + user_id;
            result = DataBaseEvents.ExecuteNonQuery(query, data_source);
            if (result <= 0)
            {
                MessageBox.Show("Invalid delete operation");
                return;
            }

            main_page.Main_receipt_list.Delete_All_List();
            Receipt.Show_All_Receipts(main_page);

            query = "Delete From Book_User Where Book_User.USER_ID = " + user_id;
            result = DataBaseEvents.ExecuteNonQuery(query, data_source);
            if (result <= 0)
            {
                MessageBox.Show("Invalid delete operation");
                return;
            }

            query = "Delete From Users Where USER_ID = " + user_id;

            result = DataBaseEvents.ExecuteNonQuery(query, data_source);
            if(result <= 0)
            {
                MessageBox.Show("Invalid delete event");
                return;
            }

            return;
        }
        public static void Show_All_Users(Microwave main_page)
        {
            string query = "Select * From Users ";
            DataTable dt = DataBaseEvents.ExecuteQuery(query, data_source);

            main_page.Main_user_list.Fill_User_List(dt, INFO_COLOR_MODE.NORMAL);
            main_page.Main_user_list.Draw_All_Users();
        }
        public static DataTable Show_All_Users(Book book)
        {
            string query = "Select Users.USER_ID As ID, Users.NAME As Name, " +
                           "Users.SURNAME As Surname, Users.GENDER As Gender, Users.AGE As Age," +
                           " Users.EMAIL As Email, Users.DATE As Date From Book_User " +
                           "Join Users On Book_User.USER_ID = Users.USER_ID Where Book_User.BOOK_ID = " + book.Book_id;

            return DataBaseEvents.ExecuteQuery(query, data_source);
        }
        public void Set_Book(INFO_COLOR_MODE color_mode)
        {
            info = new UserInfo();
            info.Initialize_User_Info(user_id, name, surname, gender, age, email, date, color_mode);
        }
        public void Give_Book_Back(Book book)
        {     
            string query_select = string.Format("Select Book_User.COUNT From Book_User Where Book_User.BOOK_ID = {0} and Book_User.USER_ID = {1}", book.Book_id, this.User_id);
            DataTable dt = DataBaseEvents.ExecuteQuery(query_select, data_source);

            if (dt.Rows.Count <= 0)
                return;

            int current_count = int.Parse(dt.Rows[0][0].ToString());
            if ( current_count > 1)
            {
                current_count--;
                string query_update = string.Format("Update Book_User Set COUNT = {0} Where Book_User.BOOK_ID = {1} and Book_User.USER_ID = {2}", current_count, book.Book_id, this.user_id);
                DataBaseEvents.ExecuteNonQuery(query_update, data_source);
            }
            else
            {
                string query_delete = string.Format("Delete From Book_User Where Book_User.BOOK_ID = {0} and Book_User.USER_ID = {1}", book.Book_id, this.user_id);
                DataBaseEvents.ExecuteNonQuery(query_delete, data_source);
            }

            Book exact = main_page.Main_book_list.Find_Book_By_ID(book.Book_id);
            exact.Count++;
            exact.Change_Count();

            book.Count--;
            Receipt receipt = new Informer(0, book.Book_id, this.user_id, main_page.Manager.Employee_id, "RETURN", MODE.RETURN);
            receipt.Add();
        }

        public void Change_Fee()
        {
            string query = string.Format("Update Users Set FEE = '{0}' Where Users.USER_ID = '{1}'", fee, user_id);
            DataBaseEvents.ExecuteNonQuery(query, data_source);
        }

        public DataTable Show_All_Penalties()
        {
            string query = string.Format("Select Receipt.RECEIPT_ID As 'Penalty ID', Books.NAME As 'Book', Receipt.PENALTY_NAME As 'Penalty',Receipt.FEE As 'Fee', Receipt.CREATION_DATE As 'Date' " +
                           "From Receipt Join Books On Receipt.BOOK_ID = Books.BOOK_ID Where Receipt.USER_ID = '{0}' and Receipt.NAME = 'PENALTY'", this.user_id);

            return DataBaseEvents.ExecuteQuery(query, data_source);
        }


        static public DataTable Search_User_By_Name(string name)
        {
            string query = string.Format("Select * From Users Where Users.NAME Like '{0}%'", name);
            DataTable dt = DataBaseEvents.ExecuteQuery(query, data_source);
            return dt;
        }
        static public DataTable Search_User_By_Surname(string surname)
        {
            string query = string.Format("Select * From Users Where Users.SURNAME Like '{0}%'", surname);
            DataTable dt = DataBaseEvents.ExecuteQuery(query, data_source);
            return dt;
        }
        static public DataTable Search_User_By_ID(string id)
        {
            string query = string.Format("Select * From Users Where Users.USER_ID Like '{0}%'", id);
            DataTable dt = DataBaseEvents.ExecuteQuery(query, data_source);
            return dt;
        }
        static public DataTable Search_User_By_Email(string email)
        {
            string query = string.Format("Select * From Users Where Users.EMAIL Like '{0}%'", email);
            DataTable dt = DataBaseEvents.ExecuteQuery(query, data_source);
            return dt;

        }
        static public DataTable Search_User_By_Age(string age)
        {
            string query = string.Format("Select * From Users Where Users.AGE Like '{0}%'", age);
            DataTable dt = DataBaseEvents.ExecuteQuery(query, data_source);
            return dt;
        }
        static public DataTable Search_User_By_Gender(string gender)
        {
            string query = string.Format("Select * From Users Where Users.GENDER Like '{0}%'", gender);
            DataTable dt = DataBaseEvents.ExecuteQuery(query, data_source);
            return dt;
        }

        public static int Contains_Email(string email)
        {
            string query = string.Format("Select Users.USER_ID From Users Where Users.EMAIL = '{0}'", email);
            DataTable dt = DataBaseEvents.ExecuteQuery(query, data_source);

            if (dt.Rows.Count <= 0)
                return -1;

            int id = int.Parse(dt.Rows[0][0].ToString());

            return id;
        }

        // Background Database Events
        private void Take_Id_From_Database()
        {
            string title = "Select Users.USER_ID from Users ";
            string query = title + string.Format("Where Users.NAME = '{0}' and Users.SURNAME = '{1}' and Users.EMAIL = '{2}'", name, surname, email);

            DataTable dt = DataBaseEvents.ExecuteQuery(query, data_source);

            int id = int.Parse(dt.Rows[0][0].ToString());
            this.user_id = id;
            this.info.User_id = id;
        }
    }
}
