using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STSM.Classes
{
    class Requests
    {
        DataAccessLayer dal = new DataAccessLayer();

        public void add_Requests(int Supplier_Id)
        {
            dal.addRequests(Supplier_Id);
        }
        public void block_Requests(int Request_Id)
        {
            dal.blockRequest(Request_Id);
        }
        public DataTable select_All_Requests_for_Supplier(int Supplier_Id)
        {
            return (dal.selectAllRequestsforSupplier(Supplier_Id));
        }
        public DataTable select_Specific_Requests(int Request_Id)
        {
            return (dal.selectSpecificRequests(Request_Id));
        }
        public DataTable selectAllRequests()
        {
            return (dal.selectAllRequests());
        }
    }
}
