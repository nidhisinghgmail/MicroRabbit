using MicroRabbit.Domain.Core.Commands;
using MicroRabbit.Domain.Core.Events;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MicroRabbit.Domain.Core.Bus
{
    public interface IEventBus
    {
        /// <summary>
        /// Initial command or methods , first is task it is send command method, it is going to take any type of object(generic),
        /// restriction is there in T type, it should be of type command , it is mediator library to send commands to various places thru bus.
        /// Reference of threading
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="command"></param>
        /// <returns></returns>
        Task SendCommand<T>(T command) where T : Command;

        /// <summary>
        /// Publish method, we can publish any type of event hence it is also made generic, @ is used because event is reserved key word,
        /// hence we can use this as variable by adding @.
        /// T is of type Event 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="event"></param>
        void Publish<T>(T @event) where T : Event;

        /// <summary>
        /// Services that are publishing events, but we want services to subscribe to event, it will subscribe to different publish events
        /// this method will be a type T , which is a event type and also each event might have event handler , a generic one ,
        /// where T is of type event and TH is type IEventHandler which is of type T
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="TH"></typeparam>
        void Subscribe<T, TH>()
            where T : Event
            where TH : IEventHandler<T>;
    }
}
