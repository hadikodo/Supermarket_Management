using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace STSM.Forms
{
    public partial class Stock_Product_ADD : Form
    {

        Classes.DataAccessLayer dal = new
        Classes.DataAccessLayer();
        SqlDataReader sqlReader;
        SqlCommand com;
        Classes.Categories CAT = new Classes.Categories();
        Classes.Products PRO = new Classes.Products();
        //private   String PID =Stock_Product_Editor.ID;
        private String BARCODE;
        private String NAME = "";
        private String PRICE = "";
        private String Cat = "";


        public Stock_Product_ADD()
        {
            InitializeComponent();

            foreach (String s in CAT.getcat_name())
            {
                catbox.Items.Add(s);
            }


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


            int barcode;
            int price;
            Boolean exist = false;
            Name = nametxt.Text;
            PRICE = pricetxt.Text;
            Cat = catbox.Text;
            BARCODE = barcodetxt.Text;

            Console.WriteLine("name :" + "pr" + PRICE + "cat" + Cat + "barceode" + BARCODE);
            if (String.IsNullOrEmpty(nametxt.Text) || String.IsNullOrWhiteSpace(nametxt.Text) || String.IsNullOrEmpty(pricetxt.Text) || String.IsNullOrWhiteSpace(pricetxt.Text) || String.IsNullOrEmpty(barcodetxt.Text) || String.IsNullOrWhiteSpace(barcodetxt.Text) || String.IsNullOrEmpty(Cat) || String.IsNullOrWhiteSpace(Cat))
            {

                MessageBox.Show("All Entry must be fill");
                this.clear();
            }
            else if (int.TryParse(BARCODE, out barcode) && int.TryParse(PRICE, out price) && nametxt.Text.Length != 0)
            {
                if (dal.getConnection().State == ConnectionState.Open)
                {
                    dal.cnClose();
                }
                exist = (PRO.ProductExist(BARCODE) > 0) ? true : false;
                if (exist)
                {
                    MessageBox.Show("The product Already exist", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    this.clear();
                }
                else
                {


                    if (dal.getConnection().State == ConnectionState.Open)
                    {

                    }
                    else
                    {
                        dal.cnOpen();
                    }

                    com = new SqlCommand("add_products", dal.getConnection());
                    com.CommandType = CommandType.StoredProcedure;
                    com.Parameters.AddWithValue("@barcode", barcode);
                    com.Parameters.AddWithValue("@name", Name);
                    com.Parameters.AddWithValue("@sell_price", price);
                    com.Parameters.AddWithValue("@categories", Cat);
                    try
                    {
                        com.ExecuteNonQuery();

                        DialogResult dialogResult = MessageBox.Show("successfully Inserted", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (dialogResult == DialogResult.OK)
                        {

                            this.Close();
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message + "There is problem", "error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    finally
                    {



                        if (dal.getConnection().State == ConnectionState.Open)
                        {
                            dal.cnClose();
                        }
                    }




                }



            }

            else
            {
                MessageBox.Show("ENTER VALID NUMBER");
                this.clear();
            }
        }
        public void clear()
        {



            nametxt.Text = "";
            pricetxt.Text = "";
            barcodetxt.Text = "";
        }

        private void catbox_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void catbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
