using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STSM.Classes
{
    class Globals
    {
        public static Boolean isReady { get; set; }
        public static Boolean isHold { get; set; }
        public static Boolean isCheckCancelled { get; set; }
        public static int currentOID { get; set; }
        public static int newQte { get; set; }
        public static int currentQte { get; set; }
        public static int nbDeleted { get; set; }

    }
}
