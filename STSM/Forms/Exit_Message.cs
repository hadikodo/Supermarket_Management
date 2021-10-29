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
    public partial class Exit_Message : Form
    {

        public int check = 0;
        public Exit_Message()
        {
            InitializeComponent();
        }

        private void Exit_Message_Load(object sender, EventArgs e)
        {

        }

        private void Yes_btn_Click(object sender, EventArgs e)
        {
            check = 1;
            this.Hide();
        }

        private void No_btn_Click(object sender, EventArgs e)
        {
            check = 2;
            this.Hide();
        }
    }
}
