using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STSM.Classes
{
    class Orders
    {
        DataAccessLayer dal = new DataAccessLayer();

        public void add_Order(int Order_Id)
        {
            dal.addOrder(Order_Id);
        }
        public void block_Order(int Order_Id)
        {
            dal.blockOrder(Order_Id);
        }
        public DataTable select_All_Orders_for_User_Id(int User_Id)
        {
            return (dal.selectAllOrdersforUserId(User_Id));
        }

        public DataTable select_Specific_Order(int Order_Id)
        {
            return (dal.selectSpecificOrder(Order_Id));
        }

        public DataTable select_All_Orders()
        {
            return (dal.selectAllOrders());
        }
    }
}
