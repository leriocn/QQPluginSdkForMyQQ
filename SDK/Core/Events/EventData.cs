using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyQQPluginSDK.Core.Events
{
    public class EventData
    {
        public string RebotQQ { get; set; }
        public int EventType { get; set; }
        public int EventSubType { get; set; }
        public string From { get; set; }
        public string OperateQQ { get; set; }
        public string BeingQQ { get; set; }
        public string Msg { get; set; }
        public string MsgNum { get; set; }
        public string MsgId { get; set; }
        public string Origin { get; set; }
        public int RetOut { get; set; }
    }
}
