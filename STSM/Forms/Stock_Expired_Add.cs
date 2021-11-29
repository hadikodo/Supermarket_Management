using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace STSM.Forms
{
    public partial class Stock_Expired_Add : Form
    {

     
        private static String Brcode_Add = Stock_Product_Editor.Barcode;


        Classes.ExpiredDate ex = new Classes.ExpiredDate();
        Classes.Products Pr = new Classes.Products();
        Classes.DataAccessLayer copen = new Classes.DataAccessLayer();
        private static SqlCommand com;
        private string P_I_D { get; set; }
        private static SqlDataReader dr;
        public Stock_Expired_Add()
        {
            InitializeComponent();
            this.Text += Stock_Product_Editor.Product_name; 
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
        public Stock_Expired_Add(string p_I_D)
        {
            InitializeComponent();
            this.Text += Stock_Product_Editor.Product_name;
            P_I_D = p_I_D;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime today = DateTime.Today;
            int result = DateTime.Compare(today, dateTimePicker1.Value);
            int barcode;
            int qty;
            if (int.TryParse(Brcode_Add, out barcode) && int.TryParse(textBox3.Text, out qty) && dateTimePicker1.Text.Length != 0)
            {
                if (result < 0)
                {
                    //TODO : move to expired class
                    copen.cnOpen();
                    com = new SqlCommand("add_expireddate", copen.getConnection());
                    com.CommandType = CommandType.StoredProcedure;
                    com.Parameters.AddWithValue("@exp_date", dateTimePicker1.Value);
                    com.Parameters.AddWithValue("@qte", qty);
                    com.Parameters.AddWithValue("@p_barcode", barcode);
                    try
                    {
                        com.ExecuteNonQuery();

                        DialogResult dialogResult = MessageBox.Show("Successfully Inserted", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (dialogResult == DialogResult.OK)
                        {

                            if (copen.getConnection().State == ConnectionState.Open)
                            {
                                copen.cnClose();
                            }
                            this.Close();
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message + "There is problem", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    finally
                    {
                            copen.cnClose();
                    }


   

                    

                }
                else
                {


                    MessageBox.Show("the Expired date value is invalied", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                 

                }






            }
            else if (String.IsNullOrEmpty(textBox3.Text) || String.IsNullOrWhiteSpace(textBox3.Text))
            {
               
                MessageBox.Show("All Entry must be fill");
                this.clear();
            }
            else
            {
                MessageBox.Show("Barcode is required");
                this.clear();
            }


        }
        public void clear()
        {



            textBox3.Text = "";
            dateTimePicker1.Text = "";
        }
    }
}
