using MyQQPluginSDK.Core.Enums;
using MyQQPluginSDK.Core.Events;
using MyQQPluginSDK.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;

namespace MyQQPluginSDK.Core
{
    public class EventCallOption
    {
        public static void MQ_Set()
        {
            try
            {
                if (Common.Container.IsRegistered<IMenuEvent>())
                {
                    Common.Container.Resolve<IMenuEvent>().Call(null);
                }
            }
            catch (Exception ex)
            {
                Common.LogOut("点击菜单出错:" + ex.Message, ex);
            }
        }

        public static int MQ_End()
        {
            try
            {
                if (Common.Container.IsRegistered<IPluginUninstallEvent>())
                {
                    Common.Container.Resolve<IPluginUninstallEvent>().Call(null);
                }
            }
            catch (Exception ex)
            {
                Common.LogOut("插件被卸载时出错:" + ex.Message, ex);
            }

            return (int)EnumEventOptions.Agree;
        }

        public static int MQ_Message()
        {
            return (int)EnumMessageOptions.Ignore;
        }

        public static int MQ_Event(EventData eventData)
        {
            int retCode = 0;

            try
            {
                switch (eventData.EventType)
                {
                    case (int)EnumEventTypes.Plugin_SetStop:
                        if (Common.Container.IsRegistered<IPluginDisableEvent>())
                        {
                            retCode = Common.Container.Resolve<IPluginDisableEvent>().Call(eventData);
                        }
                        break;
                    case (int)EnumEventTypes.Plugin_SetUse:
                        if (Common.Container.IsRegistered<IPluginEnableEvent>())
                        {
                            retCode = Common.Container.Resolve<IPluginEnableEvent>().Call(eventData);
                        }
                        break;
                    case (int)EnumEventTypes.Plugin_Loading:
                        if (Common.Container.IsRegistered<IPluginInsEvent>())
                        {
                            retCode = Common.Container.Resolve<IPluginInsEvent>().Call(eventData);
                        }
                        break;
                    case (int)EnumEventTypes.Friend_FileRecieved:
                    case (int)EnumEventTypes.Group_FileRecieved:
                        if (Common.Container.IsRegistered<IFileUploadEvent>())
                        {
                            retCode = Common.Container.Resolve<IFileUploadEvent>().Call(eventData);
                        }
                        break;
                    case (int)EnumEventTypes.Friend_SingleAdded:
                        if (Common.Container.IsRegistered<IFriendAddedEvent>())
                        {
                            retCode = Common.Container.Resolve<IFriendAddedEvent>().Call(eventData);
                        }
                        break;
                    case (int)EnumEventTypes.Friend_NewFriendRequest:
                        if (Common.Container.IsRegistered<IFriendAddRequestEvent>())
                        {
                            retCode = Common.Container.Resolve<IFriendAddRequestEvent>().Call(eventData);
                        }
                        break;
                    case (int)EnumEventTypes.This_LoadSuccess:
                    case (int)EnumEventTypes.This_ReadyRebot:
                    case (int)EnumEventTypes.This_AddNewAccount:
                    case (int)EnumEventTypes.This_Logined:
                    case (int)EnumEventTypes.This_OfficeLineForce:
                    case (int)EnumEventTypes.This_OfficeLineManual:
                    case (int)EnumEventTypes.This_OfficeLineTimeout:
                    case (int)EnumEventTypes.This_SendMsg:
                        if (Common.Container.IsRegistered<IFrameCommonEvent>())
                        {
                            retCode = Common.Container.Resolve<IFrameCommonEvent>().Call(eventData);
                        }
                        break;
                }
            }
            catch (Exception ex)
            {
                Common.LogOut("插件处理事件出错:" + ex.Message, ex);
            }

            return retCode;
        }
    }
}
