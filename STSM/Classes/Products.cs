using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STSM.Classes
{
    class Products
    {
        DataAccessLayer dal = new DataAccessLayer();

        public void add_Products(int barcode, String name, float sellPrice, String category)
        {
            dal.insertProduct(barcode, name, sellPrice, category);
        }
        public void update_Product(int id, float sellPrice, String category)
        {
            dal.updateProduct(id, sellPrice, category);
        }
        public Boolean block_Product(int id)
        {
           
            Boolean isAffected = (dal.blockProducts(id)) ? true : false;
            return isAffected;
        }
        public Boolean unblock_Products(int id)
        {
            Boolean isAffected = (dal.UnBlockProducts(id)) ? true : false;
            return isAffected;
        }
        public DataTable select_All_Active_Products()
        {
            return(dal.selectAllActiveProducts());
        }
        public DataTable select_All_Products()
        {
            return (dal.selectAllProducts());
        }
  //to check the existence of the id
          public int ProductExist(String barcode)
        {       


            dal.cnOpen();
            SqlCommand check_User_Name = new SqlCommand("SELECT COUNT(*) FROM Products WHERE (Barcode = @brcd)", dal.getConnection());
            check_User_Name.Parameters.AddWithValue("@brcd", barcode);
            
            int ProductExist = (int)check_User_Name.ExecuteScalar();

            dal.cnClose();
            return ProductExist;
          


        }
    }
}
