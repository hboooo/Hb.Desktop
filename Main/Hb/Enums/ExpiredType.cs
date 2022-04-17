namespace Hb
{
    /// <summary>
    /// 过去类型
    /// </summary>
    public enum ExpiredType : int
    {
        /// <summary>
        /// 全部正常
        /// </summary>
        Normal = 0,
        /// <summary>
        /// 全部过期
        /// </summary>
        AllExpired = 1,
        /// <summary>
        /// 部分过期
        /// </summary>
        PartExpired = 2,
        /// <summary>
        /// 快过期
        /// </summary>
        WillExpire = 3,
    }
}
