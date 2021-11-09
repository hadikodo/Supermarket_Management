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
    public partial class DeleteItemForm : Form
    {
        public DeleteItemForm()
        {
            InitializeComponent();
        }

        private void canceldel_btn_Click(object sender, EventArgs e)
        {
            Globals.nbDeleted = 0;
            this.Close();
        }

        private void DeleteAll_btn_Click(object sender, EventArgs e)
        {
            Globals.nbDeleted = Globals.currentQte;
            this.Close();
        }

        private void cus_del_btn_Click(object sender, EventArgs e)
        {
            if (Int32.Parse(del_item_qte_txtbox.Text.ToString()) <= Globals.currentQte)
            {
                Globals.nbDeleted = Int32.Parse(del_item_qte_txtbox.Text.ToString());
                this.Close();
            }
            else
            {
                MessageBox.Show("The Total Quantity Of This Item Smaller Than " + Int32.Parse(del_item_qte_txtbox.Text.ToString()) + " !!");
            }

        }

        private void DeleteItemForm_Load(object sender, EventArgs e)
        {
            del_item_qte_txtbox.Text = "1";
            del_item_qte_txtbox.Focus();
        }
    }
}
