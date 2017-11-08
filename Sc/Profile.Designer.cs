namespace GUI
{
    partial class Profile
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
            this.CreditLabel = new System.Windows.Forms.Label();
            this.CnLabel = new System.Windows.Forms.Label();
            this.AddressLabel = new System.Windows.Forms.Label();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.Address = new System.Windows.Forms.RichTextBox();
            this.Credit = new System.Windows.Forms.Label();
            this.Contact = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.Label();
            this.Fname = new System.Windows.Forms.Label();
            this.EditButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.FnameBox = new System.Windows.Forms.TextBox();
            this.EmailBox = new System.Windows.Forms.TextBox();
            this.ContactBox = new System.Windows.Forms.TextBox();
            this.EditPanel = new System.Windows.Forms.Panel();
            this.PasswordPanel = new System.Windows.Forms.Panel();
            this.CNPassword = new System.Windows.Forms.TextBox();
            this.NPassword = new System.Windows.Forms.TextBox();
            this.OPassword = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.AddressBox = new System.Windows.Forms.RichTextBox();
            this.CreditBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.OPError = new System.Windows.Forms.Label();
            this.CNPError = new System.Windows.Forms.Label();
            this.EditPanel.SuspendLayout();
            this.PasswordPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // CreditLabel
            // 
            this.CreditLabel.AutoSize = true;
            this.CreditLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.CreditLabel.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreditLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CreditLabel.Location = new System.Drawing.Point(74, 281);
            this.CreditLabel.Name = "CreditLabel";
            this.CreditLabel.Size = new System.Drawing.Size(117, 19);
            this.CreditLabel.TabIndex = 13;
            this.CreditLabel.Text = "Credit Card No:";
            // 
            // CnLabel
            // 
            this.CnLabel.AutoSize = true;
            this.CnLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.CnLabel.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CnLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CnLabel.Location = new System.Drawing.Point(97, 128);
            this.CnLabel.Name = "CnLabel";
            this.CnLabel.Size = new System.Drawing.Size(94, 19);
            this.CnLabel.TabIndex = 12;
            this.CnLabel.Text = "Contact No:";
            // 
            // AddressLabel
            // 
            this.AddressLabel.AutoSize = true;
            this.AddressLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.AddressLabel.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddressLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AddressLabel.Location = new System.Drawing.Point(126, 175);
            this.AddressLabel.Name = "AddressLabel";
            this.AddressLabel.Size = new System.Drawing.Size(65, 19);
            this.AddressLabel.TabIndex = 11;
            this.AddressLabel.Text = "Address:";
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.EmailLabel.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.EmailLabel.Location = new System.Drawing.Point(141, 87);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(50, 19);
            this.EmailLabel.TabIndex = 10;
            this.EmailLabel.Text = "Email:";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.NameLabel.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.NameLabel.Location = new System.Drawing.Point(110, 36);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(81, 19);
            this.NameLabel.TabIndex = 9;
            this.NameLabel.Text = "Full Name:";
            // 
            // Address
            // 
            this.Address.Location = new System.Drawing.Point(197, 175);
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            this.Address.Size = new System.Drawing.Size(189, 58);
            this.Address.TabIndex = 18;
            this.Address.Text = "";
            this.Address.TextChanged += new System.EventHandler(this.Address_TextChanged);
            // 
            // Credit
            // 
            this.Credit.AutoSize = true;
            this.Credit.Cursor = System.Windows.Forms.Cursors.Default;
            this.Credit.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Credit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Credit.Location = new System.Drawing.Point(193, 281);
            this.Credit.Name = "Credit";
            this.Credit.Size = new System.Drawing.Size(113, 17);
            this.Credit.TabIndex = 22;
            this.Credit.Text = "Credit Card No:";
            this.Credit.Click += new System.EventHandler(this.Credit_Click);
            // 
            // Contact
            // 
            this.Contact.AutoSize = true;
            this.Contact.Cursor = System.Windows.Forms.Cursors.Default;
            this.Contact.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Contact.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Contact.Location = new System.Drawing.Point(193, 128);
            this.Contact.Name = "Contact";
            this.Contact.Size = new System.Drawing.Size(89, 17);
            this.Contact.TabIndex = 21;
            this.Contact.Text = "Contact No:";
            this.Contact.Click += new System.EventHandler(this.Contact_Click);
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Cursor = System.Windows.Forms.Cursors.Default;
            this.Email.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Email.Location = new System.Drawing.Point(193, 87);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(50, 17);
            this.Email.TabIndex = 20;
            this.Email.Text = "Email:";
            this.Email.Click += new System.EventHandler(this.Email_Click);
            // 
            // Fname
            // 
            this.Fname.AutoSize = true;
            this.Fname.Cursor = System.Windows.Forms.Cursors.Default;
            this.Fname.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fname.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Fname.Location = new System.Drawing.Point(193, 36);
            this.Fname.Name = "Fname";
            this.Fname.Size = new System.Drawing.Size(81, 17);
            this.Fname.TabIndex = 19;
            this.Fname.Text = "Full Name:";
            this.Fname.Click += new System.EventHandler(this.Fname_Click);
            // 
            // EditButton
            // 
            this.EditButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.EditButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.EditButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.EditButton.Location = new System.Drawing.Point(347, 316);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(88, 33);
            this.EditButton.TabIndex = 23;
            this.EditButton.Text = "Edit";
            this.EditButton.UseVisualStyleBackColor = false;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Cursor = System.Windows.Forms.Cursors.Default;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(110, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 19);
            this.label5.TabIndex = 14;
            this.label5.Text = "Full Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Cursor = System.Windows.Forms.Cursors.Default;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(141, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 19);
            this.label4.TabIndex = 15;
            this.label4.Text = "Email:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.Default;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(126, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 19);
            this.label3.TabIndex = 16;
            this.label3.Text = "Address:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(97, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 19);
            this.label2.TabIndex = 17;
            this.label2.Text = "Contact No:";
            // 
            // FnameBox
            // 
            this.FnameBox.ForeColor = System.Drawing.Color.DimGray;
            this.FnameBox.Location = new System.Drawing.Point(197, 34);
            this.FnameBox.Name = "FnameBox";
            this.FnameBox.Size = new System.Drawing.Size(192, 20);
            this.FnameBox.TabIndex = 19;
            this.FnameBox.TextChanged += new System.EventHandler(this.FnameBox_TextChanged);
            // 
            // EmailBox
            // 
            this.EmailBox.ForeColor = System.Drawing.Color.DimGray;
            this.EmailBox.Location = new System.Drawing.Point(197, 84);
            this.EmailBox.Name = "EmailBox";
            this.EmailBox.Size = new System.Drawing.Size(192, 20);
            this.EmailBox.TabIndex = 20;
            // 
            // ContactBox
            // 
            this.ContactBox.ForeColor = System.Drawing.Color.DimGray;
            this.ContactBox.Location = new System.Drawing.Point(197, 125);
            this.ContactBox.Name = "ContactBox";
            this.ContactBox.Size = new System.Drawing.Size(192, 20);
            this.ContactBox.TabIndex = 21;
            // 
            // EditPanel
            // 
            this.EditPanel.Controls.Add(this.PasswordPanel);
            this.EditPanel.Controls.Add(this.linkLabel1);
            this.EditPanel.Controls.Add(this.SubmitButton);
            this.EditPanel.Controls.Add(this.CancelButton);
            this.EditPanel.Controls.Add(this.AddressBox);
            this.EditPanel.Controls.Add(this.CreditBox);
            this.EditPanel.Controls.Add(this.ContactBox);
            this.EditPanel.Controls.Add(this.EmailBox);
            this.EditPanel.Controls.Add(this.FnameBox);
            this.EditPanel.Controls.Add(this.label1);
            this.EditPanel.Controls.Add(this.label2);
            this.EditPanel.Controls.Add(this.label3);
            this.EditPanel.Controls.Add(this.label4);
            this.EditPanel.Controls.Add(this.label5);
            this.EditPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EditPanel.Location = new System.Drawing.Point(0, 0);
            this.EditPanel.Name = "EditPanel";
            this.EditPanel.Size = new System.Drawing.Size(516, 392);
            this.EditPanel.TabIndex = 24;
            this.EditPanel.Visible = false;
            this.EditPanel.Leave += new System.EventHandler(this.EditPanel_Leave);
            // 
            // PasswordPanel
            // 
            this.PasswordPanel.Controls.Add(this.CNPError);
            this.PasswordPanel.Controls.Add(this.OPError);
            this.PasswordPanel.Controls.Add(this.CNPassword);
            this.PasswordPanel.Controls.Add(this.NPassword);
            this.PasswordPanel.Controls.Add(this.OPassword);
            this.PasswordPanel.Controls.Add(this.label8);
            this.PasswordPanel.Controls.Add(this.label7);
            this.PasswordPanel.Controls.Add(this.label6);
            this.PasswordPanel.Controls.Add(this.button2);
            this.PasswordPanel.Controls.Add(this.button1);
            this.PasswordPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PasswordPanel.Location = new System.Drawing.Point(0, 0);
            this.PasswordPanel.Name = "PasswordPanel";
            this.PasswordPanel.Size = new System.Drawing.Size(516, 392);
            this.PasswordPanel.TabIndex = 27;
            this.PasswordPanel.Visible = false;
            this.PasswordPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.PasswordPanel_Paint);
            // 
            // CNPassword
            // 
            this.CNPassword.Location = new System.Drawing.Point(210, 156);
            this.CNPassword.Name = "CNPassword";
            this.CNPassword.PasswordChar = '•';
            this.CNPassword.Size = new System.Drawing.Size(192, 20);
            this.CNPassword.TabIndex = 32;
            // 
            // NPassword
            // 
            this.NPassword.Location = new System.Drawing.Point(210, 113);
            this.NPassword.Name = "NPassword";
            this.NPassword.PasswordChar = '•';
            this.NPassword.Size = new System.Drawing.Size(192, 20);
            this.NPassword.TabIndex = 31;
            // 
            // OPassword
            // 
            this.OPassword.Location = new System.Drawing.Point(210, 67);
            this.OPassword.Name = "OPassword";
            this.OPassword.PasswordChar = '•';
            this.OPassword.Size = new System.Drawing.Size(192, 20);
            this.OPassword.TabIndex = 30;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Cursor = System.Windows.Forms.Cursors.Default;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(36, 156);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(168, 19);
            this.label8.TabIndex = 29;
            this.label8.Text = "Confirm New Password:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Cursor = System.Windows.Forms.Cursors.Default;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(93, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 19);
            this.label7.TabIndex = 28;
            this.label7.Text = "New Password:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Cursor = System.Windows.Forms.Cursors.Default;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(99, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 19);
            this.label6.TabIndex = 27;
            this.label6.Text = "Old Password:";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(297, 229);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 33);
            this.button2.TabIndex = 26;
            this.button2.Text = "Submit";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Maroon;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(130, 229);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 33);
            this.button1.TabIndex = 25;
            this.button1.Text = "Canel";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.SteelBlue;
            this.linkLabel1.Location = new System.Drawing.Point(215, 292);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(127, 20);
            this.linkLabel1.TabIndex = 26;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Change Passord";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // SubmitButton
            // 
            this.SubmitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.SubmitButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SubmitButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubmitButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SubmitButton.Location = new System.Drawing.Point(298, 329);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(88, 33);
            this.SubmitButton.TabIndex = 25;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = false;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.BackColor = System.Drawing.Color.Maroon;
            this.CancelButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CancelButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CancelButton.Location = new System.Drawing.Point(177, 329);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(88, 33);
            this.CancelButton.TabIndex = 24;
            this.CancelButton.Text = "Canel";
            this.CancelButton.UseVisualStyleBackColor = false;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // AddressBox
            // 
            this.AddressBox.ForeColor = System.Drawing.Color.DimGray;
            this.AddressBox.Location = new System.Drawing.Point(196, 175);
            this.AddressBox.Name = "AddressBox";
            this.AddressBox.Size = new System.Drawing.Size(189, 58);
            this.AddressBox.TabIndex = 23;
            this.AddressBox.Text = "";
            // 
            // CreditBox
            // 
            this.CreditBox.ForeColor = System.Drawing.Color.DimGray;
            this.CreditBox.Location = new System.Drawing.Point(197, 252);
            this.CreditBox.Name = "CreditBox";
            this.CreditBox.Size = new System.Drawing.Size(192, 20);
            this.CreditBox.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(74, 253);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 19);
            this.label1.TabIndex = 18;
            this.label1.Text = "Credit Card No:";
            // 
            // OPError
            // 
            this.OPError.AutoSize = true;
            this.OPError.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OPError.ForeColor = System.Drawing.Color.Firebrick;
            this.OPError.Location = new System.Drawing.Point(408, 70);
            this.OPError.Name = "OPError";
            this.OPError.Size = new System.Drawing.Size(80, 17);
            this.OPError.TabIndex = 33;
            this.OPError.Text = "                  ";
            this.OPError.Click += new System.EventHandler(this.ErrorMsg_Click);
            // 
            // CNPError
            // 
            this.CNPError.AutoSize = true;
            this.CNPError.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CNPError.ForeColor = System.Drawing.Color.Firebrick;
            this.CNPError.Location = new System.Drawing.Point(408, 156);
            this.CNPError.Name = "CNPError";
            this.CNPError.Size = new System.Drawing.Size(80, 17);
            this.CNPError.TabIndex = 34;
            this.CNPError.Text = "                  ";
            // 
            // Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(516, 392);
            this.Controls.Add(this.EditPanel);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.Credit);
            this.Controls.Add(this.Contact);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.Fname);
            this.Controls.Add(this.Address);
            this.Controls.Add(this.CreditLabel);
            this.Controls.Add(this.CnLabel);
            this.Controls.Add(this.AddressLabel);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.NameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Profile";
            this.Text = "Profile";
            this.Load += new System.EventHandler(this.Profile_Load);
            this.EditPanel.ResumeLayout(false);
            this.EditPanel.PerformLayout();
            this.PasswordPanel.ResumeLayout(false);
            this.PasswordPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CreditLabel;
        private System.Windows.Forms.Label CnLabel;
        private System.Windows.Forms.Label AddressLabel;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.RichTextBox Address;
        private System.Windows.Forms.Label Credit;
        private System.Windows.Forms.Label Contact;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.Label Fname;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox FnameBox;
        private System.Windows.Forms.TextBox EmailBox;
        private System.Windows.Forms.TextBox ContactBox;
        private System.Windows.Forms.Panel EditPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox AddressBox;
        private System.Windows.Forms.TextBox CreditBox;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Panel PasswordPanel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox CNPassword;
        private System.Windows.Forms.TextBox NPassword;
        private System.Windows.Forms.TextBox OPassword;
        private System.Windows.Forms.Label OPError;
        private System.Windows.Forms.Label CNPError;

    }
}