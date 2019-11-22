﻿namespace Microwave_v1._0.Forms
{
    partial class AddAuthor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddAuthor));
            this.lbl_message = new System.Windows.Forms.Label();
            this.lbl_biography = new System.Windows.Forms.Label();
            this.tb_biography = new System.Windows.Forms.TextBox();
            this.lbl_fullname = new System.Windows.Forms.Label();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.lbl_country = new System.Windows.Forms.Label();
            this.tb_country = new System.Windows.Forms.TextBox();
            this.rdo_female = new System.Windows.Forms.RadioButton();
            this.rdo_male = new System.Windows.Forms.RadioButton();
            this.lbl_gender = new System.Windows.Forms.Label();
            this.mtb_year = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_add_pic = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.pic_author = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_author)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_message
            // 
            this.lbl_message.AutoSize = true;
            this.lbl_message.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_message.Location = new System.Drawing.Point(13, 9);
            this.lbl_message.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_message.Name = "lbl_message";
            this.lbl_message.Size = new System.Drawing.Size(0, 20);
            this.lbl_message.TabIndex = 44;
            // 
            // lbl_biography
            // 
            this.lbl_biography.AutoSize = true;
            this.lbl_biography.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_biography.ForeColor = System.Drawing.Color.White;
            this.lbl_biography.Location = new System.Drawing.Point(13, 226);
            this.lbl_biography.Name = "lbl_biography";
            this.lbl_biography.Size = new System.Drawing.Size(100, 24);
            this.lbl_biography.TabIndex = 42;
            this.lbl_biography.Text = "Biography:";
            // 
            // tb_biography
            // 
            this.tb_biography.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(61)))), ((int)(((byte)(71)))));
            this.tb_biography.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_biography.ForeColor = System.Drawing.Color.DimGray;
            this.tb_biography.Location = new System.Drawing.Point(140, 227);
            this.tb_biography.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_biography.Multiline = true;
            this.tb_biography.Name = "tb_biography";
            this.tb_biography.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_biography.Size = new System.Drawing.Size(290, 129);
            this.tb_biography.TabIndex = 33;
            this.tb_biography.Text = "Biography...";
            // 
            // lbl_fullname
            // 
            this.lbl_fullname.AutoSize = true;
            this.lbl_fullname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_fullname.ForeColor = System.Drawing.Color.White;
            this.lbl_fullname.Location = new System.Drawing.Point(13, 42);
            this.lbl_fullname.Name = "lbl_fullname";
            this.lbl_fullname.Size = new System.Drawing.Size(66, 24);
            this.lbl_fullname.TabIndex = 36;
            this.lbl_fullname.Text = "Name:";
            // 
            // tb_name
            // 
            this.tb_name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(61)))), ((int)(((byte)(71)))));
            this.tb_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_name.ForeColor = System.Drawing.Color.DimGray;
            this.tb_name.Location = new System.Drawing.Point(140, 43);
            this.tb_name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(290, 27);
            this.tb_name.TabIndex = 29;
            this.tb_name.Text = "Author\'s Name";
            // 
            // lbl_country
            // 
            this.lbl_country.AutoSize = true;
            this.lbl_country.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_country.ForeColor = System.Drawing.Color.White;
            this.lbl_country.Location = new System.Drawing.Point(13, 91);
            this.lbl_country.Name = "lbl_country";
            this.lbl_country.Size = new System.Drawing.Size(80, 24);
            this.lbl_country.TabIndex = 45;
            this.lbl_country.Text = "Country:";
            // 
            // tb_country
            // 
            this.tb_country.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(61)))), ((int)(((byte)(71)))));
            this.tb_country.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_country.ForeColor = System.Drawing.Color.DimGray;
            this.tb_country.Location = new System.Drawing.Point(140, 91);
            this.tb_country.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_country.Name = "tb_country";
            this.tb_country.Size = new System.Drawing.Size(290, 27);
            this.tb_country.TabIndex = 46;
            this.tb_country.Text = "Country";
            // 
            // rdo_female
            // 
            this.rdo_female.AutoSize = true;
            this.rdo_female.ForeColor = System.Drawing.SystemColors.Window;
            this.rdo_female.Location = new System.Drawing.Point(276, 139);
            this.rdo_female.Margin = new System.Windows.Forms.Padding(4);
            this.rdo_female.Name = "rdo_female";
            this.rdo_female.Size = new System.Drawing.Size(75, 21);
            this.rdo_female.TabIndex = 49;
            this.rdo_female.TabStop = true;
            this.rdo_female.Text = "Female";
            this.rdo_female.UseVisualStyleBackColor = true;
            // 
            // rdo_male
            // 
            this.rdo_male.AutoSize = true;
            this.rdo_male.ForeColor = System.Drawing.SystemColors.Window;
            this.rdo_male.Location = new System.Drawing.Point(140, 139);
            this.rdo_male.Margin = new System.Windows.Forms.Padding(4);
            this.rdo_male.Name = "rdo_male";
            this.rdo_male.Size = new System.Drawing.Size(59, 21);
            this.rdo_male.TabIndex = 48;
            this.rdo_male.TabStop = true;
            this.rdo_male.Text = "Male";
            this.rdo_male.UseVisualStyleBackColor = true;
            // 
            // lbl_gender
            // 
            this.lbl_gender.AutoSize = true;
            this.lbl_gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_gender.ForeColor = System.Drawing.Color.White;
            this.lbl_gender.Location = new System.Drawing.Point(13, 136);
            this.lbl_gender.Name = "lbl_gender";
            this.lbl_gender.Size = new System.Drawing.Size(79, 24);
            this.lbl_gender.TabIndex = 47;
            this.lbl_gender.Text = "Gender:";
            // 
            // mtb_year
            // 
            this.mtb_year.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(61)))), ((int)(((byte)(71)))));
            this.mtb_year.Location = new System.Drawing.Point(140, 178);
            this.mtb_year.Mask = "0000";
            this.mtb_year.Name = "mtb_year";
            this.mtb_year.Size = new System.Drawing.Size(38, 22);
            this.mtb_year.TabIndex = 50;
            this.mtb_year.ValidatingType = typeof(int);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 24);
            this.label1.TabIndex = 51;
            this.label1.Text = "Birth Year:";
            // 
            // btn_add_pic
            // 
            this.btn_add_pic.FlatAppearance.BorderSize = 0;
            this.btn_add_pic.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_add_pic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add_pic.Image = ((System.Drawing.Image)(resources.GetObject("btn_add_pic.Image")));
            this.btn_add_pic.Location = new System.Drawing.Point(228, 498);
            this.btn_add_pic.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_add_pic.Name = "btn_add_pic";
            this.btn_add_pic.Size = new System.Drawing.Size(63, 52);
            this.btn_add_pic.TabIndex = 43;
            this.btn_add_pic.UseVisualStyleBackColor = true;
            this.btn_add_pic.Click += new System.EventHandler(this.Change_Image_Click);
            // 
            // btn_add
            // 
            this.btn_add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_add.FlatAppearance.BorderSize = 0;
            this.btn_add.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.Image = global::Microwave_v1._0.Properties.Resources.correct_symbol__1_;
            this.btn_add.Location = new System.Drawing.Point(12, 494);
            this.btn_add.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(55, 57);
            this.btn_add.TabIndex = 40;
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // pic_author
            // 
            this.pic_author.Image = ((System.Drawing.Image)(resources.GetObject("pic_author.Image")));
            this.pic_author.Location = new System.Drawing.Point(297, 377);
            this.pic_author.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pic_author.Name = "pic_author";
            this.pic_author.Size = new System.Drawing.Size(133, 169);
            this.pic_author.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_author.TabIndex = 39;
            this.pic_author.TabStop = false;
            // 
            // AddAuthor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(437, 555);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mtb_year);
            this.Controls.Add(this.rdo_female);
            this.Controls.Add(this.rdo_male);
            this.Controls.Add(this.lbl_gender);
            this.Controls.Add(this.tb_country);
            this.Controls.Add(this.lbl_country);
            this.Controls.Add(this.lbl_message);
            this.Controls.Add(this.btn_add_pic);
            this.Controls.Add(this.lbl_biography);
            this.Controls.Add(this.tb_biography);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.pic_author);
            this.Controls.Add(this.lbl_fullname);
            this.Controls.Add(this.tb_name);
            this.Name = "AddAuthor";
            this.Opacity = 0.95D;
            this.Text = "AddAuthor";
            ((System.ComponentModel.ISupportInitialize)(this.pic_author)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_message;
        private System.Windows.Forms.Button btn_add_pic;
        private System.Windows.Forms.Label lbl_biography;
        private System.Windows.Forms.TextBox tb_biography;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.PictureBox pic_author;
        private System.Windows.Forms.Label lbl_fullname;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.Label lbl_country;
        private System.Windows.Forms.TextBox tb_country;
        private System.Windows.Forms.RadioButton rdo_female;
        private System.Windows.Forms.RadioButton rdo_male;
        private System.Windows.Forms.Label lbl_gender;
        private System.Windows.Forms.MaskedTextBox mtb_year;
        private System.Windows.Forms.Label label1;
    }
}