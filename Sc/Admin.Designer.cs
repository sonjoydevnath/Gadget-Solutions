namespace GUI
{
    partial class Admin
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.brandCombo = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DbPanel = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.GridDB = new System.Windows.Forms.DataGridView();
            this.Back = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Aasd = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.FName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelError = new System.Windows.Forms.Label();
            this.TMemory = new System.Windows.Forms.TextBox();
            this.TRDate = new System.Windows.Forms.TextBox();
            this.TCpu = new System.Windows.Forms.TextBox();
            this.TFeat = new System.Windows.Forms.TextBox();
            this.TLPrice = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelSize = new System.Windows.Forms.Label();
            this.Os = new System.Windows.Forms.Label();
            this.Brand = new System.Windows.Forms.Label();
            this.ModelNo = new System.Windows.Forms.Label();
            this.TBody = new System.Windows.Forms.TextBox();
            this.TBat = new System.Windows.Forms.TextBox();
            this.TCam = new System.Windows.Forms.TextBox();
            this.TSize = new System.Windows.Forms.TextBox();
            this.TOs = new System.Windows.Forms.TextBox();
            this.TModelNo = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.phoneBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gSDataSet = new GUI.GSDataSet();
            this.phoneTableAdapter = new GUI.GSDataSetTableAdapters.PhoneTableAdapter();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteCommentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.DbPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridDB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phoneBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gSDataSet)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.DbPanel);
            this.panel1.Controls.Add(this.brandCombo);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.Aasd);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.FName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.labelError);
            this.panel1.Controls.Add(this.TMemory);
            this.panel1.Controls.Add(this.TRDate);
            this.panel1.Controls.Add(this.TCpu);
            this.panel1.Controls.Add(this.TFeat);
            this.panel1.Controls.Add(this.TLPrice);
            this.panel1.Controls.Add(this.label24);
            this.panel1.Controls.Add(this.label23);
            this.panel1.Controls.Add(this.label22);
            this.panel1.Controls.Add(this.label21);
            this.panel1.Controls.Add(this.label20);
            this.panel1.Controls.Add(this.label19);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.labelSize);
            this.panel1.Controls.Add(this.Os);
            this.panel1.Controls.Add(this.Brand);
            this.panel1.Controls.Add(this.ModelNo);
            this.panel1.Controls.Add(this.TBody);
            this.panel1.Controls.Add(this.TBat);
            this.panel1.Controls.Add(this.TCam);
            this.panel1.Controls.Add(this.TSize);
            this.panel1.Controls.Add(this.TOs);
            this.panel1.Controls.Add(this.TModelNo);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(667, 406);
            this.panel1.TabIndex = 24;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // brandCombo
            // 
            this.brandCombo.FormattingEnabled = true;
            this.brandCombo.Items.AddRange(new object[] {
            "Asus",
            "Apple",
            "One Plus",
            "Htc",
            "Walton",
            "Samsung",
            "Others"});
            this.brandCombo.Location = new System.Drawing.Point(104, 198);
            this.brandCombo.Name = "brandCombo";
            this.brandCombo.Size = new System.Drawing.Size(100, 21);
            this.brandCombo.TabIndex = 63;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Back);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(667, 406);
            this.panel2.TabIndex = 59;
            this.panel2.Visible = false;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // DbPanel
            // 
            this.DbPanel.Controls.Add(this.button2);
            this.DbPanel.Controls.Add(this.GridDB);
            this.DbPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DbPanel.Location = new System.Drawing.Point(0, 0);
            this.DbPanel.Name = "DbPanel";
            this.DbPanel.Size = new System.Drawing.Size(667, 406);
            this.DbPanel.TabIndex = 54;
            this.DbPanel.Visible = false;
            this.DbPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.DbPanel_Paint);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(504, 344);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 33);
            this.button2.TabIndex = 60;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_2);
            // 
            // GridDB
            // 
            this.GridDB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridDB.Location = new System.Drawing.Point(12, 38);
            this.GridDB.Name = "GridDB";
            this.GridDB.Size = new System.Drawing.Size(643, 287);
            this.GridDB.TabIndex = 3;
            this.GridDB.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridDB_CellContentClick);
            this.GridDB.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridDB_CellEndEdit);
            this.GridDB.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.GridDB_CellMouseUp);
            this.GridDB.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridDB_CellValueChanged);
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.Back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Back.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Back.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Back.Location = new System.Drawing.Point(466, 311);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(88, 33);
            this.Back.TabIndex = 61;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = false;
            this.Back.Click += new System.EventHandler(this.Back_Click_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(37, 38);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(577, 212);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            this.dataGridView1.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseUp);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(354, 66);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 38);
            this.button1.TabIndex = 61;
            this.button1.Text = "Show Database";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(117, 382);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(319, 13);
            this.label2.TabIndex = 62;
            this.label2.Text = "____________________________________________________";
            // 
            // Aasd
            // 
            this.Aasd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.Aasd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Aasd.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Aasd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Aasd.Location = new System.Drawing.Point(354, 120);
            this.Aasd.Name = "Aasd";
            this.Aasd.Size = new System.Drawing.Size(132, 38);
            this.Aasd.TabIndex = 60;
            this.Aasd.Text = "Upload";
            this.Aasd.UseVisualStyleBackColor = false;
            this.Aasd.Click += new System.EventHandler(this.Aasd_Click_1);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(354, 11);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(132, 38);
            this.button3.TabIndex = 59;
            this.button3.Text = "Show Comments";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click_2);
            // 
            // FName
            // 
            this.FName.AutoSize = true;
            this.FName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FName.Location = new System.Drawing.Point(130, 175);
            this.FName.Name = "FName";
            this.FName.Size = new System.Drawing.Size(0, 13);
            this.FName.TabIndex = 57;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(28, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 56;
            this.label1.Text = "File Name :";
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelError.ForeColor = System.Drawing.Color.Red;
            this.labelError.Location = new System.Drawing.Point(28, 146);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(0, 15);
            this.labelError.TabIndex = 55;
            // 
            // TMemory
            // 
            this.TMemory.Location = new System.Drawing.Point(360, 232);
            this.TMemory.Name = "TMemory";
            this.TMemory.Size = new System.Drawing.Size(100, 20);
            this.TMemory.TabIndex = 51;
            // 
            // TRDate
            // 
            this.TRDate.Location = new System.Drawing.Point(360, 329);
            this.TRDate.Name = "TRDate";
            this.TRDate.Size = new System.Drawing.Size(100, 20);
            this.TRDate.TabIndex = 50;
            // 
            // TCpu
            // 
            this.TCpu.Location = new System.Drawing.Point(360, 297);
            this.TCpu.Name = "TCpu";
            this.TCpu.Size = new System.Drawing.Size(100, 20);
            this.TCpu.TabIndex = 49;
            // 
            // TFeat
            // 
            this.TFeat.Location = new System.Drawing.Point(360, 264);
            this.TFeat.Name = "TFeat";
            this.TFeat.Size = new System.Drawing.Size(100, 20);
            this.TFeat.TabIndex = 48;
            // 
            // TLPrice
            // 
            this.TLPrice.Location = new System.Drawing.Point(360, 361);
            this.TLPrice.Name = "TLPrice";
            this.TLPrice.Size = new System.Drawing.Size(100, 20);
            this.TLPrice.TabIndex = 46;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label24.Location = new System.Drawing.Point(265, 334);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(78, 13);
            this.label24.TabIndex = 45;
            this.label24.Text = "Release Date :";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label23.Location = new System.Drawing.Point(276, 366);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(69, 13);
            this.label23.TabIndex = 44;
            this.label23.Text = "Latest Price :";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label22.Location = new System.Drawing.Point(293, 237);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(50, 13);
            this.label22.TabIndex = 43;
            this.label22.Text = "Memory :";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label21.Location = new System.Drawing.Point(292, 269);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(54, 13);
            this.label21.TabIndex = 42;
            this.label21.Text = "Features :";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label20.Location = new System.Drawing.Point(319, 302);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(35, 13);
            this.label20.TabIndex = 41;
            this.label20.Text = "CPU :";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label19.Location = new System.Drawing.Point(312, 204);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(37, 13);
            this.label19.TabIndex = 40;
            this.label19.Text = "Body :";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label17.Location = new System.Drawing.Point(38, 332);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(49, 13);
            this.label17.TabIndex = 39;
            this.label17.Text = "Camera :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(43, 364);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 38;
            this.label4.Text = "Battery :";
            // 
            // labelSize
            // 
            this.labelSize.AutoSize = true;
            this.labelSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSize.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelSize.Location = new System.Drawing.Point(21, 300);
            this.labelSize.Name = "labelSize";
            this.labelSize.Size = new System.Drawing.Size(70, 13);
            this.labelSize.TabIndex = 37;
            this.labelSize.Text = "Screen Size :";
            // 
            // Os
            // 
            this.Os.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Os.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Os.Location = new System.Drawing.Point(28, 256);
            this.Os.Name = "Os";
            this.Os.Size = new System.Drawing.Size(73, 40);
            this.Os.TabIndex = 36;
            this.Os.Text = "Operationg    System :";
            // 
            // Brand
            // 
            this.Brand.AutoSize = true;
            this.Brand.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Brand.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Brand.Location = new System.Drawing.Point(51, 202);
            this.Brand.Name = "Brand";
            this.Brand.Size = new System.Drawing.Size(41, 13);
            this.Brand.TabIndex = 35;
            this.Brand.Text = "Brand :";
            // 
            // ModelNo
            // 
            this.ModelNo.AutoSize = true;
            this.ModelNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModelNo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ModelNo.Location = new System.Drawing.Point(30, 230);
            this.ModelNo.Name = "ModelNo";
            this.ModelNo.Size = new System.Drawing.Size(59, 13);
            this.ModelNo.TabIndex = 34;
            this.ModelNo.Text = "Model No :";
            // 
            // TBody
            // 
            this.TBody.Location = new System.Drawing.Point(360, 199);
            this.TBody.Name = "TBody";
            this.TBody.Size = new System.Drawing.Size(100, 20);
            this.TBody.TabIndex = 30;
            // 
            // TBat
            // 
            this.TBat.Location = new System.Drawing.Point(104, 361);
            this.TBat.Name = "TBat";
            this.TBat.Size = new System.Drawing.Size(100, 20);
            this.TBat.TabIndex = 29;
            // 
            // TCam
            // 
            this.TCam.Location = new System.Drawing.Point(104, 329);
            this.TCam.Name = "TCam";
            this.TCam.Size = new System.Drawing.Size(100, 20);
            this.TCam.TabIndex = 28;
            // 
            // TSize
            // 
            this.TSize.Location = new System.Drawing.Point(104, 296);
            this.TSize.Name = "TSize";
            this.TSize.Size = new System.Drawing.Size(100, 20);
            this.TSize.TabIndex = 27;
            // 
            // TOs
            // 
            this.TOs.Location = new System.Drawing.Point(104, 265);
            this.TOs.Name = "TOs";
            this.TOs.Size = new System.Drawing.Size(100, 20);
            this.TOs.TabIndex = 26;
            // 
            // TModelNo
            // 
            this.TModelNo.Location = new System.Drawing.Point(104, 227);
            this.TModelNo.Name = "TModelNo";
            this.TModelNo.Size = new System.Drawing.Size(100, 20);
            this.TModelNo.TabIndex = 25;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Location = new System.Drawing.Point(20, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(301, 147);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // phoneBindingSource
            // 
            this.phoneBindingSource.DataMember = "Phone";
            this.phoneBindingSource.DataSource = this.gSDataSet;
            // 
            // gSDataSet
            // 
            this.gSDataSet.DataSetName = "GSDataSet";
            this.gSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // phoneTableAdapter
            // 
            this.phoneTableAdapter.ClearBeforeFill = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteProductToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(153, 26);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // deleteProductToolStripMenuItem
            // 
            this.deleteProductToolStripMenuItem.Name = "deleteProductToolStripMenuItem";
            this.deleteProductToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.deleteProductToolStripMenuItem.Text = "Delete Product";
            this.deleteProductToolStripMenuItem.Click += new System.EventHandler(this.deleteProductToolStripMenuItem_Click);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteCommentToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(165, 26);
            // 
            // deleteCommentToolStripMenuItem
            // 
            this.deleteCommentToolStripMenuItem.Name = "deleteCommentToolStripMenuItem";
            this.deleteCommentToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.deleteCommentToolStripMenuItem.Text = "Delete Comment";
            this.deleteCommentToolStripMenuItem.Click += new System.EventHandler(this.deleteCommentToolStripMenuItem_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(667, 406);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Admin";
            this.Text = "Account";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.DbPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridDB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phoneBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gSDataSet)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.contextMenuStrip2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TBody;
        private System.Windows.Forms.TextBox TBat;
        private System.Windows.Forms.TextBox TCam;
        private System.Windows.Forms.TextBox TSize;
        private System.Windows.Forms.TextBox TOs;
        private System.Windows.Forms.TextBox TModelNo;
        private System.Windows.Forms.TextBox TRDate;
        private System.Windows.Forms.TextBox TCpu;
        private System.Windows.Forms.TextBox TFeat;
        private System.Windows.Forms.TextBox TLPrice;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelSize;
        private System.Windows.Forms.Label Os;
        private System.Windows.Forms.Label Brand;
        private System.Windows.Forms.Label ModelNo;
        private System.Windows.Forms.TextBox TMemory;
        private System.Windows.Forms.Panel DbPanel;
        private GSDataSet gSDataSet;
        private System.Windows.Forms.BindingSource phoneBindingSource;
        private GSDataSetTableAdapters.PhoneTableAdapter phoneTableAdapter;
        private System.Windows.Forms.DataGridView GridDB;
        public System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.Label FName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem deleteProductToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Aasd;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem deleteCommentToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox brandCombo;

    }
}