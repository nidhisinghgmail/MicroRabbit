using MicroRabbit.Domain.Core.Events;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MicroRabbit.Domain.Core.Bus
{
    //can handle any generic Event, implements I Eventhalder, where the event that is coming in has to be of type event,
    //it is having handle event, any event coming it handle that and has to a type of TEvent
    //and other empty interface is also created
    public interface IEventHandler<in TEvent> : IEventHandler
        where TEvent: Event
    {
        Task Handle(TEvent @event);   
    }

    public interface IEventHandler
    {

    }
}
