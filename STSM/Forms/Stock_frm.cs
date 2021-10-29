using System;
using System.Windows.Forms;

namespace STSM.Forms
{
    public partial class Stock_frm : Form
    {

        Classes.Stocks st = new Classes.Stocks();
        public static String ID = "";
        //to store ID 
        public static  String Product_Name = "";
        public static String Barcode_Product = "";
        //to store ID 
        int barcode;
        //to store barcode int
        public Stock_frm()
        {
            InitializeComponent();
            radioButton1.Checked = true;
            radioButton2.Checked = false;
            viewbtn.Enabled = false;
            addbtn.Enabled = false;
            toolbtn.Enabled = false;
            //deletebtn.Enabled = false;

            this.fill();
            this.Adjust_header();
        }
        public void Adjust_header()
        {
            dataGridView1.Columns [0].HeaderText = "Stock ID";
            dataGridView1.Columns [1].HeaderText = "Product Name";
            dataGridView1.Columns [2].HeaderText = "Barcode";
            dataGridView1.Columns [3].HeaderText = "Categories";
            dataGridView1.Columns [4].HeaderText = "Total Quantity";
            //dataGridView1.Columns[5].HeaderText = "Status";


        }

        public void fill()
        {

            dataGridView1.DataSource = null;
            // st.Fill_STOCK_GRID("select  Stocks.S_ID,Products.ProductName,Products.Barcode,Categories.Cat_Name,Stocks.Total_QTE,Products.Active FROM Stocks,Products,Categories where Stocks.P_ID=Products.P_ID AND Products.Cat_ID=Categories.Cat_ID", dataGridView1);
            st.Fill_STOCK_GRID("select p.P_ID,ProductName,Barcode,Cat_Name,SUM(QTE)  Total_Quantity from Products p   \n" +
                 "inner join ExpiredDate e on p.P_ID=e.P_ID \n"+
                 "inner join Categories c on p.Cat_ID = C.Cat_ID \n"+
                 "   group by p.P_ID, ProductName,Cat_Name,Barcode   \n", dataGridView1);

            this.Adjust_header();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            if (radioButton1.Checked == true )
            {

                st.Fill_STOCK_GRID("select p.P_ID,ProductName,Barcode,Cat_Name,SUM(QTE)  Total_Quantity from Products p   \n" +
                                "inner join ExpiredDate e on p.P_ID=e.P_ID \n" +
                                "inner join Categories c on p.Cat_ID = C.Cat_ID \n" +
                                "AND p.ProductName like '" + textBox1.Text + "%' \n" +
                                "   group by p.P_ID, ProductName,Cat_Name,Barcode   \n", dataGridView1);
                Adjust_header();

            }else if(radioButton2.Checked == true)
            {
                

                int barcode;

                if (int.TryParse(textBox1.Text, out barcode))
                {
                    st.Fill_STOCK_GRID("select p.P_ID,ProductName,Barcode,Cat_Name,SUM(QTE)  Total_Quantity from Products p   \n" +
                                                  "inner join ExpiredDate e on p.P_ID=e.P_ID \n" +
                                                  "inner join Categories c on p.Cat_ID = C.Cat_ID \n" +
                                                  "AND p.Barcode=" + barcode + " \n" +
                                                  "   group by p.P_ID, ProductName,Cat_Name,Barcode   \n", dataGridView1); this.Adjust_header();
                }
                else if (String.IsNullOrEmpty(textBox1.Text) || String.IsNullOrWhiteSpace(textBox1.Text))
                {

                    //nothing
                }
                  else  { MessageBox.Show("number is required"); }
               

            }
         
        }

        private void refreshbtn_Click(object sender, EventArgs e)
        {
            // st.Fill_STOCK_GRID("select  Stocks.S_ID,Products.ProductName,Products.Barcode,Categories.Cat_Name,Stocks.Total_QTE,Products.Active FROM Stocks,Products,Categories where Stocks.P_ID=Products.P_ID AND Products.Cat_ID=Categories.Cat_ID", dataGridView1);
            st.Fill_STOCK_GRID("select p.P_ID,ProductName,Barcode,Cat_Name,SUM(QTE)  Total_Quantity from Products p   \n" +
                   "inner join ExpiredDate e on p.P_ID=e.P_ID \n" +
                   "inner join Categories c on p.Cat_ID = C.Cat_ID \n" +
                   "   group by p.P_ID, ProductName,Cat_Name,Barcode   \n", dataGridView1);
            this.Adjust_header();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            

            if (e.RowIndex >= 0)
            {
               // viewbtn.Enabled = true;
                //toolbtn.Enabled = true;
                //deletebtn.Enabled = true;
                //gets a collection that contains all the rows
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                //populate the textbox from specific value of the coordinates of column and row.
                ID = row.Cells[0].Value.ToString();
                Product_Name = row.Cells[1].Value.ToString();
                Barcode_Product = row.Cells[2].Value.ToString();


            }
            else
            {

                viewbtn.Enabled = false;
                toolbtn.Enabled = false;
               //deletebtn.Enabled = false;

            }
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            //DialogResult dialogResult = MessageBox.Show(" Are you Sure deleting nb "+ ID, " error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            //if (dialogResult == DialogResult.OK)
            //{


            //    //st.delete_Stocks_by_Id(ID.ToString());
            //    //MessageBox.Show("تم المسح");
            //    //fill();
            //}
            }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            stock_add m = new stock_add();

            if (m.IsDisposed)
            {


            }  //TODO: (Done)catch the disposible error
            else
            {
                m.ShowDialog();

            }

        }

        private void viewbtn_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(Product_Name) || String.IsNullOrWhiteSpace(Product_Name))
            {

               
            }
            else
            {
              DialogResult dialogResult = MessageBox.Show(" Are you want to show more  for the Product Name : " + Product_Name, "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
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

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void toolbtn_Click(object sender, EventArgs e)
        {
            Stock_Product_Editor P2 = new Stock_Product_Editor();
            st.CloseConnection();
            if (P2.IsDisposed)
            {


            }  //TODO: (Done)catch the disposible error
            else
            {
                P2.ShowDialog();

            }
        }

        private void Stock_frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            dataGridView1.DataSource = null;
        }

        private void Stock_frm_Load(object sender, EventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }
    }
}
