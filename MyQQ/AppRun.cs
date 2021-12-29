using MyQQPlugin;
using MyQQPluginSDK;
using MyQQPluginSDK.Core;
using MyQQPluginSDK.Core.Enums;
using System.Runtime.InteropServices;
using Unity;

namespace RobotCore
{
    internal static class AppRun
    {
        /// <summary>
        /// 设置应用信息
        /// </summary>
        /// <param name="appInfo"></param>
        internal static void SetAppInfo(AppInfo appInfo)
        {
            appInfo.Sdk = "S2";
            appInfo.Name = "MyQQPlugin";
            appInfo.Author = "乐悠尚智";
            appInfo.Description = string.Concat(new string[]
            {
                "MyQQ C# SDK",
                "\r\n",
                "小栗子官网地址：https://cq.lerio.cn/"
            });
            appInfo.Version = "1.0.0";
        }
    }
}
