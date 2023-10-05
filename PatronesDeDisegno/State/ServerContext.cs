using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public class ServerContext
    {
        private ServerState _state;

        public ServerState State { get => _state; set => _state = value; }


        public void AttendRequest()
        {
            State.Response();
        }
    }
}
