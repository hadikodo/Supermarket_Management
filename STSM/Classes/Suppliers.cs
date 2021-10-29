using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STSM.Classes
{
    class Suppliers
    {
        DataAccessLayer dal = new DataAccessLayer();

        public void add_Supplier(String name, int phone)
        {
            dal.addSupplier(name,phone);
        }

        public void block_Supplier(int id)
        {
            dal.blockSupplier(id);
        }

        public void update_Supplier(int id,String name,int phone)
        {
            dal.updateSupplier(id,name,phone);
        }

        public DataTable Select_All_Suppliers()
        {
            return (dal.selectAllSuppliers());
        }
    }
}
