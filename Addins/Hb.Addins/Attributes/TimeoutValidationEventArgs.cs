using System;

namespace Hb.Addins.Attributes
{
    public class TimeoutValidationEventArgs : EventArgs
    {
        /// <summary>
        /// 指示函数是否已经被处理
        /// </summary>
        public bool IsHandled { get; set; }
    }
}
