using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public abstract class Colleague
{
    private string colleagueName;
    private IMediator mediator;

    public IMediator Mediator { get { return mediator; } }

    public string ColleagueName { get { return colleagueName; } }

    public Colleague(IMediator _mediator, string _name)
    {
        mediator = _mediator;
        colleagueName = _name;
    }

    public void Communicate(string message, bool sendAll)
    {
        Mediator.Send(message, this, sendAll);
    }


    public abstract void Receive(string message);
}

