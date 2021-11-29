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
    public partial class OrderDetailsForm : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {

        public static DataTable dataTable = new DataTable();

        public OrderDetailsForm()
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

        private void OrderDetailsForm_Load(object sender, EventArgs e)
        {
            int qte = 0;
            DataAccessLayer dal = new DataAccessLayer();
            DataTable dt = dal.selectSpecificOrder(Globals.openedOrderID);
            DataRow[] dr = dt.Select();
            if (dr.Length == 0)
            {

            }
            else
            {
                foreach (DataRow row in dr)
                {
                    oid_value.Text = Globals.openedOrderID.ToString();
                    date_value.Text = row["O_Date"].ToString();
                    tprice_value.Text = row["Total_Price"].ToString() + " L.L.";
                    cashname_value.Text = row["FullName"].ToString();
                }
            }
            dal.cnClose();
            dal.cnOpen();
            dataTable = dal.getOrderDetailsByID(Globals.openedOrderID);
            dr = dataTable.Select();
            if (dr.Length == 0)
            {

            }
            else
            {
                foreach (DataRow row in dr)
                {
                    dataview_main.Rows.Add(row["Barcode"].ToString(), row["ProductName"].ToString(), row["Item_Price"].ToString(), row["QTE"].ToString(), row["Total_Price"].ToString());
                    qte += Int32.Parse(row["QTE"].ToString());
                }
            }
            qte_value.Text = qte.ToString();
            try
            {
                itemname_value.Text = dataview_main.SelectedRows[0].Cells[1].Value.ToString();

            }
            catch (Exception ex)
            {

            }
        }

        private void print_btn_Click(object sender, EventArgs e)
        {

        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Cell_Click(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                itemname_value.Text = dataview_main.SelectedRows[0].Cells[1].Value.ToString();

            }
            catch (Exception ex)
            {

            }
        }
    }
}
