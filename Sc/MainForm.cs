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
    public partial class MainForm : Form
    {

        public static bool AdminLogin = false;
        public static bool UserLogin = false;






        Point LastClick;

        Admin ac;
        About ab;
        DBerror er;
        Profile pf;
        User us;



        public MainForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;



            
            ab = new About(this);
            er = new DBerror();
            us = new User();
            ClickHome();


        }

        public void ClickProfile()
        {
            ProfileButton.PerformClick();
        }


        public void ClickHome()
        {
            HomeButton.PerformClick();

        }

        public void ButtonColorChange(Button b)
        {
            HomeButton.BackColor = Color.FromArgb(26, 32, 40);
            DeviceListButton.BackColor = Color.FromArgb(26, 32, 40);
            AccountButton.BackColor = Color.FromArgb(26, 32, 40);
            LoginButton.BackColor = Color.FromArgb(26, 32, 40);
            LogOut.BackColor = Color.FromArgb(26, 32, 40);
            AboutButton.BackColor = Color.FromArgb(26, 32, 40);
            ProfileButton.BackColor = Color.FromArgb(26, 32, 40);

            b.BackColor = Color.FromArgb(36, 103, 194);
        }


        private void Header_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Header_MouseDown(object sender, MouseEventArgs e)
        {
            LastClick = e.Location;
        }

        private void Header_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - LastClick.X;
                this.Top += e.Y - LastClick.Y;
            }
        }

        private void SlideButton_Click(object sender, EventArgs e)
        {
            this.PanelTimer.Enabled = true;
            this.PanelTimer2.Enabled = true;
        }

        private void PanelTimer_Tick(object sender, EventArgs e)
        {
            if (SlideMenu.Width == 53)
            {
                for (int i = SlideMenu.Width; i <= 196; i++)
                {
                    SlideMenu.Width = i;
                }
                this.PanelTimer.Enabled = false;
                Logo.Visible = true;

            }
            else
            {

                for (int i = SlideMenu.Width; i >= 53; i--)
                {
                    SlideMenu.Width = i;
                }
                this.PanelTimer.Enabled = false;
                Logo.Visible = false;

            }
        }

        private void HomeButton_MouseHover(object sender, EventArgs e)
        {
            HomeButton.ForeColor = Color.FromArgb(36, 103, 194);
        }

        private void HomeButton_MouseLeave(object sender, EventArgs e)
        {
            HomeButton.ForeColor = Color.FromArgb(224, 224, 224);
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            ButtonColorChange(HomeButton);
            Home hm = new Home(this);
            hm.MdiParent = this;
            hm.Dock = DockStyle.Fill;

            this.Panel.Controls.Clear();
            this.Panel.Controls.Add(hm);
            hm.Show();
        }

        private void LoginButton_MouseHover(object sender, EventArgs e)
        {
            LoginButton.ForeColor = Color.FromArgb(36, 103, 194);
        }

        private void LoginButton_MouseLeave(object sender, EventArgs e)
        {
            LoginButton.ForeColor = Color.FromArgb(224, 224, 224);
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            ButtonColorChange(LoginButton);
            Login lg = new Login(this);
            lg.MdiParent = this;
            lg.Dock = DockStyle.Fill;

            this.Panel.Controls.Clear();
            this.Panel.Controls.Add(lg);

            lg.Show();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            if (AdminLogin == true || UserLogin == true)
                MessageBox.Show("Must log Out before Closing the Application!!");
            else
                Application.Exit();          
        }

        private void DeviceListButton_MouseHover(object sender, EventArgs e)
        {
            DeviceListButton.ForeColor = Color.FromArgb(36, 103, 194);
        }

        private void DeviceListButton_MouseLeave(object sender, EventArgs e)
        {
            DeviceListButton.ForeColor = Color.FromArgb(224, 224, 224);
        }

        private void DeviceListButton_Click(object sender, EventArgs e)
        {
            ButtonColorChange(DeviceListButton);
            Device dv = new Device(this);
            dv.MdiParent = this;
            dv.Dock = DockStyle.Fill;
            this.Panel.Controls.Clear();
            this.Panel.Controls.Add(dv);

            dv.Show();
        }

        private void LogOut_MouseHover(object sender, EventArgs e)
        {
            LogOut.ForeColor = Color.FromArgb(36, 103, 194);
        }

        private void LogOut_MouseLeave(object sender, EventArgs e)
        {
            LogOut.ForeColor = Color.FromArgb(224, 224, 224);
        }

        private void Panel_Paint(object sender, PaintEventArgs e)
        {

        }


        private void LoginCheck_Tick(object sender, EventArgs e)
        {
            if (AdminLogin == true)
            {
                LoginButton.Visible = false;
                LogOut.Visible = true;
                AccountButton.Visible = true;

            }
            else if (UserLogin == true)
            {
                LoginButton.Visible = false;
                LogOut.Visible = true;
                ProfileButton.Visible = true;
            }
            else if (UserLogin == false && AdminLogin == false)
            {
                LoginButton.Visible = true;
                LogOut.Visible = false;
                ProfileButton.Visible = false;
                AccountButton.Visible = false;
            }
        }

        private void AccountButton_MouseHover(object sender, EventArgs e)
        {
            AccountButton.ForeColor = Color.FromArgb(36, 103, 194);
        }

        private void AccountButton_MouseLeave(object sender, EventArgs e)
        {
            AccountButton.ForeColor = Color.FromArgb(224, 224, 224);
        }

        private void AboutButton_MouseHover(object sender, EventArgs e)
        {
            AboutButton.ForeColor = Color.FromArgb(36, 103, 194);
        }

        private void AboutButton_MouseLeave(object sender, EventArgs e)
        {
            AboutButton.ForeColor = Color.FromArgb(224, 224, 224);
        }

        private void LogOut_Click(object sender, EventArgs e)
        {
            if (ac is Admin)
                ac.Close();
            else if (pf is Profile)
                pf.Close();


            
            MessageBox.Show("sure??");
            AdminLogin = false;
            UserLogin = false;
            ClickHome();


        }

        private void AccountButton_Click(object sender, EventArgs e)
        {
            ButtonColorChange(AccountButton);
            ac = new Admin(this);
            ac.MdiParent = this;
            ac.Dock = DockStyle.Fill;

            this.Panel.Controls.Clear();
            this.Panel.Controls.Add(ac);
            ac.Show();
        }

        private void AboutButton_Click(object sender, EventArgs e)
        {
            ButtonColorChange(AboutButton);

            ab.MdiParent = this;
            ab.Dock = DockStyle.Fill;

            this.Panel.Controls.Clear();
            this.Panel.Controls.Add(ab);
            ab.Show();
        }

        private void DBErrorShow_Click(object sender, EventArgs e)
        {
            DBErrorShow.Text = er.getError();
        }

        private void ProfileButton_Click(object sender, EventArgs e)
        {
            ButtonColorChange(ProfileButton);
            pf = new Profile(this);
            pf.MdiParent = this;
            pf.Dock = DockStyle.Fill;

            this.Panel.Controls.Clear();
            this.Panel.Controls.Add(pf);
            pf.Show();

        }

        private void ProfileButton_MouseHover(object sender, EventArgs e)
        {
            ProfileButton.ForeColor = Color.FromArgb(36, 103, 194);
        }

        private void ProfileButton_MouseLeave(object sender, EventArgs e)
        {
            ProfileButton.ForeColor = Color.FromArgb(224, 224, 224);
        }

        private void NameLabel_Click(object sender, EventArgs e)
        {

        }

        private void PanelTimer2_Tick(object sender, EventArgs e)
        {
            if (AdvPanel.Width == 53)
            {
                for (int i = AdvPanel.Width; i >= 0; i--)
                {
                    AdvPanel.Width = i;
                }
                this.PanelTimer2.Enabled = false;
            }
            else
            {

                for (int i = AdvPanel.Width; i <= 53; i++)
                {
                    AdvPanel.Width = i;
                }
                this.PanelTimer2.Enabled = false;
            }
        }


        private void Apple_Click(object sender, EventArgs e)
        {
            BrowserControl(1);
        }

        private void Sumsung_Click(object sender, EventArgs e)
        {
            BrowserControl(2);
        }

        private void Windows_Click(object sender, EventArgs e)
        {
            BrowserControl(3);
        }

        private void HTC_Click(object sender, EventArgs e)
        {
            BrowserControl(4);
        }

        private void OnePlus_Click(object sender, EventArgs e)
        {
            BrowserControl(5);
        }

        private void Asus_Click(object sender, EventArgs e)
        {
            BrowserControl(6);
        }


        public void BrowserControl(int i) {
            this.Panel.Controls.Clear();
            this.Panel.Controls.Add(Browser);
            this.Panel.Controls.Add(Url);
            Url.Visible = true;
            Browser.Visible = true;
            switch (i) { 
                case 1:
                    Browser.Navigate("http://www.apple.com/");
                    break;
                case 2:
                    Browser.Navigate("http://www.sumsung.com/");
                    break;
                case 3:
                    Browser.Navigate("https://www.microsoft.com/en-us/windows/view-all");
                    break;
                case 4:
                    Browser.Navigate("https://www.htc.com/");
                    break;
                case 5:
                    Browser.Navigate("https://oneplus.net/");
                    break;
                case 6:
                    Browser.Navigate("https://www.asus.com/");
                    break;
         }

        
        }

        private void Browser_Navigating_1(object sender, WebBrowserNavigatingEventArgs e)
        {
            Url.Text = "Please Wait. Your request proceeding...";
        }

        private void Browser_DocumentCompleted_1(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            Url.Text = e.Url.ToString() + " loaded";
        }















    }




}