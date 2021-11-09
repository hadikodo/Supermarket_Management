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
    public partial class ChangeQuantityForm : Form
    {
        public ChangeQuantityForm()
        {
            InitializeComponent();
        }

        private void ChangeQuantityForm_Load(object sender, EventArgs e)
        {
            newqte_txtbox.Focus();
        }

        private void change_qte_btn_Click(object sender, EventArgs e)
        {
            Globals.newQte = Int32.Parse(newqte_txtbox.Text.ToString());
            this.Close();
        }

        private void cancelnq_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
