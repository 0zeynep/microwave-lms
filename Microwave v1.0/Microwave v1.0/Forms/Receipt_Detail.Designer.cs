﻿namespace Microwave_v1._0.Forms
{
    partial class Receipt_Detail
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Receipt_Detail));
            this.pnl_main = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.lbl_message = new System.Windows.Forms.Label();
            this.tb_message = new System.Windows.Forms.RichTextBox();
            this.btn_remove = new System.Windows.Forms.Button();
            this.lbl_user_email_val = new System.Windows.Forms.Label();
            this.lbl_users_email = new System.Windows.Forms.Label();
            this.lbl_lib_name_val = new System.Windows.Forms.Label();
            this.lbl_lib_id_val = new System.Windows.Forms.Label();
            this.lbl_user_name_val = new System.Windows.Forms.Label();
            this.lbl_user_id_val = new System.Windows.Forms.Label();
            this.lbl_book_name_val = new System.Windows.Forms.Label();
            this.lbl_book_id_val = new System.Windows.Forms.Label();
            this.lbl_libs_name = new System.Windows.Forms.Label();
            this.lbl_users_name = new System.Windows.Forms.Label();
            this.lbl_books_name = new System.Windows.Forms.Label();
            this.lbl_libs_id = new System.Windows.Forms.Label();
            this.lbl_users_id = new System.Windows.Forms.Label();
            this.lbl_books_id = new System.Windows.Forms.Label();
            this.pb_book = new System.Windows.Forms.PictureBox();
            this.pnl_drag = new System.Windows.Forms.Panel();
            this.lbl_pt_name = new System.Windows.Forms.Label();
            this.lbl_rcpt_name = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lbl_date = new System.Windows.Forms.Label();
            this.print_document = new System.Drawing.Printing.PrintDocument();
            this.print_prev = new System.Windows.Forms.PrintPreviewDialog();
            this.drag_control = new Microwave_v1._0.DragControl();
            this.pnl_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_book)).BeginInit();
            this.pnl_drag.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_main
            // 
            this.pnl_main.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(38)))));
            this.pnl_main.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_main.Controls.Add(this.button2);
            this.pnl_main.Controls.Add(this.lbl_message);
            this.pnl_main.Controls.Add(this.tb_message);
            this.pnl_main.Controls.Add(this.btn_remove);
            this.pnl_main.Controls.Add(this.lbl_user_email_val);
            this.pnl_main.Controls.Add(this.lbl_users_email);
            this.pnl_main.Controls.Add(this.lbl_lib_name_val);
            this.pnl_main.Controls.Add(this.lbl_lib_id_val);
            this.pnl_main.Controls.Add(this.lbl_user_name_val);
            this.pnl_main.Controls.Add(this.lbl_user_id_val);
            this.pnl_main.Controls.Add(this.lbl_book_name_val);
            this.pnl_main.Controls.Add(this.lbl_book_id_val);
            this.pnl_main.Controls.Add(this.lbl_libs_name);
            this.pnl_main.Controls.Add(this.lbl_users_name);
            this.pnl_main.Controls.Add(this.lbl_books_name);
            this.pnl_main.Controls.Add(this.lbl_libs_id);
            this.pnl_main.Controls.Add(this.lbl_users_id);
            this.pnl_main.Controls.Add(this.lbl_books_id);
            this.pnl_main.Controls.Add(this.pb_book);
            this.pnl_main.Controls.Add(this.pnl_drag);
            this.pnl_main.Location = new System.Drawing.Point(0, 0);
            this.pnl_main.Name = "pnl_main";
            this.pnl_main.Size = new System.Drawing.Size(600, 300);
            this.pnl_main.TabIndex = 25;
            // 
            // button2
            // 
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(546, 211);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(39, 34);
            this.button2.TabIndex = 26;
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lbl_message
            // 
            this.lbl_message.AutoSize = true;
            this.lbl_message.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_message.ForeColor = System.Drawing.Color.White;
            this.lbl_message.Location = new System.Drawing.Point(40, 211);
            this.lbl_message.Name = "lbl_message";
            this.lbl_message.Size = new System.Drawing.Size(76, 16);
            this.lbl_message.TabIndex = 23;
            this.lbl_message.Text = "Message:";
            // 
            // tb_message
            // 
            this.tb_message.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(38)))));
            this.tb_message.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_message.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_message.ForeColor = System.Drawing.Color.White;
            this.tb_message.Location = new System.Drawing.Point(151, 211);
            this.tb_message.Name = "tb_message";
            this.tb_message.ReadOnly = true;
            this.tb_message.Size = new System.Drawing.Size(378, 75);
            this.tb_message.TabIndex = 22;
            this.tb_message.Text = "";
            // 
            // btn_remove
            // 
            this.btn_remove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_remove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_remove.FlatAppearance.BorderSize = 0;
            this.btn_remove.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_remove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_remove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_remove.ForeColor = System.Drawing.Color.White;
            this.btn_remove.Image = ((System.Drawing.Image)(resources.GetObject("btn_remove.Image")));
            this.btn_remove.Location = new System.Drawing.Point(546, 252);
            this.btn_remove.Margin = new System.Windows.Forms.Padding(2);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(39, 34);
            this.btn_remove.TabIndex = 21;
            this.btn_remove.UseVisualStyleBackColor = true;
            this.btn_remove.Click += new System.EventHandler(this.btn_remove_Click);
            // 
            // lbl_user_email_val
            // 
            this.lbl_user_email_val.AutoSize = true;
            this.lbl_user_email_val.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_user_email_val.ForeColor = System.Drawing.Color.White;
            this.lbl_user_email_val.Location = new System.Drawing.Point(284, 119);
            this.lbl_user_email_val.Name = "lbl_user_email_val";
            this.lbl_user_email_val.Size = new System.Drawing.Size(158, 16);
            this.lbl_user_email_val.TabIndex = 18;
            this.lbl_user_email_val.Text = "rsltnyldzz@gmail.com";
            // 
            // lbl_users_email
            // 
            this.lbl_users_email.AutoSize = true;
            this.lbl_users_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_users_email.ForeColor = System.Drawing.Color.White;
            this.lbl_users_email.Location = new System.Drawing.Point(148, 119);
            this.lbl_users_email.Name = "lbl_users_email";
            this.lbl_users_email.Size = new System.Drawing.Size(100, 16);
            this.lbl_users_email.TabIndex = 17;
            this.lbl_users_email.Text = "User\'s Email:";
            // 
            // lbl_lib_name_val
            // 
            this.lbl_lib_name_val.AutoSize = true;
            this.lbl_lib_name_val.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_lib_name_val.ForeColor = System.Drawing.Color.White;
            this.lbl_lib_name_val.Location = new System.Drawing.Point(284, 161);
            this.lbl_lib_name_val.Name = "lbl_lib_name_val";
            this.lbl_lib_name_val.Size = new System.Drawing.Size(160, 16);
            this.lbl_lib_name_val.TabIndex = 14;
            this.lbl_lib_name_val.Text = "Doğan Dinçer Demirci";
            // 
            // lbl_lib_id_val
            // 
            this.lbl_lib_id_val.AutoSize = true;
            this.lbl_lib_id_val.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_lib_id_val.ForeColor = System.Drawing.Color.White;
            this.lbl_lib_id_val.Location = new System.Drawing.Point(284, 177);
            this.lbl_lib_id_val.Name = "lbl_lib_id_val";
            this.lbl_lib_id_val.Size = new System.Drawing.Size(16, 16);
            this.lbl_lib_id_val.TabIndex = 13;
            this.lbl_lib_id_val.Text = "0";
            // 
            // lbl_user_name_val
            // 
            this.lbl_user_name_val.AutoSize = true;
            this.lbl_user_name_val.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_user_name_val.ForeColor = System.Drawing.Color.White;
            this.lbl_user_name_val.Location = new System.Drawing.Point(284, 103);
            this.lbl_user_name_val.Name = "lbl_user_name_val";
            this.lbl_user_name_val.Size = new System.Drawing.Size(176, 16);
            this.lbl_user_name_val.TabIndex = 12;
            this.lbl_user_name_val.Text = "Nurettin Resul Tanyıldızı";
            // 
            // lbl_user_id_val
            // 
            this.lbl_user_id_val.AutoSize = true;
            this.lbl_user_id_val.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_user_id_val.ForeColor = System.Drawing.Color.White;
            this.lbl_user_id_val.Location = new System.Drawing.Point(284, 136);
            this.lbl_user_id_val.Name = "lbl_user_id_val";
            this.lbl_user_id_val.Size = new System.Drawing.Size(24, 16);
            this.lbl_user_id_val.TabIndex = 11;
            this.lbl_user_id_val.Text = "32";
            // 
            // lbl_book_name_val
            // 
            this.lbl_book_name_val.AutoSize = true;
            this.lbl_book_name_val.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_book_name_val.ForeColor = System.Drawing.Color.White;
            this.lbl_book_name_val.Location = new System.Drawing.Point(284, 61);
            this.lbl_book_name_val.Name = "lbl_book_name_val";
            this.lbl_book_name_val.Size = new System.Drawing.Size(171, 16);
            this.lbl_book_name_val.TabIndex = 10;
            this.lbl_book_name_val.Text = "Türkiye\'nin Yakın Tarihi";
            // 
            // lbl_book_id_val
            // 
            this.lbl_book_id_val.AutoSize = true;
            this.lbl_book_id_val.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_book_id_val.ForeColor = System.Drawing.Color.White;
            this.lbl_book_id_val.Location = new System.Drawing.Point(284, 77);
            this.lbl_book_id_val.Name = "lbl_book_id_val";
            this.lbl_book_id_val.Size = new System.Drawing.Size(24, 16);
            this.lbl_book_id_val.TabIndex = 9;
            this.lbl_book_id_val.Text = "45";
            // 
            // lbl_libs_name
            // 
            this.lbl_libs_name.AutoSize = true;
            this.lbl_libs_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_libs_name.ForeColor = System.Drawing.Color.White;
            this.lbl_libs_name.Location = new System.Drawing.Point(148, 161);
            this.lbl_libs_name.Name = "lbl_libs_name";
            this.lbl_libs_name.Size = new System.Drawing.Size(130, 16);
            this.lbl_libs_name.TabIndex = 8;
            this.lbl_libs_name.Text = "Librarian\'s Name:";
            // 
            // lbl_users_name
            // 
            this.lbl_users_name.AutoSize = true;
            this.lbl_users_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_users_name.ForeColor = System.Drawing.Color.White;
            this.lbl_users_name.Location = new System.Drawing.Point(148, 103);
            this.lbl_users_name.Name = "lbl_users_name";
            this.lbl_users_name.Size = new System.Drawing.Size(102, 16);
            this.lbl_users_name.TabIndex = 7;
            this.lbl_users_name.Text = "User\'s Name:";
            // 
            // lbl_books_name
            // 
            this.lbl_books_name.AutoSize = true;
            this.lbl_books_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_books_name.ForeColor = System.Drawing.Color.White;
            this.lbl_books_name.Location = new System.Drawing.Point(148, 61);
            this.lbl_books_name.Name = "lbl_books_name";
            this.lbl_books_name.Size = new System.Drawing.Size(105, 16);
            this.lbl_books_name.TabIndex = 6;
            this.lbl_books_name.Text = "Book\'s Name:";
            // 
            // lbl_libs_id
            // 
            this.lbl_libs_id.AutoSize = true;
            this.lbl_libs_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_libs_id.ForeColor = System.Drawing.Color.White;
            this.lbl_libs_id.Location = new System.Drawing.Point(148, 177);
            this.lbl_libs_id.Name = "lbl_libs_id";
            this.lbl_libs_id.Size = new System.Drawing.Size(104, 16);
            this.lbl_libs_id.TabIndex = 3;
            this.lbl_libs_id.Text = "Librarian\'s ID:";
            // 
            // lbl_users_id
            // 
            this.lbl_users_id.AutoSize = true;
            this.lbl_users_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_users_id.ForeColor = System.Drawing.Color.White;
            this.lbl_users_id.Location = new System.Drawing.Point(148, 136);
            this.lbl_users_id.Name = "lbl_users_id";
            this.lbl_users_id.Size = new System.Drawing.Size(76, 16);
            this.lbl_users_id.TabIndex = 2;
            this.lbl_users_id.Text = "User\'s ID:";
            // 
            // lbl_books_id
            // 
            this.lbl_books_id.AutoSize = true;
            this.lbl_books_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_books_id.ForeColor = System.Drawing.Color.White;
            this.lbl_books_id.Location = new System.Drawing.Point(148, 77);
            this.lbl_books_id.Name = "lbl_books_id";
            this.lbl_books_id.Size = new System.Drawing.Size(79, 16);
            this.lbl_books_id.TabIndex = 1;
            this.lbl_books_id.Text = "Book\'s ID:";
            // 
            // pb_book
            // 
            this.pb_book.Image = ((System.Drawing.Image)(resources.GetObject("pb_book.Image")));
            this.pb_book.Location = new System.Drawing.Point(16, 56);
            this.pb_book.Name = "pb_book";
            this.pb_book.Size = new System.Drawing.Size(100, 137);
            this.pb_book.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_book.TabIndex = 0;
            this.pb_book.TabStop = false;
            // 
            // pnl_drag
            // 
            this.pnl_drag.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(35)))));
            this.pnl_drag.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_drag.Controls.Add(this.lbl_pt_name);
            this.pnl_drag.Controls.Add(this.lbl_rcpt_name);
            this.pnl_drag.Controls.Add(this.button1);
            this.pnl_drag.Controls.Add(this.lbl_date);
            this.pnl_drag.Location = new System.Drawing.Point(-1, -1);
            this.pnl_drag.Name = "pnl_drag";
            this.pnl_drag.Size = new System.Drawing.Size(600, 50);
            this.pnl_drag.TabIndex = 25;
            // 
            // lbl_pt_name
            // 
            this.lbl_pt_name.AutoSize = true;
            this.lbl_pt_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pt_name.ForeColor = System.Drawing.Color.Red;
            this.lbl_pt_name.Location = new System.Drawing.Point(122, 18);
            this.lbl_pt_name.Name = "lbl_pt_name";
            this.lbl_pt_name.Size = new System.Drawing.Size(0, 24);
            this.lbl_pt_name.TabIndex = 25;
            // 
            // lbl_rcpt_name
            // 
            this.lbl_rcpt_name.AutoSize = true;
            this.lbl_rcpt_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_rcpt_name.ForeColor = System.Drawing.Color.White;
            this.lbl_rcpt_name.Location = new System.Drawing.Point(12, 18);
            this.lbl_rcpt_name.Name = "lbl_rcpt_name";
            this.lbl_rcpt_name.Size = new System.Drawing.Size(163, 24);
            this.lbl_rcpt_name.TabIndex = 4;
            this.lbl_rcpt_name.Text = "RECEIPT NAME";
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(548, 6);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(39, 34);
            this.button1.TabIndex = 24;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_date.ForeColor = System.Drawing.Color.White;
            this.lbl_date.Location = new System.Drawing.Point(421, 24);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(80, 16);
            this.lbl_date.TabIndex = 5;
            this.lbl_date.Text = "02.12.2019";
            // 
            // print_document
            // 
            this.print_document.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.print_document_PrintPage);
            // 
            // print_prev
            // 
            this.print_prev.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.print_prev.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.print_prev.ClientSize = new System.Drawing.Size(400, 300);
            this.print_prev.Enabled = true;
            this.print_prev.Icon = ((System.Drawing.Icon)(resources.GetObject("print_prev.Icon")));
            this.print_prev.Name = "print_prev";
            this.print_prev.ShowIcon = false;
            this.print_prev.Visible = false;
            // 
            // drag_control
            // 
            this.drag_control.SelectControl = this.pnl_drag;
            // 
            // Receipt_Detail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 300);
            this.Controls.Add(this.pnl_main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Receipt_Detail";
            this.Opacity = 0.95D;
            this.Text = "Receipt_Detail";
            this.Load += new System.EventHandler(this.Receipt_Detail_Load);
            this.pnl_main.ResumeLayout(false);
            this.pnl_main.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_book)).EndInit();
            this.pnl_drag.ResumeLayout(false);
            this.pnl_drag.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_main;
        private System.Windows.Forms.Label lbl_message;
        private System.Windows.Forms.RichTextBox tb_message;
        private System.Windows.Forms.Button btn_remove;
        private System.Windows.Forms.Label lbl_user_email_val;
        private System.Windows.Forms.Label lbl_users_email;
        private System.Windows.Forms.Label lbl_lib_name_val;
        private System.Windows.Forms.Label lbl_lib_id_val;
        private System.Windows.Forms.Label lbl_user_name_val;
        private System.Windows.Forms.Label lbl_user_id_val;
        private System.Windows.Forms.Label lbl_book_name_val;
        private System.Windows.Forms.Label lbl_book_id_val;
        private System.Windows.Forms.Label lbl_libs_name;
        private System.Windows.Forms.Label lbl_users_name;
        private System.Windows.Forms.Label lbl_books_name;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.Label lbl_rcpt_name;
        private System.Windows.Forms.Label lbl_libs_id;
        private System.Windows.Forms.Label lbl_users_id;
        private System.Windows.Forms.Label lbl_books_id;
        private System.Windows.Forms.PictureBox pb_book;
        private System.Windows.Forms.Button button1;
        private DragControl drag_control;
        private System.Windows.Forms.Panel pnl_drag;
        private System.Windows.Forms.Button button2;
        private System.Drawing.Printing.PrintDocument print_document;
        private System.Windows.Forms.PrintPreviewDialog print_prev;
        private System.Windows.Forms.Label lbl_pt_name;
    }
}