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
    public partial class Register : Form
    {
        User us;
        Point LastClick;
        public Register()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            us = new User();
        }

      

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void Register_MouseDown(object sender, MouseEventArgs e)
        {
            LastClick = e.Location;
        }

        private void Register_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - LastClick.X;
                this.Top += e.Y - LastClick.Y;
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            if (AcceptLabel.Checked == false)
                FillError.Text = "Must Accept all terms and condition";
            else
            {
                FillError.Text ="";
                PMatch.Text = "";
                UnameError.Text = "";
                EmailError.Text = "";
                int s = us.add(Fname.Text.Trim(), Uname.Text.Trim(), Password.Text.Trim(), CPassword.Text.Trim(), Address.Text.Trim(), Email.Text.Trim(), ContactNo.Text.Trim(), CardNo.Text.Trim());
                
                switch (s) { 
                    case 1:
                        PMatch.Text = "Mismatch";
                        break;
                    case 2:
                        FillError.Text = "Must Fill all the Fields";
                        break;
                    case 3:
                        UnameError.Text = "Already Exist";
                        break;
                    case 4:
                        EmailError.Text = "Email Exist";
                        break;
                    case 5:
                        MessageBox.Show("Successfully Registered");
                        this.Close();
                        break;            
                   }
            }
        }




    }
}
