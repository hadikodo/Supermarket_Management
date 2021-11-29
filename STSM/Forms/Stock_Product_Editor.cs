using STSM.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace STSM.Forms
{
    public partial class Stock_Product_Editor : Form
    {
        Classes.Stocks st = new Classes.Stocks();
        Classes.Products pr = new Classes.Products();
        Classes.ExpiredDate ed = new Classes.ExpiredDate();
        public static  string ID = "";
        public static string Product_name = "";
        public static  string Barcode = "";
        public static string Category = "";
        private DataTable dt;
        private Boolean isActive = false;

        public Stock_Product_Editor()
        {
            InitializeComponent();
            updatebtn.Enabled = false;
            showmorebtn.Enabled = false;
            enablebtn.Enabled = false;
            disablebtn.Enabled = false;
            fill();
            
        }
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams handleparam = base.CreateParams;
                handleparam.ExStyle |= 0x02000000;
                return handleparam;
            }
        }
        public void Adjust_header()
        {
            dataGridView1.Columns[0].HeaderText = "Product ID";            
            dataGridView1.Columns[2].HeaderText = "Barcode";
            dataGridView1.Columns[1].HeaderText = "Product Name";
            dataGridView1.Columns[3].HeaderText = "Price";
            dataGridView1.Columns[4].HeaderText = "Category";
            dataGridView1.Columns[5].HeaderText = "Status";
            dataGridView1.Columns[6].HeaderText = "Total Quantity";
        }
        public void fill()
        {
            st.Fill_STOCK_GRID("select a.P_ID,a.ProductName,a.Barcode,a.Sell_Price,b.Cat_Name,a.Active,c.tot from Products a inner join Categories b on a.Cat_ID=b.Cat_ID Left Join (select P_ID,sum(QTE) as tot from ExpiredDate group by P_ID) c on c.P_ID=a.P_ID", dataGridView1);
            this.Adjust_header();
            int totpro = ed.GET_nb("SELECT COUNT(*) FROM Products");
            totalpro.Text = totpro.ToString();
            int totcat = ed.GET_nb("SELECT COUNT(*) FROM Categories");
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //gets a collection that contains all the rows
            if (e.RowIndex >= 0)
            {  
                updatebtn.Enabled = true;
                showmorebtn.Enabled = true;
                enablebtn.Enabled = true;
                disablebtn.Enabled = true;
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                //populate the textbox from specific value of the coordinates of column and row.
                ID = row.Cells[0].Value.ToString();
                Product_name = row.Cells[1].Value.ToString();
                Barcode = row.Cells[2].Value.ToString();
                Category = row.Cells[3].Value.ToString();
                label3.Text = "Choosen Product: " + Product_name;
                isActive = (row.Cells[5].Value.ToString() == "1") ? true : false;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        ///     on click check if the products status is active : not 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void viewbtn_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(Product_name) || String.IsNullOrWhiteSpace(Product_name))
            {
                MessageBox.Show("choose product", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            }
            else
            {
                if (!isActive)
                {
                    MessageBox.Show("The product is Already disabled", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show(" Are you Sure you want to disbale product : " + Product_name, "Noitfy", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                    if (dialogResult == DialogResult.OK)
                    {
                        pr.block_Product(int.Parse(ID));
                        this.fill();
                    }
                }       
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


            if (String.IsNullOrEmpty(Product_name) || String.IsNullOrWhiteSpace(Product_name))
            {
                MessageBox.Show("choose product", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);


            }
            else
            {
                if (isActive)
                {
                    MessageBox.Show("The product is Already Enabled", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show(" Are you Sure you want to Enable product : " + Product_name, "Notify", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                    if (dialogResult == DialogResult.OK)
                    {
                        int rowindex = dataGridView1.CurrentCell.RowIndex;
                        int columnindex = dataGridView1.CurrentCell.ColumnIndex;
                        if (pr.unblock_Products(int.Parse(ID)))
                        {
                            this.fill();
                        }
                    }
                }
            }
        }

        private void refreshbtn_Click(object sender, EventArgs e)
        {
            fill();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            st.Fill_STOCK_GRID("select a.P_ID,a.ProductName,a.Barcode,a.Sell_Price,b.Cat_Name,a.Active,c.tot from Products a inner join Categories b on a.Cat_ID=b.Cat_ID Left Join (select P_ID,sum(QTE) as tot from ExpiredDate group by P_ID) c on c.P_ID=a.P_ID where a.Cat_ID=b.Cat_ID AND a.ProductName like '" + textBox1.Text + "%' ", dataGridView1);
            this.Adjust_header();
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            Stock_Product_ADD m = new Stock_Product_ADD();

            if (m.IsDisposed)
            {


            }  
            else
            {
                m.ShowDialog();
                this.fill();
            }
        }

        private void toolbtn_Click(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(ID) || String.IsNullOrWhiteSpace(ID))
            {
                MessageBox.Show("choose product", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                Stock_Product_Update m = new Stock_Product_Update();

                if (m.IsDisposed)
                {
                }
                else
                {
                    m.ShowDialog();
                    this.fill();
                }

            }
            }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            int columnIndex = 5;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                int getStatus =  int.Parse(row.Cells[columnIndex].Value.ToString());

       
                if (getStatus==1)
                {

                    row.DefaultCellStyle.BackColor = Color.White;
                    //row.Cells[columnIndex].Value = 0;
                    //row.Cells[columnIndex].ValueType = typeof(String);
                    //row.Cells[columnIndex].Value = "Active";

                }
                else
                {



                    row.DefaultCellStyle.BackColor = Color.Gray;
                    //row.Cells[columnIndex].Value = 0;
                    //row.Cells[columnIndex].ValueType = typeof(String);
                    //row.Cells[columnIndex].Value = "InActive";
                }


            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(Product_name) || String.IsNullOrWhiteSpace(Product_name))
            {


            }
            else
            {
                DialogResult dialogResult = MessageBox.Show(" Are you want to show more  for the Product Name : " + Product_name, "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.OK)
                {
                    

        Stock_show_more m2 = new Stock_show_more();
                    st.CloseConnection();
                    if (m2.IsDisposed)
                    {


                    }  //TODO: (Done)catch the disposible error
                    else
                    {
                        m2.ShowDialog();

                    }

                }


            }
        }

        private void viewbtn_Click_1(object sender, EventArgs e)
        {
           

                    Stock_frm m2 = new Stock_frm();
                    st.CloseConnection();
                    if (m2.IsDisposed)
                    {


                    }  //TODO: (Done)catch the disposible error
                    else
                    {
                        m2.ShowDialog();

                    }


            }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Stock_Product_Editor_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
