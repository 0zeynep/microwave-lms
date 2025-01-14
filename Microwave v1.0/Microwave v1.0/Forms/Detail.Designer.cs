﻿using System.Windows.Forms;

namespace Microwave_v1._0.Forms
{
    partial class Detail
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Detail));
            this.pnl_main = new System.Windows.Forms.Panel();
            this.pnl_change_pass = new System.Windows.Forms.Panel();
            this.lbl_msg = new System.Windows.Forms.Label();
            this.lbl_power = new System.Windows.Forms.Label();
            this.pnl_pow3 = new System.Windows.Forms.Panel();
            this.pnl_pow2 = new System.Windows.Forms.Panel();
            this.pnl_pow1 = new System.Windows.Forms.Panel();
            this.tb_pass_confirm = new System.Windows.Forms.TextBox();
            this.lbl_confirm = new System.Windows.Forms.Label();
            this.tb_new_pass = new System.Windows.Forms.TextBox();
            this.lbl_new_pass = new System.Windows.Forms.Label();
            this.tb_7 = new System.Windows.Forms.RichTextBox();
            this.tb_6 = new System.Windows.Forms.TextBox();
            this.tb_5 = new System.Windows.Forms.TextBox();
            this.tb_4 = new System.Windows.Forms.TextBox();
            this.tb_3 = new System.Windows.Forms.TextBox();
            this.tb_2 = new System.Windows.Forms.TextBox();
            this.tb_1 = new System.Windows.Forms.TextBox();
            this.pnl_sep2 = new System.Windows.Forms.Panel();
            this.lbl_desc = new System.Windows.Forms.Label();
            this.pnl_sep1 = new System.Windows.Forms.Panel();
            this.dgw_users = new System.Windows.Forms.DataGridView();
            this.lbl_date = new System.Windows.Forms.Label();
            this.lbl_6 = new System.Windows.Forms.Label();
            this.lbl_5 = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_4 = new System.Windows.Forms.Label();
            this.lbl_3 = new System.Windows.Forms.Label();
            this.lbl_2 = new System.Windows.Forms.Label();
            this.lbl_1 = new System.Windows.Forms.Label();
            this.lbl_matched = new System.Windows.Forms.Label();
            this.btn_show_pass = new System.Windows.Forms.Button();
            this.btn_ok = new System.Windows.Forms.Button();
            this.btn_change_pass = new System.Windows.Forms.Button();
            this.btn_give_penalty = new System.Windows.Forms.Button();
            this.btn_give_book = new System.Windows.Forms.Button();
            this.btn_return_book = new System.Windows.Forms.Button();
            this.btn_id = new System.Windows.Forms.Button();
            this.btn_remove = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.picture_box = new System.Windows.Forms.PictureBox();
            this.pnl_main.SuspendLayout();
            this.pnl_change_pass.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_users)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_box)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_main
            // 
            this.pnl_main.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.pnl_main.Controls.Add(this.btn_show_pass);
            this.pnl_main.Controls.Add(this.pnl_change_pass);
            this.pnl_main.Controls.Add(this.btn_change_pass);
            this.pnl_main.Controls.Add(this.tb_7);
            this.pnl_main.Controls.Add(this.btn_give_penalty);
            this.pnl_main.Controls.Add(this.btn_give_book);
            this.pnl_main.Controls.Add(this.btn_return_book);
            this.pnl_main.Controls.Add(this.btn_id);
            this.pnl_main.Controls.Add(this.tb_6);
            this.pnl_main.Controls.Add(this.tb_5);
            this.pnl_main.Controls.Add(this.tb_4);
            this.pnl_main.Controls.Add(this.tb_3);
            this.pnl_main.Controls.Add(this.tb_2);
            this.pnl_main.Controls.Add(this.tb_1);
            this.pnl_main.Controls.Add(this.pnl_sep2);
            this.pnl_main.Controls.Add(this.btn_remove);
            this.pnl_main.Controls.Add(this.btn_edit);
            this.pnl_main.Controls.Add(this.lbl_desc);
            this.pnl_main.Controls.Add(this.pnl_sep1);
            this.pnl_main.Controls.Add(this.dgw_users);
            this.pnl_main.Controls.Add(this.lbl_date);
            this.pnl_main.Controls.Add(this.lbl_6);
            this.pnl_main.Controls.Add(this.picture_box);
            this.pnl_main.Controls.Add(this.lbl_5);
            this.pnl_main.Controls.Add(this.lbl_name);
            this.pnl_main.Controls.Add(this.lbl_4);
            this.pnl_main.Controls.Add(this.lbl_3);
            this.pnl_main.Controls.Add(this.lbl_2);
            this.pnl_main.Controls.Add(this.lbl_1);
            this.pnl_main.Location = new System.Drawing.Point(12, 12);
            this.pnl_main.Name = "pnl_main";
            this.pnl_main.Size = new System.Drawing.Size(773, 471);
            this.pnl_main.TabIndex = 1;
            // 
            // pnl_change_pass
            // 
            this.pnl_change_pass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(38)))));
            this.pnl_change_pass.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl_change_pass.Controls.Add(this.lbl_matched);
            this.pnl_change_pass.Controls.Add(this.lbl_msg);
            this.pnl_change_pass.Controls.Add(this.lbl_power);
            this.pnl_change_pass.Controls.Add(this.pnl_pow3);
            this.pnl_change_pass.Controls.Add(this.pnl_pow2);
            this.pnl_change_pass.Controls.Add(this.pnl_pow1);
            this.pnl_change_pass.Controls.Add(this.btn_ok);
            this.pnl_change_pass.Controls.Add(this.tb_pass_confirm);
            this.pnl_change_pass.Controls.Add(this.lbl_confirm);
            this.pnl_change_pass.Controls.Add(this.tb_new_pass);
            this.pnl_change_pass.Controls.Add(this.lbl_new_pass);
            this.pnl_change_pass.Location = new System.Drawing.Point(16, 237);
            this.pnl_change_pass.Name = "pnl_change_pass";
            this.pnl_change_pass.Size = new System.Drawing.Size(345, 144);
            this.pnl_change_pass.TabIndex = 57;
            // 
            // lbl_msg
            // 
            this.lbl_msg.AutoSize = true;
            this.lbl_msg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_msg.ForeColor = System.Drawing.Color.White;
            this.lbl_msg.Location = new System.Drawing.Point(52, 111);
            this.lbl_msg.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_msg.Name = "lbl_msg";
            this.lbl_msg.Size = new System.Drawing.Size(0, 20);
            this.lbl_msg.TabIndex = 57;
            // 
            // lbl_power
            // 
            this.lbl_power.AutoSize = true;
            this.lbl_power.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_power.ForeColor = System.Drawing.Color.White;
            this.lbl_power.Location = new System.Drawing.Point(258, 76);
            this.lbl_power.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_power.Name = "lbl_power";
            this.lbl_power.Size = new System.Drawing.Size(47, 16);
            this.lbl_power.TabIndex = 56;
            this.lbl_power.Text = "Strong";
            // 
            // pnl_pow3
            // 
            this.pnl_pow3.BackColor = System.Drawing.Color.PaleGreen;
            this.pnl_pow3.Location = new System.Drawing.Point(243, 72);
            this.pnl_pow3.Name = "pnl_pow3";
            this.pnl_pow3.Size = new System.Drawing.Size(10, 20);
            this.pnl_pow3.TabIndex = 55;
            // 
            // pnl_pow2
            // 
            this.pnl_pow2.BackColor = System.Drawing.Color.Gold;
            this.pnl_pow2.Location = new System.Drawing.Point(232, 72);
            this.pnl_pow2.Name = "pnl_pow2";
            this.pnl_pow2.Size = new System.Drawing.Size(10, 20);
            this.pnl_pow2.TabIndex = 54;
            // 
            // pnl_pow1
            // 
            this.pnl_pow1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.pnl_pow1.Location = new System.Drawing.Point(221, 72);
            this.pnl_pow1.Name = "pnl_pow1";
            this.pnl_pow1.Size = new System.Drawing.Size(10, 20);
            this.pnl_pow1.TabIndex = 53;
            // 
            // tb_pass_confirm
            // 
            this.tb_pass_confirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(38)))));
            this.tb_pass_confirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_pass_confirm.ForeColor = System.Drawing.Color.White;
            this.tb_pass_confirm.Location = new System.Drawing.Point(129, 45);
            this.tb_pass_confirm.Name = "tb_pass_confirm";
            this.tb_pass_confirm.Size = new System.Drawing.Size(187, 22);
            this.tb_pass_confirm.TabIndex = 51;
            this.tb_pass_confirm.UseSystemPasswordChar = true;
            this.tb_pass_confirm.TextChanged += new System.EventHandler(this.tb_pass_confirm_TextChanged);
            // 
            // lbl_confirm
            // 
            this.lbl_confirm.AutoSize = true;
            this.lbl_confirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_confirm.ForeColor = System.Drawing.Color.White;
            this.lbl_confirm.Location = new System.Drawing.Point(2, 45);
            this.lbl_confirm.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_confirm.Name = "lbl_confirm";
            this.lbl_confirm.Size = new System.Drawing.Size(68, 20);
            this.lbl_confirm.TabIndex = 50;
            this.lbl_confirm.Text = "Confirm:";
            // 
            // tb_new_pass
            // 
            this.tb_new_pass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(38)))));
            this.tb_new_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_new_pass.ForeColor = System.Drawing.Color.White;
            this.tb_new_pass.Location = new System.Drawing.Point(129, 16);
            this.tb_new_pass.Name = "tb_new_pass";
            this.tb_new_pass.Size = new System.Drawing.Size(187, 22);
            this.tb_new_pass.TabIndex = 49;
            this.tb_new_pass.UseSystemPasswordChar = true;
            this.tb_new_pass.TextChanged += new System.EventHandler(this.tb_new_pass_TextChanged);
            // 
            // lbl_new_pass
            // 
            this.lbl_new_pass.AutoSize = true;
            this.lbl_new_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_new_pass.ForeColor = System.Drawing.Color.White;
            this.lbl_new_pass.Location = new System.Drawing.Point(2, 15);
            this.lbl_new_pass.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_new_pass.Name = "lbl_new_pass";
            this.lbl_new_pass.Size = new System.Drawing.Size(117, 20);
            this.lbl_new_pass.TabIndex = 48;
            this.lbl_new_pass.Text = "New Password:";
            // 
            // tb_7
            // 
            this.tb_7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(38)))));
            this.tb_7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.tb_7.ForeColor = System.Drawing.Color.White;
            this.tb_7.Location = new System.Drawing.Point(460, 95);
            this.tb_7.Margin = new System.Windows.Forms.Padding(2);
            this.tb_7.Name = "tb_7";
            this.tb_7.ReadOnly = true;
            this.tb_7.Size = new System.Drawing.Size(303, 62);
            this.tb_7.TabIndex = 55;
            this.tb_7.Text = "";
            // 
            // tb_6
            // 
            this.tb_6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(38)))));
            this.tb_6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_6.ForeColor = System.Drawing.Color.White;
            this.tb_6.Location = new System.Drawing.Point(572, 135);
            this.tb_6.Name = "tb_6";
            this.tb_6.ReadOnly = true;
            this.tb_6.Size = new System.Drawing.Size(187, 22);
            this.tb_6.TabIndex = 50;
            // 
            // tb_5
            // 
            this.tb_5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(38)))));
            this.tb_5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_5.ForeColor = System.Drawing.Color.White;
            this.tb_5.Location = new System.Drawing.Point(572, 102);
            this.tb_5.Name = "tb_5";
            this.tb_5.ReadOnly = true;
            this.tb_5.Size = new System.Drawing.Size(187, 22);
            this.tb_5.TabIndex = 49;
            // 
            // tb_4
            // 
            this.tb_4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(38)))));
            this.tb_4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_4.ForeColor = System.Drawing.Color.White;
            this.tb_4.Location = new System.Drawing.Point(572, 68);
            this.tb_4.Name = "tb_4";
            this.tb_4.ReadOnly = true;
            this.tb_4.Size = new System.Drawing.Size(187, 22);
            this.tb_4.TabIndex = 48;
            // 
            // tb_3
            // 
            this.tb_3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(38)))));
            this.tb_3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_3.ForeColor = System.Drawing.Color.White;
            this.tb_3.Location = new System.Drawing.Point(236, 134);
            this.tb_3.Name = "tb_3";
            this.tb_3.ReadOnly = true;
            this.tb_3.Size = new System.Drawing.Size(187, 22);
            this.tb_3.TabIndex = 47;
            // 
            // tb_2
            // 
            this.tb_2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(38)))));
            this.tb_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_2.ForeColor = System.Drawing.Color.White;
            this.tb_2.Location = new System.Drawing.Point(236, 101);
            this.tb_2.Name = "tb_2";
            this.tb_2.ReadOnly = true;
            this.tb_2.Size = new System.Drawing.Size(187, 22);
            this.tb_2.TabIndex = 46;
            // 
            // tb_1
            // 
            this.tb_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(38)))));
            this.tb_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_1.ForeColor = System.Drawing.Color.White;
            this.tb_1.Location = new System.Drawing.Point(236, 67);
            this.tb_1.Name = "tb_1";
            this.tb_1.ReadOnly = true;
            this.tb_1.Size = new System.Drawing.Size(187, 22);
            this.tb_1.TabIndex = 45;
            // 
            // pnl_sep2
            // 
            this.pnl_sep2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.pnl_sep2.Location = new System.Drawing.Point(16, 227);
            this.pnl_sep2.Margin = new System.Windows.Forms.Padding(2);
            this.pnl_sep2.Name = "pnl_sep2";
            this.pnl_sep2.Size = new System.Drawing.Size(743, 1);
            this.pnl_sep2.TabIndex = 42;
            // 
            // lbl_desc
            // 
            this.lbl_desc.AutoSize = true;
            this.lbl_desc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_desc.ForeColor = System.Drawing.Color.White;
            this.lbl_desc.Location = new System.Drawing.Point(12, 201);
            this.lbl_desc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_desc.Name = "lbl_desc";
            this.lbl_desc.Size = new System.Drawing.Size(322, 24);
            this.lbl_desc.TabIndex = 42;
            this.lbl_desc.Text = "Users which have that book currently:";
            // 
            // pnl_sep1
            // 
            this.pnl_sep1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.pnl_sep1.Location = new System.Drawing.Point(134, 44);
            this.pnl_sep1.Margin = new System.Windows.Forms.Padding(2);
            this.pnl_sep1.Name = "pnl_sep1";
            this.pnl_sep1.Size = new System.Drawing.Size(628, 1);
            this.pnl_sep1.TabIndex = 41;
            // 
            // dgw_users
            // 
            this.dgw_users.AllowUserToAddRows = false;
            this.dgw_users.AllowUserToDeleteRows = false;
            this.dgw_users.AllowUserToResizeColumns = false;
            this.dgw_users.AllowUserToResizeRows = false;
            this.dgw_users.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgw_users.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgw_users.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgw_users.ColumnHeadersHeight = 29;
            this.dgw_users.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.NullValue = null;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgw_users.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgw_users.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(38)))));
            this.dgw_users.Location = new System.Drawing.Point(16, 237);
            this.dgw_users.MaximumSize = new System.Drawing.Size(743, 223);
            this.dgw_users.MultiSelect = false;
            this.dgw_users.Name = "dgw_users";
            this.dgw_users.ReadOnly = true;
            this.dgw_users.RowHeadersVisible = false;
            this.dgw_users.RowHeadersWidth = 51;
            this.dgw_users.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgw_users.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgw_users.Size = new System.Drawing.Size(743, 223);
            this.dgw_users.TabIndex = 40;
            this.dgw_users.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgw_users_CellClick);
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_date.ForeColor = System.Drawing.Color.White;
            this.lbl_date.Location = new System.Drawing.Point(693, 3);
            this.lbl_date.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(80, 18);
            this.lbl_date.TabIndex = 39;
            this.lbl_date.Text = "29/11/2019";
            // 
            // lbl_6
            // 
            this.lbl_6.AutoSize = true;
            this.lbl_6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_6.ForeColor = System.Drawing.Color.White;
            this.lbl_6.Location = new System.Drawing.Point(456, 134);
            this.lbl_6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_6.Name = "lbl_6";
            this.lbl_6.Size = new System.Drawing.Size(56, 20);
            this.lbl_6.TabIndex = 38;
            this.lbl_6.Text = "Count:";
            // 
            // lbl_5
            // 
            this.lbl_5.AutoSize = true;
            this.lbl_5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_5.ForeColor = System.Drawing.Color.White;
            this.lbl_5.Location = new System.Drawing.Point(456, 101);
            this.lbl_5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_5.Name = "lbl_5";
            this.lbl_5.Size = new System.Drawing.Size(82, 20);
            this.lbl_5.TabIndex = 37;
            this.lbl_5.Text = "Popularity:";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoEllipsis = true;
            this.lbl_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.ForeColor = System.Drawing.Color.White;
            this.lbl_name.Location = new System.Drawing.Point(184, 3);
            this.lbl_name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(290, 39);
            this.lbl_name.TabIndex = 25;
            this.lbl_name.Text = "Book Name";
            // 
            // lbl_4
            // 
            this.lbl_4.AutoSize = true;
            this.lbl_4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_4.ForeColor = System.Drawing.Color.White;
            this.lbl_4.Location = new System.Drawing.Point(456, 67);
            this.lbl_4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_4.Name = "lbl_4";
            this.lbl_4.Size = new System.Drawing.Size(50, 20);
            this.lbl_4.TabIndex = 36;
            this.lbl_4.Text = "Shelf:";
            // 
            // lbl_3
            // 
            this.lbl_3.AutoSize = true;
            this.lbl_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_3.ForeColor = System.Drawing.Color.White;
            this.lbl_3.Location = new System.Drawing.Point(134, 134);
            this.lbl_3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_3.Name = "lbl_3";
            this.lbl_3.Size = new System.Drawing.Size(77, 20);
            this.lbl_3.TabIndex = 35;
            this.lbl_3.Text = "Category:";
            // 
            // lbl_2
            // 
            this.lbl_2.AutoSize = true;
            this.lbl_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_2.ForeColor = System.Drawing.Color.White;
            this.lbl_2.Location = new System.Drawing.Point(134, 101);
            this.lbl_2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_2.Name = "lbl_2";
            this.lbl_2.Size = new System.Drawing.Size(78, 20);
            this.lbl_2.TabIndex = 34;
            this.lbl_2.Text = "Publisher:";
            // 
            // lbl_1
            // 
            this.lbl_1.AutoSize = true;
            this.lbl_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_1.ForeColor = System.Drawing.Color.White;
            this.lbl_1.Location = new System.Drawing.Point(134, 67);
            this.lbl_1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_1.Name = "lbl_1";
            this.lbl_1.Size = new System.Drawing.Size(61, 20);
            this.lbl_1.TabIndex = 33;
            this.lbl_1.Text = "Author:";
            // 
            // lbl_matched
            // 
            this.lbl_matched.AutoSize = true;
            this.lbl_matched.BackColor = System.Drawing.Color.Transparent;
            this.lbl_matched.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_matched.ForeColor = System.Drawing.Color.PaleGreen;
            this.lbl_matched.Location = new System.Drawing.Point(75, 50);
            this.lbl_matched.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_matched.Name = "lbl_matched";
            this.lbl_matched.Size = new System.Drawing.Size(49, 13);
            this.lbl_matched.TabIndex = 58;
            this.lbl_matched.Text = "Matched";
            // 
            // btn_show_pass
            // 
            this.btn_show_pass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_show_pass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_show_pass.FlatAppearance.BorderSize = 0;
            this.btn_show_pass.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_show_pass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_show_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_show_pass.ForeColor = System.Drawing.Color.White;
            this.btn_show_pass.Image = global::Microwave_v1._0.Properties.Resources.visibility_on;
            this.btn_show_pass.Location = new System.Drawing.Point(428, 135);
            this.btn_show_pass.Margin = new System.Windows.Forms.Padding(2);
            this.btn_show_pass.Name = "btn_show_pass";
            this.btn_show_pass.Size = new System.Drawing.Size(24, 19);
            this.btn_show_pass.TabIndex = 58;
            this.btn_show_pass.UseVisualStyleBackColor = true;
            this.btn_show_pass.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_ok
            // 
            this.btn_ok.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_ok.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ok.FlatAppearance.BorderSize = 0;
            this.btn_ok.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ok.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ok.ForeColor = System.Drawing.Color.White;
            this.btn_ok.Image = ((System.Drawing.Image)(resources.GetObject("btn_ok.Image")));
            this.btn_ok.Location = new System.Drawing.Point(2, 94);
            this.btn_ok.Margin = new System.Windows.Forms.Padding(2);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(46, 44);
            this.btn_ok.TabIndex = 52;
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // btn_change_pass
            // 
            this.btn_change_pass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_change_pass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_change_pass.FlatAppearance.BorderSize = 0;
            this.btn_change_pass.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_change_pass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_change_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_change_pass.ForeColor = System.Drawing.Color.White;
            this.btn_change_pass.Image = ((System.Drawing.Image)(resources.GetObject("btn_change_pass.Image")));
            this.btn_change_pass.Location = new System.Drawing.Point(16, 179);
            this.btn_change_pass.Margin = new System.Windows.Forms.Padding(2);
            this.btn_change_pass.Name = "btn_change_pass";
            this.btn_change_pass.Size = new System.Drawing.Size(46, 44);
            this.btn_change_pass.TabIndex = 56;
            this.btn_change_pass.UseVisualStyleBackColor = true;
            this.btn_change_pass.Click += new System.EventHandler(this.btn_change_pass_Click);
            // 
            // btn_give_penalty
            // 
            this.btn_give_penalty.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_give_penalty.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_give_penalty.FlatAppearance.BorderSize = 0;
            this.btn_give_penalty.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_give_penalty.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_give_penalty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_give_penalty.ForeColor = System.Drawing.Color.White;
            this.btn_give_penalty.Image = ((System.Drawing.Image)(resources.GetObject("btn_give_penalty.Image")));
            this.btn_give_penalty.Location = new System.Drawing.Point(513, 179);
            this.btn_give_penalty.Margin = new System.Windows.Forms.Padding(2);
            this.btn_give_penalty.Name = "btn_give_penalty";
            this.btn_give_penalty.Size = new System.Drawing.Size(46, 44);
            this.btn_give_penalty.TabIndex = 54;
            this.btn_give_penalty.UseVisualStyleBackColor = true;
            this.btn_give_penalty.Click += new System.EventHandler(this.btn_give_penalty_Click);
            // 
            // btn_give_book
            // 
            this.btn_give_book.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_give_book.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_give_book.FlatAppearance.BorderSize = 0;
            this.btn_give_book.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_give_book.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_give_book.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_give_book.ForeColor = System.Drawing.Color.White;
            this.btn_give_book.Image = ((System.Drawing.Image)(resources.GetObject("btn_give_book.Image")));
            this.btn_give_book.Location = new System.Drawing.Point(563, 179);
            this.btn_give_book.Margin = new System.Windows.Forms.Padding(2);
            this.btn_give_book.Name = "btn_give_book";
            this.btn_give_book.Size = new System.Drawing.Size(46, 44);
            this.btn_give_book.TabIndex = 53;
            this.btn_give_book.UseVisualStyleBackColor = true;
            this.btn_give_book.Click += new System.EventHandler(this.btn_give_book_Click);
            // 
            // btn_return_book
            // 
            this.btn_return_book.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_return_book.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_return_book.FlatAppearance.BorderSize = 0;
            this.btn_return_book.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_return_book.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_return_book.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_return_book.ForeColor = System.Drawing.Color.White;
            this.btn_return_book.Image = ((System.Drawing.Image)(resources.GetObject("btn_return_book.Image")));
            this.btn_return_book.Location = new System.Drawing.Point(613, 179);
            this.btn_return_book.Margin = new System.Windows.Forms.Padding(2);
            this.btn_return_book.Name = "btn_return_book";
            this.btn_return_book.Size = new System.Drawing.Size(46, 44);
            this.btn_return_book.TabIndex = 52;
            this.btn_return_book.UseVisualStyleBackColor = true;
            this.btn_return_book.Click += new System.EventHandler(this.btn_return_book_Click);
            // 
            // btn_id
            // 
            this.btn_id.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_id.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_id.FlatAppearance.BorderSize = 0;
            this.btn_id.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_id.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_id.ForeColor = System.Drawing.Color.White;
            this.btn_id.Image = ((System.Drawing.Image)(resources.GetObject("btn_id.Image")));
            this.btn_id.Location = new System.Drawing.Point(134, -1);
            this.btn_id.Margin = new System.Windows.Forms.Padding(2);
            this.btn_id.Name = "btn_id";
            this.btn_id.Size = new System.Drawing.Size(46, 44);
            this.btn_id.TabIndex = 51;
            this.btn_id.Text = "171";
            this.btn_id.UseVisualStyleBackColor = true;
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
            this.btn_remove.Location = new System.Drawing.Point(713, 179);
            this.btn_remove.Margin = new System.Windows.Forms.Padding(2);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(46, 44);
            this.btn_remove.TabIndex = 44;
            this.btn_remove.UseVisualStyleBackColor = true;
            this.btn_remove.Click += new System.EventHandler(this.btn_remove_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_edit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_edit.FlatAppearance.BorderSize = 0;
            this.btn_edit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_edit.ForeColor = System.Drawing.Color.White;
            this.btn_edit.Image = ((System.Drawing.Image)(resources.GetObject("btn_edit.Image")));
            this.btn_edit.Location = new System.Drawing.Point(663, 179);
            this.btn_edit.Margin = new System.Windows.Forms.Padding(2);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(46, 44);
            this.btn_edit.TabIndex = 43;
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // picture_box
            // 
            this.picture_box.Image = global::Microwave_v1._0.Properties.Resources.man_user__1_;
            this.picture_box.Location = new System.Drawing.Point(3, 3);
            this.picture_box.Name = "picture_box";
            this.picture_box.Size = new System.Drawing.Size(121, 163);
            this.picture_box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture_box.TabIndex = 0;
            this.picture_box.TabStop = false;
            // 
            // Detail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(797, 495);
            this.Controls.Add(this.pnl_main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Detail";
            this.Opacity = 0.95D;
            this.Text = "Detail";
            this.pnl_main.ResumeLayout(false);
            this.pnl_main.PerformLayout();
            this.pnl_change_pass.ResumeLayout(false);
            this.pnl_change_pass.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_users)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_box)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picture_box;
        private System.Windows.Forms.Panel pnl_main;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_6;
        private System.Windows.Forms.Label lbl_5;
        private System.Windows.Forms.Label lbl_4;
        private System.Windows.Forms.Label lbl_3;
        private System.Windows.Forms.Label lbl_2;
        private System.Windows.Forms.Label lbl_1;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.DataGridView dgw_users;
        private System.Windows.Forms.Label lbl_desc;
        private System.Windows.Forms.Panel pnl_sep1;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Panel pnl_sep2;
        private System.Windows.Forms.Button btn_remove;
        private System.Windows.Forms.TextBox tb_6;
        private System.Windows.Forms.TextBox tb_5;
        private System.Windows.Forms.TextBox tb_4;
        private System.Windows.Forms.TextBox tb_3;
        private System.Windows.Forms.TextBox tb_2;
        private System.Windows.Forms.TextBox tb_1;
        private System.Windows.Forms.Button btn_id;
        private System.Windows.Forms.Button btn_give_penalty;
        private System.Windows.Forms.Button btn_give_book;
        private System.Windows.Forms.Button btn_return_book;
        private RichTextBox tb_7;
        private Button btn_change_pass;
        private Panel pnl_change_pass;
        private Label lbl_power;
        private Panel pnl_pow3;
        private Panel pnl_pow2;
        private Panel pnl_pow1;
        private Button btn_ok;
        private TextBox tb_pass_confirm;
        private Label lbl_confirm;
        private TextBox tb_new_pass;
        private Label lbl_new_pass;
        private Label lbl_msg;
        private Label lbl_matched;
        private Button btn_show_pass;

        public PictureBox Picture_box { get => picture_box; set => picture_box = value; }
        public Panel Pnl_main { get => pnl_main; set => pnl_main = value; }
        public Label Lbl_name { get => lbl_name; set => lbl_name = value; }
        public Label Lbl_6 { get => lbl_6; set => lbl_6 = value; }
        public Label Lbl_5 { get => lbl_5; set => lbl_5 = value; }
        public Label Lbl_4 { get => lbl_4; set => lbl_4 = value; }
        public Label Lbl_3 { get => lbl_3; set => lbl_3 = value; }
        public Label Lbl_2 { get => lbl_2; set => lbl_2 = value; }
        public Label Lbl_1 { get => lbl_1; set => lbl_1 = value; }
        public Label Lbl_date { get => lbl_date; set => lbl_date = value; }
        public DataGridView Dgw_users { get => dgw_users; set => dgw_users = value; }
        public Label Lbl_desc { get => lbl_desc; set => lbl_desc = value; }
        public Panel Pnl_sep1 { get => pnl_sep1; set => pnl_sep1 = value; }
        public Button Btn_edit { get => btn_edit; set => btn_edit = value; }
        public Panel Pnl_sep2 { get => pnl_sep2; set => pnl_sep2 = value; }
        public Button Btn_remove { get => btn_remove; set => btn_remove = value; }
        public TextBox Tb_6 { get => tb_6; set => tb_6 = value; }
        public TextBox Tb_5 { get => tb_5; set => tb_5 = value; }
        public TextBox Tb_4 { get => tb_4; set => tb_4 = value; }
        public TextBox Tb_3 { get => tb_3; set => tb_3 = value; }
        public TextBox Tb_2 { get => tb_2; set => tb_2 = value; }
        public TextBox Tb_1 { get => tb_1; set => tb_1 = value; }
        public Button Btn_id { get => btn_id; set => btn_id = value; }
        public Button Btn_give_penalty { get => btn_give_penalty; set => btn_give_penalty = value; }
        public Button Btn_give_book { get => btn_give_book; set => btn_give_book = value; }
        public Button Btn_return_book { get => btn_return_book; set => btn_return_book = value; }
    }
}