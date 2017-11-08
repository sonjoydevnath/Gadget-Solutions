using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace GUI
{
    public partial class Device : Form
    {
        MainForm mf;
        Product pr = new Product();
        Review r = new Review();
        string butt;
        
        public Device()
        {
            InitializeComponent();
        }

        public Device(MainForm mf) : this() {
           this.mf = mf;
           
        }


 
        private void Device_Load(object sender, EventArgs e)
        {
            
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
        private void performOperation(string p)
        {
            panel4.Controls.Clear();
            panel1.Visible = false;
            panel2.Visible = false;
      

            panel4.Visible = true;
            int top = 20;
            int left = 50;
            int panelSize = 20;

            ArrayList listP = new ArrayList();
            listP = pr.ShowProduct(p);
            int length = Convert.ToInt32(listP.Count.ToString());

            for (int i = 0; i < length; i++)
            {

                Button button = new Button();
                
                button.Left = left;
                button.Top = top;
                button.Size = new Size(100, 35);
                button.BackColor = Color.FromArgb(21, 45, 24, 28);
                if ((top + button.Height) < 355)
                {
                    if ((left + button.Width) < 543)
                    {
                        panel4.Controls.Add(button);
                        button.Click += new EventHandler(this.button_Click);
                        button.Text = listP[i].ToString();
                        left += button.Width + 35;
                    }
                    else
                    {
                        panel4.Controls.Add(button);
                        button.Click += new EventHandler(this.button_Click);
                        button.Text = listP[i].ToString();
                        top += button.Height + 25;
                        left = 50;
                    }
                }
                else
                {
                    panel4.Height += 12;
                    if ((left + button.Width) < 543)
                    {
                        panel4.Controls.Add(button);
                        button.Click += new EventHandler(this.button_Click);
                        button.Text = listP[i].ToString();
                        left += button.Width + 35;
                    }
                    else
                    {
                        panel4.Controls.Add(button);
                        button.Click += new EventHandler(this.button_Click);
                        button.Text = listP[i].ToString();

                        top += button.Height + 25;
                        left = 50;
                    }
                    
                }


            }
         

        }
        protected void button_Click(object sender, EventArgs e)
        {

            panel4.Hide();
            panel1.Show();
            panel2.Show();
            Button bt = (Button)sender;
             ArrayList lt=new ArrayList();
            lt=pr.ProductDetailsShow(bt.Text);
            label13.Text = lt[0].ToString(); 
            labelMod.Text = lt[0].ToString();
            labelBrand.Text = lt[1].ToString();
            labelOs.Text = lt[2].ToString();
            labelSs.Text = lt[3].ToString();
            labelCam.Text = lt[4].ToString();
            labelBat.Text = lt[5].ToString();
            labelBody.Text = lt[6].ToString();
            labelMemo.Text = lt[7].ToString();
            labelFeat.Text = lt[8].ToString();
            labelCpu.Text = lt[9].ToString();
            labelRdate.Text = lt[10].ToString();
            labelPrice.Text = lt[11].ToString();
			string url =@"C:\GadgetSolution\";
            Image image = Image.FromFile((url+lt[12].ToString()));
            this.pictureBox1.Image = image;
           
            butt=bt.Text;
            commentLabel(butt);
        }

        public void commentLabel(string c)
        {
            commentPanel.Controls.Clear();
            int left = 4;
            int top = 15;
            ArrayList listC = new ArrayList();
            listC = r.showComment(c);
            int length = Convert.ToInt32(listC.Count.ToString());
            ArrayList listU = new ArrayList();
            listU = r.showName(c);
            for (int i = 0; i < length; i++)
            {
                Label l = new Label();
                l.Left = left;
                l.Top = top;
                l.Size = new Size(250, 13);
                l.ForeColor = Color.FromArgb(255, 255, 192);
                commentPanel.Controls.Add(l);
                l.Text=listU[i]+": "+listC[i];
                top = top + 20;
            }

        }
        private void button5_Click(object sender, EventArgs e)
        {
            performOperation(buttonAs.Text); 
        }
        

        private void button6_Click(object sender, EventArgs e)
        {
            performOperation(buttonSam.Text);
        }
       


        private void button2_Click_1(object sender, EventArgs e)
        {
            button3.Visible = true;
            button4.Visible = true;
            buttonAs.Visible = false;
            buttonSam.Visible = false;
            buttonHtc.Visible = false;
            buttonDell.Visible = false;
            buttonApple.Visible = false;
            button1Plus.Visible = false;
            buttonWalton.Visible = false;
            buttonMac.Visible = false;
            buttonHp.Visible = false;
            buttonSony.Visible = false;
            buttonOthr.Visible = false;

            panel1.Visible = false;
            panel2.Visible = false;
            panel4.Visible = false;
            label15.Visible = false;
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            performOperation(buttonHtc.Text);
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            performOperation(buttonDell.Text);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
          

         
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            label15.Text = button3.Text;
            label15.Visible = true;
            button3.Visible = false;
            button4.Visible = false;
            buttonAs.Visible = true;
            buttonSam.Visible = true;
            buttonHtc.Visible = true;
            buttonDell.Visible = false;
            buttonApple.Visible = true;
            button1Plus.Visible = true;
            buttonWalton.Visible = true;
            buttonOthr.Visible = true;
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            label15.Text = button4.Text;
            label15.Visible = true;
            button3.Visible = false;
            button4.Visible = false;
            buttonAs.Visible = true;
            buttonSam.Visible = true;
            buttonHtc.Visible = false;
            button1Plus.Visible = false;
            buttonWalton.Visible = false;
            buttonDell.Visible = true;
            buttonMac.Visible = true;
            buttonHp.Visible = true;
            buttonSony.Visible = true;
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = true;
            panel4.Visible = false;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = true;
            panel4.Visible = false;
           
        }

        private void button11_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = true;
            panel4.Visible = false;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = true;
            panel4.Visible = false;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = true;
            panel4.Visible = false;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = true;
            panel4.Visible = false;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = true;
            panel4.Visible = false;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = true;
            panel4.Visible = false;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = true;
            panel4.Visible = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ButtonPro2_Click(object sender, EventArgs e)
        {
            

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            
        }
        
        
        
        private void ButtonPro2_Click_1(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = true;
            panel4.Visible = false;
        }

        private void button5_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            //commentLabel(butt);
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
	

        private void button1Plus_Click(object sender, EventArgs e)
        {
            performOperation(button1Plus.Text);
        }

        private void buttonOthers_Click(object sender, EventArgs e)
        {
            performOperation(buttonWalton.Text);
        }

        private void panel3_Paint_1(object sender, PaintEventArgs e)
        {

        }



        private void buttonSony_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonApple_Click_1(object sender, EventArgs e)
        {
            performOperation(buttonApple.Text);
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void labelMod_Click(object sender, EventArgs e)
        {

        }

        public void Comment_Click(object sender, EventArgs e)
        {
            if (MainForm.AdminLogin == true || MainForm.UserLogin == true)
            {
                if (MainForm.AdminLogin == true)
                {
                    Review r = new Review(butt, "Admin", textBox1.Text);
                    r.addComment();
                    textBox1.Text = "";
                    commentLabel(butt);
                }
                else
                {
                    Review r = new Review(butt, Login.username, textBox1.Text);
                    r.addComment();
                    commentLabel(butt);
                    textBox1.Text = "";
                }
            }
            else { MessageBox.Show("You have to login first"); }
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            Comment_Click(sender,e);

        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void buttonOthr_Click(object sender, EventArgs e)
        {
            performOperation(buttonOthr.Text);
        }

        private void buttonWalton_Click(object sender, EventArgs e)
        {
            performOperation(buttonWalton.Text);
        }

        

        

        
    }
}
