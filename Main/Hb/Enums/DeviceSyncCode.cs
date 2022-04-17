using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace Hb
{
    /// <summary>
    /// 照片同步到设备错误码
    /// </summary>
    public enum DeviceSyncCode
    {
        [Description("未同步")]
        Unsynchronized = -1,
        /// <summary>
        /// 成功
        /// </summary>
        [Description("成功")]
        Success = 0,
        /// <summary>
        /// 未知错误
        /// </summary>
        [Description("未知错误")]
        UnKnowError = 1,
        /// <summary>
        /// 打开设备连接失败
        /// </summary>
        [Description("打开设备连接失败")]
        OpenDeviceConnectFailed = 2,
        /// <summary>
        /// 用户信息未找到
        /// </summary>
        [Description("用户信息未找到")]
        UserInfoNotFind = 3,
        /// <summary>
        /// 用户照片未找到
        /// </summary>
        [Description("用户照片未找到")]
        UserImageNotFind = 4,
        /// <summary>
        /// 用户照片过大
        /// </summary>
        [Description("用户照片过大")]
        UserImageOversize = 5,
        /// <summary>
        /// 上传到设备失败
        /// </summary>
        [Description("上传到设备失败")]
        UploadToDeviceFailed = 6,
    }
}
