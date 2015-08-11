using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace SignalR
{
    public class HitCounter : Hub
    {
        static int hitCount = 0;
        public void RecordHit()
        {
            hitCount += 1;
            Clients.All.onRecordHit(hitCount);
        }
    }
}