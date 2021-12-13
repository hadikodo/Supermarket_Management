using STSM.Classes;
using STSM.Forms;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Win32;
using System.Threading;

namespace STSM
{
    public partial class MainMenu : Form
    {
        private RegistryKey key = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
        Settings sett = new Settings();
        public static string totalAmount = "0";
        public static DataTable finalDataTable = new DataTable();
        public static int isHeldOrder = 0;
        public static int heldOrderId = 0;

        public MainMenu()
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
        private void MainMenu_Load(object sender, EventArgs e)
        {
            checkOut_btn.Hide();
            product_label.Text = "Product Name";
            dataview_main.ReadOnly = true;
            this.WindowState = FormWindowState.Maximized;
            gc1.Visible = false;
            gc2.Visible = false;
            gc3.Visible = false;
            barcode_bar.Focus();
            if (sett.getstart() == 1)
            {
                key.SetValue("STSM", Application.ExecutablePath);
                startup_switch.Value = true;
            }
            else
            {
                key.DeleteValue("STSM", false);
                startup_switch.Value = false;
            }
            dollar_txtedit.Text = sett.getdollar().ToString();
            euro_txtedit.Text = sett.geteuro().ToString();
            pos_btn.Hide();
            dataview_main.MultiSelect = false;
            newSale_btn.Hide();
            deleteItem_btn.Hide();
            holdOrders_btn.Hide();
            change_quantity.Hide();
            return_btn.Hide();
            hold_btn.Hide();
            dataview_main.Hide();
            order_info.Hide();
            sales_back.Hide();
            itemsNumberTextBox.Text = "0";
            dataview_main.Rows.Clear();
            finalDataTable.Columns.Add("Barcode");
            finalDataTable.Columns.Add("ProductName");
            finalDataTable.Columns.Add("Price");
            finalDataTable.Columns.Add("Quantity");
            finalDataTable.Columns.Add("Total");
            finalDataTable.Columns.Add("P_ID");
            itemsNumberTextBox.Enabled = false;
            usdTextBox.Enabled = false;
            lebanesePoundsTextBox.Enabled = false;
            //dataview_main.Height = 800;
            barcode_bar.Focus();
        }

        private void Exit_btn_Click(object sender, EventArgs e)
        {
            Exit_Message m = new Exit_Message();
            m.ShowDialog();
            if (m.check == 1)
            {
                m.Close();
                finalDataTable.Columns.Clear();
                this.Close();
            }
            else
            {
                m.Close();
            }
        }

        private void home_btn_Click(object sender, EventArgs e)
        {
            home_btn.Show();
            addItem_btn.Show();
            stock_btn.Show();
            setting_btn.Show();
            about_btn.Show();
            sales_btn.Show();
            receipt_btn.Show();
            Exit_btn.Show();
            newSale_btn.Hide();
            deleteItem_btn.Hide();
            sales_back.Hide();
            holdOrders_btn.Hide();
            change_quantity.Hide();
            pos_btn.Hide();
            return_btn.Hide();
            hold_btn.Hide();
            dataview_main.Hide();
            order_info.Hide();
            checkOut_btn.Hide();
            gc1.Visible = false;
            gc2.Visible = false;
            gc3.Visible = false;
            sales_btn.Location = new Point(0, 90);
            barcode_bar.Focus();
            product_label.Text = "Product Name";
            dataview_main.Rows.Clear();
            dataview_main.Height = 797;
        }

        private void receipt_btn_Click(object sender, EventArgs e)
        {
            Globals.isHold = false;
            home_btn.Show();
            stock_btn.Show();
            setting_btn.Show();
            about_btn.Show();
            sales_btn.Show();
            receipt_btn.Show();
            newSale_btn.Hide();
            deleteItem_btn.Hide();
            holdOrders_btn.Hide();
            change_quantity.Hide();
            pos_btn.Hide();
            return_btn.Hide();
            hold_btn.Hide();
            dataview_main.Hide();
            order_info.Hide();
            gc1.Visible = false;
            gc2.Visible = false;
            gc3.Visible = false;
            sales_btn.Location = new Point(0, 90);
            dataview_main.Visible = true;
            dataview_main.Columns["orderId_clm"].Visible = true;
            dataview_main.Columns["orderDate_clm"].Visible = true;
            dataview_main.Columns["user_id"].Visible = true;
            dataview_main.Columns["order_total"].Visible = true;
            dataview_main.Columns["open_order_btn"].Visible = true;
            dataview_main.Columns["barcode_clm"].Visible = false;
            dataview_main.Columns["productId_clm"].Visible = false;
            dataview_main.Columns["price_clm"].Visible = false;
            dataview_main.Columns["total_clm"].Visible = false;
            dataview_main.Columns["quantity_clm"].Visible = false;
            dataview_main.Columns["productName_clm"].Visible = false;
            DataAccessLayer dal = new DataAccessLayer();
            DataTable dt = dal.selectAllOrdersWithUserFullName();
            DataRow[] dr = dt.Select("Hold=0");
            if (dr.Length == 0)
            {

            }
            else
            {
                foreach (DataRow row in dr)
                {
                    dataview_main.Rows.Add(0, 0, 0, 0, 0, 0, row["O_ID"].ToString(), row["FullName"].ToString(), row["O_Date"].ToString(), row["Total_Price"].ToString());
                }
            }
            barcode_bar.Focus();
        }

        /*private void supplier_btn_Click(object sender, EventArgs e)
        {
            home_btn.Show();
            stock_btn.Show();
            setting_btn.Show();
            about_btn.Show();
            sales_btn.Show();
            receipt_btn.Show();
            newSale_btn.Hide();
            deleteItem_btn.Hide();
            holdOrders_btn.Hide();
            change_quantity.Hide();
            pos_btn.Hide();
            return_btn.Hide();
            hold_btn.Hide();
            dataview_main.Hide();
            order_info.Hide();
            gc1.Visible = false;
            gc2.Visible = false;
            gc3.Visible = false;
            sales_btn.Location = new Point(0, 90);
            barcode_bar.Focus();
        }*/

        private void stock_btn_Click(object sender, EventArgs e)
        {
            Stock_Product_Editor p = new Stock_Product_Editor();
            p.ShowDialog();
        }

        private void setting_btn_Click(object sender, EventArgs e)
        {
            gc1.Visible = true;
            gc2.Visible = true;
            gc3.Visible = true;
            home_btn.Show();
            stock_btn.Show();
            setting_btn.Show();
            about_btn.Show();
            sales_btn.Show();
            receipt_btn.Show();
            newSale_btn.Hide();
            deleteItem_btn.Hide();
            holdOrders_btn.Hide();
            change_quantity.Hide();
            pos_btn.Hide();
            return_btn.Hide();
            hold_btn.Hide();
            sales_btn.Location = new Point(0, 90);
            dataview_main.Hide();
            order_info.Hide();
            barcode_bar.Focus();
        }

        private void about_btn_Click(object sender, EventArgs e)
        {
            home_btn.Show();
            stock_btn.Show();
            setting_btn.Show();
            about_btn.Show();
            sales_btn.Show();
            receipt_btn.Show();
            newSale_btn.Hide();
            deleteItem_btn.Hide();
            holdOrders_btn.Hide();
            change_quantity.Hide();
            pos_btn.Hide();
            return_btn.Hide();
            hold_btn.Hide();
            dataview_main.Hide();
            order_info.Hide();
            gc1.Visible = false;
            sales_btn.Location = new Point(0, 90);
            barcode_bar.Focus();
        }

        private void sales_btn_Click(object sender, EventArgs e)
        {
            stock_btn.Hide();
            setting_btn.Hide();
            about_btn.Hide();
            receipt_btn.Hide();
            pos_btn.Hide();
            change_quantity.Hide();
            return_btn.Hide();
            hold_btn.Hide();
            holdOrders_btn.Show();
            newSale_btn.Show();
            deleteItem_btn.Hide();
            dataview_main.Hide();
            order_info.Hide();
            sales_btn.Hide();
            home_btn.Hide();
            Exit_btn.Hide();
            sales_back.Show();
            gc1.Visible = false;
            gc2.Visible = false;
            gc3.Visible = false;
            newSale_btn.Location = new Point(0, 0);
            barcode_bar.Focus();
        }
        private void sales_back_Click(object sender, EventArgs e)
        {
            home_btn_Click(home_btn, e);
            sales_back.Hide();
            barcode_bar.Focus();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (!(string.IsNullOrEmpty(barcode_bar.Text)))
            {
                int alreadyExits = 0;
                int enteredBarcode = Int32.Parse(barcode_bar.Text);
                DataAccessLayer dal = new DataAccessLayer();
                DataTable dt = dal.selectAllActiveExpiredDate();
                DataRow[] dr = dt.Select("Barcode=" + enteredBarcode.ToString());
                foreach (DataGridViewRow row in dataview_main.Rows)
                {
                    if (!(row.Cells[0].Value == null || row.Cells[0].Value == DBNull.Value || String.IsNullOrWhiteSpace(row.Cells[0].Value.ToString())))
                    {
                        if (row.Cells[0].Value.ToString() == enteredBarcode.ToString())
                        {
                            int qty = (Int32.Parse(row.Cells[3].Value.ToString())) + 1;
                            row.Cells[3].Value = qty;
                            itemsNumberTextBox.Text = (Int32.Parse(itemsNumberTextBox.Text.ToString()) + 1).ToString();
                            row.Cells[4].Value = qty * float.Parse(row.Cells[2].Value.ToString());
                            product_label.Text = row.Cells[1].Value.ToString();
                            alreadyExits = 1;
                            float totalPrice = 0;

                            foreach (DataGridViewRow row2 in dataview_main.Rows)
                            {
                                if (!(row2.Cells[0].Value == null || row2.Cells[0].Value == DBNull.Value || String.IsNullOrWhiteSpace(row2.Cells[0].Value.ToString())))
                                {
                                    totalPrice += float.Parse(row2.Cells[4].Value.ToString());
                                }
                            }
                            lebanesePoundsTextBox.Text = totalPrice.ToString();
                            usdTextBox.Text = (totalPrice / Int32.Parse(dollar_txtedit.Text)).ToString();
                            totalAmount = totalPrice.ToString();
                            break;
                        }

                    }
                }

                if (alreadyExits == 0)
                {
                    if ((dr.Length != 0))
                    {
                        float totalPrice = 0;
                        dataview_main.Rows.Add(dr[0]["Barcode"], dr[0]["ProductName"], dr[0]["Sell_Price"], 1, dr[0]["Sell_Price"], dr[0]["P_ID"]);
                        product_label.Text = dr[0]["ProductName"].ToString();
                        foreach (DataGridViewRow row2 in dataview_main.Rows)
                        {
                            if (!(row2.Cells[0].Value == null || row2.Cells[0].Value == DBNull.Value || String.IsNullOrWhiteSpace(row2.Cells[0].Value.ToString())))
                            {

                                totalPrice += float.Parse(row2.Cells[4].Value.ToString());

                            }
                        }
                        itemsNumberTextBox.Text = (Int32.Parse(itemsNumberTextBox.Text.ToString()) + 1).ToString();
                        lebanesePoundsTextBox.Text = totalPrice.ToString();
                        usdTextBox.Text = (totalPrice / sett.getdollar()).ToString();
                        totalAmount = totalPrice.ToString();
                    }
                    else
                    { MessageBox.Show("Please enter a valid barcode"); }
                }
                dal.cnOpen();
                SqlCommand cmd1 = new SqlCommand("Update Orders set Total_Price = " + totalAmount + " where O_ID = " + Globals.currentOID, dal.getConnection());
                cmd1.ExecuteNonQuery();
                dal.cnClose();
            }
            else
            {
                MessageBox.Show("Please enter a valid barcode");
            }
            barcode_bar.Text = "";
            barcode_bar.Focus();
        }

        private void checkOut_btn_Click(object sender, EventArgs e)
        {
            if (Int32.Parse(totalAmount) != 0)
            {
                DataRow drLocal = null;
                foreach (DataGridViewRow dr in dataview_main.Rows)
                {
                    if (!(dr.Cells[0].Value == null || dr.Cells[0].Value == DBNull.Value || String.IsNullOrWhiteSpace(dr.Cells[0].Value.ToString())))
                    {
                        drLocal = finalDataTable.NewRow();
                        drLocal["Barcode"] = dr.Cells["barcode_clm"].Value.ToString();
                        drLocal["ProductName"] = dr.Cells["productName_clm"].Value.ToString();
                        drLocal["Price"] = dr.Cells["price_clm"].Value.ToString();
                        drLocal["Quantity"] = dr.Cells["quantity_clm"].Value.ToString();
                        drLocal["Total"] = dr.Cells["total_clm"].Value.ToString();
                        drLocal["P_ID"] = dr.Cells["productId_clm"].Value.ToString();
                        finalDataTable.Rows.Add(drLocal);
                    }
                }
                new CheckoutInterface().ShowDialog();
                if (Globals.isCheckCancelled == false)
                {
                    newSale_btn.Location = new Point(0, 90);
                    sales_btn.Location = new Point(0, 90);
                    sales_btn.Enabled = true;
                    newSale_btn.Text = "New Sale";
                    home_btn_Click(home_btn, e);
                }
            }
            else
                MessageBox.Show("Please Add At Least One Item !");
            barcode_bar.Focus();

        }

        private void Barcode_label_Click(object sender, EventArgs e)
        {

        }

        private void NewSale_btn_Click(object sender, EventArgs e)
        {
            lebanesePoundsTextBox.Text = "0";
            usdTextBox.Text = "0";
            barcode_bar.Text = "";
            itemsNumberTextBox.Text = "0";
            DataAccessLayer dal = new DataAccessLayer();
            if (!(string.IsNullOrWhiteSpace(lebanesePoundsTextBox.Text)))
            {
                dal.cnOpen();
                SqlCommand cmd1 = new SqlCommand("INSERT INTO Orders (O_Date, Total_Price, U_ID, Active, Hold) VALUES(" + "GETDATE()" + "," + 0 + "," + 3 + "," + 0 + "," + 0 + ")", dal.getConnection());
                cmd1.ExecuteNonQuery();
                dal.cnClose();
                dal.cnOpen();
                SqlCommand cmd12 = new SqlCommand("SELECT TOP 1 * FROM Orders ORDER BY O_ID DESC", dal.getConnection());
                SqlDataReader datardr = cmd12.ExecuteReader();
                while (datardr.Read())
                {
                    Globals.currentOID = Int32.Parse(datardr["O_ID"].ToString());
                }
                dal.cnClose();
            }
            else
            {
                MessageBox.Show("Somthing Went Wrong, Order Can't be Created !!");
            }
            barcode_bar.Focus();
            pos_btn.Show();
            change_quantity.Show();
            return_btn.Show();
            hold_btn.Show();
            holdOrders_btn.Hide();
            deleteItem_btn.Show();
            Exit_btn.Hide();
            sales_back.Hide();
            newSale_btn.Hide();
            sales_btn.Hide();
            dataview_main.Show();
            order_info.Show();
            checkOut_btn.Show();
            addItem_btn.Show();
            dataview_main.Rows.Clear();
            dataview_main.Columns["orderId_clm"].Visible = false;
            dataview_main.Columns["open_order_btn"].Visible = false;
            dataview_main.Columns["user_id"].Visible = false;
            dataview_main.Columns["order_total"].Visible = false;
            dataview_main.Columns["open_order_btn"].Visible = false;
            dataview_main.Columns["orderDate_clm"].Visible = false;
            dataview_main.Columns["barcode_clm"].Visible = true;
            dataview_main.Columns["productId_clm"].Visible = false;
            dataview_main.Columns["price_clm"].Visible = true;
            dataview_main.Columns["total_clm"].Visible = true;
            dataview_main.Columns["quantity_clm"].Visible = true;
            dataview_main.Columns["productName_clm"].Visible = true;
            barcode_bar.Focus();

        }

        private void dataview_main_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Globals.isHold)
            {
                int nullRow = 0;
                foreach (DataGridViewRow row1 in dataview_main.SelectedRows)
                {
                    if ((row1.Cells["orderId_clm"].Value == null || row1.Cells["orderId_clm"].Value == DBNull.Value || String.IsNullOrWhiteSpace(row1.Cells["orderId_clm"].Value.ToString())))
                    {
                        nullRow = 1;
                    }
                }
                if (nullRow == 0)
                {
                    if (MessageBox.Show("Do you want to resume the selected order?", "Resume order", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        foreach (DataGridViewRow row5 in dataview_main.SelectedRows)
                        {
                            heldOrderId = Int32.Parse(row5.Cells["orderId_clm"].Value.ToString());
                        }
                        isHeldOrder = 1;
                        addItem_btn.Show();
                        pos_btn.Show();
                        deleteItem_btn.Show();
                        order_info.Show();
                        change_quantity.Show();
                        newSale_btn.Hide();
                        checkOut_btn.Show();
                        hold_btn.Show();
                        return_btn.Show();
                        float totalPrice = 0;
                        int orderId = 0;
                        foreach (DataGridViewRow row in dataview_main.SelectedRows)
                        {
                            orderId = Int32.Parse(row.Cells["orderId_clm"].Value.ToString());
                        }
                        dataview_main.Rows.Clear();
                        dataview_main.Columns["orderId_clm"].Visible = false;
                        dataview_main.Columns["orderDate_clm"].Visible = false;
                        dataview_main.Columns["open_order_btn"].Visible = false;
                        dataview_main.Columns["user_id"].Visible = false;
                        dataview_main.Columns["order_total"].Visible = false;
                        dataview_main.Columns["barcode_clm"].Visible = true;
                        dataview_main.Columns["productId_clm"].Visible = false;
                        dataview_main.Columns["price_clm"].Visible = true;
                        dataview_main.Columns["total_clm"].Visible = true;
                        dataview_main.Columns["quantity_clm"].Visible = true;
                        dataview_main.Columns["productName_clm"].Visible = true;
                        DataAccessLayer dal = new DataAccessLayer();
                        Globals.currentOID = orderId;
                        dal.cnOpen();
                        dal.inholdOrder(orderId);
                        dal.cnClose();
                        DataTable dt = new DataTable();
                        dal.cnOpen();
                        SqlDataAdapter sa = new SqlDataAdapter("SELECT Products.Barcode,Products.ProductName,Products.Sell_Price,Orders_Details.QTE,Orders_Details.Total_Price,Products.P_ID FROM Orders_Details INNER JOIN Products ON Orders_Details.P_ID=Products.P_ID WHERE Orders_Details.O_ID=" + orderId + ";", dal.getConnection());
                        sa.Fill(dt);
                        DataRow[] dr = dt.Select();
                        dal.cnClose();
                        foreach (DataRow row2 in dr)
                        {
                            dataview_main.Rows.Add(row2[0].ToString(), row2[1].ToString(), row2[2].ToString(), row2[3].ToString(), row2[4].ToString(), row2[5].ToString());
                            totalPrice += float.Parse(row2[4].ToString());
                            itemsNumberTextBox.Text = (Int32.Parse(itemsNumberTextBox.Text.ToString()) + 1).ToString();
                        }
                        lebanesePoundsTextBox.Text = totalPrice.ToString();
                        usdTextBox.Text = (totalPrice / sett.getdollar()).ToString();
                        totalAmount = totalPrice.ToString();
                    }
                }
                gc1.Visible = false;
                gc2.Visible = false;
                gc3.Visible = false;
                barcode_bar.Focus();
            }
            else
            {
                try
                {
                    foreach (DataGridViewRow row in dataview_main.SelectedRows)
                    {
                        Globals.openedOrderID = Int32.Parse(row.Cells["orderId_clm"].Value.ToString());
                    }
                    OrderDetailsForm odf = new OrderDetailsForm();
                    odf.ShowDialog();
                }
                catch
                {
                    MessageBox.Show("Somthing Went Wrong !!");
                }
            }
        }

        private void deleteItem_btn_Click(object sender, EventArgs e)
        {
            if (dataview_main.SelectedRows.Count >= 1)
            {
                Globals.currentQte = Int32.Parse(dataview_main.CurrentRow.Cells[3].Value.ToString());
                DeleteItemForm dif = new DeleteItemForm();
                dif.ShowDialog();
                foreach (DataGridViewRow item in this.dataview_main.SelectedRows)
                {
                    if (!(item.Cells[0].Value == null || item.Cells[0].Value == DBNull.Value || String.IsNullOrWhiteSpace(item.Cells[0].Value.ToString())))
                    {
                        if (Int32.Parse(item.Cells[3].Value.ToString()) == Globals.nbDeleted)
                        {
                            dataview_main.Rows.RemoveAt(item.Index);
                            float totalPrice = 0;
                            foreach (DataGridViewRow row2 in dataview_main.Rows)
                            {
                                if (!(row2.Cells[0].Value == null || row2.Cells[0].Value == DBNull.Value || String.IsNullOrWhiteSpace(row2.Cells[0].Value.ToString())))
                                {
                                    totalPrice +=float.Parse(row2.Cells[4].Value.ToString());
                                }
                            }
                            lebanesePoundsTextBox.Text = totalPrice.ToString();
                            usdTextBox.Text = (totalPrice / sett.getdollar()).ToString();
                            totalAmount = totalPrice.ToString();
                        }
                        else
                        {
                            item.Cells[3].Value = (Int32.Parse(item.Cells[3].Value.ToString()) - Globals.nbDeleted);
                            item.Cells[4].Value = (Int32.Parse(item.Cells[3].Value.ToString())) * float.Parse(item.Cells[2].Value.ToString());
                            float totalPrice = 0;
                            foreach (DataGridViewRow row2 in dataview_main.Rows)
                            {
                                if (!(row2.Cells[0].Value == null || row2.Cells[0].Value == DBNull.Value || String.IsNullOrWhiteSpace(row2.Cells[0].Value.ToString())))
                                {
                                    totalPrice +=float.Parse(row2.Cells[4].Value.ToString());
                                }
                            }
                            lebanesePoundsTextBox.Text = totalPrice.ToString();
                            usdTextBox.Text = (totalPrice / sett.getdollar()).ToString();
                            totalAmount = totalPrice.ToString();
                        }
                    }
                }
                itemsNumberTextBox.Text = (Int32.Parse(itemsNumberTextBox.Text.ToString()) - Globals.nbDeleted).ToString();
                barcode_bar.Focus();
            }
            else
            {
                MessageBox.Show("Please Add At Least One Item !");
                barcode_bar.Focus();
            }
        }

        private void Pos_btn_Click(object sender, EventArgs e)
        {
            posInterface ps = new posInterface(this);
            ps.Show();
        }

        private void HeldOrders_btn_Click(object sender, EventArgs e)
        {
            Globals.isHold = true;
            addItem_btn.Hide();
            pos_btn.Hide();
            hold_btn.Hide();
            return_btn.Hide();
            deleteItem_btn.Hide();
            checkOut_btn.Hide();
            hold_btn.Hide();
            return_btn.Hide();
            holdOrders_btn.Hide();
            dataview_main.Rows.Clear();
            lebanesePoundsTextBox.Text = "";
            usdTextBox.Text = "";
            barcode_bar.Text = "";
            itemsNumberTextBox.Text = "0";
            dataview_main.Visible = true;
            dataview_main.Columns["orderId_clm"].Visible = true;
            dataview_main.Columns["orderDate_clm"].Visible = true;
            dataview_main.Columns["user_id"].Visible = true;
            dataview_main.Columns["order_total"].Visible = true;
            dataview_main.Columns["open_order_btn"].Visible = true;
            dataview_main.Columns["barcode_clm"].Visible = false;
            dataview_main.Columns["productId_clm"].Visible = false;
            dataview_main.Columns["price_clm"].Visible = false;
            dataview_main.Columns["total_clm"].Visible = false;
            dataview_main.Columns["quantity_clm"].Visible = false;
            dataview_main.Columns["productName_clm"].Visible = false;
            DataAccessLayer dal = new DataAccessLayer();
            DataTable dt = dal.selectAllOrdersWithUserFullName();
            DataRow[] dr = dt.Select("Hold=1");
            if (dr.Length == 0)
            {

            }
            else
            {
                foreach (DataRow row in dr)
                {
                    dataview_main.Rows.Add(0, 0, 0, 0, 0, 0, row["O_ID"].ToString(), row["FullName"].ToString(), row["O_Date"].ToString(), row["Total_Price"].ToString());
                }
            }
            barcode_bar.Focus();
        }

        private void Dataview_main_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
        }
        private void gc1_Paint(object sender, PaintEventArgs e)
        {

        }
        int de = 0;
        private void pro_disable_all_Click(object sender, EventArgs e)
        {
            Promotions p = new Promotions();
            if (de == 0)
            {
                p.disable_pro_all();
                pro_disable_enable_all.Text = "Enable All";
                de = 1;
            }
            else
            {
                p.enable_pro_all();
                pro_disable_enable_all.Text = "Disable All";
                de = 0;
            }

        }

        private void note_disable_enable_all_Click(object sender, EventArgs e)
        {

        }

        private void stratup_switch_Click(object sender, EventArgs e)
        {

        }

        private void apply_settings_btn_Click(object sender, EventArgs e)
        {
            if (startup_switch.Value == true)
            {
                key.SetValue("STSM", Application.ExecutablePath);
                sett.setstart(1);
            }
            else
            {
                key.DeleteValue("STSM", false);
                sett.setstart(0);
            }
            sett.setdollar(int.Parse(dollar_txtedit.Text));
            sett.seteuro(int.Parse(euro_txtedit.Text));
            MessageBox.Show("Apply Successfully!!");
        }

        private void pro_clear_all_Click(object sender, EventArgs e)
        {

        }

        private void note_clear_all_Click(object sender, EventArgs e)
        {

        }

        private void return_btn_Click(object sender, EventArgs e)
        {
            DataAccessLayer dal = new DataAccessLayer();
            DataRow[] dr = MainMenu.finalDataTable.Select();
            float receivedAmount;
            float totalAmount;
            if (!(string.IsNullOrWhiteSpace(lebanesePoundsTextBox.Text)))
            {
                DataRow drLocal = null;
                foreach (DataGridViewRow dr2 in dataview_main.Rows)
                {
                    if (!(dr2.Cells[0].Value == null || dr2.Cells[0].Value == DBNull.Value || String.IsNullOrWhiteSpace(dr2.Cells[0].Value.ToString())))
                    {
                        drLocal = finalDataTable.NewRow();
                        drLocal["Barcode"] = dr2.Cells["barcode_clm"].Value.ToString();
                        drLocal["ProductName"] = dr2.Cells["productName_clm"].Value.ToString();
                        drLocal["Price"] = dr2.Cells["price_clm"].Value.ToString();
                        drLocal["Quantity"] = dr2.Cells["quantity_clm"].Value.ToString();
                        drLocal["Total"] = dr2.Cells["total_clm"].Value.ToString();
                        drLocal["P_ID"] = dr2.Cells["productId_clm"].Value.ToString();
                        finalDataTable.Rows.Add(drLocal);
                    }
                }
                if (MessageBox.Show("You are about to return the scanned items. This will affect the stock database. Are you sure you want to continue?", "Return Items", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    totalAmount = float.Parse(lebanesePoundsTextBox.Text.ToString());
                    dal.cnOpen();
                    SqlCommand cmd1 = new SqlCommand("INSERT INTO Return_r (R_Date, Total_Price, U_ID, Active) VALUES(" + "GETDATE()" + "," + totalAmount + "," + 3 + "," + 0 + ")", dal.getConnection());
                    cmd1.ExecuteNonQuery();
                    dal.cnClose();
                    int oID = 0;
                    dal.cnOpen();
                    SqlCommand cmd12 = new SqlCommand("SELECT TOP 1 * FROM Return_r ORDER BY R_ID DESC", dal.getConnection());
                    SqlDataReader datardr = cmd12.ExecuteReader();
                    while (datardr.Read())
                    {
                        oID = Int32.Parse(datardr["R_ID"].ToString());
                    }
                    dal.cnClose();
                    foreach (DataRow row in MainMenu.finalDataTable.Rows)
                    {
                        if (row[5].ToString() != "posItem")
                        {
                            dal.cnOpen();
                            SqlCommand cmd2 = new SqlCommand("INSERT INTO Return_Details (R_ID, P_ID, QTE, Item_Price,Total_Price) VALUES(" + oID + "," + Int32.Parse(row["P_ID"].ToString()) + "," + Int32.Parse(row["Quantity"].ToString()) + "," + Int32.Parse(row["Price"].ToString()) + "," + Int32.Parse(row["Total"].ToString()) + ")", dal.getConnection());
                            cmd2.ExecuteNonQuery();
                            dal.cnClose();
                        }
                    }
                    MessageBox.Show("Successfully completed return. The items have been added back to the stock.");
                }
            }
            else
            {
                MessageBox.Show("Please enter an item to be returned first");
            }
            barcode_bar.Focus();
            home_btn_Click(home_btn, e);
        }

        private void change_quantity_Click(object sender, EventArgs e)
        {
            if (dataview_main.SelectedRows.Count >= 1)
            {
                ChangeQuantityForm cqf = new ChangeQuantityForm();
                cqf.newqte_txtbox.Focus();
                cqf.ShowDialog();
                barcode_bar.Focus();
                itemsNumberTextBox.Text = (Int32.Parse(itemsNumberTextBox.Text.ToString()) - Int32.Parse(dataview_main.CurrentRow.Cells[3].Value.ToString()) + Globals.newQte).ToString();
                dataview_main.CurrentRow.Cells[3].Value = Globals.newQte;
                dataview_main.CurrentRow.Cells[4].Value = Int32.Parse(dataview_main.CurrentRow.Cells[3].Value.ToString()) * Int32.Parse(dataview_main.CurrentRow.Cells[2].Value.ToString());
                float totalPrice = 0;
                foreach (DataGridViewRow row2 in dataview_main.Rows)
                {
                    if (!(row2.Cells[0].Value == null || row2.Cells[0].Value == DBNull.Value || String.IsNullOrWhiteSpace(row2.Cells[0].Value.ToString())))
                    {
                        totalPrice += float.Parse(row2.Cells[4].Value.ToString());
                    }
                }
                lebanesePoundsTextBox.Text = totalPrice.ToString();
                usdTextBox.Text = (totalPrice / Int32.Parse(dollar_txtedit.Text)).ToString();
                totalAmount = totalPrice.ToString();
            }
            else
            {
                MessageBox.Show("Please Add At Least One Item !");
                barcode_bar.Focus();
            }
        }

        private void usdTextBox_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void manage_note_Click(object sender, EventArgs e)
        {

        }

        private void reset_settings_btn_Click(object sender, EventArgs e)
        {

        }

        private void hold_btn_Click(object sender, EventArgs e)
        {
            DataAccessLayer dal = new DataAccessLayer();
            float totalAmount;
            dal.cnOpen();
            dal.removeOrderDetailsByID(Globals.currentOID);
            if (!(string.IsNullOrWhiteSpace(lebanesePoundsTextBox.Text)))
            {
                totalAmount = float.Parse(lebanesePoundsTextBox.Text.ToString());
                foreach (DataGridViewRow row in dataview_main.Rows)
                {
                    if (!(row.Cells[0].Value == null || row.Cells[0].Value == DBNull.Value || String.IsNullOrWhiteSpace(row.Cells[0].Value.ToString())))
                    {
                        dal.addOrderDetails(Globals.currentOID, Int32.Parse(row.Cells["productId_clm"].Value.ToString()), Int32.Parse(row.Cells["quantity_clm"].Value.ToString()), Int32.Parse(row.Cells["price_clm"].Value.ToString()), Int32.Parse(row.Cells["total_clm"].Value.ToString()));
                    }
                }
                dal.holdOrder(Globals.currentOID);
                MessageBox.Show("Order has been placed on hold.");
                home_btn_Click(home_btn, e);
                sales_btn_Click(sales_btn, e);
                HeldOrders_btn_Click(holdOrders_btn, e);
            }
            else
            {
                MessageBox.Show("Please enter at least one item before holding an order");
            }
            barcode_bar.Focus();
        }

        private void pro_manage_Click(object sender, EventArgs e)
        {

        }

        private void dataview_main_Cell_Click(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                product_label.Text = dataview_main.SelectedRows[0].Cells[1].Value.ToString();

            }
            catch (Exception ex)
            {

            }
        }

        private void OnPressKey(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = e.SuppressKeyPress = true;
                Button1_Click(addItem_btn, e);
            }
        }
    }
}
