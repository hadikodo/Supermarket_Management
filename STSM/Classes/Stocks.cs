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
    class Stocks
    {
        DataAccessLayer dal = new DataAccessLayer();
        private SqlDataAdapter da;
        private DataTable dt;
        public void add_Stocks(int barcode, int T_quantity)
        {
            dal.addStocks(barcode, T_quantity);
        }
        public void delete_Stocks_by_Id(int id)
        {
            dal.deleteStockById(id);
        }

        public void update_Stocks_By_Id(int id,int quantity)
        {
            dal.updateStockById(id, quantity);
        }
        
        public DataTable select_All_Stocks_for_Product_Id(int id)
        {
           return (dal.selectAllStocksByProductId(id));
        }

        public DataTable select_Specific_Stocks_By_Id(int id)
        {
            return (dal.selectSpecificStocksById(id));
        }

        public DataTable select_All_Stocks()
        {
            return (dal.selectAllStocks());
        }

        public void Fill_STOCK_GRID(string sql, DataGridView dataGrid)
        {
            dt = new DataTable();
            dal.cnOpen();

            if (sql is string) { }
            da = new SqlDataAdapter(sql, dal.getConnection());
            //we fill the result to dt which declared above as datatable

            try
            {
            da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    dataGrid.DataSource = dt;
                }
                else
                {
                    //MessageBox.Show("no data to view ");
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
            //then we populate the datagridview by specifying the datasource equal to dt
            dal.cnClose();
        }

       
        public void CloseConnection()
        {


            if (dal.getConnection().State == ConnectionState.Open)
            {
                dal.cnClose();
            }
        }


    }
}
