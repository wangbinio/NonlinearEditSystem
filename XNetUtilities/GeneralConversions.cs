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
        //  100nanoseconds resolution
        public const double NanoSecToSec = 0.0000001;
        public const double SecToNanoSec = 10000000.0;
        public const double NanoSecToMicSec = 0.0001;
        public const double MicSecToNanoSec = 10000.0;
    }
}
