﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State.States
{
    public class AvailableServerState : ServerState
    {
        public override void Response()
        {
            Console.WriteLine("HTTP 200");
        }
    }
}
