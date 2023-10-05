using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;


    public class UserAdmin : Colleague
    {
    public UserAdmin(IMediator _mediator) : base(_mediator)
    {
    }

    public override void Receive(string message)
        {
            Console.WriteLine("Admin receives: " + message);
        }
    }

