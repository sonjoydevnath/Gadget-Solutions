namespace GUI
{
    partial class Login
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
            this.UnameLabel = new System.Windows.Forms.Label();
            this.Uname = new System.Windows.Forms.TextBox();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.TextBox();
            this.LoginButton = new System.Windows.Forms.Button();
            this.RegisterButoon = new System.Windows.Forms.Button();
            this.ErrorMsg = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // UnameLabel
            // 
            this.UnameLabel.AutoSize = true;
            this.UnameLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UnameLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.UnameLabel.Location = new System.Drawing.Point(92, 130);
            this.UnameLabel.Name = "UnameLabel";
            this.UnameLabel.Size = new System.Drawing.Size(98, 21);
            this.UnameLabel.TabIndex = 0;
            this.UnameLabel.Text = "User Name:";
            // 
            // Uname
            // 
            this.Uname.Location = new System.Drawing.Point(205, 133);
            this.Uname.Name = "Uname";
            this.Uname.Size = new System.Drawing.Size(192, 20);
            this.Uname.TabIndex = 1;
            this.Uname.TextChanged += new System.EventHandler(this.Uname_TextChanged);
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PasswordLabel.Location = new System.Drawing.Point(104, 176);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(86, 21);
            this.PasswordLabel.TabIndex = 2;
            this.PasswordLabel.Text = "Password:";
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(205, 176);
            this.Password.Name = "Password";
            this.Password.PasswordChar = '•';
            this.Password.Size = new System.Drawing.Size(192, 20);
            this.Password.TabIndex = 3;
            this.Password.TextChanged += new System.EventHandler(this.Password_TextChanged);
            // 
            // LoginButton
            // 
            this.LoginButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.LoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LoginButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LoginButton.Location = new System.Drawing.Point(309, 249);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(88, 33);
            this.LoginButton.TabIndex = 4;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = false;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // RegisterButoon
            // 
            this.RegisterButoon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.RegisterButoon.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RegisterButoon.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterButoon.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.RegisterButoon.Location = new System.Drawing.Point(187, 249);
            this.RegisterButoon.Name = "RegisterButoon";
            this.RegisterButoon.Size = new System.Drawing.Size(88, 33);
            this.RegisterButoon.TabIndex = 5;
            this.RegisterButoon.Text = "Register";
            this.RegisterButoon.UseVisualStyleBackColor = false;
            this.RegisterButoon.Click += new System.EventHandler(this.RegisterButoon_Click);
            // 
            // ErrorMsg
            // 
            this.ErrorMsg.AutoSize = true;
            this.ErrorMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorMsg.ForeColor = System.Drawing.Color.Firebrick;
            this.ErrorMsg.Location = new System.Drawing.Point(202, 216);
            this.ErrorMsg.Name = "ErrorMsg";
            this.ErrorMsg.Size = new System.Drawing.Size(144, 17);
            this.ErrorMsg.TabIndex = 6;
            this.ErrorMsg.Text = "                                  ";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(516, 392);
            this.Controls.Add(this.ErrorMsg);
            this.Controls.Add(this.RegisterButoon);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.Uname);
            this.Controls.Add(this.UnameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UnameLabel;
        private System.Windows.Forms.TextBox Uname;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Button RegisterButoon;
        private System.Windows.Forms.Label ErrorMsg;

    }
}