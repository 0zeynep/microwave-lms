﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Windows.Forms;
using Microwave_v1._0.Classes;
using System.Data;

namespace Microwave_v1._0
{   /* NOTE:
     * Book class includes all the information about books.
    */
    public class Book
    {
        // Global
        public static int point_y = 5; // Book infoları ekrana çizdirirken kullanılan offset.
        static Microwave main_page = null;
        static private string datasource = @"data source = ..\..\Resources\Databases\LMS_Database.db";
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

        
        // Constructor
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

            // Take infos from database by matching with ID's
            Join_Tables_For_Names();

            info = new Book_Info();
            info.Initialize_Book_Info(book_id, name, author_name, publisher_name, date, count, description, cover_path_file);

        }

        // Methods
        public void Add()
        {
            string title;
            string values;

            if(main_page.Main_list.Is_List_Empty())
            {
                int starter_id = 05101900;
                title = "INSERT INTO Books (BOOK_ID,AUTHOR_ID,PUBLISHER_ID, CATEGORY_ID, LIBRARIAN_ID, " +
                        "SHELF_ID, POPULARITY_ID, NAME, DATE, DESCRIPT, COUNT, COVER_PATH, POPULARITY_SCORE) ";

                values = string.Format("VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}', '{7}','{8}','{9}','{10}', '{11}','{12}')",
                                       starter_id, author_id, publisher_id, category_id, librarian_id, shelf_id, popularity_id, name, 
                                       date,description, count, cover_path_file, popularity_score);
            }
            else
            {
                title = "INSERT INTO Books (AUTHOR_ID,PUBLISHER_ID, CATEGORY_ID, LIBRARIAN_ID, SHELF_ID, " +
                        "POPULARITY_ID, NAME, DATE, DESCRIPT, COUNT, COVER_PATH, POPULARITY_SCORE) ";

                values = string.Format("VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}', '{7}','{8}','{9}','{10}', '{11}')", 
                                        author_id, publisher_id, category_id, librarian_id, shelf_id, popularity_id, name, date,
                                        description, count, cover_path_file, popularity_score);
            }

            string query = title + values;

            DataBaseEvents.ExecuteNonQuery(query, datasource);

            // Take book id which is given by database automatically
            Take_Id_From_Database();

            Cover_Pic_to_Image_List();
            main_page.Main_list.Add_Book_to_List(this);

            main_page.Pnl_book_list.VerticalScroll.Value = 0;

            Info.Draw_Book_Obj(ref Book.point_y);

            main_page.Main_list.Deselect_All_Book_Infos();
            Info.Select_Book_Info();
        }
        public void Edit()
        {
            Join_Tables_For_Names();

            string title = "UPDATE Books";
            string query = title + string.Format(" SET AUTHOR_ID = '{0}', PUBLISHER_ID = '{1}', CATEGORY_ID = '{2}', " +
                "SHELF_ID = '{3}', NAME = '{4}', DESCRIPT = '{5}', COUNT = '{6}', COVER_PATH = '{7}' " +
                "WHERE BOOK_ID = '{8}'", author_id, publisher_id, category_id, shelf_id, name, description, count, cover_path_file, book_id);

            int result = DataBaseEvents.ExecuteNonQuery(query, datasource);
            if (result <= 0)
            {
                MessageBox.Show("Invalid update event");
                return;
            }


            // For user interface
            info.Initialize_Book_Info(book_id, name, author_name, publisher_name, date, count, description, cover_path_file);
            info.Select_Book_Info();
        }
        public void Delete()
        {
            string title = "DELETE FROM Books ";
            string query = title + string.Format("Where BOOK_ID = '{0}';", book_id);

            int result = DataBaseEvents.ExecuteNonQuery(query, datasource);
            if (result <= 0)
                MessageBox.Show("Delete is not valid");
            return;
        }
        static public void Show_All_Books()
        {
            string query = "Select * From Books ";
            DataTable dt = DataBaseEvents.ExecuteQuery(query, datasource);


            // For User Interface
            main_page = (Microwave)Application.OpenForms["Microwave"];
            // Fills Book_List with DataTable
            main_page.Main_list.Fill_Book_List(dt);
            main_page.Main_list.Show_All_Books();

        }

        static public void Show_All_Books(User user)
        {
        }


        // TODO:
        static public DataTable Search_Book_By_ID() { return null; }
        static public DataTable Search_Book_By_Name() { return null; }
        static public DataTable Search_Book_By_Author() { return null; }
        static public DataTable Search_Book_By_Publisher() { return null; }
        static public DataTable Search_Book_By_Category() { return null; }
        static public DataTable Search_Book_By_Shelf() { return null; }
        static public DataTable Search_Book_By_Popularity() { return null; }
        public void Calculate_Popularity_Score() { }
        public void Give_Book_To_User() { }
        private void Change_Popularity_Stat() { }
        private void Change_Count_In_Database() { }




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

            DataTable names_table = DataBaseEvents.ExecuteQuery(query, datasource);

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

            DataTable dt = DataBaseEvents.ExecuteQuery(query, datasource);

            int id = int.Parse(dt.Rows[0][0].ToString());
            this.book_id = id;
            
            
            // For user inteface
            this.Info.Book_id = id; // IMPORTANT
        }

        // Adds the cover picture of this book to the image list on the main form by giving its id as a key
        public void Cover_Pic_to_Image_List()
        {
            main_page.Cover_image_list.Images.Add(this.book_id.ToString(), Picture_Events.Get_Copy_Image_Bitmap(this.cover_path_file));
        }


        
    }
}