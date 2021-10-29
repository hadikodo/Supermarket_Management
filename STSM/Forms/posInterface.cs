using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using STSM.Classes;
using System.Data.SqlClient;

namespace STSM.Forms
{
    public partial class posInterface : Form
    {
        private readonly MainMenu ml;
        public static string chosenItem = "";
        public static string chosenPrice = "";
        public static string chosenProductId = "";
        public static string chosenProductBarcode = "";
        public posInterface(MainMenu m)
        {
            InitializeComponent();
            ml = m;
        }

        private void PosInterface_Load(object sender, EventArgs e)
        {

        }

        private void BreadPos_btn_Click(object sender, EventArgs e)
        {
            DataAccessLayer dal = new DataAccessLayer();
            dal.cnOpen();
            SqlCommand cmd1 = new SqlCommand("SELECT * FROM Products WHERE ProductName='Bread'", dal.getConnection());
            SqlDataReader rdr1 = cmd1.ExecuteReader();
            while(rdr1.Read())
            {

                chosenItem = rdr1["ProductName"].ToString();
                chosenPrice = rdr1["Sell_Price"].ToString();
                chosenProductBarcode = rdr1["Barcode"].ToString();
                chosenProductId = rdr1["P_ID"].ToString();
            }

            dal.cnClose();
            
            this.Hide();

            posInterface_AddItem ad = new posInterface_AddItem(ml);
            ad.Show();
            

        }

        private void WaterPos_btn_Click(object sender, EventArgs e)
        {
            DataAccessLayer dal = new DataAccessLayer();
            dal.cnOpen();
            SqlCommand cmd1 = new SqlCommand("SELECT * FROM Products WHERE ProductName='Water'", dal.getConnection());
            SqlDataReader rdr1 = cmd1.ExecuteReader();
            while (rdr1.Read())
            {

                chosenItem = rdr1["ProductName"].ToString();
                chosenPrice = rdr1["Sell_Price"].ToString();
                chosenProductBarcode = rdr1["Barcode"].ToString();
                chosenProductId = rdr1["P_ID"].ToString();
            }

            dal.cnClose();
            this.Hide();

            posInterface_AddItem ad = new posInterface_AddItem(ml);
            ad.Show();

        }

        private void SoftDrinkPos_btn_Click(object sender, EventArgs e)
        {
            DataAccessLayer dal = new DataAccessLayer();
            dal.cnOpen();
            SqlCommand cmd1 = new SqlCommand("SELECT * FROM Products WHERE ProductName='Softdrink'", dal.getConnection());
            SqlDataReader rdr1 = cmd1.ExecuteReader();
            while (rdr1.Read())
            {

                chosenItem = rdr1["ProductName"].ToString();
                chosenPrice = rdr1["Sell_Price"].ToString();
                chosenProductBarcode = rdr1["Barcode"].ToString();
                chosenProductId = rdr1["P_ID"].ToString();
            }

            dal.cnClose();
            this.Hide();

            posInterface_AddItem ad = new posInterface_AddItem(ml);
            ad.Show();



        }

        private void CoffePos_btn_Click(object sender, EventArgs e)
        {
            DataAccessLayer dal = new DataAccessLayer();
            dal.cnOpen();
            SqlCommand cmd1 = new SqlCommand("SELECT * FROM Products WHERE ProductName='coffee'", dal.getConnection());
            SqlDataReader rdr1 = cmd1.ExecuteReader();
            while (rdr1.Read())
            {

                chosenItem = rdr1["ProductName"].ToString();
                chosenPrice = rdr1["Sell_Price"].ToString();
                chosenProductBarcode = rdr1["Barcode"].ToString();
                chosenProductId = rdr1["P_ID"].ToString();
            }

            dal.cnClose();
            this.Hide();

            posInterface_AddItem ad = new posInterface_AddItem(ml);
            ad.Show();


        }

        private void VegetablesPos_btn_Click(object sender, EventArgs e)
        {
            DataAccessLayer dal = new DataAccessLayer();
            dal.cnOpen();
            SqlCommand cmd1 = new SqlCommand("SELECT * FROM Products WHERE ProductName='vegetables'", dal.getConnection());
            SqlDataReader rdr1 = cmd1.ExecuteReader();
            while (rdr1.Read())
            {

                chosenItem = rdr1["ProductName"].ToString();
                chosenPrice = rdr1["Sell_Price"].ToString();
                chosenProductBarcode = rdr1["Barcode"].ToString();
                chosenProductId = rdr1["P_ID"].ToString();
            }

            dal.cnClose();
            this.Hide();

            posInterface_AddItem ad = new posInterface_AddItem(ml);
            ad.Show();

        }

        private void IceCreamPos_btn_Click(object sender, EventArgs e)
        {
            DataAccessLayer dal = new DataAccessLayer();
            dal.cnOpen();
            SqlCommand cmd1 = new SqlCommand("SELECT * FROM Products WHERE ProductName='icecream'", dal.getConnection());
            SqlDataReader rdr1 = cmd1.ExecuteReader();
            while (rdr1.Read())
            {

                chosenItem = rdr1["ProductName"].ToString();
                chosenPrice = rdr1["Sell_Price"].ToString();
                chosenProductBarcode = rdr1["Barcode"].ToString();
                chosenProductId = rdr1["P_ID"].ToString();
            }

            dal.cnClose();
            this.Hide();

            posInterface_AddItem ad = new posInterface_AddItem(ml);
            ad.Show();



        }

        private void GumPos_btn_Click(object sender, EventArgs e)
        {
            DataAccessLayer dal = new DataAccessLayer();
            dal.cnOpen();
            SqlCommand cmd1 = new SqlCommand("SELECT * FROM Products WHERE ProductName='gum'", dal.getConnection());
            SqlDataReader rdr1 = cmd1.ExecuteReader();
            while (rdr1.Read())
            {

                chosenItem = rdr1["ProductName"].ToString();
                chosenPrice = rdr1["Sell_Price"].ToString();
                chosenProductBarcode = rdr1["Barcode"].ToString();
                chosenProductId = rdr1["P_ID"].ToString();
            }

            dal.cnClose();
            this.Hide();

            posInterface_AddItem ad = new posInterface_AddItem(ml);
            ad.Show();
        }

        private void ChocolatePos_btn_Click(object sender, EventArgs e)
        {
            DataAccessLayer dal = new DataAccessLayer();
            dal.cnOpen();
            SqlCommand cmd1 = new SqlCommand("SELECT * FROM Products WHERE ProductName='chocolate'", dal.getConnection());
            SqlDataReader rdr1 = cmd1.ExecuteReader();
            while (rdr1.Read())
            {

                chosenItem = rdr1["ProductName"].ToString();
                chosenPrice = rdr1["Sell_Price"].ToString();
                chosenProductBarcode = rdr1["Barcode"].ToString();
                chosenProductId = rdr1["P_ID"].ToString();
            }

            dal.cnClose();
            this.Hide();

            posInterface_AddItem ad = new posInterface_AddItem(ml);
            ad.Show();
        }

        private void TissuePos_btn_Click(object sender, EventArgs e)
        {
            DataAccessLayer dal = new DataAccessLayer();
            dal.cnOpen();
            SqlCommand cmd1 = new SqlCommand("SELECT * FROM Products WHERE ProductName='tissue'", dal.getConnection());
            SqlDataReader rdr1 = cmd1.ExecuteReader();
            while (rdr1.Read())
            {

                chosenItem = rdr1["ProductName"].ToString();
                chosenPrice = rdr1["Sell_Price"].ToString();
                chosenProductBarcode = rdr1["Barcode"].ToString();
                chosenProductId = rdr1["P_ID"].ToString();
            }

            dal.cnClose();
            this.Hide();

            posInterface_AddItem ad = new posInterface_AddItem(ml);
            ad.Show();
        }

        private void FruitPos_btn_Click(object sender, EventArgs e)
        {
            DataAccessLayer dal = new DataAccessLayer();
            dal.cnOpen();
            SqlCommand cmd1 = new SqlCommand("SELECT * FROM Products WHERE ProductName='fruits'", dal.getConnection());
            SqlDataReader rdr1 = cmd1.ExecuteReader();
            while (rdr1.Read())
            {

                chosenItem = rdr1["ProductName"].ToString();
                chosenPrice = rdr1["Sell_Price"].ToString();
                chosenProductBarcode = rdr1["Barcode"].ToString();
                chosenProductId = rdr1["P_ID"].ToString();
            }

            dal.cnClose();
            this.Hide();

            posInterface_AddItem ad = new posInterface_AddItem(ml);
            ad.Show();
        }

        private void CancelPos_Click(object sender, EventArgs e)
        {
            this.Hide();

        }
    }
}
