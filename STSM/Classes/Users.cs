using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STSM.Classes
{
    class Users
    {
        int d;
        string m;
        DataAccessLayer dal = new DataAccessLayer();
        SqlDataReader dr;
        SqlCommand cmd;
         public void addUser(String username, int pass, String name, String perm)
        {
            dal.insertUser(username, pass, name, perm); 
        }
        public void updateUser(int id, String username, int pass, String name, String perm)
        {
            dal.updateUser(id, username,pass,name,perm); 
        }
        public void blockUser(int id)
        {
            dal.blockUser(id);
        }
        public void UnblockUser(int id)
        {
            dal.UnblockUser(id);
        }
        public DataTable select_all_user()
        {
            return (dal.selectAllUsers());
        }

        public string getUsername(int id)
        {
            try
            {
                dal.cnOpen();
                cmd = new SqlCommand("Select * From Users where U_ID=" + id + "", dal.getConnection());
                dr = cmd.ExecuteReader();
                dr.Read();
                m = dr["Username"].ToString();
            }
            catch (Exception) { 

            }
            dal.cnClose();
            return m;
        }
        public string getPassword(int id)
        {
            try
            {
                dal.cnOpen();
                cmd = new SqlCommand("Select * From Users where U_ID=" + id + "", dal.getConnection());
                dr = cmd.ExecuteReader();
                dr.Read();
                m= dr["Password"].ToString();
            }
            catch (Exception)
            {

            }
            dal.cnClose();
            return m;
        }

        public int serchUserID(string username)
        {            
            try
            {
                dal.cnOpen();
                cmd = new SqlCommand("Select * From Users where Username='" + username + "'", dal.getConnection());
                dr = cmd.ExecuteReader();
                dr.Read();
                d= int.Parse(dr["U_ID"].ToString());
            }
            catch (Exception)
            {

            }
            dal.cnClose();
            return d;
        }
    }
}
