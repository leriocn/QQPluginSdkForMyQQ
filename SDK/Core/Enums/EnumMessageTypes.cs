using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyQQPluginSDK.Core.Enums
{
    public enum EnumMessageTypes
    {
        /// <summary>
        /// 消息类型_未定义
        /// </summary>
        Undefined = -1,
        /// <summary>
        /// 消息类型_好友
        /// </summary>
        Friend = 1,
        /// <summary>
        /// 消息类型_群
        /// </summary>
        Group = 2,
        /// <summary>
        /// 消息类型_讨论组
        /// </summary>
        Discuss = 3,
        /// <summary>
        /// 消息类型_群临时会话
        /// </summary>
        GroupTemp = 4,
        /// <summary>
        /// 消息类型_讨论组临时会话
        /// </summary>
        DiscussTemp = 5,
        /// <summary>
        /// 消息类型_在线临时会话
        /// </summary>
        Temp = 6
    }
}
