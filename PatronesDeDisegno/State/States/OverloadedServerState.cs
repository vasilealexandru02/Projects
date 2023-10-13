using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State.States
{
    public class OverloadedServerState : ServerState
    {
        public override void Response()
        {
            Task.Delay(1000);
            Console.WriteLine("HTTP 200 with 1000ms delay");
        }
    }
}
