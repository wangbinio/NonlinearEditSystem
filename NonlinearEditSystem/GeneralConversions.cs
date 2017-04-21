using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NonLinearEditSystem
{
    class GeneralConversions
    {
        // HT_Time is 100 nanoseconds resolution
        public static double HT_TIME_TO_SECONDS = 0.0000001;
        public static double SECONDS_TO_HT_TIME = 10000000.0;
        public static double HT_TIME_TO_MSEC = 0.0001;
        public static double MSEC_TO_HT_TIME = 10000.0;
    }
}
