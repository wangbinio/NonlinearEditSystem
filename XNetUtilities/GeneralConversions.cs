using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XNetUtilities
{
    /// <summary>
    /// 类说明：通用单位转换工具类
    /// 日期：2017-04-21
    /// 作者：szwb
    /// 修改：
    /// </summary>
    public abstract class GeneralConversions
    {
        // HT_Time is 100 nanoseconds resolution
        public const double HT_TIME_TO_SECONDS = 0.0000001;
        public const double SECONDS_TO_HT_TIME = 10000000.0;
        public const double HT_TIME_TO_MSEC = 0.0001;
        public const double MSEC_TO_HT_TIME = 10000.0;
    }
}
