﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Microwave_v1._0.Forms
{
    public partial class Detail : Form
    {
        public Detail()
        {
            InitializeComponent();
        }

        public Detail(Book book)
        {
            InitializeComponent();

            this.btn_give_book.Hide();
            this.btn_give_penalty.Hide();
            this.btn_return_book.Hide();

            this.btn_id.Text = book.Book_id.ToString();
            this.lbl_date.Text = book.Date.Substring(0,10);

            this.lbl_name.Text = book.Name; // Label for name

            this.lbl_1.Text = "Author:";
            this.lbl_2.Text = "Publisher:";
            this.lbl_3.Text = "Category:";
            this.lbl_4.Text = "Shelf:";
            this.lbl_5.Text = "Popularity:";
            this.lbl_6.Text = "Count:";
            this.lbl_desc.Text = "Users which have that book currently:";

            this.tb_1.Text = book.Author_name;
            this.tb_2.Text = book.Publisher_name;
            this.tb_3.Text = book.Category_name;
            this.tb_4.Text = "#" + book.Shelf_name;
            this.tb_5.Text = book.Popularity_name + " ( " + book.Popularity_score + " )";
            this.tb_6.Text = book.Count.ToString();

            this.picture_box.Image = Picture_Events.Get_Copy_Image_Bitmap(book.Cover_path_file);
        }

        public Detail(User user)
        {
            InitializeComponent();

            this.btn_give_book.Show();
            this.btn_give_penalty.Show();
            this.btn_return_book.Show();

            this.btn_id.Text = user.User_id.ToString();
            this.lbl_date.Text = user.Date.Substring(0, 10);

            this.lbl_name.Text = user.Name + " " + user.Surname;

            this.lbl_1.Text = "Email:";
            this.lbl_2.Text = "Gender:";
            this.lbl_3.Text = "Password:";
            this.lbl_4.Text = "Age:";
            this.lbl_5.Text = "Total Fee:";
            this.lbl_6.Hide();

            this.lbl_desc.Text = "Books that user currently has:";

            this.tb_1.Text = user.Email;
            this.tb_2.Text = user.Gender;
            this.tb_3.Text = user.Password;
            this.tb_4.Text = user.Age.ToString();
            this.tb_5.Text = "15₺";
            this.tb_6.Hide();

            picture_box.Image = global::Microwave_v1._0.Properties.Resources.man_user__2_;
        }


    }
}