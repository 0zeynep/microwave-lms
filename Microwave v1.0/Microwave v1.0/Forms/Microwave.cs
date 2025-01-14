﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Threading;
using Microwave_v1._0.Forms;
using Microwave_v1._0.Classes;
using Microwave_v1._0.Model;

/*
 NOT:
 -Microwave class'ı C#'ın Form Classından inherit edilmiş bir class'tır. Programımızın ana formu bu classtır.
 -Bu Class'ta Book List classından programda kullanılacak olan kitapların tutulduğu Main List object yaratılır.
 ve Program çalışırken liste üzerinde yapılacak bütün değişiklikler main listi etkiler.
 -diğer classlardan listeyi düzenlemek isteyen bütün fonksiyonlar bu forma ve formun main listine ulaşmak
 zorundadır.
 -Ayrıca, Listedeki kitaplar hakkında bilgilerin gösterildiği Book Tag classından main_tag isimli obje oluşturulup
 seçilen kitabın bilgilerine göre bu obje düzenlenmektedir.
 -Kitap ekleneceği zaman,Kitap bilgilerinin girileceği AddBook Form Classından add_book objesi de bu classın içersinde 
 tutulmaktadır 

   /* Microwave class is inherited from C# Form Class. The main form of program is formed from this class. 
    In this class, Main List object will be created from the books which will be going to use in program 
    from Book List class.
    when


 */

namespace Microwave_v1._0
{
    public enum MENU_CHOSEN
    {
        HOME = 0, BOOKS, USERS, AUTHOR, PUBLISHER, DEPARTMENT, RECEIPTS, SHELF, CATEGORY, ABOUT_US
    }
    public partial class Microwave : Form
    {
        // Variables 
        private SystemManager manager = null;

        private Warning warning_form = null;
        private AddBook add_book = null;
        private AddUser add_user = null;
        private AddAuthor add_author = null;
        private AddPublisher add_publisher = null;
        private AddDepartment add_department = null;
        private AddCategory add_category = null;
        private ShowEmployee show_employee = null;
        private AboutUs about_us = null;
        private Popularity_Form pop_form = null;
        private Detail profile_form = null;
        
        private Book_List main_book_list = null;
        private User_List main_user_list = null;
        private Author_List main_author_list = null;
        private Publisher_List main_pub_list = null;
        private Department_List main_department_list = null;
        private Receipt_List main_receipt_list = null;
        private Shelf_List main_shelf_list = null;
        private Category_List main_category_list = null;

        private Book_Tag main_tag = null;



        private string data_source = System.Configuration.ConfigurationManager.AppSettings["data_source"];
        private string path_file = System.Configuration.ConfigurationManager.AppSettings["def_bk_path"];

        MENU_CHOSEN chosen = MENU_CHOSEN.HOME;

        // Searching stuff
        private Book_List book_search_list = null;
        private bool book_searched_already = false;
        private User_List user_search_list = null;
        private bool user_searched_already = false;
        private Publisher_List publisher_search_list = null;
        private bool publisher_searched_already = false;
        private Author_List author_search_list = null;
        private bool author_searched_already = false;
        private Receipt_List receipt_search_list = null;
        private bool receipt_searched_already = false;
        private Category_List category_search_list = null;
        private bool category_searched_already = false;

        private Dictionary<string, int> penalty_types;

        // Getters and Setters
        public Warning Warning_form { get => warning_form; set => warning_form = value; }
        public AddBook Add_book { get => add_book; set => add_book = value; }
        public AddUser Add_user { get => add_user; set => add_user = value; }
        public AddAuthor Add_author { get => add_author; set => add_author = value; }
        public AddPublisher Add_publisher { get => add_publisher; set => add_publisher = value; }
        public AddDepartment Add_department { get => add_department; set => add_department = value; }
        public ShowEmployee Show_employee { get => show_employee; set => show_employee = value; }

        
        public Book_List Main_book_list { get => main_book_list; set => main_book_list = value; }
        public User_List Main_user_list { get => main_user_list; set => main_user_list = value; }
        public Author_List Main_author_list { get => main_author_list; set => main_author_list = value; }
        public Publisher_List Main_pub_list { get => main_pub_list; set => main_pub_list = value; }
        public Department_List Main_department_list { get => main_department_list; set => main_department_list = value; }
        
        public Book_Tag Book_tag { get => main_tag; set => main_tag = value; }
        public string Path_file { get => path_file; set => path_file = value; }
        public Book_List Book_search_list { get => book_search_list; set => book_search_list = value; }


        public bool Book_searched_already { get => book_searched_already; set => book_searched_already = value; }
        public User_List User_search_list { get => user_search_list; set => user_search_list = value; }
        public bool User_searched_already { get => user_searched_already; set => user_searched_already = value; }
        public bool Publisher_searched_already { get => publisher_searched_already; set => publisher_searched_already = value; }
        public Publisher_List Publisher_search_list { get => publisher_search_list; set => publisher_search_list = value; }
        public bool Author_searched_already { get => author_searched_already; set => author_searched_already = value; }
        public Author_List Author_search_list { get => author_search_list; set => author_search_list = value; }
        public Receipt_List Main_receipt_list { get => main_receipt_list; set => main_receipt_list = value; }
        public Receipt_List Receipt_search_list { get => receipt_search_list; set => receipt_search_list = value; }
        public bool Receipt_searched_already { get => receipt_searched_already; set => receipt_searched_already = value; }
        public Shelf_List Main_shelf_list { get => main_shelf_list; set => main_shelf_list = value; }
        public Category_List Category_search_list { get => category_search_list; set => category_search_list = value; }
        public bool Category_searched_already { get => category_searched_already; set => category_searched_already = value; }
        public AddCategory Add_category { get => add_category; set => add_category = value; }
        public Category_List Main_category_list { get => main_category_list; set => main_category_list = value; }
        public SystemManager Manager { get => manager; set => manager = value; }
        public AboutUs About_us { get => about_us; set => about_us = value; }
        public Popularity_Form Pop_form { get => pop_form; set => pop_form = value; }
        public Dictionary<string, int> Penalty_types { get => penalty_types; set => penalty_types = value; }
        public Detail Profile_form { get => profile_form; set => profile_form = value; }


        // Booleans
        private bool show_pnl_book_st   = false;
        private bool show_pnl_user_st   = false;
        private bool show_pnl_author_st = false;
        private bool show_pnl_pub_st    = false;
        private bool show_pnl_rcpt_st   = false;

        // Constructor
        public Microwave(SystemManager manager)
        {
            InitializeComponent();

            this.manager = manager;

            main_tag = new Book_Tag();
            main_book_list = new Book_List();
            main_department_list = new Department_List();
            main_user_list = new User_List();
            main_pub_list = new Publisher_List();
            main_author_list = new Author_List();
            main_receipt_list = new Receipt_List();
            main_shelf_list = new Shelf_List();
            main_category_list = new Category_List();


            // Searching
            book_search_list = new Book_List();
            user_search_list = new User_List();
            publisher_search_list = new Publisher_List();
            author_search_list = new Author_List();
            receipt_search_list = new Receipt_List();
            category_search_list = new Category_List();


            pnl_home.Show();
            pnl_tag.Hide();
            pnl_book.Hide();
            pnl_user.Hide();
            pnl_authors.Hide();
            pnl_pub.Hide();
            pnl_department.Hide();
            pnl_receipt.Hide();
            pnl_shelf.Hide();
            pnl_categories.Hide();
       
            btn_show_search_types.Hide();


            tb_search_book.Hide();
            tb_search_user.Hide();
            tb_search_author.Hide();
            tb_search_publisher.Hide();
            tb_search_receipt.Hide();
            tb_search_category.Hide();
            btn_show_search_types.Hide();
            
            // Book search
            pnl_book_st.Hide();
            lb_book_search.Hide();
            rb_book_name.Checked = true;
            tb_search_book.Text = "Search a book";
            tb_search_book.ForeColor = Color.Gray;

            // User search
            pnl_user_st.Hide();
            lb_user_search.Hide();
            rb_user_name.Checked = true;
            tb_search_user.Text = "Search a user";
            tb_search_user.ForeColor = Color.Gray;

            // Publisher search
            pnl_publisher_st.Hide();
            lb_publisher_search.Hide();
            rb_pub_name.Checked = true;
            tb_search_publisher.Text = "Search a publisher";
            tb_search_publisher.ForeColor = Color.Gray;

            // Author search
            pnl_author_st.Hide();
            lb_author_search.Hide();
            rb_author_name.Checked = true;
            tb_search_author.Text = "Search an author";
            tb_search_author.ForeColor = Color.Gray;

            // Receipt search
            pnl_receipt_st.Hide();
            lb_receipt_search.Hide();
            rb_receipt_name.Checked = true;
            tb_search_receipt.Text = "Search a receipt";
            tb_search_receipt.ForeColor = Color.Gray;


            // Category search

            lb_category_search.Hide();
            tb_search_category.Text = "Search a category";
            tb_search_category.ForeColor = Color.Gray;

            // Penalty Types

            penalty_types = new Dictionary<string, int>();
            penalty_types.Add("TIMEOUT", 3);
            penalty_types.Add("SCRETCH", 5);
            penalty_types.Add("DAMAGED", 15);
            penalty_types.Add("LOST", 20);

            
        }

        private void Microwave_Load(object sender, EventArgs e)
        {
            main_tag.Edit_Book_Tag("Select A Book To Show", "Select A Book To Show", "", "0");
            main_tag.Draw_Book_Tag();

            this.pnl_book_list.VerticalScroll.Value = 0;
            this.pnl_author_list.VerticalScroll.Value = 0;
            this.pnl_user_list.VerticalScroll.Value = 0;
            this.pnl_pub_list.VerticalScroll.Value = 0;
            this.pnl_department_list.VerticalScroll.Value = 0;
            this.pnl_receipt_list.VerticalScroll.Value = 0;
            this.pnl_categories_list.VerticalScroll.Value = 0;
            this.pnl_shelf_list.VerticalScroll.Value = 0;

            Book.Show_All_Books(this);
            User.Show_All_Users(this);
            Publisher.Show_All_Publishers(this);
            Department.Show_All_Departments(this);
            Receipt.Show_All_Receipts(this);
            Shelf.Show_All_Shelf(this);
            Category.Show_All_Categories(this);
            Author.Show_All_Authors(this);
            pnl_home.BringToFront();

        }
        private void Btn_Add_Click(object sender, EventArgs e)
        {
            this.pic_logo.Focus();

            string message = null;
            Color color = Warning.Default_Color;

            if(chosen == MENU_CHOSEN.BOOKS)
            {
                pnl_book_list.VerticalScroll.Value = 0;
                book_search_list.Delete_All_List();
                main_book_list.Draw_All_Books();

                book_searched_already = false;

                message = "Do you want to add a book?";
                color = Color.DarkGreen;
                Create_Warning_Form(message, color);
                if (warning_form.Result == true)
                    Create_Add_Book_Form();
                warning_form.Refresh_Form();
            }
            else if(chosen == MENU_CHOSEN.USERS)
            {
                pnl_user_list.VerticalScroll.Value = 0;
                user_search_list.Delete_All_List();
                main_user_list.Draw_All_Users();

                user_searched_already = false;

                message = "Do you want to add a user?";
                color = Color.Bisque;
                Create_Warning_Form(message, color);
                if (warning_form.Result == true)
                    Create_Add_User_Form();

                warning_form.Refresh_Form();
            }
            else if (chosen == MENU_CHOSEN.AUTHOR)
            {
                pnl_author_list.VerticalScroll.Value = 0;
                author_search_list.Delete_All_List();
                main_author_list.Delete_All_List();
                Author.Show_All_Authors(this);
                main_author_list.Draw_All_Authors();
                author_searched_already = false;


                message = "Do you want to add an author?";
                color = Color.BlueViolet;
                Create_Warning_Form(message, color);
                if (warning_form.Result == true)
                    Create_Add_Author_Form();

                warning_form.Refresh_Form();
            }
            else if (chosen == MENU_CHOSEN.PUBLISHER)
            {
                pnl_pub_list.VerticalScroll.Value = 0;
                publisher_search_list.Delete_All_List();
                main_pub_list.Draw_All_Publishers();
                publisher_searched_already = false;

                message = "Do you want to add a publisher?";
                color = Color.DarkCyan;
                Create_Warning_Form(message, color);
                if (warning_form.Result == true)
                    Create_Add_Publisher_Form();

                warning_form.Refresh_Form();
            }
            else if (chosen == MENU_CHOSEN.DEPARTMENT)
            {


                message = "Do you want to add a Department?";
                color = Color.Chocolate;
                Create_Warning_Form(message, color);
                if (warning_form.Result == true)
                    Create_Add_Department_Form();

                warning_form.Refresh_Form();
            }
            else if (chosen == MENU_CHOSEN.CATEGORY)
            {
                message = "Do you want to add a Category?";
                color = Color.Tan;
                Create_Warning_Form(message, color);
                if (warning_form.Result == true)
                {
                    Create_Add_Category_Form();
                }
                warning_form.Refresh_Form();

            }
            else if (chosen == MENU_CHOSEN.SHELF)
            {
                message = "Do you want to add a new Shelf?";
                color = Color.Tan;
                Create_Warning_Form(message, color);
                if (warning_form.Result == true)
                {
                    Create_New_Shelf();
                }
                warning_form.Refresh_Form();
            }

        }
        public void Create_Warning_Form(string message, Color color)
        {
            if (Warning_form == null)
            {
                Warning_form = new Warning(manager);
            }
            try
            {
                Warning_form.Initialize_Warning(message, color);
                Warning_form.ShowDialog();
            }
            catch (ObjectDisposedException)
            {
                Warning_form = new Warning(manager);
                Warning_form.Initialize_Warning(message, color);
                Warning_form.ShowDialog();
            }
        }

        public void Create_Add_Book_Form()
        {
            if (Add_book == null)
            {
                Add_book = new AddBook();
            }

            try
            {
                Add_book.Show();
            }
            catch (ObjectDisposedException)
            {
                Add_book = new AddBook();
                Add_book.Show();
            }
            this.pic_logo.Focus();
            Add_book.Focus();
        }
        public void Create_Add_User_Form()
        {
            if (add_user == null)
            {
                add_user = new AddUser();
            }

            try
            {
                add_user.Show();
            }
            catch (ObjectDisposedException)
            {
                add_user = new AddUser();
                add_user.Show();
            }
            pic_logo.Focus();
            Add_user.Focus();
        }
        public void Create_Add_Author_Form()
        {
            if (Add_author == null)
            {
                Add_author = new AddAuthor();
            }

            try
            {
                Add_author.ShowDialog();
            }
            catch (ObjectDisposedException)
            {
                Add_author = new AddAuthor();
                Add_author.ShowDialog();
            }
            this.pic_logo.Focus();
            Add_author.Focus();
        }
        public void Create_Add_Publisher_Form()
        {
            if (Add_publisher == null)
            {
                Add_publisher = new AddPublisher();
            }

            try
            {
                Add_publisher.ShowDialog();
            }
            catch (ObjectDisposedException)
            {
                Add_publisher = new AddPublisher();
                Add_publisher.ShowDialog();
            }
            this.pic_logo.Focus();
            Add_publisher.Focus();
        }
        public void Create_Add_Department_Form()
        {
            if (add_department == null)
            {
                add_department = new AddDepartment();
            }
            try
            {
                add_department.Show();
            }
            catch (ObjectDisposedException)
            {
                add_department = new AddDepartment();
                add_department.Show();
            }
            pic_logo.Focus();
            add_department.Focus();
        }
        public void Create_Add_Category_Form()
        {
            if (add_category == null)
            {
                add_category = new AddCategory();
            }
            try
            {
                add_category.ShowDialog();
            }
            catch (ObjectDisposedException)
            {
                add_category = new AddCategory();
                add_category.ShowDialog();
            }
            pic_logo.Focus();
            add_category.Focus();
        }
        public void Create_About_Us()
        {
            if (about_us == null)
            {
                about_us = new AboutUs();
            }
            try
            {
                about_us.ShowDialog();
            }
            catch (ObjectDisposedException)
            {
                about_us = new AboutUs();
                about_us.ShowDialog();
            }
        }
        public void Create_Popularity_Form()
        {
            if (pop_form == null)
            {
                pop_form = new Popularity_Form();
            }

            try
            {
                pop_form.Show();
            }
            catch (ObjectDisposedException)
            {
                pop_form = new Popularity_Form();
                pop_form.Show();
            }
            this.pic_logo.Focus();
            pop_form.Focus();
        }
        public void Create_New_Shelf()
        {
            string shelf_name = Shelf.Generate_Shelf_Name();
            Shelf shelf = new Shelf(0, shelf_name);
            shelf.Add();
        }
        public void Create_Profile_Form()
        {

            Create_Warning_Form("Enter password to enter profile", Color.Black);

            if(warning_form.Result)
            {
                if (profile_form == null)
                {
                    profile_form = new Detail(manager, true);
                }

                try
                {
                    profile_form.Show();
                }
                catch (ObjectDisposedException)
                {
                    profile_form = new Detail(manager, true);
                    profile_form.Show();
                }
            }

            warning_form.Refresh_Form();
        }

        private void btn_book_Click(object sender, EventArgs e)
        {
            chosen = MENU_CHOSEN.BOOKS;
            if(main_author_list.info_exist)
                main_author_list.Hide_All_Author_Objects();

            pnl_stick.Location = new Point(pnl_stick.Location.X, btn_book.Location.Y);
            pnl_stick.Show();
            pnl_book.Show();
            pnl_tag.Show();
            pnl_user.Hide();
            pnl_pub.Hide();
            pnl_authors.Hide();
            pnl_department.Hide();
            pnl_receipt.Hide();
            pnl_shelf.Hide();
            pnl_categories.Hide();
            btn_show_search_types.Show();
            tb_search_book.Show();
            tb_search_user.Hide();
            tb_search_author.Hide();
            tb_search_publisher.Hide();
            tb_search_receipt.Hide();
            tb_search_category.Hide();

            pnl_book_list.VerticalScroll.Value = 0;

            main_book_list.Deselect_All_Infos();
            main_book_list.Draw_All_Books();
            book_search_list.Delete_All_List();
            this.tb_search_book.Text = "Search a book";
        }
        private void btn_users_Click(object sender, EventArgs e)
        {
            chosen = MENU_CHOSEN.USERS;
            if (main_author_list.info_exist)
                main_author_list.Hide_All_Author_Objects();

            pnl_stick.Location = new Point(pnl_stick.Location.X, btn_user.Location.Y);
            pnl_stick.Show();
            pnl_user.Show();
            pnl_book.Hide();
            pnl_pub.Hide();
            pnl_tag.Hide();
            pnl_authors.Hide();
            pnl_department.Hide();
            pnl_receipt.Hide();
            pnl_shelf.Hide();
            pnl_categories.Hide();
            btn_show_search_types.Show();
            tb_search_book.Hide();
            tb_search_user.Show();
            tb_search_author.Hide();
            tb_search_publisher.Hide();
            tb_search_receipt.Hide();
            tb_search_category.Hide();

            pnl_user_list.VerticalScroll.Value = 0;
            main_user_list.Deselect_All_Infos();
            main_user_list.Draw_All_Users();
            user_search_list.Delete_All_List();
            this.tb_search_user.Text = "Search a user";

        }
        private void btn_author_Click(object sender, EventArgs e)
        {
            chosen = MENU_CHOSEN.AUTHOR;

            main_author_list.Draw_All_Authors();

            pnl_stick.Location = new Point(pnl_stick.Location.X, btn_author.Location.Y);
            pnl_stick.Show();
            pnl_pub.Hide();
            pnl_book.Hide();
            pnl_tag.Hide();
            pnl_user.Hide();
            pnl_department.Hide();
            pnl_receipt.Hide();
            pnl_authors.Show();
            pnl_categories.Hide();
            pnl_shelf.Hide();
            btn_show_search_types.Show();
            tb_search_book.Hide();
            tb_search_user.Hide();
            tb_search_author.Show();
            tb_search_publisher.Hide();
            tb_search_receipt.Hide();
            tb_search_category.Hide();

            pnl_author_list.VerticalScroll.Value = 0;
            main_author_list.Deselect_All_Infos();
            author_search_list.Delete_All_List();
            this.tb_search_author.Text = "Search an author";


        }
        private void btn_publisher_Click(object sender, EventArgs e)
        {
            chosen = MENU_CHOSEN.PUBLISHER;
            if (main_author_list.info_exist)
                main_author_list.Hide_All_Author_Objects();


            pnl_stick.Location = new Point(pnl_stick.Location.X, btn_publisher.Location.Y);
            pnl_stick.Show();
            pnl_pub.Show();
            pnl_book.Hide();
            pnl_tag.Hide();
            pnl_user.Hide();
            pnl_department.Hide();
            pnl_authors.Hide();
            pnl_receipt.Hide();
            pnl_categories.Hide();
            pnl_shelf.Hide();
            btn_show_search_types.Show();
            tb_search_book.Hide();
            tb_search_user.Hide();
            tb_search_author.Hide();
            tb_search_receipt.Hide();
            tb_search_category.Hide();
            tb_search_publisher.Show();


            pnl_pub_list.VerticalScroll.Value = 0;
            main_pub_list.Deselect_All_Infos();
            publisher_search_list.Delete_All_List();
            main_pub_list.Draw_All_Publishers();
            this.tb_search_publisher.Text = "Search a publisher";


        }
        private void btn_department_Click(object sender, EventArgs e)
        {
            chosen = MENU_CHOSEN.DEPARTMENT;
            if (main_author_list.info_exist)
                main_author_list.Hide_All_Author_Objects();

            pnl_stick.Location = new Point(pnl_stick.Location.X, btn_department.Location.Y);
            pnl_stick.Show();
            pnl_pub.Hide();
            pnl_book.Hide();
            pnl_tag.Hide();
            pnl_user.Hide();
            pnl_authors.Hide();
            pnl_receipt.Hide();
            pnl_department.Show();
            pnl_shelf.Hide();
            pnl_categories.Hide();
            btn_show_search_types.Hide();
            tb_search_book.Hide();
            tb_search_user.Hide();
            tb_search_author.Hide();
            tb_search_publisher.Hide();
            tb_search_category.Hide();
            tb_search_receipt.Hide();



            main_department_list.Deselect_All_Infos();


        }
        private void btn_email_Click(object sender, EventArgs e)
        {
            chosen = MENU_CHOSEN.RECEIPTS;
            if (main_author_list.info_exist)
                main_author_list.Hide_All_Author_Objects();


            pnl_stick.Location = new Point(pnl_stick.Location.X, btn_receipt.Location.Y);
            pnl_stick.Show();
            pnl_pub.Hide();
            pnl_book.Hide();
            pnl_tag.Hide();
            pnl_user.Hide();
            pnl_authors.Hide();
            pnl_department.Hide();
            pnl_receipt.Show();
            pnl_categories.Hide();
            pnl_shelf.Hide();
            btn_show_search_types.Show();
            tb_search_book.Hide();
            tb_search_user.Hide();
            tb_search_author.Hide();
            tb_search_publisher.Hide();
            tb_search_receipt.Show();
            tb_search_category.Hide();

            main_receipt_list.Deselect_All_Infos();
            receipt_search_list.Delete_All_List();
            main_receipt_list.Draw_All_Receipts();
            this.tb_search_receipt.Text = "Search a receipt";

        }
        private void btn_shelf_Click(object sender, EventArgs e)
        {
            chosen = MENU_CHOSEN.SHELF;
            if (main_author_list.info_exist)
                main_author_list.Hide_All_Author_Objects();


            pnl_stick.Location = new Point(pnl_stick.Location.X, btn_shelf.Location.Y);
            pnl_stick.Show();
            pnl_pub.Hide();
            pnl_book.Hide();
            pnl_tag.Hide();
            pnl_user.Hide();
            pnl_authors.Hide();
            pnl_department.Hide();
            pnl_categories.Hide();
            pnl_receipt.Hide();
            btn_show_search_types.Hide();
            tb_search_book.Hide();
            tb_search_user.Hide();
            tb_search_author.Hide();
            tb_search_publisher.Hide();
            tb_search_category.Hide();
            tb_search_receipt.Hide();
            pnl_shelf.Show();
          


        }
        private void btn_categories_Click(object sender, EventArgs e)
        {
            chosen = MENU_CHOSEN.CATEGORY;
            if (main_author_list.info_exist)
                main_author_list.Hide_All_Author_Objects();


            pnl_stick.Location = new Point(pnl_stick.Location.X, btn_categories.Location.Y);
            pnl_stick.Show();
            pnl_pub.Hide();
            pnl_book.Hide();
            pnl_tag.Hide();
            pnl_user.Hide();
            pnl_authors.Hide();
            pnl_department.Hide();
            pnl_receipt.Hide();
            pnl_shelf.Hide();
            pnl_categories.Show();
            btn_show_search_types.Hide();
            tb_search_book.Hide();
            tb_search_user.Hide();
            tb_search_author.Hide();
            tb_search_publisher.Hide();
            tb_search_receipt.Hide();
            tb_search_category.Show();

            pnl_categories_list.VerticalScroll.Value = 0;
            main_category_list.Deselect_All_Infos();
            category_search_list.Delete_All_List();
            main_category_list.Draw_All_Categories();
            this.tb_search_category.Text = "Search a category";
        }
        private void btn_about_us_Click(object sender, EventArgs e)
        {
            chosen = MENU_CHOSEN.ABOUT_US;
            pnl_stick.Location = new Point(pnl_stick.Location.X, btn_about.Location.Y);
            pnl_stick.Show();
            if (main_author_list.info_exist)
                main_author_list.Hide_All_Author_Objects();

            Create_About_Us();
        }
        private void btn_popularity_Click(object sender, EventArgs e)
        {
            pnl_stick.Location = new Point(pnl_stick.Location.X, btn_popularity.Location.Y);
            Create_Popularity_Form();
        }

        public void Remove_Image_From_Cover_List(int book_id)
        {
            Cover_image_list.Images[book_id.ToString()].Dispose();
            Cover_image_list.Images.RemoveByKey(book_id.ToString());
        }
        private void General_Click(object sender, EventArgs e)
        {
            this.lb_book_search.Hide();
            this.lb_publisher_search.Hide();
            this.lb_user_search.Hide();
            this.lb_author_search.Hide();
            this.lb_receipt_search.Hide();
            this.lb_category_search.Hide();
            this.pic_logo.Focus();
            this.pic_logo.Select();
        }
       




        private void Btn_show_search_types_Click(object sender, EventArgs e)
        {
            if (chosen == MENU_CHOSEN.BOOKS)
            {
                if (show_pnl_book_st == false)
                {
                    this.pnl_book_st.Show();
                    show_pnl_book_st = true;
                }
                else
                {
                    this.pnl_book_st.Hide();
                    show_pnl_book_st = false;
                }
                lb_book_search.Hide();
            }
            else if (chosen == MENU_CHOSEN.USERS)
            {
                if (show_pnl_user_st == false)
                {
                    this.pnl_user_st.Show();
                    show_pnl_user_st = true;
                }
                else
                {
                    this.pnl_user_st.Hide();
                    show_pnl_user_st = false;
                }
                lb_user_search.Hide();
            }
            else if (chosen == MENU_CHOSEN.AUTHOR)
            {
                if (show_pnl_author_st == false)
                {
                    this.pnl_author_st.Show();
                    show_pnl_author_st = true;
                }
                else
                {
                    this.pnl_author_st.Hide();
                    show_pnl_author_st = false;
                }
                lb_author_search.Hide();
            }
            else if (chosen == MENU_CHOSEN.PUBLISHER)
            {
                if (show_pnl_pub_st == false)
                {
                    this.pnl_publisher_st.Show();
                    show_pnl_pub_st = true;
                }
                else
                {
                    this.pnl_publisher_st.Hide();
                    show_pnl_pub_st = false;
                }
                lb_publisher_search.Hide();
            }
            else if(chosen == MENU_CHOSEN.RECEIPTS)
            {
                if(show_pnl_rcpt_st == false)
                {
                    this.pnl_receipt_st.Show();
                    show_pnl_rcpt_st = true;
                }
                else
                {
                    this.pnl_receipt_st.Hide();
                    show_pnl_rcpt_st = false;
                }
                lb_receipt_search.Hide();
            }

        }

        // Searching events for books
        private void RadioButtonBook_CheckedChanged(object sender, EventArgs e)
        {
            this.pnl_book_st.Hide();
            this.tb_search_book.Text = "";
            this.tb_search_book.Focus();
            this.show_pnl_book_st = false;
        }
        private void Tb_search_book_TextChanged(object sender, EventArgs e)
        {
            string text = tb_search_book.Text.Trim();
            book_searched_already = false;
            if (chosen == MENU_CHOSEN.BOOKS)
            {
                if (text == "")
                {
                    lb_book_search.Hide();
                    lb_book_search.Items.Clear();

                    book_search_list.Delete_All_List();
                    main_book_list.Draw_All_Books();
                    return;
                }
                if(text == "Search a book")
                {
                    book_search_list.Delete_All_List();
                    main_book_list.Draw_All_Books();
                    return;
                }
                else
                {
                    this.pnl_book_list.VerticalScroll.Value = 0;
                    if (rb_book_name.Checked)
                    {
                        string query = string.Format("Select Books.NAME from Books Where Books.NAME Like '{0}%'", text);
                        Fill_Book_Search_List_Box(query);
                        if (lb_book_search.Items.Count > 0)
                            lb_book_search.Show();
                        return;
                    }
                    if (rb_book_id.Checked)
                    {
                        string query = string.Format("Select Books.BOOK_ID From Books Where Books.BOOK_ID Like '{0}%'", text);
                        Fill_Book_Search_List_Box(query);
                        if (lb_book_search.Items.Count > 0)
                            lb_book_search.Show();
                        return;
                    }
                    if (rb_book_author.Checked)
                    {
                        string query = string.Format("Select Authors.NAME From Authors Where Authors.NAME Like '{0}%'", text);
                        Fill_Book_Search_List_Box(query);
                        if (lb_book_search.Items.Count > 0)
                            lb_book_search.Show();
                        return;
                    }
                    if (rb_book_publis.Checked)
                    {
                        string query = string.Format("Select Publishers.NAME From Publishers Where Publishers.NAME Like '{0}%'", text);
                        Fill_Book_Search_List_Box(query);
                        if (lb_book_search.Items.Count > 0)
                            lb_book_search.Show();
                        return;
                    }
                    if (rb_book_category.Checked)
                    {
                        string query = string.Format("Select Categories.NAME From Categories Where Categories.NAME Like '{0}%'", text);
                        Fill_Book_Search_List_Box(query);
                        if (lb_book_search.Items.Count > 0)
                            lb_book_search.Show();
                        return;
                    }
                    if (rb_book_shelf.Checked)
                    {
                        string query = string.Format("Select Shelves.NAME From Shelves Where Shelves.NAME Like '{0}%'", text);
                        Fill_Book_Search_List_Box(query);
                        if (lb_book_search.Items.Count > 0)
                            lb_book_search.Show();
                        return;
                    }
                    if (rb_book_pop.Checked)
                    {
                        string query = string.Format("Select Popularity.NAME From Popularity Where Popularity.NAME Like '{0}%'", text);
                        Fill_Book_Search_List_Box(query);
                        if (lb_book_search.Items.Count > 0)
                            this.lb_book_search.Show();
                        return;
                    }
                    
                }

            }
        }
        private void Tb_search_book_KeyPress(object sender, KeyPressEventArgs e)
        {
            string text = tb_search_book.Text;

            if(e.KeyChar == (char)Keys.Enter && !book_searched_already)
            {
                lb_book_search.Hide();
                if(tb_search_book.Text == "")
                {
                    return;
                }
                main_book_list.Hide_All_Book_Objects();
                book_search_list.Delete_All_List();
                this.pnl_book_list.VerticalScroll.Value = 0;

                if (rb_book_name.Checked)
                {
                    book_search_list.Fill_Book_List(Book.Search_Book_By_Name(text),main_book_list, book_search_list, main_tag, pnl_book_list, INFO_COLOR_MODE.NAME);
                    book_search_list.Draw_All_Books();
                    book_searched_already = true;
                    return;
                }
                if (rb_book_id.Checked)
                {
                    book_search_list.Fill_Book_List(Book.Search_Book_By_ID(text), main_book_list, book_search_list, main_tag, pnl_book_list, INFO_COLOR_MODE.ID);
                    book_search_list.Draw_All_Books();
                    book_searched_already = true;
                    return;
                }
                if (rb_book_author.Checked)
                {
                    book_search_list.Fill_Book_List(Book.Search_Book_By_Author(text), main_book_list, book_search_list, main_tag, pnl_book_list, INFO_COLOR_MODE.AUTHOR);
                    book_search_list.Draw_All_Books();
                    book_searched_already = true;
                    return;
                }
                if (rb_book_publis.Checked)
                {
                    book_search_list.Fill_Book_List(Book.Search_Book_By_Publisher(text), main_book_list, book_search_list, main_tag, pnl_book_list, INFO_COLOR_MODE.PUBLISHER);
                    book_search_list.Draw_All_Books();
                    book_searched_already = true;
                    return;
                }
                if (rb_book_category.Checked)
                {
                    book_search_list.Fill_Book_List(Book.Search_Book_By_Category(text), main_book_list, book_search_list, main_tag, pnl_book_list, INFO_COLOR_MODE.CATEGORY);
                    book_search_list.Draw_All_Books();
                    book_searched_already = true;
                    return;
                }
                if (rb_book_shelf.Checked)
                {
                    book_search_list.Fill_Book_List(Book.Search_Book_By_Shelf(text), main_book_list, book_search_list, main_tag, pnl_book_list, INFO_COLOR_MODE.SHELF);
                    book_search_list.Draw_All_Books();
                    book_searched_already = true;
                    return;
                }
                if (rb_book_pop.Checked)
                {
                    book_search_list.Fill_Book_List(Book.Search_Book_By_Popularity(text), main_book_list, book_search_list, main_tag, pnl_book_list, INFO_COLOR_MODE.NORMAL);
                    book_search_list.Draw_All_Books();
                    book_searched_already = true;
                    return;
                }
            }

        }
        private void Tb_search_book_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Down)
            {
                if (lb_book_search.Items.Count != 0)
                {
                    lb_book_search.Select();
                    lb_book_search.SelectedIndex = 0;
                }
            }
        }
        private void Lb_book_search_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetterOrDigit(e.KeyChar) || e.KeyChar == ' '|| e.KeyChar == (char)Keys.Back)
            {
                if (e.KeyChar == (char)Keys.Back)
                    tb_search_book.Text = tb_search_book.Text.Remove(tb_search_book.Text.Length - 1, 1);
                else
                    tb_search_book.Text += e.KeyChar;
                tb_search_book.Focus();
                tb_search_book.Select(tb_search_book.Text.Length, 0);
            }
            else if(e.KeyChar == (char)Keys.Enter)
            {
                tb_search_book.Focus();
                tb_search_book.Text = lb_book_search.SelectedItem.ToString();
                tb_search_book.Select(tb_search_book.Text.Length, 0);
            }


        }
        private void Fill_Book_Search_List_Box(string query)
        {

            lb_book_search.Items.Clear();
            
            DataTable dt = DataBaseEvents.ExecuteQuery(query, data_source);

            int rows_count = dt.Rows.Count;

            if (rows_count <= 0)
            {
                return;
            }

            for(int i = 0; i < rows_count; i++)
            {
                string item = dt.Rows[i][0].ToString();
                if (lb_book_search.Items.Contains(item))
                    continue;
                lb_book_search.Items.Add(item);
            }

        }
        private void Tb_search_Leave(object sender, EventArgs e)
        {

            if (chosen == MENU_CHOSEN.BOOKS)
            {
                if (tb_search_book.Text == "")
                {
                    tb_search_book.Text = "Search a book";
                    tb_search_book.ForeColor = Color.Gray;
                }
            }
            else if (chosen == MENU_CHOSEN.USERS)
            {
                if (tb_search_book.Text == "")
                {
                    tb_search_book.Text = "Search a user";
                    tb_search_book.ForeColor = Color.Gray;
                }

            }
            else if (chosen == MENU_CHOSEN.DEPARTMENT)
            {
                if (tb_search_book.Text == "")
                {
                    tb_search_book.Text = "Search a department";
                    tb_search_book.ForeColor = Color.Gray;
                }

            }
            else if (chosen == MENU_CHOSEN.PUBLISHER)
            {
                if (tb_search_publisher.Text == "")
                {
                    tb_search_publisher.Text = "Search a publisher";
                    tb_search_publisher.ForeColor = Color.Gray;
                }
            }

        }
        private void Tb_search_Enter(object sender, EventArgs e)
        {    
            if (tb_search_book.Text == "Search a book")
            {
                tb_search_book.Text = "";
            }

            if (lb_book_search.Items.Count > 0)
                lb_book_search.Show();
           
            tb_search_book.ForeColor = Color.LightGray;
        }
        private void Lb_book_search_Leave(object sender, EventArgs e)
        {
            lb_book_search.Hide();
        }
        private void Lb_book_search_DoubleClick(object sender, EventArgs e)
        {
            tb_search_book.Focus();
            if(lb_book_search.SelectedItem != null)
                tb_search_book.Text = lb_book_search.SelectedItem.ToString();
            tb_search_book.Select(tb_search_book.Text.Length, 0);
        }

        // Searching events for publishers
        private void rb_pub_name_CheckedChanged(object sender, EventArgs e)
        {
            this.pnl_publisher_st.Hide();
            this.tb_search_publisher.Text = "";
            this.tb_search_publisher.Focus();
            this.show_pnl_pub_st = false;
        }
        private void tb_search_publisher_TextChanged(object sender, EventArgs e)
        {
            string text = tb_search_publisher.Text.Trim();
            publisher_searched_already = false;
            if (chosen == MENU_CHOSEN.PUBLISHER)
            {
                if (text == "")
                {
                    lb_publisher_search.Hide();
                    lb_publisher_search.Items.Clear();

                    publisher_search_list.Delete_All_List();
                    main_pub_list.Draw_All_Publishers();
                    return;
                }
                else if (text == "Search a publisher")
                {
                    publisher_search_list.Delete_All_List();
                    main_pub_list.Draw_All_Publishers();
                    return;
                }

                this.pnl_pub_list.VerticalScroll.Value = 0;

                if (rb_pub_name.Checked)
                {
                    string query = string.Format("Select Publishers.NAME from Publishers Where Publishers.NAME Like '{0}%'", text);
                    Fill_Publisher_Search_List_Box(query);
                    if (lb_publisher_search.Items.Count > 0)
                        lb_publisher_search.Show();
                    return;
                }
                if (rb_pub_id.Checked)
                {
                    string query = string.Format("Select Publishers.PUBLISHER_ID from Publishers Where Publishers.PUBLISHER_ID Like '{0}%'", text);
                    Fill_Publisher_Search_List_Box(query);
                    if (lb_publisher_search.Items.Count > 0)
                        lb_publisher_search.Show();
                    return;
                }
            }
        }
        private void tb_search_publisher_KeyPress(object sender, KeyPressEventArgs e)
        {
            string text = tb_search_publisher.Text;

            if (e.KeyChar == (char)Keys.Enter)
            {
                lb_publisher_search.Hide();
                if (tb_search_publisher.Text == "" && !publisher_searched_already)
                {
                    return;
                }
                main_pub_list.Hide_All_Publisher_Objects();
                publisher_search_list.Delete_All_List();
                this.pnl_book_list.VerticalScroll.Value = 0;

                if (rb_pub_name.Checked)
                {
                    publisher_search_list.Fill_Pub_List(Publisher.Search_Publisher_By_Name(text));
                    publisher_search_list.Draw_All_Publishers();
                    publisher_searched_already = true;
                    return;
                }
                if (rb_pub_id.Checked)
                {
                    publisher_search_list.Fill_Pub_List(Publisher.Search_Publisher_By_ID(text));
                    publisher_search_list.Draw_All_Publishers();
                    publisher_searched_already = true;
                    return;
                }
            }
        }
        private void tb_search_publisher_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                if (lb_publisher_search.Items.Count != 0)
                {
                    lb_publisher_search.Select();
                    lb_publisher_search.SelectedIndex = 0;
                }
            }
        }
        private void lb_publisher_search_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetterOrDigit(e.KeyChar) || e.KeyChar == ' ' || e.KeyChar == (char)Keys.Back)
            {
                if (e.KeyChar == (char)Keys.Back)
                    tb_search_publisher.Text = tb_search_publisher.Text.Remove(tb_search_publisher.Text.Length - 1, 1);
                else
                    tb_search_publisher.Text += e.KeyChar;
                tb_search_publisher.Focus();
                tb_search_publisher.Select(tb_search_publisher.Text.Length, 0);
            }
            else if (e.KeyChar == (char)Keys.Enter)
            {
                tb_search_publisher.Focus();
                if(lb_publisher_search.SelectedItem != null)
                    tb_search_publisher.Text = lb_publisher_search.SelectedItem.ToString();
                tb_search_publisher.Select(tb_search_publisher.Text.Length, 0);
            }
        }
        private void Fill_Publisher_Search_List_Box(string query)
        {
            lb_publisher_search.Items.Clear();

            DataTable dt = DataBaseEvents.ExecuteQuery(query, data_source);

            int rows_count = dt.Rows.Count;

            if (rows_count <= 0)
            {
                return;
            }

            for (int i = 0; i < rows_count; i++)
            {
                string item = dt.Rows[i][0].ToString();
                if (lb_publisher_search.Items.Contains(item))
                    continue;
                lb_publisher_search.Items.Add(item);
            }
        }
        private void tb_search_publisher_Enter(object sender, EventArgs e)
        {
            if (tb_search_publisher.Text == "Search a publisher")
            {
                tb_search_publisher.Text = "";
            }

            if (lb_publisher_search.Items.Count > 0)
                lb_publisher_search.Show();

            tb_search_publisher.ForeColor = Color.LightGray;
        }
        private void lb_publisher_search_Leave(object sender, EventArgs e)
        {
            lb_publisher_search.Hide();
        }
        private void lb_publisher_search_DoubleClick(object sender, EventArgs e)
        {
            tb_search_publisher.Focus();
            if (lb_publisher_search.SelectedItem != null)
                tb_search_publisher.Text = lb_publisher_search.SelectedItem.ToString();
            tb_search_publisher.Select(tb_search_publisher.Text.Length, 0);
        }

        
        // Searching events for author
        private void tb_search_author_Enter(object sender, EventArgs e)
        {
            if (tb_search_author.Text == "Search an author")
            {
                tb_search_author.Text = "";
            }

            if (lb_author_search.Items.Count > 0)
                lb_author_search.Show();

            tb_search_author.ForeColor = Color.LightGray;
        }
        private void tb_search_author_Leave(object sender, EventArgs e)
        {
            if (tb_search_author.Text == "")
            {
                tb_search_author.Text = "Search an author";
                tb_search_author.ForeColor = Color.Gray;
            }
        }
        private void tb_search_author_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                if (lb_author_search.Items.Count > 0)
                {
                    lb_author_search.Select();
                    lb_author_search.SelectedIndex = 0;
                }
            }
        }
        private void tb_search_author_KeyPress(object sender, KeyPressEventArgs e)
        {
            string text = tb_search_author.Text;

            if (e.KeyChar == (char)Keys.Enter && !author_searched_already)
            {
                lb_author_search.Hide();
                if (tb_search_author.Text == "")
                {
                    return;
                }
                main_author_list.Hide_All_Author_Objects();
                author_search_list.Delete_All_List();
                this.pnl_author_list.VerticalScroll.Value = 0;

                if (rb_author_name.Checked)
                {
                    author_search_list.Fill_Author_List(Author.Search_Author_By_Name(text)); ;
                    author_search_list.Draw_All_Authors();
                    author_searched_already = true;
                    return;
                }
                if (rb_author_country.Checked)
                {
                    author_search_list.Fill_Author_List(Author.Search_Author_By_Country(text)); ;
                    author_search_list.Draw_All_Authors();
                    author_searched_already = true;
                    return;
                }
                if (rb_author_ID.Checked)
                {
                    author_search_list.Fill_Author_List(Author.Search_Author_By_ID(text)); ;
                    author_search_list.Draw_All_Authors();
                    author_searched_already = true;
                    return;
                }
                if (rb_author_gender.Checked)
                {
                    author_search_list.Fill_Author_List(Author.Search_Author_By_Gender(text)); ;
                    author_search_list.Draw_All_Authors();
                    author_searched_already = true;
                    return;
                }
                
            }
        }
        private void tb_search_author_TextChanged(object sender, EventArgs e)
        {
            string text = tb_search_author.Text.Trim();
            author_searched_already = false;

            if (chosen == MENU_CHOSEN.AUTHOR)
            {
                if (text == "")
                {
                    lb_author_search.Hide();
                    lb_author_search.Items.Clear();

                    author_search_list.Delete_All_List();
                    main_author_list.Draw_All_Authors();
                    return;
                }
                if (text == "Search an author")
                {
                    author_search_list.Delete_All_List();
                    main_author_list.Draw_All_Authors();
                    return;
                }
                else
                {
                    this.pnl_author_list.VerticalScroll.Value = 0;

                    if (rb_author_name.Checked)
                    {
                        string query = string.Format("Select Authors.NAME From Authors Where Authors.NAME Like '{0}%'", text);
                        Fill_Author_Search_List_Box(query);
                        if (lb_author_search.Items.Count > 0)
                            lb_author_search.Show();
                        return;
                    }
                    if (rb_author_country.Checked)
                    {
                        string query = string.Format("Select Author.COUNTRY From Author Where Author.COUNTRY Like '{0}%'", text);
                        Fill_Author_Search_List_Box(query);
                        if (lb_author_search.Items.Count > 0)
                            lb_author_search.Show();
                        return;
                    }
                    if (rb_author_ID.Checked)
                    {
                        string query = string.Format("Select Author.AUTHOR_ID From Author Where Author.AUTHOR_ID Like '{0}%'", text);
                        Fill_Author_Search_List_Box(query);
                        if (lb_author_search.Items.Count > 0)
                            lb_author_search.Show();
                        return;
                    }
                    if (rb_author_gender.Checked)
                    {
                        string query = string.Format("Select Author.GENDER From Author Where Author.GENDER Like '{0}%'", text);
                        Fill_Author_Search_List_Box(query);
                        if (lb_author_search.Items.Count > 0)
                            lb_author_search.Show();
                        return;
                    }
                    
                }

            }

        }
        private void rb_author_name_CheckedChanged(object sender, EventArgs e)
        {
            this.pnl_author_st.Hide();
            this.tb_search_author.Text = "";
            this.tb_search_author.Focus();
            this.show_pnl_author_st = false;

        }
        private void lb_author_search_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetterOrDigit(e.KeyChar) || e.KeyChar == ' ' || e.KeyChar == (char)Keys.Back)
            {
                if (e.KeyChar == (char)Keys.Back)
                    tb_search_author.Text = tb_search_author.Text.Remove(tb_search_author.Text.Length - 1, 1);
                else
                    tb_search_author.Text += e.KeyChar;
                    tb_search_author.Focus();
                    tb_search_author.Select(tb_search_author.Text.Length, 0);
            }
            else if (e.KeyChar == (char)Keys.Enter)
            {
                tb_search_author.Focus();
                if (lb_author_search.SelectedItem != null)
                    tb_search_author.Text = lb_author_search.SelectedItem.ToString();
                tb_search_author.Select(tb_search_author.Text.Length, 0);
            }

        }
        private void lb_author_search_Leave(object sender, EventArgs e)
        {
            lb_author_search.Hide(); 
        }
        private void lb_author_search_DoubleClick(object sender, EventArgs e)
        {
            tb_search_author.Focus();
            if (lb_author_search.SelectedItem != null)
                tb_search_author.Text = lb_author_search.SelectedItem.ToString();
            tb_search_author.Select(tb_search_author.Text.Length, 0);
        }
        private void Fill_Author_Search_List_Box(string query)

        {
            lb_author_search.Items.Clear();

            DataTable dt = DataBaseEvents.ExecuteQuery(query, data_source);

            int rows_count = dt.Rows.Count;

            if (rows_count <= 0)
                return;

            for (int i = 0; i < rows_count; i++)
            {
                string item = dt.Rows[i][0].ToString();
                if (lb_author_search.Items.Contains(item))
                    continue;
                lb_author_search.Items.Add(item);
            }
        }


        // Searching events for user
        private void RadioButtonUser_CheckedChanged(object sender, EventArgs e)
        {
            this.pnl_user_st.Hide();
            this.show_pnl_user_st = false;
        }
        private void Tb_search_user_TextChanged(object sender, EventArgs e)
        {
            string text = tb_search_user.Text.Trim();
            user_searched_already = false;

            if (chosen == MENU_CHOSEN.USERS)
            {
                if (text == "")
                {
                    lb_user_search.Hide();
                    lb_user_search.Items.Clear();

                    user_search_list.Delete_All_List();
                    main_user_list.Draw_All_Users();
                    return;
                }
                if (text == "Search a user")
                {
                    user_search_list.Delete_All_List();
                    main_user_list.Draw_All_Users();
                    return;
                }
                else
                {
                    this.pnl_user_list.VerticalScroll.Value = 0;

                    if (rb_user_name.Checked)
                    {
                        string query = string.Format("Select Users.NAME From Users Where Users.NAME Like '{0}%'", text);
                        Fill_User_Search_List_Box(query);
                        if (lb_user_search.Items.Count > 0)
                            lb_user_search.Show();
                        return;
                    }
                    if (rb_user_surname.Checked)
                    {
                        string query = string.Format("Select Users.SURNAME From Users Where Users.SURNAME Like '{0}%'", text);
                        Fill_User_Search_List_Box(query);
                        if (lb_user_search.Items.Count > 0)
                            lb_user_search.Show();
                        return;
                    }
                    if (rb_user_id.Checked)
                    {
                        string query = string.Format("Select Users.USER_ID From Users Where Users.USER_ID Like '{0}%'", text);
                        Fill_User_Search_List_Box(query);
                        if (lb_user_search.Items.Count > 0)
                            lb_user_search.Show();
                        return;
                    }
                    if (rb_user_email.Checked)
                    {
                        string query = string.Format("Select Users.EMAIL From Users Where Users.EMAIL Like '{0}%'", text);
                        Fill_User_Search_List_Box(query);
                        if (lb_user_search.Items.Count > 0)
                            lb_user_search.Show();
                        return;
                    }
                    if (rb_user_age.Checked)
                    {
                        string query = string.Format("Select Users.AGE From Users Where Users.AGE Like '{0}%'", text);
                        Fill_User_Search_List_Box(query);
                        if (lb_user_search.Items.Count > 0)
                            lb_user_search.Show();
                        return;
                    }
                    if (rb_user_gender.Checked)
                    {
                        string query = string.Format("Select Users.GENDER From Users Where Users.GENDER Like '{0}%'", text);
                        Fill_User_Search_List_Box(query);
                        if (lb_user_search.Items.Count > 0)
                            lb_user_search.Show();
                        return;
                    }
                }

            }

        }
        private void Tb_search_user_KeyPress(object sender, KeyPressEventArgs e)
        {
            string text = tb_search_user.Text;

            if (e.KeyChar == (char)Keys.Enter && !user_searched_already)
            {
                lb_user_search.Hide();
                if (tb_search_user.Text == "")
                {
                    return;
                }
                main_user_list.Hide_All_User_Objects();
                user_search_list.Delete_All_List();
                this.pnl_user_list.VerticalScroll.Value = 0;

                if (rb_user_name.Checked)
                {
                    user_search_list.Fill_User_List(User.Search_User_By_Name(text), INFO_COLOR_MODE.NAME); ;
                    user_search_list.Draw_All_Users();
                    user_searched_already = true;
                    return;
                }
                if (rb_user_surname.Checked)
                {
                    user_search_list.Fill_User_List(User.Search_User_By_Surname(text), INFO_COLOR_MODE.SURNAME); ;
                    user_search_list.Draw_All_Users();
                    user_searched_already = true;
                    return;
                }
                if (rb_user_gender.Checked)
                {
                    user_search_list.Fill_User_List(User.Search_User_By_Gender(text), INFO_COLOR_MODE.GENDER); ;
                    user_search_list.Draw_All_Users();
                    user_searched_already = true;
                    return;
                }
                if (rb_user_age.Checked)
                {
                    user_search_list.Fill_User_List(User.Search_User_By_Age(text), INFO_COLOR_MODE.AGE); ;
                    user_search_list.Draw_All_Users();
                    user_searched_already = true;
                    return;
                }
                if (rb_user_id.Checked)
                {
                    user_search_list.Fill_User_List(User.Search_User_By_ID(text), INFO_COLOR_MODE.ID); ;
                    user_search_list.Draw_All_Users();
                    user_searched_already = true;
                    return;
                }
                if (rb_user_email.Checked)
                {
                    user_search_list.Fill_User_List(User.Search_User_By_Email(text), INFO_COLOR_MODE.EMAIL); ;
                    user_search_list.Draw_All_Users();
                    user_searched_already = true;
                    return;
                }
            }
        }
        private void Tb_search_user_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                if (lb_user_search.Items.Count > 0)
                {
                    lb_user_search.Select();
                    lb_user_search.SelectedIndex = 0;
                }
            }
        }
        private void Lb_user_search_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetterOrDigit(e.KeyChar) || e.KeyChar == ' ' || e.KeyChar == (char)Keys.Back)
            {
                if (e.KeyChar == (char)Keys.Back)
                    tb_search_user.Text = tb_search_user.Text.Remove(tb_search_user.Text.Length - 1, 1);
                else
                    tb_search_user.Text += e.KeyChar;
                tb_search_user.Focus();
                tb_search_user.Select(tb_search_user.Text.Length, 0);
            }
            else if (e.KeyChar == (char)Keys.Enter)
            {
                tb_search_user.Focus();
                if (lb_user_search.SelectedItem != null)
                    tb_search_user.Text = lb_user_search.SelectedItem.ToString();
                tb_search_user.Select(tb_search_user.Text.Length, 0);
            }
        }
        private void Lb_user_search_Leave(object sender, EventArgs e)
        {
            lb_user_search.Hide();
        }
        private void Lb_user_search_DoubleClick(object sender, EventArgs e)
        {
            tb_search_user.Focus();
            if (lb_user_search.SelectedItem != null)
                tb_search_user.Text = lb_user_search.SelectedItem.ToString();
            tb_search_user.Select(tb_search_user.Text.Length, 0);
        }
        private void Tb_search_user_Enter(object sender, EventArgs e)
        {
            if (tb_search_user.Text == "Search a user")
            {
                tb_search_user.Text = "";
            }

            if (lb_user_search.Items.Count > 0)
                lb_user_search.Show();

            tb_search_user.ForeColor = Color.LightGray;

        }
        private void Tb_search_user_Leave(object sender, EventArgs e)
        {
            if (tb_search_user.Text == "")
            {
                tb_search_user.Text = "Search a user";
                tb_search_user.ForeColor = Color.Gray;
            }
        }
        private void Fill_User_Search_List_Box(string query)
        {
            lb_user_search.Items.Clear();

            DataTable dt = DataBaseEvents.ExecuteQuery(query, data_source);

            int rows_count = dt.Rows.Count;

            if (rows_count <= 0)
                return;

            for (int i = 0; i < rows_count; i++)
            {
                string item = dt.Rows[i][0].ToString();
                if (lb_user_search.Items.Contains(item))
                    continue;
                lb_user_search.Items.Add(item);
            }
        }
        // Searching events for category
        private void tb_search_category_Enter(object sender, EventArgs e)
        {
            if (tb_search_category.Text == "Search a category")
            {
                tb_search_category.Text = "";
            }

            if (lb_category_search.Items.Count > 0)
                lb_category_search.Show();

            tb_search_author.ForeColor = Color.LightGray;
        }
        private void tb_search_category_Leave(object sender, EventArgs e)
        {
            if (tb_search_category.Text == "")
            {
                tb_search_category.Text = "Search a category";
                tb_search_category.ForeColor = Color.Gray;
            }
        }
        private void tb_search_category_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                if (lb_category_search.Items.Count > 0)
                {
                    lb_category_search.Select();
                    lb_category_search.SelectedIndex = 0;
                }
            }
        }
        private void tb_search_category_KeyPress(object sender, KeyPressEventArgs e)
        {
            string text = tb_search_category.Text;

            if (e.KeyChar == (char)Keys.Enter && !category_searched_already)
            {
                lb_category_search.Hide();
                if (tb_search_category.Text == "")
                {
                    return;
                }
                main_category_list.Hide_All_Category_Objects();
                category_search_list.Delete_All_List();
                this.pnl_categories_list.VerticalScroll.Value = 0;


                category_search_list.Fill_Category_List(Category.Search_Category_By_Name(text)); ;
                category_search_list.Draw_All_Categories();
                category_searched_already = true;
                return;
            }
        }
        private void tb_search_category_TextChanged(object sender, EventArgs e)
        {
            string text = tb_search_category.Text.Trim();
            category_searched_already = false;

            if (chosen == MENU_CHOSEN.CATEGORY)
            {
                if (text == "")
                {
                    lb_category_search.Hide();
                    lb_category_search.Items.Clear();

                    category_search_list.Delete_All_List();
                    main_category_list.Draw_All_Categories();
                    return;
                }
                if (text == "Search a category")
                {
                    category_search_list.Delete_All_List();
                    main_category_list.Draw_All_Categories();
                    return;
                }
                else
                {
                    this.pnl_categories_list.VerticalScroll.Value = 0;


                    string query = string.Format("Select Categories.NAME From Categories Where Categories.NAME Like '{0}%'", text);
                    Fill_Category_Search_List_Box(query);
                    if (lb_category_search.Items.Count > 0)
                        lb_category_search.Show();
                    return;

                }

            }

        }
        private void lb_category_search_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetterOrDigit(e.KeyChar) || e.KeyChar == ' ' || e.KeyChar == (char)Keys.Back)
            {
                if (e.KeyChar == (char)Keys.Back)
                    tb_search_category.Text = tb_search_category.Text.Remove(tb_search_category.Text.Length - 1, 1);
                else
                    tb_search_category.Text += e.KeyChar;
                tb_search_category.Focus();
                tb_search_category.Select(tb_search_category.Text.Length, 0);
            }
            else if (e.KeyChar == (char)Keys.Enter)
            {
                tb_search_category.Focus();
                if (lb_category_search.SelectedItem != null)
                    tb_search_category.Text = lb_category_search.SelectedItem.ToString();
                tb_search_category.Select(tb_search_category.Text.Length, 0);
            }

        }
        private void lb_category_search_Leave(object sender, EventArgs e)
        {
            lb_category_search.Hide();
        }
        private void lb_category_search_DoubleClick(object sender, EventArgs e)
        {
            tb_search_category.Focus();
            if (lb_category_search.SelectedItem != null)
                tb_search_category.Text = lb_category_search.SelectedItem.ToString();
            tb_search_category.Select(tb_search_category.Text.Length, 0);
        }
        private void Fill_Category_Search_List_Box(string query)

        {
            lb_category_search.Items.Clear();

            DataTable dt = DataBaseEvents.ExecuteQuery(query, data_source);

            int rows_count = dt.Rows.Count;

            if (rows_count <= 0)
                return;

            for (int i = 0; i < rows_count; i++)
            {
                string item = dt.Rows[i][0].ToString();
                if (lb_category_search.Items.Contains(item))
                    continue;
                lb_category_search.Items.Add(item);
            }
        }
        // Searching events for receipts
        private void RadioButtonReceipt_CheckedChanged(object sender, EventArgs e)
        {
            this.pnl_receipt_st.Hide();
            this.show_pnl_rcpt_st = false;
        }
        private void Tb_search_receipt_TextChanged(object sender, EventArgs e)
        {
            string text = tb_search_receipt.Text.Trim();
            receipt_searched_already = false;

            if (chosen == MENU_CHOSEN.RECEIPTS)
            {
                if (text == "")
                {
                    lb_receipt_search.Hide();
                    lb_receipt_search.Items.Clear();

                    receipt_search_list.Delete_All_List();
                    main_receipt_list.Draw_All_Receipts();
                    return;
                }
                if (text == "Search a receipt")
                {
                    receipt_search_list.Delete_All_List();
                    main_receipt_list.Draw_All_Receipts();
                    return;
                }
                else
                {
                    this.pnl_receipt_list.VerticalScroll.Value = 0;

                    if (rb_receipt_name.Checked)
                    {
                        string query = string.Format("Select Receipt.NAME From Receipt Where Receipt.NAME Like '{0}%'", text);
                        Fill_Receipt_Search_List_Box(query);
                        if (lb_receipt_search.Items.Count > 0)
                            lb_receipt_search.Show();
                        return;
                    }
                    if (rb_receipt_id.Checked)
                    {
                        string query = string.Format("Select Receipt.RECEIPT_ID From Receipt Where Receipt.RECEIPT_ID Like '{0}%'", text);
                        Fill_Receipt_Search_List_Box(query);
                        if (lb_receipt_search.Items.Count > 0)
                            lb_receipt_search.Show();
                        return;
                    }
                    if (rb_receipt_u_name.Checked)
                    {
                        string query = string.Format("Select Users.NAME from Receipt Join Users On Receipt.USER_ID = Users.USER_ID Where Users.NAME Like '{0}%'", text);
                        Fill_Receipt_Search_List_Box(query);
                        if (lb_receipt_search.Items.Count > 0)
                            lb_receipt_search.Show();
                        return;
                    }
                    if (rb_receipt_b_name.Checked)
                    {
                        string query = string.Format("Select Books.NAME from Receipt Join Books On Receipt.BOOK_ID = Books.BOOK_ID Where Books.NAME Like '{0}%'", text);


                        Fill_Receipt_Search_List_Box(query);
                        if (lb_receipt_search.Items.Count > 0)
                            lb_receipt_search.Show();
                        return;
                    }
                    if (rb_receipt_l_name.Checked)
                    {
                        /*string query = string.Format("Select Users.GENDER From Users Where Users.GENDER Like '{0}%'", text);
                        Fill_User_Search_List_Box(query);
                        if (lb_receipt_search.Items.Count > 0)
                            lb_receip_search.Show();*/
                        return;
                    }
                    if (rb_receipt_date.Checked)
                    {
                        string query = string.Format("Select Receipt.CREATION_DATE From Receipt Where Receipt.CREATION_DATE Like '{0}%'", text);
                        Fill_Receipt_Search_List_Box(query);
                        if (lb_receipt_search.Items.Count > 0)
                            lb_receipt_search.Show();
                        return;
                    }
                }

            }

        }
        private void Tb_search_receipt_KeyPress(object sender, KeyPressEventArgs e)
        {
            string text = tb_search_receipt.Text;

            if (e.KeyChar == (char)Keys.Enter && !receipt_searched_already)
            {
                lb_receipt_search.Hide();
                if (tb_search_receipt.Text == "")
                {
                    return;
                }
                main_receipt_list.Hide_All_Receipt_Objects();
                receipt_search_list.Delete_All_List();
                this.pnl_receipt_list.VerticalScroll.Value = 0;

                if (rb_receipt_name.Checked)
                {
                    receipt_search_list.Fill_Receipt_List(Receipt.Search_Receipt_By_Name(text));
                    receipt_search_list.Draw_All_Receipts();
                    receipt_searched_already = true;
                    return;
                }
                if (rb_receipt_id.Checked)
                {
                    receipt_search_list.Fill_Receipt_List(Receipt.Search_Receipt_By_ID(text));
                    receipt_search_list.Draw_All_Receipts();
                    receipt_searched_already = true;
                    return;
                }
                if (rb_receipt_u_name.Checked)
                {
                    receipt_search_list.Fill_Receipt_List(Receipt.Search_Receipt_By_User_Name(text));
                    receipt_search_list.Draw_All_Receipts();
                    receipt_searched_already = true;
                    return;
                }
                if (rb_receipt_b_name.Checked)
                {
                    receipt_search_list.Fill_Receipt_List(Receipt.Search_Receipt_By_Book_Name(text));
                    receipt_search_list.Draw_All_Receipts();
                    receipt_searched_already = true;
                    return;
                }
                if (rb_receipt_l_name.Checked)
                {
                    /*receipt_search_list.Fill_receipt_List(receipt.Search_receipt_By_ID(text), INFO_COLOR_MODE.ID); ;
                    receipt_search_list.Draw_All_receipts();
                    receipt_searched_already = true*/
                    return;
                }
                if (rb_receipt_date.Checked)
                {
                    receipt_search_list.Fill_Receipt_List(Receipt.Search_Receipt_By_Date(text));
                    receipt_search_list.Draw_All_Receipts();
                    receipt_searched_already = true;
                    return;
                }
            }
        }
        private void Tb_search_receipt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                if (lb_receipt_search.Items.Count > 0)
                {
                    lb_receipt_search.Select();
                    lb_receipt_search.SelectedIndex = 0;
                }
            }
        }
        private void Lb_receipt_search_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetterOrDigit(e.KeyChar) || e.KeyChar == ' ' || e.KeyChar == (char)Keys.Back)
            {
                if (e.KeyChar == (char)Keys.Back)
                    tb_search_receipt.Text = tb_search_receipt.Text.Remove(tb_search_receipt.Text.Length - 1, 1);
                else
                    tb_search_receipt.Text += e.KeyChar;
                tb_search_receipt.Focus();
                tb_search_receipt.Select(tb_search_receipt.Text.Length, 0);
            }
            else if (e.KeyChar == (char)Keys.Enter)
            {
                tb_search_receipt.Focus();
                if (lb_receipt_search.SelectedItem != null)
                    tb_search_receipt.Text = lb_receipt_search.SelectedItem.ToString();
                tb_search_receipt.Select(tb_search_receipt.Text.Length, 0);
            }
        }
        private void Lb_receipt_search_Leave(object sender, EventArgs e)
        {
            lb_receipt_search.Hide();
        }
        private void Lb_receipt_search_DoubleClick(object sender, EventArgs e)
        {
            tb_search_receipt.Focus();
            if (lb_receipt_search.SelectedItem != null)
                tb_search_receipt.Text = lb_receipt_search.SelectedItem.ToString();
            tb_search_receipt.Select(tb_search_receipt.Text.Length, 0);
        }
        private void Tb_search_receipt_Enter(object sender, EventArgs e)
        {
            if (tb_search_receipt.Text == "Search a receipt")
            {
                tb_search_receipt.Text = "";
            }

            if (lb_receipt_search.Items.Count > 0)
                lb_receipt_search.Show();

            tb_search_receipt.ForeColor = Color.LightGray;

        }
        private void Tb_search_receipt_Leave(object sender, EventArgs e)
        {
            if (tb_search_receipt.Text == "")
            {
                tb_search_receipt.Text = "Search a receipt";
                tb_search_receipt.ForeColor = Color.Gray;
            }
        }
        private void Fill_Receipt_Search_List_Box(string query)
        {
            lb_receipt_search.Items.Clear();
            DataTable dt = DataBaseEvents.ExecuteQuery(query, data_source);

            int rows_count = dt.Rows.Count;

            if (rows_count <= 0)
                return;

            for(int i = 0; i < rows_count; i++)
            {
                string item = dt.Rows[i][0].ToString();
                if (lb_receipt_search.Items.Contains(item))
                    continue;
                lb_receipt_search.Items.Add(item);
            }

        }
        // Initilaze page
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pnl_home.Hide();
        }
        private void btn_show_all_emp_Click(object sender, EventArgs e)
        {
            if (show_employee == null)
            {
                show_employee = new ShowEmployee(null, manager);
            }

            try
            {
                show_employee.Show();
            }
            catch (ObjectDisposedException)
            {
                show_employee = new ShowEmployee(null, manager);
                show_employee.Show();
            }
        }

        private void Microwave_FormClosing(object sender, FormClosingEventArgs e)
        {
            Login login = (Login)Application.OpenForms["Login"];
            login.Close();
        }


        // Profile
        private void btn_profil_Click(object sender, EventArgs e)
        {
            Create_Profile_Form();
        }

       
    }

}

