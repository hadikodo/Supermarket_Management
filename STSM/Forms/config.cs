using System;
using System.Windows.Forms;

namespace STSM.Forms
{   
    public partial class config : Form
    {
        public config()
        {
            InitializeComponent();
            txtServer.Text = Properties.Settings.Default.Server;
            txtDatabase.Text = Properties.Settings.Default.Database;
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
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Server = txtServer.Text;
            Properties.Settings.Default.Database = txtDatabase.Text;

            Properties.Settings.Default.Save();
            MessageBox.Show("Saved Successfully");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
