using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STSM.Classes
{
    class Return
    {
        DataAccessLayer dal = new DataAccessLayer();

        public void add_Return(int User_id)
        {
            dal.addReturn(User_id);
        }
        public void block_Return(int Return_Id)
        {
            dal.blockReturn(Return_Id);
        }
        public DataTable select_All_Return_for_User(int User_id)
        {
            return (dal.selectAllReturnforUser(User_id));
        }
        public DataTable select_Specific_Return(int return_id)
        {
            return(dal.selectSpecificReturn(return_id));
        }
        public DataTable selectAllReturns()
        {
            return (dal.selectAllReturns());
        }
    }
}
