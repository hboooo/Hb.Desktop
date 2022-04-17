using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Hb
{
    public class ModuleEx
    {
        private FieldInfo[] _fieldInfos = null;

        private static ModuleEx _moduleEx;

        private static readonly object _locker = new object();

        public static ModuleEx Instance
        {
            get
            {
                if (_moduleEx == null)
                {
                    lock (_locker)
                    {
                        if (_moduleEx == null)
                        {
                            _moduleEx = new ModuleEx();
                        }
                    }
                }
                return _moduleEx;
            }
        }

        private ModuleEx()
        {
            InitFields();
        }

        private void InitFields()
        {
            var moduleID = typeof(ModuleId);
            _fieldInfos = moduleID.GetFields();
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="mask"></param>
        /// <returns></returns>
        public Dictionary<int, string> GetModules(int mask)
        {
            Dictionary<int, string> moduleItems = new Dictionary<int, string>();
            foreach (var fieldInfo in _fieldInfos)
            {
                int value = (int)fieldInfo.GetValue(null);
                if (value > 0 && (value & mask) == mask && value != mask)
                {
                    moduleItems[value] = fieldInfo.Name;
                }
            }
            return moduleItems;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="moduleId"></param>
        /// <returns></returns>
        public string GetModuleName(int moduleId)
        {
            foreach (var fieldInfo in _fieldInfos)
            {
                if (fieldInfo.FieldType == typeof(int)) continue;
                int value = (int)fieldInfo.GetValue(null);
                if (moduleId == value)
                {
                    return fieldInfo.Name;
                }
            }
            return null;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public int GetModuleID(string name)
        {
            foreach (var fieldInfo in _fieldInfos)
            {
                if (fieldInfo.Name == name)
                {
                    return (int)fieldInfo.GetValue(null);
                }
            }
            return (int)ModuleId.UnKnow;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public ModuleId GetModuleEnum(string name)
        {
            foreach (var fieldInfo in _fieldInfos)
            {
                if (fieldInfo.Name == name)
                {
                    return (ModuleId)fieldInfo.GetValue(null);
                }
            }
            return ModuleId.UnKnow;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public ModuleId GetModuleEnum(int moduleId)
        {
            foreach (var fieldInfo in _fieldInfos)
            {
                if (fieldInfo.FieldType == typeof(int)) continue;
                int value = (int)fieldInfo.GetValue(null);
                if (moduleId == value)
                {
                    return (ModuleId)fieldInfo.GetValue(null);
                }
            }
            return ModuleId.UnKnow;
        }

        /// <summary>
        /// 獲取流程類型
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public int GetModuleMask(string name)
        {
            return GetModuleMask(GetModuleID(name));
        }

        /// <summary>
        /// 獲取流程類型
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public int GetModuleMask(int moduleId)
        {
            return moduleId & 0xFFF0000;
        }
    }
}
