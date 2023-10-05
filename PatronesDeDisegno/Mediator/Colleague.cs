using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public abstract class Colleague
{
    private IMediator mediator;

    public IMediator Mediator { get { return mediator; } }

    public Colleague(IMediator _mediator)
    {
        mediator = _mediator;
    }

    public void Communicate(string message)
    {
        Mediator.Send(message, this);
    }

    public abstract void Receive(string message);
}

