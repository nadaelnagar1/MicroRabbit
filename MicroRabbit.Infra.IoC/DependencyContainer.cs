namespace MicroRabbit.Infra.IoC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            // Register the Bus
            services.AddTransient<IEventBus, RabbitMQBus>();

        }

    }
}
