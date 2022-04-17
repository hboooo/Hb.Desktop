using System;
using System.Reflection;

namespace Hb
{
    public static class DeviceProtocolTypeExtension
    {
        /// <summary>
        /// 获取设备协议类型
        /// </summary>
        /// <param name="valEnum"></param>
        /// <returns></returns>
        public static int GetProtocolType(this Enum valEnum)
        {
            Type type = valEnum.GetType();
            MemberInfo[] memInfo = type.GetMember(valEnum.ToString());
            if (null != memInfo && memInfo.Length > 0)
            {
                object[] attrs = memInfo[0].GetCustomAttributes(typeof(DeviceProtocolTypeAttribute), false);
                if (null != attrs && attrs.Length > 0)
                    return ((DeviceProtocolTypeAttribute)attrs[0]).Type;
            }
            return 0;
        }
    }
}
