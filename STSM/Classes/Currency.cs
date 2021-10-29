using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STSM.Classes
{
    class Currency
    { 
        DataAccessLayer dal = new DataAccessLayer();

        public void add_Currency(String name,int value,int enabled)
        {
            dal.addCurrency(name,value,enabled); 
        }
        public DataTable select_Currency_By_Id(int Currency_Id)
        {
            return (dal.selectCurrencyById(Currency_Id));
        }
        public DataTable selectCurrencyByEnabled(int Enabled_Id)
        {
            return (dal.selectCurrencyByEnabled(Enabled_Id));
        }
        public DataTable select_All_Currencies()
        {
            return (dal.selectAllCurrencies());
        }
    }
}
