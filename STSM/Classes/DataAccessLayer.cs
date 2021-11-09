using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace STSM.Classes
{
    class DataAccessLayer
    {
        /// <summary>
        /// ////////////////////Connections////////////////////////////////
        /// </summary>
        private static String conString = "Data Source=AYkudo;Initial Catalog=STSM_DB;Integrated Security=True"; 
        private  SqlConnection sqlconn = new SqlConnection(conString);
        private  DataSet ds = new DataSet();    
        private  SqlDataAdapter da = new SqlDataAdapter();
        private  SqlCommand com ;
        private  SqlDataReader dr;
        public void cnOpen()
        {
            try
            {
                sqlconn.Open();
            }
            catch (Exception ex)
            {

            }
        }

        public void cnClose()
        {
            sqlconn.Close();
        }
        ///////////////////////////////////////////////////////////////////////


        ////////////////////////Common Methods/////////////////////////////////// 
        
        public DataTable fillTableQuery(String query)
        {
            DataAccessLayer copen = new DataAccessLayer(); 
            copen.cnOpen();
            da.SelectCommand = new SqlCommand(query, sqlconn);
            ds.Clear();
            da.Fill(ds);
            DataTable ds1 = ds.Tables[0];
             
            return ds1;
        }
        public string getconnectionstring()
        {
            return conString;
        }
        public void customQuery(String query)
        {
            DataAccessLayer copen = new DataAccessLayer();
            com = new SqlCommand(query, sqlconn);

            try
            {
                copen.cnOpen();
                SqlDataReader dr = com.ExecuteReader();
                dr.Close();
                
            }
            catch(SqlException e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                 
            }
        }

        public SqlConnection getConnection()
        {
            return sqlconn;
        }
        public String getconString()
        {
            return conString;
        }

        /// /////////////////////////////////////////////////////////////////////////////////////////

        //////////////////////////////////Categories Methods////////////////////////////////////////

        public void addCategory(String s)
        {
                DataAccessLayer copen = new DataAccessLayer();
                copen.cnOpen();
                com = new SqlCommand("add_categories", sqlconn);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@cate_name", s);
                dr = com.ExecuteReader();
                dr.Close();
                 
        }

        public void updateCat_Name(int id, String category_name)
        {
                DataAccessLayer copen = new DataAccessLayer();
                copen.cnOpen();
                com = new SqlCommand("update_categories", sqlconn);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@id", id);
                com.Parameters.AddWithValue("@name_cat", category_name);
                dr = com.ExecuteReader();
                dr.Close();
                 
        }

        public DataTable QueryGetall()
        {
            DataAccessLayer copen = new DataAccessLayer();
            copen.cnOpen();
            com = new SqlCommand("select_all_categories", sqlconn);
            com.CommandType = CommandType.StoredProcedure;
            da.SelectCommand = com;
            ds.Clear();
            da.Fill(ds);
            DataTable ds1 = ds.Tables[0];
             
            return ds1;
        }

        public void blockCategory(int i)
        {
            DataAccessLayer copen = new DataAccessLayer();
            copen.cnOpen();
            com = new SqlCommand("block_categories", sqlconn);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@id", i);
            dr = com.ExecuteReader();
            dr.Close();
             
        }

        //////////////////////////////////////////////////////////////////////////////////////////////

        //////////////////////////////////////////Stocks Methods/////////////////////////////////////
        public void addStocks(int i, int s)
        {
            DataAccessLayer copen = new DataAccessLayer();
                copen.cnOpen();
                com = new SqlCommand("add_stocks", sqlconn);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@barcode", i);
                com.Parameters.AddWithValue("@T_qte", s);
                dr = com.ExecuteReader();
                
            
        }

        public void deleteStockById(int id)
        {
            DataAccessLayer copen = new DataAccessLayer();
            copen.cnOpen();
            com = new SqlCommand("delete_stocks", sqlconn);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@id", id);
            dr = com.ExecuteReader();
        }

        public void updateStockById(int i, int s)
        {
            try
            {
                DataAccessLayer copen = new DataAccessLayer();
                copen.cnOpen();
                com = new SqlCommand("update_stocks", sqlconn);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@id", i);
                com.Parameters.AddWithValue("@qte", s);
                dr = com.ExecuteReader();
            }catch(Exception ex)
            {

            }
        }

        public DataTable selectAllStocksByProductId(int id)
        {
            DataAccessLayer copen = new DataAccessLayer();
            copen.cnOpen();
            com = new SqlCommand("select_all_stocks_for_product", sqlconn);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@id_p", id);
            da.SelectCommand = com;
            ds.Clear();
            da.Fill(ds);
            DataTable ds1 = ds.Tables[0];
             
            return ds1;
        }

        public DataTable selectSpecificStocksById(int id)
        {
            DataAccessLayer copen = new DataAccessLayer();
            copen.cnOpen();
            com = new SqlCommand("select_specific_stocks", sqlconn);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@id_s", id);
            da.SelectCommand = com;
            ds.Clear();
            da.Fill(ds);
            DataTable ds1 = ds.Tables[0];
             
            return ds1;
        }

        public DataTable selectAllStocks()
        {
            DataAccessLayer copen = new DataAccessLayer();
            copen.cnOpen();
            com = new SqlCommand("select_all_stocks", sqlconn);
            com.CommandType = CommandType.StoredProcedure;
            da.SelectCommand = com;
            ds.Clear();
            da.Fill(ds);
            DataTable ds1 = ds.Tables[0];
             
            return ds1;
        }
        ////////////////////////////////////////////////////////////////////////////////////////////////

        ////////////////////////////////////////Suppliers Methods//////////////////////////////////////

        public void addSupplier(String i, int s)
        {
            DataAccessLayer copen = new DataAccessLayer();
            copen.cnOpen();
            com = new SqlCommand("add_suppliers", sqlconn);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@name", i);
            com.Parameters.AddWithValue("@phone", s);
            dr = com.ExecuteReader();
             

        }

        public void blockSupplier(int id)
        {
            DataAccessLayer copen = new DataAccessLayer();
            copen.cnOpen();
            com = new SqlCommand("block_suppliers", sqlconn);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@id", id);
            dr = com.ExecuteReader();
            dr.Close();
             
        }

        public void updateSupplier(int i,String n, int s)
        {
            DataAccessLayer copen = new DataAccessLayer();
            copen.cnOpen();
            com = new SqlCommand("update_suppliers", sqlconn);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@id", i);
            com.Parameters.AddWithValue("@name", n);
            com.Parameters.AddWithValue("@phone", s);
            dr = com.ExecuteReader();
            dr.Close();
             

        }

        public DataTable selectAllSuppliers()
        {
      
            DataAccessLayer copen = new DataAccessLayer();
            copen.cnOpen();
            com = new SqlCommand("select_all_suppliers", sqlconn);
            com.CommandType = CommandType.StoredProcedure;
            da.SelectCommand = com;
            ds.Clear();
            da.Fill(ds);
            DataTable ds1 = ds.Tables[0];
             
            return ds1;
        }
        ////////////////////////////////////////////////////////////////////////////////////////////

        ////////////////////////////Permissions Methods////////////////////////////////////////////
        public void updatePermission(int id, String Per_type)
        {
            DataAccessLayer copen = new DataAccessLayer();
            copen.cnOpen();
                com = new SqlCommand("update_permission", sqlconn);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@id", id);
                com.Parameters.AddWithValue("@Per_type", Per_type);
                dr = com.ExecuteReader();
                dr.Close();
                             
        }

        public void insertPermission(String PerType )
        {
            DataAccessLayer copen = new DataAccessLayer();
            copen.cnOpen();
            com = new SqlCommand("add_permission", sqlconn);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@per_type", PerType);
            dr = com.ExecuteReader();
            dr.Close();
             
        }

        public void blockPermission(int id)
        {
            DataAccessLayer copen = new DataAccessLayer();
            copen.cnOpen();
            com = new SqlCommand("block_permission", sqlconn);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@id", id);
            dr = com.ExecuteReader();
            dr.Close();
             
        }


        public DataTable selectAllPermissions()
        {

            DataAccessLayer copen = new DataAccessLayer();
            copen.cnOpen();
            com = new SqlCommand("select_all_permission", sqlconn);
            com.CommandType = CommandType.StoredProcedure;
            da.SelectCommand = com;
            ds.Clear();
            da.Fill(ds);
            DataTable ds1 = ds.Tables[0];
             
            return ds1;
        }
        ////////////////////////////////////////////////////////////////////////////////////////////////

        ////////////////////////////////////////Users Methods//////////////////////////////////////

        public void insertUser(String username,int pass,String name,String perm)
        {
            DataAccessLayer copen = new DataAccessLayer();
            copen.cnOpen();
            com = new SqlCommand("add_user", sqlconn);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@username", username);
            com.Parameters.AddWithValue("@pass", pass);
            com.Parameters.AddWithValue("@name", name);
            com.Parameters.AddWithValue("@permission", perm);
            dr = com.ExecuteReader();
            dr.Close();
             
        }

        public void updateUser(int id, String username,int pass,String name,String perm)
        {
                DataAccessLayer copen = new DataAccessLayer();
                copen.cnOpen();
                com = new SqlCommand("update_user", sqlconn);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@id", id);
                com.Parameters.AddWithValue("@username", username);
                com.Parameters.AddWithValue("@pass", pass);
                com.Parameters.AddWithValue("@name", name);
                com.Parameters.AddWithValue("@permission", perm);
                dr = com.ExecuteReader();
                dr.Close();
        }

        public void blockUser(int id)
        {
            DataAccessLayer copen = new DataAccessLayer();
            copen.cnOpen();
            com = new SqlCommand("block_user", sqlconn);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@id", id);
            dr = com.ExecuteReader();
            dr.Close();
             
        }
        public void UnblockUser(int id)
        {
            DataAccessLayer copen = new DataAccessLayer();
            copen.cnOpen();
            com = new SqlCommand("unblock_user", sqlconn);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@id", id);
            dr = com.ExecuteReader();
            dr.Close();
             
        }

        public DataTable selectAllUsers()
        {

            DataAccessLayer copen = new DataAccessLayer();
            copen.cnOpen();
            com = new SqlCommand("select_all_user", sqlconn);
            com.CommandType = CommandType.StoredProcedure;
            da.SelectCommand = com;
            ds.Clear();
            da.Fill(ds);
            DataTable ds1 = ds.Tables[0];
             
            return ds1;
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////

        ////////////////////////////////////////Products Methods//////////////////////////////////////

        public void insertProduct(int barcode,String name,float sellPrice,String category)
        {
            DataAccessLayer copen = new DataAccessLayer();
            copen.cnOpen();
            com = new SqlCommand("add_products", sqlconn);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@barcode", barcode);
            com.Parameters.AddWithValue("@name", name);
            com.Parameters.AddWithValue("@sell_price", sellPrice);
            com.Parameters.AddWithValue("@categories", category);
            dr = com.ExecuteReader();
            dr.Close();
             
        }

        public void updateProduct(int id, float sellPrice, String category)
        {
            cnOpen();
            com = new SqlCommand("update_products", sqlconn);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@id", id);
            com.Parameters.AddWithValue("@sell_price", sellPrice);
            com.Parameters.AddWithValue("@categories", category);
            dr = com.ExecuteReader();
            dr.Read();
            dr.Close();
            cnClose();
        }

        public Boolean  blockProducts(int id)
        {
            cnOpen();
            try
            {                           
                com = new SqlCommand("block_products "+id+"", sqlconn);
                dr = com.ExecuteReader();
                dr.Read();
                dr.Close();
                cnClose();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                cnClose();
                return false;
            }            
        }

        public Boolean UnBlockProducts(int id)
        {
            cnOpen();
            try
            {
                com = new SqlCommand("unblock_products", sqlconn);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@id", id);
                dr = com.ExecuteReader();
                dr.Close();
                cnClose();
                return true;
            }catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
                cnClose();
                return false;
            }
        }

        public DataTable selectAllActiveProducts()
        {
            
            DataAccessLayer copen = new DataAccessLayer();
            copen.cnOpen();
            com = new SqlCommand("select_all_active_products", sqlconn);
            com.CommandType = CommandType.StoredProcedure;
            da.SelectCommand = com;
            ds.Clear();
            da.Fill(ds);
            DataTable ds1 = ds.Tables[0];
             
            return ds1;
        }

        public DataTable selectAllActiveExpiredDate()
        {

            DataAccessLayer copen = new DataAccessLayer();
            copen.cnOpen();
            com = new SqlCommand("select_all_active_expireddate", sqlconn);
            com.CommandType = CommandType.StoredProcedure;
            da.SelectCommand = com;
            ds.Clear();
            da.Fill(ds);
            DataTable ds1 = ds.Tables[0];
            return ds1;
        }

        public DataTable selectAllProducts()
        {
            DataAccessLayer copen = new DataAccessLayer();
            copen.cnOpen();
            com = new SqlCommand("select_all_products", sqlconn);
            com.CommandType = CommandType.StoredProcedure;
            da.SelectCommand = com;
            ds.Clear();
            da.Fill(ds);
            DataTable ds1 = ds.Tables[0];
             
            return ds1;


        }

        ////////////////////////////////////////////////////////////////////////////////////////////////

        ////////////////////////////////////////Expired_date Methods//////////////////////////////////////

        public void addExpiredDate(String date,int quantity,int barcode)
        {
            DataAccessLayer copen = new DataAccessLayer();
            copen.cnOpen();
            com = new SqlCommand("add_expireddate", sqlconn);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@exp_date",date) ;
            com.Parameters.AddWithValue("@qte", quantity);
            com.Parameters.AddWithValue("@p_barcode", barcode);
            dr = com.ExecuteReader();
            // TODO:    change from excuteReader to excute nonquery since data are retreived
            dr.Close();
             
        }

        public void updateExpiredDate(int pId,int quantity)
        {
            DataAccessLayer copen = new DataAccessLayer();
            copen.cnOpen();
            com = new SqlCommand("update_expireddate", sqlconn);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@P_id", pId);
            com.Parameters.AddWithValue("@qte", quantity);
            dr = com.ExecuteReader();
            dr.Close();
             
        }

        public void deleteExpiredDateById(int id,int U_id)
        {
            DataAccessLayer copen = new DataAccessLayer();
            copen.cnOpen();
            com = new SqlCommand("delete_expireddate_by_id", sqlconn);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@id_exp", id);
            com.Parameters.AddWithValue("@id_user", U_id);
            dr = com.ExecuteReader();
            dr.Close();
             
        }

        public void deleteExpiredDate(int U_id)
        {
            DataAccessLayer copen = new DataAccessLayer();
            copen.cnOpen();
            com = new SqlCommand("delete_all_expireddate", sqlconn);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@id_user", U_id);
            dr = com.ExecuteReader();
            dr.Close();
             
        }

        public DataTable selectAllInactiveExpireddate()
        {

            DataAccessLayer copen = new DataAccessLayer();
            copen.cnOpen();
            com = new SqlCommand("select_all_inactive_expireddate", sqlconn);
            com.CommandType = CommandType.StoredProcedure;
            da.SelectCommand = com;
            ds.Clear();
            da.Fill(ds);
            DataTable ds1 = ds.Tables[0];
             
            return ds1;

        }

        public DataTable selectSpecificExpireddatebyProduct(int id)
        {
            DataAccessLayer copen = new DataAccessLayer();
            copen.cnOpen();
            com = new SqlCommand("select_specific_expireddate_by_product", sqlconn);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@p_id", id);
            da.SelectCommand = com;
            ds.Clear();
            da.Fill(ds);
            DataTable ds1 = ds.Tables[0];
             
            return ds1;
        }

        public DataTable selectSpecificExpireddatebyQuantity(int quantity)
        {
            DataAccessLayer copen = new DataAccessLayer();
            copen.cnOpen();
            com = new SqlCommand("select_specific_expireddate_by_qte", sqlconn);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@qte", quantity);
            da.SelectCommand = com;
            ds.Clear();
            da.Fill(ds);
            DataTable ds1 = ds.Tables[0];
             
            return ds1;
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////

        ////////////////////////////////////////Order Methods//////////////////////////////////////

        public void addOrder( int Uid)
        {
            DataAccessLayer copen = new DataAccessLayer();
            copen.cnOpen();
            com = new SqlCommand("add_orders", sqlconn);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@user_id", Uid);
            dr = com.ExecuteReader();
            dr.Close();
             
        }

        public void blockOrder(int id)
        {
            DataAccessLayer copen = new DataAccessLayer();
            copen.cnOpen();
            com = new SqlCommand("block_orders", sqlconn);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@O_id", id);
            dr = com.ExecuteReader();
            dr.Close();
             
        }

        public void holdOrder(int id)
        {
            DataAccessLayer copen = new DataAccessLayer();
            copen.cnOpen();
            com = new SqlCommand("sp_set_order_hold", sqlconn);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@order_id", id);
            dr = com.ExecuteReader();
            dr.Close();
        }

        public void inholdOrder(int id)
        {
            DataAccessLayer copen = new DataAccessLayer();
            copen.cnOpen();
            com = new SqlCommand("sp_set_order_inhold", sqlconn);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@order_id", id);
            dr = com.ExecuteReader();
            dr.Close();
        }

        public Boolean isHolded(int id)
        {
            Boolean res;
            DataAccessLayer copen = new DataAccessLayer();
            copen.cnOpen();
            com = new SqlCommand("select dbo.isHold(@order_id)", sqlconn);
            com.Parameters.AddWithValue("@order_id", id);
            res = (bool)com.ExecuteScalar();
            return res;
        }


        public DataTable selectAllOrdersforUserId(int Uid)
        {
            DataAccessLayer copen = new DataAccessLayer();
            copen.cnOpen();
            com = new SqlCommand("select_all_orders_for_user", sqlconn);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@id_user", Uid);
            da.SelectCommand = com;
            ds.Clear();
            da.Fill(ds);
            DataTable ds1 = ds.Tables[0];
             
            return ds1;
        }

        public DataTable selectSpecificOrder(int Oid)
        {
            DataAccessLayer copen = new DataAccessLayer();
            copen.cnOpen();
            com = new SqlCommand("select_specific_orders", sqlconn);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@id_o", Oid);
            da.SelectCommand = com;
            ds.Clear();
            da.Fill(ds);
            DataTable ds1 = ds.Tables[0];
             
            return ds1;
        }

        public DataTable selectAllOrders()
        {
            DataAccessLayer copen = new DataAccessLayer();
            copen.cnOpen();
            com = new SqlCommand("select_all_orders", sqlconn);
            com.CommandType = CommandType.StoredProcedure;
            da.SelectCommand = com;
            ds.Clear();
            da.Fill(ds);
            DataTable ds1 = ds.Tables[0];
             
            return ds1;

        }
        ////////////////////////////////////////////////////////////////////////////////////////////////

        ////////////////////////////////////////Order_Details Methods//////////////////////////////////////

        public void addOrderDetails(int Oid,int Pid,int qte,int item_price,int total_price)
        {
            DataAccessLayer copen = new DataAccessLayer();
            copen.cnOpen();
            com = new SqlCommand("sp_AddOrderDetails", sqlconn);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@order_id", Oid);
            com.Parameters.AddWithValue("@p_id", Pid);
            com.Parameters.AddWithValue("@qte", qte);
            com.Parameters.AddWithValue("@item_p", item_price);
            com.Parameters.AddWithValue("@total_price", total_price);
            dr = com.ExecuteReader();
            dr.Close();  
        }

        public void updateQteOrderDetails(int Oid, int Pid, int qte)
        {
            DataAccessLayer copen = new DataAccessLayer();
            copen.cnOpen();
            com = new SqlCommand("sp_updateQteOrderDetails", sqlconn);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@o_id", Oid);
            com.Parameters.AddWithValue("@p_id", Pid);
            com.Parameters.AddWithValue("@qte", qte);
            dr = com.ExecuteReader();
            dr.Close();
        }

        public Boolean checkIfOrderDetailsExist(int o_id, int p_id)
        {
            Boolean res;
            DataAccessLayer copen = new DataAccessLayer();
            copen.cnOpen();
            com = new SqlCommand("select dbo.checkIfOrderDetailsExist(@o_id,@p_id)", sqlconn);
            com.Parameters.AddWithValue("@o_id", o_id);
            com.Parameters.AddWithValue("@p_id", p_id);
            res = (bool)com.ExecuteScalar();
            return res;
        }

        public void removeOrderDetailsByID(int Oid)
        {
            DataAccessLayer copen = new DataAccessLayer();
            copen.cnOpen();
            com = new SqlCommand("sp_removeOrderDetailsByID", sqlconn);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@order_id", Oid);
            dr = com.ExecuteReader();
            dr.Close();
        }

        public DataTable selectOrderDetailsForProduct(int Odid)
        {
            DataAccessLayer copen = new DataAccessLayer();
            copen.cnOpen();
            com = new SqlCommand("select_all_orders_details_for_product", sqlconn);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@id_p", Odid);
            da.SelectCommand = com;
            ds.Clear();
            da.Fill(ds);
            DataTable ds1 = ds.Tables[0];
             
            return ds1;
        }

        public DataTable selectOrderDetailsForOrder(int Oid)
        {
            DataAccessLayer copen = new DataAccessLayer();
            copen.cnOpen();
            com = new SqlCommand("select_orders_details_for_orders", sqlconn);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@id_o", Oid);
            da.SelectCommand = com;
            ds.Clear();
            da.Fill(ds);
            DataTable ds1 = ds.Tables[0];
             
            return ds1;
        }

        public DataTable selectAllOrdersDetails()
        {
            DataAccessLayer copen = new DataAccessLayer();
            copen.cnOpen();
            com = new SqlCommand("select_all_orders_details", sqlconn);
            com.CommandType = CommandType.StoredProcedure;
            da.SelectCommand = com;
            ds.Clear();
            da.Fill(ds);
            DataTable ds1 = ds.Tables[0];
             
            return ds1;
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////

        ////////////////////////////////////////Currency Methods//////////////////////////////////////

        public void addCurrency(String name, int v, int en)
        {
            DataAccessLayer copen = new DataAccessLayer();
            copen.cnOpen();
            com = new SqlCommand("add_currency", sqlconn);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@name", name);
            com.Parameters.AddWithValue("@value", v);
            com.Parameters.AddWithValue("@enabled", en);
            dr = com.ExecuteReader();
            dr.Close();
             
        }

        public DataTable selectCurrencyById(int Cid)
        {
            DataAccessLayer copen = new DataAccessLayer();
            copen.cnOpen();
            com = new SqlCommand("select_currency", sqlconn);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@id_cur", Cid);
            da.SelectCommand = com;
            ds.Clear();
            da.Fill(ds);
            DataTable ds1 = ds.Tables[0];
             
            return ds1;
        }

        public DataTable selectCurrencyByEnabled(int Enid)
        {
            DataAccessLayer copen = new DataAccessLayer();
            copen.cnOpen();
            com = new SqlCommand("select_currency_en", sqlconn);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@enabled", Enid);
            da.SelectCommand = com;
            ds.Clear();
            da.Fill(ds);
            DataTable ds1 = ds.Tables[0];
             
            return ds1;
        }
        public DataTable selectAllCurrencies()
        {

            DataAccessLayer copen = new DataAccessLayer();
            copen.cnOpen();
            com = new SqlCommand("select_all_currency", sqlconn);
            com.CommandType = CommandType.StoredProcedure;
            da.SelectCommand = com;
            ds.Clear();
            da.Fill(ds);
            DataTable ds1 = ds.Tables[0];
             
            return ds1;
        }


        ////////////////////////////////////////////////////////////////////////////////////////////////

        ////////////////////////////////////////Languages Methods//////////////////////////////////////

        public void addLanguages(String name)
        {
            DataAccessLayer copen = new DataAccessLayer();
            copen.cnOpen();
            com = new SqlCommand("add_languages", sqlconn);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@name", name);
            dr = com.ExecuteReader();
            dr.Close();
             
        }
        public DataTable selectLanguageById(int Lid)
        {
            DataAccessLayer copen = new DataAccessLayer();
            copen.cnOpen();
            com = new SqlCommand("select_languages", sqlconn);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@id_lang", Lid);
            da.SelectCommand = com;
            ds.Clear();
            da.Fill(ds);
            DataTable ds1 = ds.Tables[0];
             
            return ds1;
        }

        public DataTable selectEnabledLanguage()
        {
            DataAccessLayer copen = new DataAccessLayer();
            copen.cnOpen();
            com = new SqlCommand("select_languages_enabled", sqlconn);
            com.CommandType = CommandType.StoredProcedure;
            da.SelectCommand = com;
            ds.Clear();
            da.Fill(ds);
            DataTable ds1 = ds.Tables[0];
             
            return ds1;
        }

        public DataTable selectAllLanguages()
        {

            DataAccessLayer copen = new DataAccessLayer();
            copen.cnOpen();
            com = new SqlCommand("select_all_languages", sqlconn);
            com.CommandType = CommandType.StoredProcedure;
            da.SelectCommand = com;
            ds.Clear();
            da.Fill(ds);
            DataTable ds1 = ds.Tables[0];
             
            return ds1;
        }

        public void setLanguageEnabled(int LId)
        {
            DataAccessLayer copen = new DataAccessLayer();
            copen.cnOpen();
            com = new SqlCommand("set_language_enabled", sqlconn);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@id_lang", LId);
            dr = com.ExecuteReader();
            dr.Close();
             
        }
        ////////////////////////////////////////////////////////////////////////////////////////////////

        ////////////////////////////////////////Requests Methods//////////////////////////////////////

        public void addRequests(int supp_id)
        {
            DataAccessLayer copen = new DataAccessLayer();
            copen.cnOpen();
            com = new SqlCommand("add_requests", sqlconn);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@sup_id", supp_id);
            dr = com.ExecuteReader();
            dr.Close();
             
        }
        public void blockRequest(int req_id)
        {
            DataAccessLayer copen = new DataAccessLayer();
            copen.cnOpen();
            com = new SqlCommand("block_requests", sqlconn);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@Req_id", req_id);
            dr = com.ExecuteReader();
            dr.Close();
             
        }
        public DataTable selectAllRequestsforSupplier(int supp_id)
        {
            DataAccessLayer copen = new DataAccessLayer();
            copen.cnOpen();
            com = new SqlCommand("select_all_requests_for_supplier", sqlconn);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@id_sup", supp_id);
            da.SelectCommand = com;
            ds.Clear();
            da.Fill(ds);
            DataTable ds1 = ds.Tables[0];
             
            return ds1;
        }
      
        public DataTable selectSpecificRequests(int req_id)
        {
            DataAccessLayer copen = new DataAccessLayer();
            copen.cnOpen();
            com = new SqlCommand("select_specific_requests", sqlconn);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@id_req", req_id);
            da.SelectCommand = com;
            ds.Clear();
            da.Fill(ds);
            DataTable ds1 = ds.Tables[0];
             
            return ds1;
        }
        public DataTable selectAllRequests()
        {

            DataAccessLayer copen = new DataAccessLayer();
            copen.cnOpen();
            com = new SqlCommand("select_all_requests", sqlconn);
            com.CommandType = CommandType.StoredProcedure;
            da.SelectCommand = com;
            ds.Clear();
            da.Fill(ds);
            DataTable ds1 = ds.Tables[0];
             
            return ds1;
        }
        ////////////////////////////////////////////////////////////////////////////////////////////////

        ////////////////////////////////////////Requests_Details Methods//////////////////////////////////////
        public void addRequestDetails(int req_id,int P_Id,int qte)
        {
            DataAccessLayer copen = new DataAccessLayer();
            copen.cnOpen();
            com = new SqlCommand("add_requests_details", sqlconn);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@req_id", req_id);
            com.Parameters.AddWithValue("@p_id", P_Id);
            com.Parameters.AddWithValue("@qte", qte);
            dr = com.ExecuteReader();
            dr.Close();
             
        }

        public DataTable selectallrequestsdetailsforproduct(int P_id)
        {
            DataAccessLayer copen = new DataAccessLayer();
            copen.cnOpen();
            com = new SqlCommand("select_all_requests_details_for_product", sqlconn);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@id_p", P_id);
            da.SelectCommand = com;
            ds.Clear();
            da.Fill(ds);
            DataTable ds1 = ds.Tables[0];
             
            return ds1;
        }
        public DataTable selectrequestsdetailsforrequests(int req_id)
        {
            DataAccessLayer copen = new DataAccessLayer();
            copen.cnOpen();
            com = new SqlCommand("select_requests_details_for_requests", sqlconn);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@id_req", req_id);
            da.SelectCommand = com;
            ds.Clear();
            da.Fill(ds);
            DataTable ds1 = ds.Tables[0];
             
            return ds1;
        }
        public DataTable selectallrequestsdetails()
        {
            DataAccessLayer copen = new DataAccessLayer();
            copen.cnOpen();
            com = new SqlCommand("select_all_requests_details", sqlconn);
            com.CommandType = CommandType.StoredProcedure;
            da.SelectCommand = com;
            ds.Clear();
            da.Fill(ds);
            DataTable ds1 = ds.Tables[0];
             
            return ds1;
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////

        ////////////////////////////////////////Return Methods//////////////////////////////////////

        public void addReturn(int U_id)
        {
            DataAccessLayer copen = new DataAccessLayer();
            copen.cnOpen();
            com = new SqlCommand("add_return", sqlconn);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@user_id", U_id);
            dr = com.ExecuteReader();
            dr.Close();
             
        }
        public void blockReturn(int r_id)
        {
            DataAccessLayer copen = new DataAccessLayer();
            copen.cnOpen();
            com = new SqlCommand("block_return", sqlconn);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@R_id", r_id);
            dr = com.ExecuteReader();
            dr.Close();
             
        }
        public DataTable selectAllReturnforUser(int U_id)
        {
            DataAccessLayer copen = new DataAccessLayer();
            copen.cnOpen();
            com = new SqlCommand("select_all_return_for_user", sqlconn);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@id_user", U_id);
            da.SelectCommand = com;
            ds.Clear();
            da.Fill(ds);
            DataTable ds1 = ds.Tables[0];
             
            return ds1;
        }
        public DataTable selectSpecificReturn(int r_id)
        {
            DataAccessLayer copen = new DataAccessLayer();
            copen.cnOpen();
            com = new SqlCommand("select_specific_return", sqlconn);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@id_r", r_id);
            da.SelectCommand = com;
            ds.Clear();
            da.Fill(ds);
            DataTable ds1 = ds.Tables[0];
             
            return ds1;
        }

        public DataTable selectAllReturns()
        {

            DataAccessLayer copen = new DataAccessLayer();
            copen.cnOpen();
            com = new SqlCommand("select_all_returns", sqlconn);
            com.CommandType = CommandType.StoredProcedure;
            da.SelectCommand = com;
            ds.Clear();
            da.Fill(ds);
            DataTable ds1 = ds.Tables[0];
             
            return ds1;
        }
        ////////////////////////////////////////////////////////////////////////////////////////////////

        ////////////////////////////////////////Return_Details Methods//////////////////////////////////////

        public void addReturnDetails(int r_id,int p_id,int qte)
        {
            DataAccessLayer copen = new DataAccessLayer();
            copen.cnOpen();
            com = new SqlCommand("add_return_details", sqlconn);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@r_id", r_id);
            com.Parameters.AddWithValue("@p_id", p_id);
            com.Parameters.AddWithValue("@qte", qte);
            dr = com.ExecuteReader();
            dr.Close();
             
        }
        public DataTable selectAllReturnDetailsforProduct(int p_id)
        {
            DataAccessLayer copen = new DataAccessLayer();
            copen.cnOpen();
            com = new SqlCommand("select_all_return_details_for_product", sqlconn);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@id_p", p_id);
            da.SelectCommand = com;
            ds.Clear();
            da.Fill(ds);
            DataTable ds1 = ds.Tables[0];
             
            return ds1;
        }
        public DataTable selectReturnDetailsforReturn(int r_id)
        {
            DataAccessLayer copen = new DataAccessLayer();
            copen.cnOpen();
            com = new SqlCommand("select_return_details_for_return", sqlconn);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@id_r", r_id);
            da.SelectCommand = com;
            ds.Clear();
            da.Fill(ds);
            DataTable ds1 = ds.Tables[0];
             
            return ds1;
        }
        public DataTable selectAllReturnDetails()
        {

            DataAccessLayer copen = new DataAccessLayer();
            copen.cnOpen();
            com = new SqlCommand("select_all_return_details", sqlconn);
            com.CommandType = CommandType.StoredProcedure;
            da.SelectCommand = com;
            ds.Clear();
            da.Fill(ds);
            DataTable ds1 = ds.Tables[0];
             
            return ds1;
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////

        ////////////////////////////////////////Notes Methods//////////////////////////////////////
        public void addNotes(String desc)
        {
            DataAccessLayer copen = new DataAccessLayer();
            copen.cnOpen();
            com = new SqlCommand("add_notes", sqlconn);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@desc", desc);
            dr = com.ExecuteReader();
            dr.Close();
             
        }
        public DataTable selectNotes(int n_id)
        {
            DataAccessLayer copen = new DataAccessLayer();
            copen.cnOpen();
            com = new SqlCommand("select_notes", sqlconn);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@id_note", n_id);
            da.SelectCommand = com;
            ds.Clear();
            da.Fill(ds);
            DataTable ds1 = ds.Tables[0];
             
            return ds1;
        }
        public DataTable selectAllNotes()
        {

            DataAccessLayer copen = new DataAccessLayer();
            copen.cnOpen();
            com = new SqlCommand("select_all_notes", sqlconn);
            com.CommandType = CommandType.StoredProcedure;
            da.SelectCommand = com;
            ds.Clear();
            da.Fill(ds);
            DataTable ds1 = ds.Tables[0];
             
            return ds1;
        }


        ////////////////////////////////////////////////////////////////////////////////////////////////

        ////////////////////////////////////////Promotions Methods//////////////////////////////////////

        public void addPromotions(String desc)
        {
            DataAccessLayer copen = new DataAccessLayer();
            copen.cnOpen();
            com = new SqlCommand("add_promotions", sqlconn);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@desc", desc);
            dr = com.ExecuteReader();
            dr.Close();
             
        }
        public DataTable selectPromotions(int Promo_id)
        {
            DataAccessLayer copen = new DataAccessLayer();
            copen.cnOpen();
            com = new SqlCommand("select_promotions", sqlconn);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@id_pro", Promo_id);
            da.SelectCommand = com;
            ds.Clear();
            da.Fill(ds);
            DataTable ds1 = ds.Tables[0];
             
            return ds1;
        }
        public DataTable selectAllPromotions()
        {
            DataAccessLayer copen = new DataAccessLayer();
            copen.cnOpen();
            com = new SqlCommand("select_all_promotions", sqlconn);
            com.CommandType = CommandType.StoredProcedure;
            da.SelectCommand = com;
            ds.Clear();
            da.Fill(ds);
            DataTable ds1 = ds.Tables[0];
             
            return ds1;
        }

       
    }
}

