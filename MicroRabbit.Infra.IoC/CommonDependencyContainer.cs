using MediatR;
using MicroRabbit.Banking.Domain.CommandHandlers;
using MicroRabbit.Banking.Domain.Commands;
using MicroRabbit.Domain.Core.Bus;
using MicroRabbit.Infra.Bus;
using Microsoft.Extensions.DependencyInjection;

namespace MicroRabbit.Infra.IoC
{
    public class CommonDependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {            
            services.AddTransient<IEventBus, RabbitMQBus>(sp =>
            {
                var scopeFactory = sp.GetRequiredService<IServiceScopeFactory>();
                return new RabbitMQBus(sp.GetRequiredService<IMediator>(), scopeFactory);
            });
            services.AddTransient<IRequestHandler<CreateTransferCommand,bool>, TransferCommandHandler>();

        }
         
    }
}
