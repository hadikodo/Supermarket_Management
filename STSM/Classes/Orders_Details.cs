using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STSM.Classes
{
    class Orders_Details
    {
        DataAccessLayer dal = new DataAccessLayer();

        public void add_Order_Details(int Order_Id,int Product_Id,int quantity,int item_price,int total_price)
        {
            dal.addOrderDetails(Order_Id,Product_Id,quantity,item_price,total_price);
        }
        public DataTable select_Order_Details_For_Product(int Product_Id)
        {
            return (dal.selectOrderDetailsForProduct(Product_Id));
        }
        public DataTable select_Order_Details_For_Order(int Order_Id)
        {
            return (dal.selectOrderDetailsForOrder(Order_Id));
        }
        public DataTable select_Order_Details()
        {
            return (dal.selectAllOrdersDetails());
        }
    }
}
