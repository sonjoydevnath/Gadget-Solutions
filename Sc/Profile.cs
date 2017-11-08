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
    public partial class Profile : Form
    {
        MainForm mf;
        User us;
        
        public Profile()
        {
            InitializeComponent();
        }
        public Profile(MainForm mf) : this() {
            this.mf = mf;
            us = new User();
          
        }




            
        
        
        private void Profile_Load(object sender, EventArgs e)
        {
            DataTable dq = us.getUserTable();
            Fname.Text = dq.Rows[0]["FullName"].ToString();
            Email.Text = dq.Rows[0]["Email"].ToString();
            Contact.Text = dq.Rows[0]["ContactNo"].ToString();
            Credit.Text = dq.Rows[0]["CardNo"].ToString();
            Address.Text = dq.Rows[0]["Address"].ToString();
        }

        private void Fname_Click(object sender, EventArgs e)
        {

        }

        private void Email_Click(object sender, EventArgs e)
        {

        }

        private void Contact_Click(object sender, EventArgs e)
        {

        }

        private void Address_TextChanged(object sender, EventArgs e)
        {

        }

        private void Credit_Click(object sender, EventArgs e)
        {

        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            FnameBox.Text = Fname.Text;
            EmailBox.Text = Email.Text;
            ContactBox.Text = Contact.Text;
            CreditBox.Text = Credit.Text;
            AddressBox.Text = Address.Text;
            EditPanel.Visible = true;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            EditPanel.Visible = false;
        }

        private void FnameBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            int i=us.ChangeInfo(FnameBox.Text,EmailBox.Text,ContactBox.Text,AddressBox.Text,CreditBox.Text);
            if (i == 0)
            {
                MessageBox.Show("Successfully Updated");
                mf.ClickProfile();
                this.Close();
            }
            else
                MessageBox.Show("Retry");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PasswordPanel.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OPassword.Text = "";
            NPassword.Text = "";
            CNPassword.Text = "";
            PasswordPanel.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int i = us.ChangePassword(OPassword.Text,NPassword.Text,CNPassword.Text);
            CNPError.Text = "";
            OPError.Text = "";

            switch (i) {
                case 0:
                    MessageBox.Show("Successfully Changed");
                    PasswordPanel.Visible = false;
                    OPassword.Text = "";
                    NPassword.Text = "";
                    CNPassword.Text = "";
                    break;
                case 1:
                    MessageBox.Show("Fill All The Fields");
                    break;
                case 2:
                    CNPError.Text = "Mismatch";
                    break;
                case 3:
                    OPError.Text = "Incorrect";
                    break;
                case 4:
                    MessageBox.Show("Try Again");
                    break;
                
            }
        }

        private void PasswordPanel_Paint(object sender, PaintEventArgs e)
        {
                                              
        }

        private void ErrorMsg_Click(object sender, EventArgs e)
        {

        }

        private void EditPanel_Leave(object sender, EventArgs e)
        {

        }
    }
}
