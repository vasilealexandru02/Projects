using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    public interface IMediator
    {
        public void Send(string message, Colleague colleague);
    }

