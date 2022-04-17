using System.ComponentModel;

namespace Hb
{
    /// <summary>
    /// 摄像头类型
    /// 数据库表 tbl_device_module_info
    /// </summary>
    public enum CameraType
    {
        /// <summary>
        /// 海康
        /// </summary>
        [Description("动态群体人脸识别摄像头")]
        Hikvision = 2,
        /// <summary>
        /// 旷视
        /// </summary>
        [Description("快速精准人脸识别摄像头")]
        Megvii = 3,
    }
}
