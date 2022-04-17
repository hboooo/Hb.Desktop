using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Management;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Hb
{
    /// <summary>
    /// author     :habo
    /// date       :2022/4/17 20:03:55
    /// description:
    /// </summary>
    public class Utils
    {

        /// <summary>
        /// 获取内部修订版本号
        /// </summary>
        /// <returns></returns>
        public static string GetReversion()
        {
            try
            {
                Assembly assembly = Assembly.GetEntryAssembly();
                if (assembly != null)
                {
                    object[] attributes = assembly.GetCustomAttributes(typeof(AssemblyInformationalVersionAttribute), false);
                    if (attributes.Length > 0)
                    {
                        AssemblyInformationalVersionAttribute attribute = (AssemblyInformationalVersionAttribute)attributes[0];
                        if (attribute != null)
                        {
                            return attribute.InformationalVersion;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Logger.Error(ex);
            }
            return "";
        }


        /// <summary>
        /// 获取启动的exe
        /// </summary>
        /// <param name="exeName"></param>
        /// <returns></returns>
        public static Process GetProcess(string exeName)
        {
            try
            {
                Process[] process = Process.GetProcessesByName(exeName.ToLower());
                if (process != null && process.Length > 0)
                {
                    return process.OrderBy(p => p.StartTime).First();
                }
            }
            catch (System.Exception ex)
            {
                Logger.Error(ex);
            }
            return null;
        }


        public static string GetOperatingSystemInfo()
        {
            string caption = string.Empty;
            string version = string.Empty;
            try
            {
                var query = "SELECT * FROM Win32_OperatingSystem";
                var searcher = new ManagementObjectSearcher(query);
                var info = searcher.Get().Cast<ManagementObject>().FirstOrDefault();
                caption = info.Properties["Caption"].Value.ToString();
                version = info.Properties["Version"].Value.ToString();
            }
            catch (Exception ex)
            {
                Logger.Error(ex);
            }
            return $"{caption}({version})";
        }
    }
}
