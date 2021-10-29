using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace STSM.Classes
{
    class Settings
    {
        private DataAccessLayer dal = new DataAccessLayer();
        private SqlCommand cmd;
        private SqlDataReader dr;
        private int start_value=0;
        private int dollar_value=0;
        private int euro_value=0;

        public Settings()
        {

        }

        public int getstart()
        {
            try
            {
                dal.cnOpen();
                cmd = new SqlCommand("Select SETT_VALUE from Settings where SETT_NAME='"+"Startup"+"'", dal.getConnection());
                dr = cmd.ExecuteReader();
                dr.Read();
                this.start_value = int.Parse(dr[0].ToString());
                dal.cnClose();
                return this.start_value;
            }catch(Exception e)
            {
                MessageBox.Show(e.ToString());
                dal.cnClose();
                return this.start_value;
            }
        }

        public void setstart(int val)
        {
            try
            {
                dal.cnOpen();
                cmd = new SqlCommand("Update Settings Set SETT_VALUE="+val+" where SETT_NAME='Startup'", dal.getConnection());
                dr = cmd.ExecuteReader();
                dr.Read();
                dal.cnClose();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                dal.cnClose();
            }
        }
        public int getdollar()
        {
            try
            {
                dal.cnOpen();
                cmd = new SqlCommand("Select SETT_VALUE from Settings where SETT_NAME='" + "Dollar" + "'", dal.getConnection());
                dr = cmd.ExecuteReader();
                dr.Read();
                this.dollar_value = int.Parse(dr[0].ToString());
                dal.cnClose();
                return this.dollar_value;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                dal.cnClose();
                return this.dollar_value;
            }
        }

        public void setdollar(int val)
        {
            try
            {
                dal.cnOpen();
                cmd = new SqlCommand("Update Settings Set SETT_VALUE=" + val + " where SETT_NAME='Dollar'", dal.getConnection());
                dr = cmd.ExecuteReader();
                dr.Read();
                dal.cnClose();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                dal.cnClose();
            }
        }
        public int geteuro()
        {
            try
            {
                dal.cnOpen();
                cmd = new SqlCommand("Select SETT_VALUE from Settings where SETT_NAME='" + "Euro" + "'", dal.getConnection());
                dr = cmd.ExecuteReader();
                dr.Read();
                this.euro_value = int.Parse(dr[0].ToString());
                dal.cnClose();
                return this.euro_value;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                dal.cnClose();
                return this.euro_value;
            }
        }

        public void seteuro(int val)
        {
            try
            {
                dal.cnOpen();
                cmd = new SqlCommand("Update Settings Set SETT_VALUE=" + val + " where SETT_NAME='Euro'", dal.getConnection());
                dr = cmd.ExecuteReader();
                dr.Read();
                dal.cnClose();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                dal.cnClose();
            }
        }
    }
}
