using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public class User : Colleague
    {
    public User(IMediator _mediator) : base(_mediator)
    {

    }

    public override void Receive(string message)
        {
            Console.WriteLine("User receives: " + message);
        }
    }

