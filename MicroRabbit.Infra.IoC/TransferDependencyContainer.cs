using MicroRabbit.Domain.Core.Bus;
using MicroRabbit.Transfer.Application.Interfaces;
using MicroRabbit.Transfer.Application.Services;
using MicroRabbit.Transfer.Data.Context;
using MicroRabbit.Transfer.Data.Repository;
using MicroRabbit.Transfer.Domain.EventHandlers;
using MicroRabbit.Transfer.Domain.Events;
using MicroRabbit.Transfer.Domain.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace MicroRabbit.Infra.IoC
{
    public class TransferDependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            services.AddTransient<ITransferService, TransferService>();
            services.AddTransient<ITransferRepository, TransferRepository>();
            services.AddTransient<TransferDbContext>();
            services.AddTransient<IEventHandler<TransferCreatedEvent>, TransferEventHandler>();
            services.AddTransient<TransferEventHandler>();

        }
    }
}
