using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State.States
{
    public class UnavailableState : ServerState
    {
        public override void Response()
        {
            Task.Delay(500);
            Console.WriteLine("HTTP 200 with 500ms delay");
        }
    }
}
