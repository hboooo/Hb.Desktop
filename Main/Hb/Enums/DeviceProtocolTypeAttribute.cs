using System;

namespace Hb
{
    [AttributeUsage(AttributeTargets.All)]
    public class DeviceProtocolTypeAttribute : Attribute
    {
        private int f_type;
        public int Type
        {
            get { return f_type; }
        }

        public DeviceProtocolTypeAttribute(int type)
        {
            f_type = type;
        }
    }
}
