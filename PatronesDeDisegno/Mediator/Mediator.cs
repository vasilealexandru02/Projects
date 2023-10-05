using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Mediator : IMediator
{
    private List<Colleague> colleagues;

    public Mediator()
    {
        colleagues = new List<Colleague>();
    }

    public void AddColleague(Colleague colleague)
    {
        colleagues.Add(colleague);
    }
    public void Send(string message, Colleague colleague, bool sendAll)
    {
        foreach (var col in colleagues)
        {
            if (sendAll)
            {
                if (colleague != col)
                {
                    col.Receive(message);
                }
            }
            else
            {
                if (colleague != col && colleague.GetType() != col.GetType())
                {
                    col.Receive(message);
                }
            }

        }

    }
}
