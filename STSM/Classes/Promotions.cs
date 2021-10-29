using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace STSM.Classes
{
    class Promotions
    {
        private DataAccessLayer dal = new DataAccessLayer();
        private SqlDataReader dr;
        private SqlCommand cmd;
        private int pro_count;

        public void add_Promotions(String description)
        {
            dal.addPromotions(description);
        }
        public DataTable select_Promotions_By_Id(int Promotion_Id)
        {
            return (dal.selectPromotions(Promotion_Id));
        }
        public DataTable select_All_Promotions()
        {
            return (dal.selectAllPromotions());
        }

        public void enable_pro(int pro_id)
        {
            try
            {
                dal.cnOpen();
                cmd = new SqlCommand("Update Promotions set Pro_Active=1 where Pro_ID=" + pro_id + "", dal.getConnection());
                dr = cmd.ExecuteReader();
                dr.Read();
                dal.cnClose();
            }
            catch (Exception)
            {
                MessageBox.Show("there is an error in Promotions");
                dal.cnClose();
            }
            
        }

        public void getpro_count()
        {
            try
            {
                dal.cnOpen();
                cmd = new SqlCommand("Select count(Pro_ID) from Promotions", dal.getConnection());
                dr = cmd.ExecuteReader();
                dr.Read();
                this.pro_count = int.Parse(dr[0].ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("there is an error in Promotions");
                dal.cnClose();
            }
        }

        public int getlastpro_id()
        {
            int f;
            try
            {
                dal.cnOpen();
                cmd = new SqlCommand("Select  Max(Pro_ID) from Promotions", dal.getConnection());
                dr = cmd.ExecuteReader();
                dr.Read();               
                f= int.Parse(dr[0].ToString());
                dal.cnClose();
                return f;
            }
            catch (Exception)
            {
                MessageBox.Show("there is an error in Promotions");
                dal.cnClose();
                return 0;
            }
            
        }

        public void disable_pro(int pro_id)
        {
            try
            {
                dal.cnOpen();
                cmd = new SqlCommand("Update Promotions set Pro_Active=0 where Pro_ID=" + pro_id + "", dal.getConnection());
                dr = cmd.ExecuteReader();
                dr.Read();
                dal.cnClose();
            }
            catch (Exception)
            {
                MessageBox.Show("there is an error in Promotions");
                dal.cnClose();
            }
            
        }

        public void enable_pro_all()
        {
            for (int i =1 ; i <= getlastpro_id(); i++)
            {
                try
                {
                    dal.cnOpen();
                    cmd = new SqlCommand("Update Promotions set Pro_Active=1 where Pro_ID=" + i + "", dal.getConnection());
                    dr = cmd.ExecuteReader();
                    dr.Read();
                    dal.cnClose();
                }
                catch (Exception)
                {
                    MessageBox.Show("there is an error in Promotions");
                    dal.cnClose();
                }
                
            }
        }

        public void disable_pro_all()
        {
            for (int i = 1; i <= getlastpro_id(); i++)
            {
                try
                {
                    dal.cnOpen();
                    cmd = new SqlCommand("Update Promotions set Pro_Active=0 where Pro_ID=" + i + "", dal.getConnection());
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
}
