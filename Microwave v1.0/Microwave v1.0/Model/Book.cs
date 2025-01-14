﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Windows.Forms;
using Microwave_v1._0.Classes;
using System.Data;
using System.Drawing;
using Microwave_v1._0.Model;
using Microwave_v1._0.UserControls;

namespace Microwave_v1._0
{   /* NOTE:
     * Book class includes all the information about books.
    */



    public class Book
    {
        // Global
        public static int point_y = 5; // Book infoları ekrana çizdirirken kullanılan offset.
        static Microwave main_page = null;
        private static string data_source = System.Configuration.ConfigurationManager.AppSettings["data_source"];
        // ID's
        private int book_id;
        private int author_id;
        private int publisher_id;
        private int category_id;
        private int shelf_id;
        private int popularity_id;
        private int librarian_id;
        // Variables
        private int popularity_score;
        private int count;
        private string name;
        private string date;           
        private string description; 
        private string cover_path_file; 
        private Book_Info info;
        private Book_Info_For_Shelf book_shelf_info;
        // From database
        private string author_name;
        private string publisher_name;
        private string category_name;
        private string shelf_name;
        private string popularity_name;


        // Getters and Setters 
        public string Date { get => date; set => date = value; }
        public int Count { get => count; set => count = value; }
        public string Description { get => description; set => description = value; }
        public string Cover_path_file { get => cover_path_file; set => cover_path_file = value; }
        public int Book_id { get => book_id; set => book_id = value; }
        public Book_Info Info { get => info; set => info = value; }
        public int Author_id { get => author_id; set => author_id = value; }
        public int Publisher_id { get => publisher_id; set => publisher_id = value; }
        public int Category_id { get => category_id; set => category_id = value; }
        public int Shelf_id { get => shelf_id; set => shelf_id = value; }
        public int Popularity_id { get => popularity_id; set => popularity_id = value; }
        public int Popularity_score { get => popularity_score; set => popularity_score = value; }
        public string Name { get => name; set => name = value; }
        public string Author_name { get => author_name; set => author_name = value; }
        public string Publisher_name { get => publisher_name; set => publisher_name = value; }
        public string Category_name { get => category_name; set => category_name = value; }
        public string Shelf_name { get => shelf_name; set => shelf_name = value; }
        public string Popularity_name { get => popularity_name; set => popularity_name = value; }
        public Book_Info_For_Shelf Book_shelf_info { get => book_shelf_info; set => book_shelf_info = value; }


        // Constructor
        public Book()
        {

        }
        public Book(int book_id, int author_id, int publisher_id, 
                    int category_id, int librarian_id, int shelf_id, 
                    string name, int count, string date, string description, 
                    string pic_path_file, int popularity_id, int popularity_score)
        {
            
            main_page = (Microwave)Application.OpenForms["Microwave"];
            this.book_id = book_id;
            this.author_id = author_id;
            this.publisher_id = publisher_id;
            this.category_id = category_id;
            this.librarian_id = librarian_id;
            this.shelf_id = shelf_id;
            this.name = name;
            this.date = date;
            this.count = count;
            this.description = description;
            this.cover_path_file = pic_path_file;
            this.popularity_score = popularity_score;
            this.popularity_id = popularity_id;

        }

       
        // Methods
        public void Add()
        {
            string title;
            string values;


            title = "INSERT INTO Books (AUTHOR_ID,PUBLISHER_ID, CATEGORY_ID, LIBRARIAN_ID, SHELF_ID, " +
                    "POPULARITY_ID, NAME, DATE, DESCRIPT, COUNT, COVER_PATH, POPULARITY_SCORE) ";

            values = string.Format("VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}', '{7}','{8}','{9}','{10}', '{11}')",
                                    author_id, publisher_id, category_id, librarian_id, shelf_id, popularity_id, name, date,
                                    description, count, cover_path_file, popularity_score);

            string query = title + values;

            DataBaseEvents.ExecuteNonQuery(query, data_source);

            // Take book id which is given by database automatically
            info = new Book_Info(main_page.Main_book_list, main_page.Book_search_list, main_page.Book_tag, main_page.Pnl_book_list);
            Shelf current = main_page.Main_shelf_list.Find_Shelf_By_ID(shelf_id);
            book_shelf_info = new Book_Info_For_Shelf(current);
            Take_Id_From_Database();

            Join_Tables_For_Names();

            info.Initialize_Book_Info(book_id, shelf_id, name, author_name, publisher_name, category_name, shelf_name, date, count, description, cover_path_file, INFO_COLOR_MODE.NORMAL);
            book_shelf_info.Initialize_Book_Info(book_id, name, author_name, publisher_name, category_name, count);

            Cover_Pic_to_Image_List();
            main_page.Main_book_list.Add_Book_to_List(this);
            current.Book_list.Add_Book_to_List(this);

            main_page.Pnl_book_list.VerticalScroll.Value = 0;

            Info.Draw_Book_Obj(ref Book.point_y);
            book_shelf_info.Draw_Book_Obj(ref current.point_book_x);
            Info.Select_Book_Info();
        }
        public void Edit()
        {
            

            string title = "UPDATE Books";
            string query = title + string.Format(" SET AUTHOR_ID = '{0}', PUBLISHER_ID = '{1}', CATEGORY_ID = '{2}', " +
                "SHELF_ID = '{3}', NAME = '{4}', DESCRIPT = '{5}', COUNT = '{6}', COVER_PATH = '{7}' " +
                "WHERE BOOK_ID = '{8}'", author_id, publisher_id, category_id, shelf_id, name, description, count, cover_path_file, book_id);

            int result = DataBaseEvents.ExecuteNonQuery(query, data_source);
            if (result <= 0)
            {
                MessageBox.Show("Invalid update event");
                return;
            }
            Join_Tables_For_Names();

            // For user interface
            info.Initialize_Book_Info(book_id, shelf_id, name, author_name, publisher_name,category_name, shelf_name, date, count, description, cover_path_file, INFO_COLOR_MODE.NORMAL);
            info.Select_Book_Info();
        }
        public void Delete()
        {
            string query;
            int result;

            query = "Delete From Receipt Where Receipt.BOOK_ID = " + book_id;
            result  = DataBaseEvents.ExecuteNonQuery(query, data_source);
            if (result <= 0)
            { 
                MessageBox.Show("Invalid delete operation");
                return;
            }

            main_page.Main_receipt_list.Delete_All_List();
            Receipt.Show_All_Receipts(main_page);

            query = "Delete From Book_User Where Book_User.BOOK_ID = " + book_id;
            result = DataBaseEvents.ExecuteNonQuery(query, data_source);
            if (result <= 0)
            {
                MessageBox.Show("Invalid delete operation");
                return;
            }

            query = "Delete From Books Where Books.BOOK_ID = " + book_id;

            result = DataBaseEvents.ExecuteNonQuery(query, data_source);
            if (result <= 0)
                MessageBox.Show("Delete is not valid");
            return;
        }
        static public void Show_All_Books(Microwave main_page)
        {
            string query = "Select * From Books ";
            DataTable dt = DataBaseEvents.ExecuteQuery(query, data_source);

            // Fills Book_List with DataTable
            main_page.Main_book_list.Fill_Book_List(dt, main_page.Main_book_list, main_page.Book_search_list, main_page.Book_tag, main_page.Pnl_book_list, INFO_COLOR_MODE.NORMAL);
        }

        public static DataTable Show_All_Books(User user)
        {
            string query = "Select Books.BOOK_ID As ID, Books.Name As Book,Authors.NAME As Author, Publishers.NAME As Publisher, Categories.NAME As Category, " +
                            "Shelves.NAME As Shelf, Popularity.NAME As Popularity, Books.POPULARITY_SCORE As Score, Books.DATE As Date, Book_User.COUNT as Count From Book_User " +
                            "Join Books On Book_User.BOOK_ID = Books.BOOK_ID " +
                            "Join Authors On Books.AUTHOR_ID = Authors.AUTHOR_ID " +
                            "Join Publishers On Books.PUBLISHER_ID = Publishers.PUBLISHER_ID " +
                            "Join Categories On Books.CATEGORY_ID = Categories.CATEGORY_ID " +
                            "Join Shelves On Books.SHELF_ID = Shelves.SHELF_ID " +
                            "Join Popularity On Books.POPULARITY_ID = Popularity.POPULARITY_ID " +
                            "Where Book_User.USER_ID = " + user.User_id;

            return DataBaseEvents.ExecuteQuery(query, data_source);
        }
        public static DataTable Show_All_Books(Author author)
        {
            string query = "SELECT Books.BOOK_ID AS ID, Books.NAME AS Book, Authors.NAME AS Author, Publishers.NAME AS Publisher, Categories.NAME AS Category, " +
                           "Shelves.NAME AS Shelf, Popularity.NAME AS Popularity, Books.POPULARITY_SCORE AS Score, Books.DATE AS Date FROM Books " +
                           "JOIN Authors ON Books.AUTHOR_ID = Authors.AUTHOR_ID " +
                           "JOIN Publishers ON Books.PUBLISHER_ID = Publishers.PUBLISHER_ID " +
                           "JOIN Categories ON Books.CATEGORY_ID = Categories.CATEGORY_ID " +
                           "JOIN Shelves ON Books.SHELF_ID = Shelves.SHELF_ID " +
                           "JOIN Popularity ON Books.POPULARITY_ID = Popularity.POPULARITY_ID " +
                           "WHERE Authors.AUTHOR_ID = " + author.Author_id;

            return DataBaseEvents.ExecuteQuery(query, data_source);

        }
        public static DataTable Show_All_Books(Publisher publisher)
        {
            string query = "SELECT Books.BOOK_ID AS ID, Books.NAME AS Book, Authors.NAME AS Author, Publishers.NAME AS Publisher, Categories.NAME AS Category, " +
                           "Shelves.NAME AS Shelf, Popularity.NAME AS Popularity, Books.POPULARITY_SCORE AS Score, Books.DATE AS Date FROM Books " +
                           "JOIN Authors ON Books.AUTHOR_ID = Authors.AUTHOR_ID " +
                           "JOIN Publishers ON Books.PUBLISHER_ID = Publishers.PUBLISHER_ID " +
                           "JOIN Categories ON Books.CATEGORY_ID = Categories.CATEGORY_ID " +
                           "JOIN Shelves ON Books.SHELF_ID = Shelves.SHELF_ID " +
                           "JOIN Popularity ON Books.POPULARITY_ID = Popularity.POPULARITY_ID " +
                           "WHERE Publishers.PUBLISHER_ID = " + publisher.Publisher_id;

            return DataBaseEvents.ExecuteQuery(query, data_source);

        }
        public static DataTable Show_All_Books(Category category)
        {
            string query = "SELECT Books.BOOK_ID AS ID, Books.NAME AS Book, Authors.NAME AS Author, Publishers.NAME AS Publisher, Categories.NAME AS Category, " +
                           "Shelves.NAME AS Shelf, Popularity.NAME AS Popularity, Books.POPULARITY_SCORE AS Score, Books.DATE AS Date FROM Books " +
                           "JOIN Authors ON Books.AUTHOR_ID = Authors.AUTHOR_ID " +
                           "JOIN Publishers ON Books.PUBLISHER_ID = Publishers.PUBLISHER_ID " +
                           "JOIN Categories ON Books.CATEGORY_ID = Categories.CATEGORY_ID " +
                           "JOIN Shelves ON Books.SHELF_ID = Shelves.SHELF_ID " +
                           "JOIN Popularity ON Books.POPULARITY_ID = Popularity.POPULARITY_ID " +
                           "WHERE Categories.CATEGORY_ID = " + category.Category_id;

            return DataBaseEvents.ExecuteQuery(query, data_source);

        }

        public void Set_Book(Book_List main_list, Book_List search_list, Book_Tag book_tag, Panel main_panel, INFO_COLOR_MODE color_mode)
        {
            Join_Tables_For_Names();

            info = new Book_Info(main_list, search_list, book_tag, main_panel);
            info.Initialize_Book_Info(book_id, shelf_id, name, author_name, publisher_name,category_name,shelf_name, date, count, description, cover_path_file, color_mode);
        }
        public void Set_Book(Shelf shelf)
        {
            Join_Tables_For_Names();

            book_shelf_info = new Book_Info_For_Shelf(shelf);
            book_shelf_info.Initialize_Book_Info(book_id, name, author_name, publisher_name, category_name, count);
        }

        static public DataTable Search_Book_By_Name(string name)
        {
            string query = string.Format("Select * From Books Where Books.NAME Like '{0}%'", name);
            DataTable dt = DataBaseEvents.ExecuteQuery(query, data_source);
            return dt;
        }
        static public DataTable Search_Book_By_ID(string book_id)
        {
            string query = string.Format("Select * From Books Where Books.BOOK_ID Like '{0}%'", book_id);
            DataTable dt = DataBaseEvents.ExecuteQuery(query, data_source);
            return dt;
        }
        static public DataTable Search_Book_By_Author(string author_name)
        {
            string query = string.Format("Select Books.BOOK_ID, Books.AUTHOR_ID, Books.PUBLISHER_ID, Books.CATEGORY_ID, Books.LIBRARIAN_ID, Books.SHELF_ID, " +
                                         "Books.POPULARITY_ID, Books.NAME, Books.DATE, Books.DESCRIPT, Books.COUNT, Books.COVER_PATH, " +
                                         "Books.POPULARITY_SCORE, Authors.NAME  From Books Join Authors On Books.AUTHOR_ID = Authors.AUTHOR_ID " +
                                         "Where Authors.NAME Like '{0}%'", author_name);
            DataTable dt = DataBaseEvents.ExecuteQuery(query, data_source);
            return dt;
        }
        static public DataTable Search_Book_By_Publisher(string pub_name)
        {
            string query = string.Format("Select Books.BOOK_ID, Books.AUTHOR_ID, Books.PUBLISHER_ID, Books.CATEGORY_ID, Books.LIBRARIAN_ID, Books.SHELF_ID, " +
                                         "Books.POPULARITY_ID, Books.NAME, Books.DATE, Books.DESCRIPT, Books.COUNT, Books.COVER_PATH, " +
                                         "Books.POPULARITY_SCORE, Publishers.NAME  From Books Join Publishers On Books.PUBLISHER_ID = Publishers.PUBLISHER_ID " +
                                         "Where Publishers.NAME Like '{0}%'", pub_name);
            DataTable dt = DataBaseEvents.ExecuteQuery(query, data_source);
            return dt;
        }
        static public DataTable Search_Book_By_Category(string ctg_name)
        {
            string query = string.Format("Select Books.BOOK_ID, Books.AUTHOR_ID, Books.PUBLISHER_ID, Books.CATEGORY_ID, Books.LIBRARIAN_ID, Books.SHELF_ID, " +
                                         "Books.POPULARITY_ID, Books.NAME, Books.DATE, Books.DESCRIPT, Books.COUNT, Books.COVER_PATH, " +
                                         "Books.POPULARITY_SCORE, Categories.NAME From Books Join Categories On Books.CATEGORY_ID = Categories.CATEGORY_ID " +
                                         "Where Categories.NAME Like '{0}%'", ctg_name);
            DataTable dt = DataBaseEvents.ExecuteQuery(query, data_source);
            return dt;
        }
        static public DataTable Search_Book_By_Shelf(string shelf_name)
        {
            string query = string.Format("Select Books.BOOK_ID, Books.AUTHOR_ID, Books.PUBLISHER_ID, Books.CATEGORY_ID, Books.LIBRARIAN_ID, Books.SHELF_ID, " +
                                         "Books.POPULARITY_ID, Books.NAME, Books.DATE, Books.DESCRIPT, Books.COUNT, Books.COVER_PATH, " +
                                         "Books.POPULARITY_SCORE, Shelves.NAME  From Books Join Shelves On Books.SHELF_ID = Shelves.SHELF_ID " +
                                         "Where Shelves.NAME Like '{0}%'", shelf_name);
            DataTable dt = DataBaseEvents.ExecuteQuery(query, data_source);
            return dt;
        }
        static public DataTable Search_Book_By_Popularity(string pop_name)
        {
            string query = string.Format("Select Books.BOOK_ID, Books.AUTHOR_ID, Books.PUBLISHER_ID, Books.CATEGORY_ID, Books.LIBRARIAN_ID, Books.SHELF_ID, " +
                                         "Books.POPULARITY_ID, Books.NAME, Books.DATE, Books.DESCRIPT, Books.COUNT, Books.COVER_PATH, " +
                                         "Books.POPULARITY_SCORE, Popularity.NAME  From Books Join Popularity On Books.POPULARITY_ID = Popularity.POPULARITY_ID " +
                                         "Where Popularity.NAME Like '{0}%'", pop_name);
            DataTable dt = DataBaseEvents.ExecuteQuery(query, data_source);
            return dt;
        }

        public void Change_Popularity_Score() 
        {
            string query = string.Format("Update Books Set POPULARITY_SCORE = '{0}' Where BOOK_ID = '{1}'", popularity_score, book_id);
            DataBaseEvents.ExecuteNonQuery(query, data_source);

            Change_Popularity_Stat();
        }
        private void Change_Popularity_Stat() 
        {
            string query = string.Format("Select * From Popularity Order By SCORE");
            DataTable dt = DataBaseEvents.ExecuteQuery(query, data_source);

            List<Popularity> pop_list = new List<Popularity>();

            int rows_count = dt.Rows.Count;

            if (rows_count <= 1)
                this.popularity_id = 0;
            else
            {
                for(int i = 0; i < rows_count; i++)
                {
                    int id = int.Parse(dt.Rows[i][0].ToString());
                    string name = dt.Rows[i][1].ToString();
                    int score = int.Parse(dt.Rows[i][2].ToString());

                    Popularity curr_pop = new Popularity(id, name, score);

                    pop_list.Add(curr_pop);
                }
            }

            for(int i = 0; i < pop_list.Count; i++)
            {
                if (this.popularity_score >= pop_list[i].Base_score)
                {
                    this.popularity_id = pop_list[i].Pop_id;
                    this.popularity_name = pop_list[i].Name;
                }
            }


            string query_edit = string.Format("Update Books Set POPULARITY_ID = '{0}' where BOOK_ID = '{1}'", this.popularity_id, this.book_id);
            DataBaseEvents.ExecuteNonQuery(query_edit, data_source);

            Book exact = main_page.Main_book_list.Find_Book_By_ID(this.book_id);
            exact.Popularity_score = this.popularity_score;
            exact.Popularity_name = this.popularity_name;
        }
        public void Give_Book_To_User(User user) 
        {
            this.count--;

            string query_select = string.Format("Select * From Book_User Where Book_User.BOOK_ID = '{0}' and Book_User.USER_ID = '{1}'", this.book_id, user.User_id);

            DataTable dt = DataBaseEvents.ExecuteQuery(query_select, data_source);
            
            if(dt.Rows.Count > 0)
            {
                int count = int.Parse(dt.Rows[0][3].ToString());
                count++;

                string query_update = string.Format("Update Book_User Set Count = '{0}' Where Book_User.BOOK_ID = '{1}' and Book_User.USER_ID = '{2}'", count, this.book_id, user.User_id);
                DataBaseEvents.ExecuteNonQuery(query_update, data_source);
            }
            else
            {
                string query_insert = string.Format("Insert into Book_User(BOOK_ID, USER_ID, COUNT) Values({0}, {1}, {2})", this.book_id, user.User_id, 1);
                int result = DataBaseEvents.ExecuteNonQuery(query_insert, data_source);
                if (result <= 0)
                {
                    MessageBox.Show("Invalid insert operation");
                    return;
                }
            }


            Book exact = main_page.Main_book_list.Find_Book_By_ID(this.book_id);
            exact.Count--;
            exact.Change_Count();

           

            Receipt receipt = new Informer(0, this.book_id, user.User_id, main_page.Manager.Employee_id, "CHECKED IN", MODE.GIVE);
            receipt.Add();
        }
        public void Change_Count() 
        {
            this.info.Initialize_Book_Info(book_id, shelf_id, name, author_name, publisher_name, category_name, shelf_name, date, count, description, cover_path_file, INFO_COLOR_MODE.NORMAL);

            string query = string.Format("Update Books Set COUNT = {0} Where Books.BOOK_ID = {1}", count, book_id);
            
            int result = DataBaseEvents.ExecuteNonQuery(query, data_source);
            if(result <= 0)
            {
                MessageBox.Show("Invalid update operation - count");
                return;
            }

        }

        // Background Database Events
        private void Join_Tables_For_Names()
        {

            string query = "Select Authors.NAME, Publishers.NAME, Categories.NAME, Shelves.NAME, Popularity.NAME from Books " +
                            "Join Authors On Books.AUTHOR_ID = Authors.AUTHOR_ID " +
                            "Join Publishers On Books.PUBLISHER_ID = Publishers.PUBLISHER_ID " +
                            "Join Categories On Books.CATEGORY_ID = Categories.CATEGORY_ID " +
                            "Join Shelves On Books.SHELF_ID = Shelves.SHELF_ID " +
                            "Join Popularity On Books.POPULARITY_ID = Popularity.POPULARITY_ID " +
                            "Where Books.BOOK_ID = " + book_id;

            DataTable names_table = DataBaseEvents.ExecuteQuery(query, data_source);

            author_name = names_table.Rows[0][0].ToString();
            publisher_name = names_table.Rows[0][1].ToString();
            category_name = names_table.Rows[0][2].ToString();
            shelf_name = names_table.Rows[0][3].ToString();
            popularity_name = names_table.Rows[0][4].ToString();

        }
        private void Take_Id_From_Database()
        {
            // To take the id of new book.
            string title = "SELECT Books.BOOK_ID FROM Books ";
            string query = title + string.Format("Where NAME = '{0}' AND PUBLISHER_ID = '{1}';", name, publisher_id);

            DataTable dt = DataBaseEvents.ExecuteQuery(query, data_source);

            int id = int.Parse(dt.Rows[0][0].ToString());
            this.book_id = id;
            
            
            // For user inteface
            this.Info.Book_id = id; // IMPORTANT
        }
        // Adds the cover picture of this book to the image list on the main form by giving its id as a key
        public void Cover_Pic_to_Image_List()
        {
            main_page.Cover_image_list.Images.Add(this.book_id.ToString(), Picture_Events.Get_Copy_Image_Bitmap(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\" + this.cover_path_file));
        } 
    }
}
