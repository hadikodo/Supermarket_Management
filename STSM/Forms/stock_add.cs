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

    public partial class stock_add : Form
    {


        Classes.ExpiredDate ex = new Classes.ExpiredDate();
        Classes.Products Pr = new Classes.Products();
        Classes.DataAccessLayer copen = new Classes.DataAccessLayer();
        private static SqlCommand com;
        private static SqlDataReader dr;
        public stock_add()
        {
            InitializeComponent();
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
        private void button1_Click(object sender, EventArgs e)
        {

            DateTime today = DateTime.Today;

            int result = DateTime.Compare(today, dateTimePicker1.Value);

            

            int barcode;
            int qty;
            if (int.TryParse(textBox1.Text, out barcode)&&int.TryParse(textBox2.Text,out qty)&& dateTimePicker1.Text.Length != 0)
            {
                if (Pr.ProductExist(textBox1.Text)>0)
                {
                    //ex.add_ExpiredDate(dateTimePicker1.Text, qty, barcode);
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
                            MessageBox.Show("تم الحفظ بنجاح");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message + "there is problem", "error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        }


                        // TODO:    change from excuteReader to excute nonquery since data are retreived

                        copen.cnClose();

                    }
                    else
                    {


                        MessageBox.Show("the Expired date value is invalied", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        clear();


                    }
                   

                }
                else
                {


                    MessageBox.Show("the product  don't exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    // TODO:  add dailog to add new product form if the product dont exist 
                    clear();
                }


              
            }
            else if (String.IsNullOrEmpty(textBox1.Text) || String.IsNullOrWhiteSpace(textBox1.Text)|| String.IsNullOrEmpty(textBox2.Text) || String.IsNullOrWhiteSpace(textBox2.Text))
            {

                MessageBox.Show("All Entry must be fill");
                clear();
            }
            else { MessageBox.Show("Barcode is required");
                clear();
            }


        }



        public void clear()
        {


            textBox1.Text = "";
            textBox2.Text = "";
            dateTimePicker1.Text = "";
        }
    }
    }

