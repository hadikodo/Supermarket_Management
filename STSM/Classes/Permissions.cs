using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STSM.Classes
{
    class Permissions
    {
        DataAccessLayer dal = new DataAccessLayer();
         public void updatePermissionById(int id,String Per_Type)
        {
            dal.updatePermission(id, Per_Type);
        }

        public  DataTable getAllPermissions()
        {
            return (dal.selectAllPermissions());
        }

        public void insertPermission(String per_type)
        {
            dal.insertPermission(per_type);
        }
         public void block_permission(int id)
        {
            dal.blockPermission(id);
        }
    }
}
