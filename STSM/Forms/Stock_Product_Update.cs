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
    public partial class Stock_Product_Update : Form
    {
        Classes.DataAccessLayer dal = new
Classes.DataAccessLayer();
        Classes.Categories CAT = new Classes.Categories();
        Classes.Products PRO = new Classes.Products();
        public Stock_Product_Update()
        {
            if (dal.getConnection().State == ConnectionState.Open)
            {
                dal.cnClose();
            }
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
            String PID_ADD = Stock_Product_Editor.ID;

            if (catbox.SelectedIndex > -1)
            {
                String Cat = catbox.Text;
                float price;
                if (pricetxt.Text!="")
                {
                    if (dal.getConnection().State == ConnectionState.Open)
                    {
                        dal.cnClose();
                    }
                    price = float.Parse(pricetxt.Text);
                    PRO.update_Product(int.Parse(PID_ADD), price, Cat);

                    DialogResult dialogResult = MessageBox.Show("successfully updated", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (dialogResult == DialogResult.OK)
                    {
                        this.Close();
                    }
                }
                else if (String.IsNullOrEmpty(pricetxt.Text) || String.IsNullOrWhiteSpace(pricetxt.Text))
                {

                    MessageBox.Show("All Entry must be fill");
                    this.clear();
                }
                else
                {
                    MessageBox.Show("Enter Valid number");
                    this.clear();
                }
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Please Enter All Fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (dialogResult == DialogResult.OK)
                {

                    this.Close();
                }
                this.clear();

            }
        }
        public void clear()
        {



          
            pricetxt.Text = "";
            
        }
    }
}
