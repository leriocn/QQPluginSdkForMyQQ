using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyQQPluginSDK.Core.Interfaces
{
    public interface IFriendCommonEvent
    {
        int Call(Events.EventData eventData);
    }
}
