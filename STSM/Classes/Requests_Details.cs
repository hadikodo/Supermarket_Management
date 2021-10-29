using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STSM.Classes
{
    class Requests_Details
    {
        DataAccessLayer dal = new DataAccessLayer();

        public void add_Request_Details(int Request_Id,int Product_Id,int quantity)
        {
            dal.addRequestDetails(Request_Id,Product_Id,quantity);
        }
        public DataTable select_All_Requests_Details_for_Product(int Product_Id)
        {
            return (dal.selectallrequestsdetailsforproduct(Product_Id));
        }
        public DataTable select_Requests_Detailsfor_Request_Id(int Request_Id)
        {
            return (dal.selectrequestsdetailsforrequests(Request_Id));

        }
        public DataTable select_All_Requests_Details()
        {
            return (dal.selectallrequestsdetails());

        }
    }
}
