using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STSM.Classes
{
    class Categories
    {
        SqlDataReader sqlReader;
        DataAccessLayer dal = new DataAccessLayer(); 

        public void add_Category(String Cat_Name)
        {
            dal.addCategory(Cat_Name); 
        }
          public DataTable get_All_Categories()
          {
            return (dal.QueryGetall());          
          }
        public void update_Category(int id, String Category_name)
        {
            dal.updateCat_Name(id, Category_name);
        }
          public void block_Category(int id)
        {
            dal.blockCategory(id);
        }


        public Array getcat_name()
        {

            dal.cnOpen();
           
                SqlCommand sqlCmd = new SqlCommand("select Categories.Cat_Name as name from Categories", dal.getConnection());
             
         

            List<String> list = new List<String>();

            using (SqlDataReader reader = sqlCmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    list.Add(reader["name"].ToString());
                }
            }
            dal.cnClose();

            return list.ToArray();


          ;

        }
    }
}
