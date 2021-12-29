using MyQQPlugin;
using MyQQPluginSDK.Core.Enums;
using MyQQPluginSDK.Core.Events;
using MyQQPluginSDK.Core.Interfaces;
using RobotCore;
using System;
using System.Runtime.InteropServices;
using Unity;

namespace MyQQPluginSDK.Core
{
    public static class EventCall
    {
        /// <summary>
        /// 入口公开函数
        /// </summary>
        /// <param name="pluginkey"></param>
        /// <param name="apidata"></param>
        /// <returns></returns>
        [DllExport(CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        [return: MarshalAs(UnmanagedType.LPStr)]
        public static string MQ_Info()
        {
            Common.Container = new UnityContainer();
            RegisterCore.Register(Common.Container);

            AppInfo appInfo = new AppInfo();
            AppRun.SetAppInfo(appInfo);
            return appInfo.ToString();
        }

        /// <summary>
        /// 分发框架机器人QQ接收到的所有事件、消息
        /// </summary>
        /// <param name="rebotQQ"></param>
        /// <param name="eventType"></param>
        /// <param name="eventSubType"></param>
        /// <param name="from"></param>
        /// <param name="apidata"></param>
        /// <param name="operateQQ"></param>
        /// <param name="beingQQ"></param>
        /// <param name="message"></param>
        /// <param name="msgNum"></param>
        /// <param name="msgId"></param>
        /// <param name="origin"></param>
        /// <param name="intPtr"></param>
        /// <returns></returns>
        [DllExport(CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static int MQ_Event(
            [MarshalAs(UnmanagedType.LPStr)] string rebotQQ,
            int eventType,
            int eventSubType,
            [MarshalAs(UnmanagedType.LPStr)] string from,
            [MarshalAs(UnmanagedType.LPStr)] string operateQQ,
            [MarshalAs(UnmanagedType.LPStr)] string beingQQ,
            [MarshalAs(UnmanagedType.LPStr)] string message,
            [MarshalAs(UnmanagedType.LPStr)] string msgNum,
            [MarshalAs(UnmanagedType.LPStr)] string msgId,
            [MarshalAs(UnmanagedType.LPStr)] string origin,
            int intPtr
            )
        {
            var eventData = new EventData
            {
                BeingQQ = beingQQ,
                EventSubType = eventSubType,
                EventType = eventType,
                From = from,
                Msg = message,
                MsgId = msgId,
                MsgNum = msgNum,
                OperateQQ = operateQQ,
                Origin = origin,
                RebotQQ = rebotQQ,
                RetOut = intPtr
            };
            return EventCallOption.MQ_Event(eventData);
        }

        /// <summary>
        /// 当用户按下“设置”执行本函数
        /// </summary>
        [DllExport(CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static void MQ_Set()
        {
            EventCallOption.MQ_Set();
        }

        /// <summary>
        /// 当插件被卸载时将会调用
        /// </summary>
        /// <param name="pluginkey"></param>
        /// <param name="apidata"></param>
        /// <returns></returns>
        [DllExport(CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static int MQ_End()
        {
            return EventCallOption.MQ_End();
        }

        /// <summary>
        /// 此子程序用于接收所有原始封包内容
        /// </summary>
        /// <param name="rebotQQ"></param>
        /// <param name="msgType"></param>
        /// <param name="msg"></param>
        /// <param name="cookies"></param>
        /// <param name="sessionKey"></param>
        /// <param name="clientKey"></param>
        /// <returns></returns>
        [DllExport(CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static int MQ_Message([MarshalAs(UnmanagedType.LPStr)] string rebotQQ,
            int msgType,
            [MarshalAs(UnmanagedType.LPStr)] string msg,
            [MarshalAs(UnmanagedType.LPStr)] string cookies,
            [MarshalAs(UnmanagedType.LPStr)] string sessionKey,
            [MarshalAs(UnmanagedType.LPStr)] string clientKey)
        {
            return EventCallOption.MQ_Message();
        }
    }
}
