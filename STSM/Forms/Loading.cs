using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using STSM.Classes;

namespace STSM.Forms
{
    public partial class Loading : Form
    {
        static DataAccessLayer dal = new DataAccessLayer();
        public Loading()
        {
            InitializeComponent();
        }
        /// <summary>
        ///     
        /// 
        /// using dataAccessLayer to get Sqlconnection rather than rewriting it as was before Lead to failure with login process with error (connection string property has not been initialized) 
        /// Finally i get the con String rather the Sqlconnection with (private static Classes.DataAccessLayer) 
        /// 
        /// </summary>
        private static Classes.DataAccessLayer loading = new Classes.DataAccessLayer();
        private String cons = loading.getconString();
      

        public static string connection = dal.getconnectionstring();

        private void Loading_Load(object sender, EventArgs e)
        {
           
        }

        private void loading_ProgressBar_progressChanged(object sender, EventArgs e)
        {
            
        }
        int tvalue = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                loading_ProgressBar.Value += 2;
                if (loading_ProgressBar.Value == 100)
                {
                    loading_Timer.Enabled = false;
                    Globals.isReady = true;
                    this.Close();
                }
                tvalue += 2;
                Progress_Value.Text = tvalue + "%";
                if (loading_ProgressBar.Value > 0 && loading_ProgressBar.Value < 49)
                {

                    barLabel.Visible = true;

                }
                if (loading_ProgressBar.Value == 46)
                {
                    System.Threading.Thread.Sleep(1500);
                    barLabel.Text = "Connecting to DataBase ...";
                    barLabel.Location = new Point(215, 259);
                    loading_ProgressBar.Value += 6;
                    tvalue = tvalue + 6;
                    Progress_Value.BackColor = Color.AliceBlue;
                }

                if (loading_ProgressBar.Value == 80)
                {
                    System.Threading.Thread.Sleep(1000);
                    SqlConnection con = new SqlConnection(cons);
                    using (con)
                    {
                        try
                        {
                            con.Open();
                            barLabel.Text = "Starting STSM...";
                            barLabel.Location = new Point(220, 259);

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("there is no connection to the database");
                            Environment.Exit(0);
                        }
                    }
                }
            }
            catch (Exception)
            {
                loading_Timer.Enabled = false;
                this.Close();
            }
        }

        private void loading_logo_Click(object sender, EventArgs e)
        {

        }
    }
}
