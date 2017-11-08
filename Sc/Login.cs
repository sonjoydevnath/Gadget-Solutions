using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Login : Form
    {
        MainForm mf;
		public static string username;
		
        public Login()
        {
            InitializeComponent();
        }

        public Login(MainForm mf) : this() {
            this.mf = mf;
            
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            User us = new User();
            if (Uname.Text == "" || Password.Text == "")
            {
                ErrorMsg.Text = "**Must Enter User Name and Password";
            }
            else {
                ErrorMsg.Text = "";
                int s = us.getUser(Uname.Text.Trim(),Password.Text.Trim());
				username = Uname.Text;

                switch (s) {
                    case 1: 
                        MainForm.AdminLogin = true;
                        mf.ClickHome();
                        break;
                    case 2:
                        MainForm.UserLogin = true;
                        mf.ClickHome();
                        break;
                    case 0:
                        ErrorMsg.Text = "Incorrect Username Or Passord";
                        break;
                }
                   
            }
        }

        private void Uname_TextChanged(object sender, EventArgs e)
        {

        }

        private void Password_TextChanged(object sender, EventArgs e)
        {

        }

        private void RegisterButoon_Click(object sender, EventArgs e)
        {
            Register rg = new Register();
            rg.Show();
        }

    }
}
