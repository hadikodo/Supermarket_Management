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
using System.Data;

namespace STSM.Forms
{
    public partial class CheckoutInterface : Form
    {

        public CheckoutInterface()
        {
            InitializeComponent();

        }

        private void CheckoutInterface_Load(object sender, EventArgs e)
        {
            totalTextBox.ReadOnly = true;
            totalTextBox.Text = MainMenu.totalAmount;
            changeTextBox.ReadOnly = true;
            exitCheckout.Hide();
            receivedTextBox.Text = "";
        }

        private void BunifuFlatButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void totalTextBox_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void NewSale_btn_Click(object sender, EventArgs e)
        {
            DataAccessLayer dal = new DataAccessLayer();
            DataRow[] dr = MainMenu.finalDataTable.Select();
            float receivedAmount=0, totalAmount;
            try
            {
                if (!receivedTextBox.Text.Equals(""))
                    receivedAmount = float.Parse(receivedTextBox.Text);
            }
            catch
            {

            }
            totalAmount = float.Parse(totalTextBox.Text);
            if (receivedAmount == totalAmount)
            {
                newSale_btn.Hide();
                bunifuFlatButton1.Hide();
                ExitCheckout_Click(exitCheckout, e);
            }
            else if (receivedAmount > totalAmount)
            {
                changeLabel.Show();
                changeTextBox.BackColor = Color.Red;
                changeTextBox.Text = "-" + (receivedAmount - totalAmount).ToString();
                changeTextBox.Show();
                newSale_btn.Hide();
                bunifuFlatButton1.Hide();
                exitCheckout.Show();
            }
            else
            {
                changeLabel.Show();
                changeTextBox.BackColor = Color.Blue;
                changeTextBox.Text = "+" + (totalAmount - receivedAmount).ToString();
                changeTextBox.Show();
                newSale_btn.Hide();
                bunifuFlatButton1.Hide();
                exitCheckout.Show();
            }
            dal.cnOpen();
            SqlCommand cmd1 = new SqlCommand("INSERT INTO Orders (O_Date, Total_Price, U_ID, Active, Hold) VALUES(" + "GETDATE()" + "," + totalAmount + "," + 3 + "," + 0 + "," + 0 + ")", dal.getConnection());
            cmd1.ExecuteNonQuery();
            dal.cnClose();
            int oID = 0;
            dal.cnOpen();
            SqlCommand cmd12 = new SqlCommand("SELECT TOP 1 * FROM Orders ORDER BY O_ID DESC", dal.getConnection());
            SqlDataReader datardr = cmd12.ExecuteReader();
            while (datardr.Read())
            {
                oID = Int32.Parse(datardr["O_ID"].ToString());
            }
            datardr.Close();
            dal.cnClose();
            foreach (DataRow row in MainMenu.finalDataTable.Rows)
            {
                if (row[5].ToString() != "posItem")
                {
                    dal.cnOpen();
                    dal.updateStockById(Int32.Parse(row["P_ID"].ToString()), Int32.Parse(row["Quantity"].ToString()));
                    dal.cnClose();
                    dal.cnOpen();
                    SqlCommand cmd2 = new SqlCommand("INSERT INTO Orders_Details (O_ID, P_ID, QTE, Item_Price,Total_Price) VALUES(" + oID + "," + Int32.Parse(row["P_ID"].ToString()) + "," + Int32.Parse(row["Quantity"].ToString()) + "," + Int32.Parse(row["Price"].ToString()) + "," + Int32.Parse(row["Total"].ToString()) + ")", dal.getConnection());
                    cmd2.ExecuteNonQuery();
                    dal.cnClose();
                }
            }
            if (MainMenu.isHeldOrder == 1)
            {
                dal.cnOpen();
                SqlCommand cmd9 = new SqlCommand("DELETE FROM Orders_Details WHERE O_ID=" + MainMenu.heldOrderId, dal.getConnection());
                SqlCommand cmd10 = new SqlCommand("DELETE FROM Orders WHERE O_ID = " + MainMenu.heldOrderId, dal.getConnection());
                cmd9.ExecuteNonQuery();
                dal.cnClose();
                dal.cnOpen();
                cmd10.ExecuteNonQuery();
                dal.cnClose();
            }
            MainMenu.finalDataTable.Clear();
        }

        private void ExitCheckout_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
