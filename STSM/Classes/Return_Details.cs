using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STSM.Classes
{
    class Return_Details
    {
        DataAccessLayer dal = new DataAccessLayer();

        public void add_Return_Details(int return_id, int product_id, int quantity)
        {
            dal.addReturnDetails(return_id,product_id,quantity);
        }
        public DataTable select_All_Return_Details_for_Product(int product_id)
        {
            return (dal.selectAllReturnDetailsforProduct(product_id));
        }
        public DataTable select_Return_Details_for_Return(int return_id)
        {
            return (dal.selectReturnDetailsforReturn(return_id));
        }
        public DataTable select_All_Return_Details()
        {
            return (dal.selectAllReturnDetails());
        }
    }
}
