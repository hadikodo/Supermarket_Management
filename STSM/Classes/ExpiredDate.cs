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
    class ExpiredDate
    {
        DataAccessLayer dal = new DataAccessLayer();
        private SqlDataReader dr;
        private DataTable dt;
        private Stocks st = new Stocks();
        private static SqlDataAdapter da = new SqlDataAdapter();
        private static SqlCommand com;
        public void add_ExpiredDate(String date, int quantity, int barcode)
        {
            dal.addExpiredDate(date, quantity, barcode); 
        }
        public void update_ExpiredDate(int pId, int quantity)
        {
            dal.cnOpen();
                com = new SqlCommand("update_expireddate", dal.getConnection());
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@P_id", pId);
                com.Parameters.AddWithValue("@qte", quantity);
            try
            {
                dr = com.ExecuteReader();
                dr.Read();
                MessageBox.Show("Insert Success , Refresh the Page");
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "There is problem", "error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            finally
            {


                dal.cnClose();
            }


            // TODO:    change from excuteReader to excute nonquery since data are retreived


        }
        public void delete_expireddate_by_id(int Ex_id, int U_id)
        {
            dal.deleteExpiredDateById(Ex_id,U_id);
        }
        public void delete_expireddate(int U_id)
        {
            dal.deleteExpiredDate(U_id);
        }
        public DataTable select_all_inactive_expireddate()
        {
            return(dal.selectAllInactiveExpireddate());
        }
        public DataTable select_specific_expireddate_by_productID(int id)
        {
            return (dal.selectSpecificExpireddatebyProduct(id));
        }
        public DataTable select_specific_expireddate_by_quantity(int quantity)
        {
            return (dal.selectSpecificExpireddatebyQuantity(quantity));
        }
        public int GET_nb(String SQL)
        {
            int RecordCount = 0;
            dal.cnOpen();
            System.Data.SqlClient.SqlCommand sqlCommand = new System.Data.SqlClient.SqlCommand(SQL);
            sqlCommand.Connection = dal.getConnection();
            try
            {
                object getnb = sqlCommand.ExecuteScalar();
                if(getnb != null)
                {
               RecordCount = Convert.ToInt32(getnb);
                }
                else
                {
                    RecordCount = -1;

                }  
            }
            catch (Exception ex)
            {
               
            }
            finally
            {
                st.CloseConnection();
                   
            }
            dal.cnClose();
            return RecordCount;
        }

        public void Delete_with_Spceific_ID(String EID)
        {

            dal.cnOpen();
            try
            {
                com = new SqlCommand("delete from ExpiredDate where ExpiredDate.Exp_ID="+EID, dal.getConnection());
                dr = com.ExecuteReader();
                dr.Read();
                MessageBox.Show("Deleted Successfully");
            }

            catch (Exception ex)
            {
                MessageBox.Show("خطا   :" + ex.Message);
            }
            finally
            {
                dal.cnClose();   
            }

        }

        public DataTable Fill_Expired_GRID(string sql, DataGridView dataGrid)
        {


            dt = new DataTable();
            dal.cnOpen();

            if (sql is string) { }
            da = new SqlDataAdapter(sql, dal.getConnection());
        

            try
            {
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    dataGrid.DataSource = dt;

                }
                else
                {
                    MessageBox.Show("No data to view Sorry ):");

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error   :" + ex.Message);
            }
            finally
            {
                dal.cnClose();
            }

            return dt;



        }

    }
}
