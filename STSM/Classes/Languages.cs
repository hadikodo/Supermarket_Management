using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STSM.Classes
{
    class Languages
    {
        DataAccessLayer dal = new DataAccessLayer();

        public void add_Languages(String name)
        {
            dal.addLanguages(name);
        }
        public DataTable select_Language_By_Id(int Language_Id)
        {
            return (dal.selectLanguageById(Language_Id));
        }

        public DataTable select_Enabled_Language()
        {
            return (dal.selectEnabledLanguage());
        }
        public DataTable select_All_Languages()
        {
            return (dal.selectAllLanguages());
        }
        public void set_Language_Enabled(int Language_Id)
        {
             dal.setLanguageEnabled(Language_Id);
        }
    }
}
