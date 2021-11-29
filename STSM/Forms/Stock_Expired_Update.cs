using STSM.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace STSM.Forms
{
    public partial class Stock_Expired_Update : Form
    {
        int exid = 0;
        Classes.ExpiredDate ed = new Classes.ExpiredDate();
        DataAccessLayer dal = new DataAccessLayer();
        SqlCommand cmd;
        SqlDataReader dr;
        public static String PID_ADD="";
        public Stock_Expired_Update()
        {
            InitializeComponent();
        }
        public Stock_Expired_Update(int exid)
        {
            InitializeComponent();
            this.exid = exid;
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
            int qty;
            if (textBox3.Text!="")
            {
                qty = int.Parse(textBox3.Text);
                dal.cnOpen();
                try
                {
                    cmd = new SqlCommand("Update ExpiredDate Set QTE=" + qty + " where Exp_ID=" + exid + "",dal.getConnection());
                    dr = cmd.ExecuteReader();
                    dr.Read();
                    DialogResult dialogResult = MessageBox.Show("successfully updated", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (dialogResult == DialogResult.OK)
                    {
                        this.Close();
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                finally
                {
                    dal.cnClose();
                }
            }
            else if (String.IsNullOrEmpty(textBox3.Text) || String.IsNullOrWhiteSpace(textBox3.Text))
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
       
    

    public void clear()
    {



        textBox3.Text = "";
      
    }

        private void Stock_Expired_Update_Load(object sender, EventArgs e)
        {

        }
    }
}

