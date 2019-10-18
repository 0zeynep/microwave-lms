﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Microwave_v1._0
{
    public partial class Warning_Add : Form
    {
        private string message;
        private bool result = false;
        private string password = "admin";
        private string email = "deneme";
        private bool clicked = false;
        private Action method = null;

        
        public string Message { get => message; set => message = value; }
        public bool Result { get => result; set => result = value; }
        public string Password { get => password; set => password = value; }
        public string Email { get => email; set => email = value; }
        public bool Clicked { get => clicked; set => clicked = value; }

        public Warning_Add()
        {
            InitializeComponent();
        }
        
        public void Initialize_Warning(string message,Action method)
        {
            this.message = message;
            this.lbl_message.Text = this.message;
            this.method = method;
        }

        private void btn_yes_Click(object sender, EventArgs e)
        {
            if(tb_password.Text == password)
            {
                method.Invoke();
                this.Close();

            }
            else
            {
                lbl_error.Text = "Password is incorrect.";
                lbl_error.ForeColor = Color.Red;
            }
            
        }

        private void btn_no_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
