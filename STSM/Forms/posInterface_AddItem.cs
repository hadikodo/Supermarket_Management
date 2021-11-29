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

namespace STSM.Forms
{
    public partial class posInterface_AddItem : Form
    {


        public static DataRow posRow;
        private readonly MainMenu m1;
        public posInterface_AddItem(MainMenu m)
        {
            InitializeComponent();
            m1 = m;

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
        private void PosInterface_AddItem_Load(object sender, EventArgs e)
        {
            posProductNameTextBox.ReadOnly = true;
            posProductPriceTextBox.ReadOnly = true;

            posProductNameTextBox.Text = posInterface.chosenItem;
            posProductPriceTextBox.Text = posInterface.chosenPrice;
            quantityTextBox.Items.Insert(0,"10");
            quantityTextBox.Items.Insert(1,"9");
            quantityTextBox.Items.Insert(2,"8");
            quantityTextBox.Items.Insert(3,"7");
            quantityTextBox.Items.Insert(4,"6");
            quantityTextBox.Items.Insert(5, "5");
            quantityTextBox.Items.Insert(6,"4");
            quantityTextBox.Items.Insert(7, "3");
            quantityTextBox.Items.Insert(8, "2");
            quantityTextBox.Items.Insert(9, "1");

            quantityTextBox.SelectedIndex = 9;
            


        }

        private void BunifuFlatButton1_Click(object sender, EventArgs e)
        {
            this.Hide();

        }

        private void NewSale_btn_Click(object sender, EventArgs e)
        {
            int alreadyExists = 0;
            float qty = float.Parse(quantityTextBox.Text.ToString());
            float price = float.Parse(posProductPriceTextBox.Text.ToString());
           

            float totalPrice = 0;

            //laman tkoun mawjoude
            foreach(DataGridViewRow row3 in m1.dataview_main.Rows)
            {
                if (!(row3.Cells[0].Value == null || row3.Cells[0].Value == DBNull.Value || String.IsNullOrWhiteSpace(row3.Cells[0].Value.ToString())))
                {

                    if(posInterface.chosenProductBarcode.ToString() == row3.Cells["barcode_clm"].Value.ToString())
                    {
                        row3.Cells["quantity_clm"].Value = (Int32.Parse(((row3.Cells["quantity_clm"]).Value.ToString())) + Int32.Parse(quantityTextBox.Text.ToString()));
                        row3.Cells["total_clm"].Value = float.Parse(row3.Cells["quantity_clm"].Value.ToString()) * float.Parse(row3.Cells["price_clm"].Value.ToString());
                        

                        alreadyExists = 1;
                        break;
                        
                    }


                }
            
                        
                        
                        
                        }

            if(alreadyExists==1)
            {
                foreach (DataGridViewRow row4 in m1.dataview_main.Rows)
                {
                    if (!(row4.Cells[0].Value == null || row4.Cells[0].Value == DBNull.Value || String.IsNullOrWhiteSpace(row4.Cells[0].Value.ToString())))
                    { totalPrice += float.Parse(row4.Cells[4].Value.ToString()); }

                }  
            }


            //behal kent mesh mawjoude bel datagridview
            if (alreadyExists == 0)
            {
                m1.dataview_main.Rows.Add(posInterface.chosenProductBarcode.ToString(), (posProductNameTextBox.Text.ToString()), (posProductPriceTextBox.Text.ToString()), (quantityTextBox.Text.ToString()), (qty * price).ToString(), posInterface.chosenProductId.ToString());

                foreach (DataGridViewRow row2 in m1.dataview_main.Rows)
                {

                    if (!(row2.Cells[0].Value == null || row2.Cells[0].Value == DBNull.Value || String.IsNullOrWhiteSpace(row2.Cells[0].Value.ToString())))
                    {

                        totalPrice += float.Parse(row2.Cells[4].Value.ToString());


                    }
                }
            }
                m1.lebanesePoundsTextBox.Text = totalPrice.ToString();
                m1.usdTextBox.Text = (totalPrice / 1520).ToString();
                MainMenu.totalAmount = totalPrice.ToString();
            if (alreadyExists == 0)
            {
                m1.itemsNumberTextBox.Text = (Int32.Parse(m1.itemsNumberTextBox.Text.ToString()) + 1).ToString();
            }

            this.Hide();

        }

        private void QuantityTextBox_SelectedItemChanged(object sender, EventArgs e)
        {

        }
    }
}
