using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyQQPluginSDK.Core.Enums
{
    public enum EnumMessageOptions
    {
        /// <summary>
        /// 其他插件可继续处理此条消息
        /// </summary>
        Ignore = 0,
        /// <summary>
        /// 其他插件可继续处理此条消息
        /// </summary>
        Continue = 1,
        /// <summary>
        /// 拦截信息，此条消息不再分发给其他插件，其他插件将不能再处理
        /// </summary>
        Abandon = 2
    }
}
