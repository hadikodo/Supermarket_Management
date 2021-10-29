using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STSM.Classes
{
    class Notes
    {
        DataAccessLayer dal = new DataAccessLayer();

        public void add_Notes(String description)
        {
            dal.addNotes(description);
        }
        public DataTable select_Notes_By_Id(int note_id)
        {
            return (dal.selectNotes(note_id));
        }
        public DataTable select_All_Notes()
        {
            return (dal.selectAllNotes());
        }
    }
}
