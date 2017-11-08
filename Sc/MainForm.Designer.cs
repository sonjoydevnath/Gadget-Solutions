namespace GUI
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.Header = new System.Windows.Forms.Panel();
            this.DBErrorShow = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SlideMenu = new System.Windows.Forms.Panel();
            this.ProfileButton = new System.Windows.Forms.Button();
            this.AboutButton = new System.Windows.Forms.Button();
            this.AccountButton = new System.Windows.Forms.Button();
            this.LogOut = new System.Windows.Forms.Button();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.DeviceListButton = new System.Windows.Forms.Button();
            this.LoginButton = new System.Windows.Forms.Button();
            this.HomeButton = new System.Windows.Forms.Button();
            this.SlideButton = new System.Windows.Forms.Button();
            this.Panel = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Browser = new System.Windows.Forms.WebBrowser();
            this.Url = new System.Windows.Forms.TextBox();
            this.PanelTimer = new System.Windows.Forms.Timer(this.components);
            this.LoginCheck = new System.Windows.Forms.Timer(this.components);
            this.PanelTimer2 = new System.Windows.Forms.Timer(this.components);
            this.AdvPanel = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.HTC = new System.Windows.Forms.Button();
            this.Asus = new System.Windows.Forms.Button();
            this.OnePlus = new System.Windows.Forms.Button();
            this.Windows = new System.Windows.Forms.Button();
            this.Sumsung = new System.Windows.Forms.Button();
            this.Apple = new System.Windows.Forms.Button();
            this.Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SlideMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.AdvPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Header
            // 
            this.Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(16)))), ((int)(((byte)(29)))));
            this.Header.Controls.Add(this.DBErrorShow);
            this.Header.Controls.Add(this.NameLabel);
            this.Header.Controls.Add(this.ExitButton);
            this.Header.Controls.Add(this.pictureBox1);
            this.Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.Header.Location = new System.Drawing.Point(0, 0);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(814, 35);
            this.Header.TabIndex = 6;
            this.Header.Paint += new System.Windows.Forms.PaintEventHandler(this.Header_Paint);
            this.Header.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Header_MouseDown);
            this.Header.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Header_MouseMove);
            // 
            // DBErrorShow
            // 
            this.DBErrorShow.AutoSize = true;
            this.DBErrorShow.ForeColor = System.Drawing.Color.Red;
            this.DBErrorShow.Location = new System.Drawing.Point(579, 11);
            this.DBErrorShow.Name = "DBErrorShow";
            this.DBErrorShow.Size = new System.Drawing.Size(19, 13);
            this.DBErrorShow.TabIndex = 3;
            this.DBErrorShow.Text = "    ";
            this.DBErrorShow.Click += new System.EventHandler(this.DBErrorShow_Click);
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(103)))), ((int)(((byte)(194)))));
            this.NameLabel.Location = new System.Drawing.Point(40, 6);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(152, 25);
            this.NameLabel.TabIndex = 2;
            this.NameLabel.Text = "Gadget Solution";
            this.NameLabel.Click += new System.EventHandler(this.NameLabel_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.ExitButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(16)))), ((int)(((byte)(29)))));
            this.ExitButton.FlatAppearance.BorderSize = 0;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(16)))), ((int)(((byte)(29)))));
            this.ExitButton.Image = ((System.Drawing.Image)(resources.GetObject("ExitButton.Image")));
            this.ExitButton.Location = new System.Drawing.Point(778, 6);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(24, 23);
            this.ExitButton.TabIndex = 1;
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(8, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 32);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // SlideMenu
            // 
            this.SlideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.SlideMenu.Controls.Add(this.ProfileButton);
            this.SlideMenu.Controls.Add(this.AboutButton);
            this.SlideMenu.Controls.Add(this.AccountButton);
            this.SlideMenu.Controls.Add(this.LogOut);
            this.SlideMenu.Controls.Add(this.Logo);
            this.SlideMenu.Controls.Add(this.DeviceListButton);
            this.SlideMenu.Controls.Add(this.LoginButton);
            this.SlideMenu.Controls.Add(this.HomeButton);
            this.SlideMenu.Controls.Add(this.SlideButton);
            this.SlideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.SlideMenu.Location = new System.Drawing.Point(0, 35);
            this.SlideMenu.Name = "SlideMenu";
            this.SlideMenu.Size = new System.Drawing.Size(192, 392);
            this.SlideMenu.TabIndex = 7;
            // 
            // ProfileButton
            // 
            this.ProfileButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ProfileButton.BackgroundImage")));
            this.ProfileButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ProfileButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ProfileButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.ProfileButton.FlatAppearance.BorderSize = 0;
            this.ProfileButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(103)))), ((int)(((byte)(194)))));
            this.ProfileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProfileButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProfileButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ProfileButton.Location = new System.Drawing.Point(3, 187);
            this.ProfileButton.Name = "ProfileButton";
            this.ProfileButton.Size = new System.Drawing.Size(193, 44);
            this.ProfileButton.TabIndex = 11;
            this.ProfileButton.Text = "Profile";
            this.ProfileButton.UseVisualStyleBackColor = true;
            this.ProfileButton.Visible = false;
            this.ProfileButton.Click += new System.EventHandler(this.ProfileButton_Click);
            this.ProfileButton.MouseLeave += new System.EventHandler(this.ProfileButton_MouseLeave);
            this.ProfileButton.MouseHover += new System.EventHandler(this.ProfileButton_MouseHover);
            // 
            // AboutButton
            // 
            this.AboutButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AboutButton.BackgroundImage")));
            this.AboutButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.AboutButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AboutButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.AboutButton.FlatAppearance.BorderSize = 0;
            this.AboutButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(103)))), ((int)(((byte)(194)))));
            this.AboutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AboutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AboutButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.AboutButton.Location = new System.Drawing.Point(8, 336);
            this.AboutButton.Name = "AboutButton";
            this.AboutButton.Size = new System.Drawing.Size(193, 44);
            this.AboutButton.TabIndex = 10;
            this.AboutButton.Text = "About";
            this.AboutButton.UseVisualStyleBackColor = true;
            this.AboutButton.Click += new System.EventHandler(this.AboutButton_Click);
            this.AboutButton.MouseLeave += new System.EventHandler(this.AboutButton_MouseLeave);
            this.AboutButton.MouseHover += new System.EventHandler(this.AboutButton_MouseHover);
            // 
            // AccountButton
            // 
            this.AccountButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AccountButton.BackgroundImage")));
            this.AccountButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.AccountButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AccountButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.AccountButton.FlatAppearance.BorderSize = 0;
            this.AccountButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(103)))), ((int)(((byte)(194)))));
            this.AccountButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AccountButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccountButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.AccountButton.Location = new System.Drawing.Point(3, 187);
            this.AccountButton.Name = "AccountButton";
            this.AccountButton.Size = new System.Drawing.Size(193, 44);
            this.AccountButton.TabIndex = 9;
            this.AccountButton.Text = "  Admin";
            this.AccountButton.UseVisualStyleBackColor = true;
            this.AccountButton.Visible = false;
            this.AccountButton.Click += new System.EventHandler(this.AccountButton_Click);
            this.AccountButton.MouseLeave += new System.EventHandler(this.AccountButton_MouseLeave);
            this.AccountButton.MouseHover += new System.EventHandler(this.AccountButton_MouseHover);
            // 
            // LogOut
            // 
            this.LogOut.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LogOut.BackgroundImage")));
            this.LogOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.LogOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogOut.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.LogOut.FlatAppearance.BorderSize = 0;
            this.LogOut.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(103)))), ((int)(((byte)(194)))));
            this.LogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogOut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LogOut.Location = new System.Drawing.Point(3, 237);
            this.LogOut.Name = "LogOut";
            this.LogOut.Size = new System.Drawing.Size(193, 44);
            this.LogOut.TabIndex = 8;
            this.LogOut.Text = "  Log Out";
            this.LogOut.UseVisualStyleBackColor = true;
            this.LogOut.Visible = false;
            this.LogOut.Click += new System.EventHandler(this.LogOut_Click);
            this.LogOut.MouseLeave += new System.EventHandler(this.LogOut_MouseLeave);
            this.LogOut.MouseHover += new System.EventHandler(this.LogOut_MouseHover);
            // 
            // Logo
            // 
            this.Logo.Image = ((System.Drawing.Image)(resources.GetObject("Logo.Image")));
            this.Logo.Location = new System.Drawing.Point(13, 17);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(137, 65);
            this.Logo.TabIndex = 7;
            this.Logo.TabStop = false;
            // 
            // DeviceListButton
            // 
            this.DeviceListButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DeviceListButton.BackgroundImage")));
            this.DeviceListButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.DeviceListButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeviceListButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.DeviceListButton.FlatAppearance.BorderSize = 0;
            this.DeviceListButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(103)))), ((int)(((byte)(194)))));
            this.DeviceListButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeviceListButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeviceListButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DeviceListButton.Location = new System.Drawing.Point(3, 137);
            this.DeviceListButton.Name = "DeviceListButton";
            this.DeviceListButton.Size = new System.Drawing.Size(193, 44);
            this.DeviceListButton.TabIndex = 6;
            this.DeviceListButton.Text = "      Device List";
            this.DeviceListButton.UseVisualStyleBackColor = true;
            this.DeviceListButton.Click += new System.EventHandler(this.DeviceListButton_Click);
            this.DeviceListButton.MouseLeave += new System.EventHandler(this.DeviceListButton_MouseLeave);
            this.DeviceListButton.MouseHover += new System.EventHandler(this.DeviceListButton_MouseHover);
            // 
            // LoginButton
            // 
            this.LoginButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LoginButton.BackgroundImage")));
            this.LoginButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.LoginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LoginButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.LoginButton.FlatAppearance.BorderSize = 0;
            this.LoginButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(103)))), ((int)(((byte)(194)))));
            this.LoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LoginButton.Location = new System.Drawing.Point(3, 187);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(193, 44);
            this.LoginButton.TabIndex = 5;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            this.LoginButton.MouseLeave += new System.EventHandler(this.LoginButton_MouseLeave);
            this.LoginButton.MouseHover += new System.EventHandler(this.LoginButton_MouseHover);
            // 
            // HomeButton
            // 
            this.HomeButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("HomeButton.BackgroundImage")));
            this.HomeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.HomeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HomeButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.HomeButton.FlatAppearance.BorderSize = 0;
            this.HomeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(103)))), ((int)(((byte)(194)))));
            this.HomeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HomeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.HomeButton.Location = new System.Drawing.Point(3, 87);
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.Size = new System.Drawing.Size(193, 44);
            this.HomeButton.TabIndex = 4;
            this.HomeButton.Text = "Home";
            this.HomeButton.UseVisualStyleBackColor = true;
            this.HomeButton.Click += new System.EventHandler(this.HomeButton_Click);
            this.HomeButton.MouseLeave += new System.EventHandler(this.HomeButton_MouseLeave);
            this.HomeButton.MouseHover += new System.EventHandler(this.HomeButton_MouseHover);
            // 
            // SlideButton
            // 
            this.SlideButton.AllowDrop = true;
            this.SlideButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.SlideButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SlideButton.BackgroundImage")));
            this.SlideButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.SlideButton.FlatAppearance.BorderSize = 0;
            this.SlideButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SlideButton.Location = new System.Drawing.Point(151, 16);
            this.SlideButton.Name = "SlideButton";
            this.SlideButton.Size = new System.Drawing.Size(29, 26);
            this.SlideButton.TabIndex = 2;
            this.SlideButton.UseVisualStyleBackColor = true;
            this.SlideButton.Click += new System.EventHandler(this.SlideButton_Click);
            // 
            // Panel
            // 
            this.Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.Panel.Controls.Add(this.pictureBox2);
            this.Panel.Controls.Add(this.Browser);
            this.Panel.Controls.Add(this.Url);
            this.Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel.Location = new System.Drawing.Point(192, 35);
            this.Panel.Name = "Panel";
            this.Panel.Size = new System.Drawing.Size(622, 392);
            this.Panel.TabIndex = 8;
            this.Panel.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel_Paint);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::GUI.Properties.Resources.s;
            this.pictureBox2.Location = new System.Drawing.Point(212, 81);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(203, 200);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // Browser
            // 
            this.Browser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Browser.Location = new System.Drawing.Point(0, 20);
            this.Browser.MinimumSize = new System.Drawing.Size(20, 20);
            this.Browser.Name = "Browser";
            this.Browser.Size = new System.Drawing.Size(622, 372);
            this.Browser.TabIndex = 2;
            this.Browser.Visible = false;
            this.Browser.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.Browser_DocumentCompleted_1);
            this.Browser.Navigating += new System.Windows.Forms.WebBrowserNavigatingEventHandler(this.Browser_Navigating_1);
            // 
            // Url
            // 
            this.Url.Dock = System.Windows.Forms.DockStyle.Top;
            this.Url.Location = new System.Drawing.Point(0, 0);
            this.Url.Name = "Url";
            this.Url.ReadOnly = true;
            this.Url.Size = new System.Drawing.Size(622, 20);
            this.Url.TabIndex = 1;
            this.Url.Visible = false;
            // 
            // PanelTimer
            // 
            this.PanelTimer.Tick += new System.EventHandler(this.PanelTimer_Tick);
            // 
            // LoginCheck
            // 
            this.LoginCheck.Enabled = true;
            this.LoginCheck.Tick += new System.EventHandler(this.LoginCheck_Tick);
            // 
            // PanelTimer2
            // 
            this.PanelTimer2.Tick += new System.EventHandler(this.PanelTimer2_Tick);
            // 
            // AdvPanel
            // 
            this.AdvPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.AdvPanel.Controls.Add(this.label5);
            this.AdvPanel.Controls.Add(this.label4);
            this.AdvPanel.Controls.Add(this.label3);
            this.AdvPanel.Controls.Add(this.label2);
            this.AdvPanel.Controls.Add(this.label1);
            this.AdvPanel.Controls.Add(this.HTC);
            this.AdvPanel.Controls.Add(this.Asus);
            this.AdvPanel.Controls.Add(this.OnePlus);
            this.AdvPanel.Controls.Add(this.Windows);
            this.AdvPanel.Controls.Add(this.Sumsung);
            this.AdvPanel.Controls.Add(this.Apple);
            this.AdvPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.AdvPanel.Location = new System.Drawing.Point(761, 35);
            this.AdvPanel.Name = "AdvPanel";
            this.AdvPanel.Size = new System.Drawing.Size(53, 392);
            this.AdvPanel.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(4, 309);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "_____";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(4, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "_____";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(4, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "_____";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(4, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "_____";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(4, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "_____";
            // 
            // HTC
            // 
            this.HTC.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("HTC.BackgroundImage")));
            this.HTC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.HTC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HTC.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.HTC.FlatAppearance.BorderSize = 0;
            this.HTC.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(103)))), ((int)(((byte)(194)))));
            this.HTC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HTC.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HTC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.HTC.Location = new System.Drawing.Point(3, 203);
            this.HTC.Name = "HTC";
            this.HTC.Size = new System.Drawing.Size(47, 44);
            this.HTC.TabIndex = 10;
            this.HTC.UseVisualStyleBackColor = true;
            this.HTC.Click += new System.EventHandler(this.HTC_Click);
            // 
            // Asus
            // 
            this.Asus.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Asus.BackgroundImage")));
            this.Asus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Asus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Asus.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Asus.FlatAppearance.BorderSize = 0;
            this.Asus.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(103)))), ((int)(((byte)(194)))));
            this.Asus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Asus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Asus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Asus.Location = new System.Drawing.Point(5, 336);
            this.Asus.Name = "Asus";
            this.Asus.Size = new System.Drawing.Size(47, 44);
            this.Asus.TabIndex = 9;
            this.Asus.UseVisualStyleBackColor = true;
            this.Asus.Click += new System.EventHandler(this.Asus_Click);
            // 
            // OnePlus
            // 
            this.OnePlus.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("OnePlus.BackgroundImage")));
            this.OnePlus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.OnePlus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OnePlus.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.OnePlus.FlatAppearance.BorderSize = 0;
            this.OnePlus.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(103)))), ((int)(((byte)(194)))));
            this.OnePlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OnePlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OnePlus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.OnePlus.Location = new System.Drawing.Point(5, 270);
            this.OnePlus.Name = "OnePlus";
            this.OnePlus.Size = new System.Drawing.Size(47, 44);
            this.OnePlus.TabIndex = 8;
            this.OnePlus.UseVisualStyleBackColor = true;
            this.OnePlus.Click += new System.EventHandler(this.OnePlus_Click);
            // 
            // Windows
            // 
            this.Windows.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Windows.BackgroundImage")));
            this.Windows.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Windows.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Windows.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Windows.FlatAppearance.BorderSize = 0;
            this.Windows.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(103)))), ((int)(((byte)(194)))));
            this.Windows.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Windows.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Windows.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Windows.Location = new System.Drawing.Point(3, 139);
            this.Windows.Name = "Windows";
            this.Windows.Size = new System.Drawing.Size(47, 44);
            this.Windows.TabIndex = 7;
            this.Windows.UseVisualStyleBackColor = true;
            this.Windows.Click += new System.EventHandler(this.Windows_Click);
            // 
            // Sumsung
            // 
            this.Sumsung.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Sumsung.BackgroundImage")));
            this.Sumsung.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Sumsung.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Sumsung.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Sumsung.FlatAppearance.BorderSize = 0;
            this.Sumsung.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(103)))), ((int)(((byte)(194)))));
            this.Sumsung.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Sumsung.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sumsung.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Sumsung.Location = new System.Drawing.Point(4, 74);
            this.Sumsung.Name = "Sumsung";
            this.Sumsung.Size = new System.Drawing.Size(47, 44);
            this.Sumsung.TabIndex = 6;
            this.Sumsung.UseVisualStyleBackColor = true;
            this.Sumsung.Click += new System.EventHandler(this.Sumsung_Click);
            // 
            // Apple
            // 
            this.Apple.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Apple.BackgroundImage")));
            this.Apple.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Apple.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Apple.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Apple.FlatAppearance.BorderSize = 0;
            this.Apple.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(103)))), ((int)(((byte)(194)))));
            this.Apple.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Apple.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Apple.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Apple.Location = new System.Drawing.Point(3, 11);
            this.Apple.Name = "Apple";
            this.Apple.Size = new System.Drawing.Size(47, 44);
            this.Apple.TabIndex = 5;
            this.Apple.UseVisualStyleBackColor = true;
            this.Apple.Click += new System.EventHandler(this.Apple_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 427);
            this.ControlBox = false;
            this.Controls.Add(this.AdvPanel);
            this.Controls.Add(this.Panel);
            this.Controls.Add(this.SlideMenu);
            this.Controls.Add(this.Header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Header.ResumeLayout(false);
            this.Header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.SlideMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.Panel.ResumeLayout(false);
            this.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.AdvPanel.ResumeLayout(false);
            this.AdvPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Header;
        private System.Windows.Forms.Panel SlideMenu;
        private System.Windows.Forms.Panel Panel;
        private System.Windows.Forms.Button SlideButton;
        private System.Windows.Forms.Timer PanelTimer;
        private System.Windows.Forms.Button HomeButton;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Button DeviceListButton;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Button LogOut;
        private System.Windows.Forms.Timer LoginCheck;
        private System.Windows.Forms.Button AccountButton;
        private System.Windows.Forms.Button AboutButton;
        private System.Windows.Forms.Label DBErrorShow;
        private System.Windows.Forms.Button ProfileButton;
        private System.Windows.Forms.Timer PanelTimer2;
        private System.Windows.Forms.Panel AdvPanel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button HTC;
        private System.Windows.Forms.Button Asus;
        private System.Windows.Forms.Button OnePlus;
        private System.Windows.Forms.Button Windows;
        private System.Windows.Forms.Button Sumsung;
        private System.Windows.Forms.Button Apple;
        private System.Windows.Forms.WebBrowser Browser;
        private System.Windows.Forms.TextBox Url;
        private System.Windows.Forms.PictureBox pictureBox2;

    }
}

