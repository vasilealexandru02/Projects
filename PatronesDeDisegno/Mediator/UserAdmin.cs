using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;


public class UserAdmin : Colleague
{
    public UserAdmin(IMediator _mediator, string _name) : base(_mediator, _name)
    {
    }

    public override void Receive(string message)
    {
        Console.WriteLine("Admin {" + ColleagueName + "} receives: " + message);
    }
}

