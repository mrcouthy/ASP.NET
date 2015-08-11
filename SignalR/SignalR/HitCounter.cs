using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;

namespace SignalR
{
    [HubName("alternamtiveNameto_HitCounterClass")]
    public class HitCounterClass : Hub
    {
        static int hitCountInteger = 0;
        public void RecordHitServerMethod()
        {
            hitCountInteger += 1;
            Clients.All.JsEventName_onRecordHit(hitCountInteger);
        }

        public override System.Threading.Tasks.Task OnDisconnected(bool stopCalled)
        {
            hitCountInteger -= 1;
            Clients.All.JsEventName_onRecordHit(hitCountInteger);
            return base.OnDisconnected(stopCalled);
        }
    }
}