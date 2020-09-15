using MicroRabbit.Domain.Core.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRabbit.Banking.Domain
{
    public abstract class TransferCommands : Command
    {
        public int To { get; protected set; }
        public int From { get; protected set; }
        public decimal Amount { get; protected set; }
    }
}
