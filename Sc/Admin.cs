using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace GUI
{
    public partial class Admin : Form
    {
        Review r;
        MainForm mf;
        Product pr;
        
        int delId;
        int sid;
        public Admin()
        {
            InitializeComponent();
            pr = new Product();
            r = new Review();
        }

        public Admin(MainForm mf) : this() {
            this.mf = mf;
            pr = new Product();
            r = new Review();

        }
   
      

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

      


        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
           ofd.Filter = "jpeg|*.jpg|bmp|*.bmp|all files|*.*";
            DialogResult res = ofd.ShowDialog();
            if (res == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(ofd.FileName);
                FName.Text = Path.GetFileName(ofd.FileName);
                
            }
        }


        private void refresh()
        {
            
            GridDB.DataSource = pr.getPhone();
            dataGridView1.DataSource = r.getComment();
            

        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

    

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void GridDB_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

 
      

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void GridDB_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
         

        }

        private void GridDB_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            string id = GridDB.Rows[e.RowIndex].Cells["ProductId"].Value.ToString();
            if (id == "")
                MessageBox.Show("Go upload to insert new product");
            else
                pr.update(GridDB.Rows[e.RowIndex].Cells["Os"].Value.ToString(), GridDB.Rows[e.RowIndex].Cells["SSize"].Value.ToString(), GridDB.Rows[e.RowIndex].Cells["Camera"].Value.ToString(), GridDB.Rows[e.RowIndex].Cells["Battery"].Value.ToString(), GridDB.Rows[e.RowIndex].Cells["Body"].Value.ToString(), GridDB.Rows[e.RowIndex].Cells["Memory"].Value.ToString(), GridDB.Rows[e.RowIndex].Cells["Features"].Value.ToString(), GridDB.Rows[e.RowIndex].Cells["Cpu"].Value.ToString(), GridDB.Rows[e.RowIndex].Cells["RDate"].Value.ToString(), GridDB.Rows[e.RowIndex].Cells["Price"].Value.ToString(), (int)GridDB.Rows[e.RowIndex].Cells["ProductID"].Value);

            refresh();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void deleteProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pr.deleteProduct(delId);
            MessageBox.Show("Successfully Removed");
            refresh();
        }

        private void GridDB_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right) {
                delId = Convert.ToInt32(GridDB.Rows[e.RowIndex].Cells["ProductId"].Value.ToString());
                this.contextMenuStrip1.Show(this.GridDB,e.Location);
                contextMenuStrip1.Show(Cursor.Position);
            }
        }

        private void button3_Click_2(object sender, EventArgs e)
        {
            refresh();
            panel2.Show();
            DbPanel.Hide();
            
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            panel2.Hide();
            refresh();
            DbPanel.Show();
        }

        private void Aasd_Click_1(object sender, EventArgs e)
        {
            if (FName.Text == "" || brandCombo.SelectedItem.ToString() == "" || TModelNo.Text == "" || TOs.Text == "" || TSize.Text == "" || TCam.Text == "" || TBat.Text == "" || TBody.Text == "" || TMemory.Text == "" || TFeat.Text == "" || TCpu.Text == "" || TRDate.Text == "" || TLPrice.Text == "")
            {

                labelError.Text = "Sir,You Need to Fill all the Field";
            }
            
            else
            {
                int i = pr.ModelValidation(TModelNo.Text.Trim());
                if (i == 0)
                    MessageBox.Show("Model Already EXist");
                else
                {
                    pr = new Product(brandCombo.SelectedItem.ToString(), TModelNo.Text, TOs.Text, TSize.Text, TCam.Text, TBat.Text, TBody.Text, TMemory.Text, TFeat.Text, TCpu.Text, TRDate.Text, TLPrice.Text, FName.Text);
                    pr.ProductAdd();
                    labelError.Text = "";
                    TModelNo.Text = "";
                    TOs.Text = "";
                    TSize.Text = "";
                    TCam.Text = "";
                    TBat.Text = "";
                    TBody.Text = "";
                    TMemory.Text = "";
                    TFeat.Text = "";
                    TCpu.Text = "";
                    TRDate.Text = "";
                    TLPrice.Text = "";
                    FName.Text = "";
                    // pictureBox1.Controls.Clear();
                    pictureBox1.Image = null;
                }
            }
        }

        private void Back_Click_1(object sender, EventArgs e)
        {
            panel2.Visible = false;
        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            DbPanel.Visible = false;
        }

        private void dataGridView1_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                sid = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["CmtId"].Value.ToString());
                this.contextMenuStrip2.Show(this.dataGridView1, e.Location);
                contextMenuStrip2.Show(Cursor.Position);
            }
        }

        private void deleteCommentToolStripMenuItem_Click(object sender, EventArgs e)
        {

            r.deleteComment(sid);
            MessageBox.Show("Successfully Removed");
            refresh();
        }

        private void DbPanel_Paint(object sender, PaintEventArgs e)
        {

        }






    }
}
