using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyQQPluginSDK.Core.Enums
{
    public enum EnumEventTypes
    {
        /// <summary>
        /// 消息类型_被单向添加好友
        /// </summary>
        Friend_SingleAdded = 1000,
        /// <summary>
        /// 消息类型_被请求添加好友
        /// </summary>
        Friend_NewFriendRequest = 1001,
        /// <summary>
        /// 消息类型_好友状态改变
        /// </summary>
        Friend_StatusChanged = 1002,
        /// <summary>
        /// 消息类型_被删除好友
        /// </summary>
        Friend_Removed = 1003,
        /// <summary>
        /// 消息类型_好友签名变更
        /// </summary>
        Friend_SignatureChanged = 1004,
        /// <summary>
        /// 消息类型_说说被评论
        /// </summary>
        Friend_ShuoShuoComment = 1005,
        /// <summary>
        /// 消息类型_好友正在输入
        /// </summary>
        Friend_InputStatus = 1006,
        /// <summary>
        /// 消息类型_好友今天首次发起会话
        /// </summary>
        Friend_FirstSay = 1007,
        /// <summary>
        /// 消息类型_被好友抖动
        /// </summary>
        Friend_Shaked = 1008,
        /// <summary>
        /// 消息类型_好友文件接收
        /// </summary>
        Friend_FileRecieved = 1009,
        /// <summary>
        /// 消息类型_好友视频接收
        /// </summary>
        Friend_VideoRecieved = 1010,
        /// <summary>
        /// 好友事件_对方同意了您的好友请求
        /// </summary>
        Friend_RequestAccepted = 1011,
        /// <summary>
        /// 好友事件_对方拒绝了您的好友请求
        /// </summary>
        Friend_RequestRefused = 1012,
        /// <summary>
        /// 消息类型_好友撤回消息
        /// </summary>
        Friend_Undid = 13002,
        /// <summary>
        /// 消息类型_好友语音接收
        /// </summary>
        Friend_RecordRecieved = 3001,



        /// <summary>
        /// 消息类型_某人申请加入群
        /// </summary>
        Group_MemberAddRequest = 2001,
        /// <summary>
        /// 消息类型_某人被邀请加入群
        /// </summary>
        Group_MemberInviteIn = 2002,
        /// <summary>
        /// 消息类型_某人已被邀请入群
        /// </summary>
        Group_MemberInviteIned = 20021,
        /// <summary>
        /// 消息类型_我被邀请加入群
        /// </summary>
        Group_Invited = 2003,
        /// <summary>
        /// 消息类型_某人被批准加入了群
        /// </summary>
        Group_MemberJoined = 2005,
        /// <summary>
        /// 消息类型_某人退出群
        /// </summary>
        Group_MemberQuit = 2006,
        /// <summary>
        /// 消息类型_某人被管理移除群
        /// </summary>
        Group_MemberKickOut = 2007,
        /// <summary>
        /// 消息类型_某群被解散
        /// </summary>
        Group_GroupDissolved = 2008,
        /// <summary>
        /// 消息类型_某人成为管理
        /// </summary>
        Group_AdministratorGave = 2009,
        /// <summary>
        /// 消息类型_某人被取消管理
        /// </summary>
        Group_AdministratorTook = 2010,
        /// <summary>
        /// 消息类型_群名片变动
        /// </summary>
        Group_ModifyBusinessCard = 2011,
        /// <summary>
        /// 消息类型_群名变动
        /// </summary>
        Group_GroupNameUpdate = 2012,
        /// <summary>
        /// 消息类型_群公告变动
        /// </summary>
        Group_GroupAnnounceUpdate = 2013,
        /// <summary>
        /// 消息类型_对象被禁言
        /// </summary>
        Group_MemberShutUp =2014,
        /// <summary>
        /// 消息类型_对象被解除禁言
        /// </summary>
        Group_MemberNotShutUp = 2015,
        /// <summary>
        /// 消息类型_群管开启全群禁言
        /// </summary>
        Group_EnableAllShutUp = 2016,
        /// <summary>
        /// 消息类型_群管关闭全群禁言
        /// </summary>
        Group_DisableAllShutUp = 2017,
        /// <summary>
        /// 消息类型_群管开启匿名聊天
        /// </summary>
        Group_EnableAnonymous = 2018,
        /// <summary>
        /// 消息类型_群管关闭匿名聊天
        /// </summary>
        Group_DisableAnonymous = 2019,
        /// <summary>
        /// 消息类型_群撤回消息
        /// </summary>
        Group_MemberUndid = 2020,
        /// <summary>
        /// 消息类型_群文件接收
        /// </summary>
        Group_FileRecieved = 2021,
        /// <summary>
        /// 消息类型_群视频接收
        /// </summary>
        Group_VideoRecieved = 2022,
        /// <summary>
        /// 消息类型_群语音接收
        /// </summary>
        Group_RecordRecieved = 3002,
        /// <summary>
        /// 消息类型_群消息被设置为精华
        /// </summary>
        Group_SetMsgEssence = 3003,
        /// <summary>
        /// 消息类型_群消息被取消精华
        /// </summary>
        Group_MsgEssenceUndid = 3004,


        /// <summary>
        /// 消息类型_框架加载完成
        /// </summary>
        This_LoadSuccess = 10000,
        /// <summary>
        /// 消息类型_框架即将重启
        /// </summary>
        This_ReadyRebot = 10001,

        /// <summary>
        /// 消息类型_添加了一个新的帐号
        /// </summary>
        This_AddNewAccount = 11000,
        /// <summary>
        /// 消息类型_QQ登录完成
        /// </summary>
        This_Logined = 11001,
        /// <summary>
        /// 消息类型_QQ被手动离线
        /// </summary>
        This_OfficeLineManual = 11002,
        /// <summary>
        /// 消息类型_QQ被强制离线
        /// </summary>
        This_OfficeLineForce = 11003,
        /// <summary>
        /// 消息类型_QQ长时间无响应或掉线
        /// </summary>
        This_OfficeLineTimeout = 11004,


        /// <summary>
        /// 消息类型_本插件载入
        /// </summary>
        Plugin_Loading = 12000,
        /// <summary>
        /// 消息类型_插件被启用
        /// </summary>
        Plugin_SetUse = 12001,
        /// <summary>
        /// 消息类型_插件被禁用
        /// </summary>
        Plugin_SetStop = 12002,
        /// <summary>
        /// 消息类型_插件被点击
        /// </summary>
        Plugin_Click = 12003,

        /// <summary>
        /// 消息类型_机器人发出消息
        /// </summary>
        This_SendMsg = 80004,
    }
}
