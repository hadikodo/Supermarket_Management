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
    public partial class Stock_show_more : Form
    {
        int exid = 0;
        Classes.ExpiredDate ed = new Classes.ExpiredDate();
        Classes.Stocks st = new Classes.Stocks();
        private  DataTable dt;
        DateTime today = DateTime.Today;
        public  String EID;
        public static String PID  { get; set;}
        public  String PNAME = Stock_Product_Editor.Product_name;
        public   String Brcode = Stock_Product_Editor.Barcode;


public Stock_show_more(String ID)
        {
            PID = ID;
            InitializeComponent();
            this.fill();
            toolbtn.Enabled = false;
            deletebtn.Enabled = false;
           
        }
        public Stock_show_more()
         {   
            InitializeComponent();
           this.fill();
            
           
            toolbtn.Enabled = false;
            deletebtn.Enabled = false;
           

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
        /// <summary>
        /// THIS function to fill the dtgview and the labels afte rany action and changes
        /// </summary>
        public void fill()
        {
            dt = new DataTable();
            dataGridView1.DataSource = null;
           dt= ed.Fill_Expired_GRID("Select ExpiredDate.Exp_ID,ExpiredDate.Exp_Date,ExpiredDate.QTE from ExpiredDate where ExpiredDate.P_ID=" + Stock_Product_Editor.ID, dataGridView1);


            if (dt.Rows.Count > 0)
            {
                this.Adjust_header();
                int expiredProduct = ed.GET_nb("Select SUM(ExpiredDate.QTE) from ExpiredDate where ExpiredDate.P_ID=" + Stock_Product_Editor.ID + " AND DATEDIFF(day, CAST(GETDATE() AS DATE),  ExpiredDate.Exp_Date)<=0");
#pragma warning disable CA1305 // Specify IFormatProvider
                expiredlabel.Text = expiredProduct.ToString();
#pragma warning restore CA1305 // Specify IFormatProvider
                int totalProduct = ed.GET_nb("Select SUM(ExpiredDate.QTE) from ExpiredDate where ExpiredDate.P_ID=" + Stock_Product_Editor.ID);
#pragma warning disable CA1305 // Specify IFormatProvider
                totalExpired.Text = totalProduct.ToString();
#pragma warning restore CA1305 // Specify IFormatProvider
                int unexpired = ed.GET_nb("Select SUM(ExpiredDate.QTE) from ExpiredDate where ExpiredDate.P_ID=" + Stock_Product_Editor.ID + " AND DATEDIFF(day, CAST(GETDATE() AS DATE),  ExpiredDate.Exp_Date)>0");
#pragma warning disable CA1305 // Specify IFormatProvider
                UNEXPIRED.Text = unexpired.ToString();
#pragma warning restore CA1305 // Specify IFormatProvider
                String PRODUCTNAME = "Product Name:" + Stock_Product_Editor.Product_name;
                Prdctlabel.Text = PRODUCTNAME;
            }
            else
            {

              
             

                DialogResult dialogResult = MessageBox.Show("Do you want to add your first Quantity", "Note", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                if (dialogResult == DialogResult.OK)
                {

                    
                    Stock_Expired_Add m = new Stock_Expired_Add(Stock_Product_Editor.ID);
                    
                    m.ShowDialog();
                    this.Close();
                }
               else {
                    this.Close();


                }
            }
        }
        /// <summary>
        /// to adjust the drgview header
        /// </summary>
        public void Adjust_header()
        {           
            dataGridView1.Columns[0].HeaderText = "Date ID";
            dataGridView1.Columns[1].HeaderText = "Expired Date";
            dataGridView1.Columns[2].HeaderText = "Quantity";
            dataGridView1.Sort(dataGridView1.Columns[1], ListSortDirection.Ascending);
        }

        private void Stock_show_more_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
        /// <summary>
        /// to iterate over the row if the date is expired red background is applied else no change 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            int columnIndex = 1;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                DateTime getdate = Convert.ToDateTime(row.Cells[columnIndex].Value.ToString());

                int result = DateTime.Compare(today, getdate.Date);
                if (result < 0)
                {
                  
                    row.DefaultCellStyle.BackColor = Color.White;
                         Console.WriteLine(" if < 0 the result is " + row.DefaultCellStyle.BackColor);

                }
                else
                {


                   
                    row.DefaultCellStyle.BackColor = Color.Red;

                    Console.WriteLine(" else > 0 the result is " + row.DefaultCellStyle.BackColor);
                }


            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            

                st.Fill_STOCK_GRID("Select ExpiredDate.Exp_ID,ExpiredDate.Exp_Date,ExpiredDate.QTE from ExpiredDate where ExpiredDate.P_ID=" + Stock_Product_Editor.ID+ " AND ExpiredDate.Exp_Date <= convert(date,'"+ dateTimePicker1.Value+"')", dataGridView1);
                this.Adjust_header();

        
            
        }

        private void refreshbtn_Click(object sender, EventArgs e)
        {
            st.Fill_STOCK_GRID("Select ExpiredDate.Exp_ID,ExpiredDate.Exp_Date,ExpiredDate.QTE from ExpiredDate where ExpiredDate.P_ID=" + Stock_Product_Editor.ID, dataGridView1);
            this.Adjust_header();
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show(" Are you Sure deleting nb " + EID, " error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            if (dialogResult == DialogResult.OK)
            {
                ed.Delete_with_Spceific_ID(EID);
                fill();           
            }
        }
        /// <summary>
        /// onclick on row the id will be stored
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                deletebtn.Enabled = true;
                toolbtn.Enabled = true;
                //deletebtn.Enabled = true;
                //gets a collection that contains all the rows
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                //populate the textbox from specific value of the coordinates of column and row.
                EID = row.Cells[0].Value.ToString();
                exid = int.Parse(row.Cells[0].Value.ToString());
            }
            else
            {
                toolbtn.Enabled = false;
                deletebtn.Enabled = false;
            }
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            Stock_Expired_Add m = new Stock_Expired_Add();
            m.ShowDialog();
            this.refreshbtn_Click(refreshbtn, e);
        }

        private void toolbtn_Click(object sender, EventArgs e)
        {
            Stock_Expired_Update m = new Stock_Expired_Update(exid);
            m.ShowDialog();
            refreshbtn_Click(refreshbtn, e);
        }

        private void Stock_show_more_FormClosed(object sender, FormClosedEventArgs e)
        {
            dataGridView1.DataSource = null;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
