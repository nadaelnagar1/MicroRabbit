﻿using MicroRabbit.Domain.Core.Commands;

namespace MicroRabbit.Banking.Domain.Commands
{
    public class TransferCommand : Command
    {
        public int From { get; set; }
        public int To { get; set; }
        public decimal Amount { get; set; }

        

    }
}
