using MicroRabbitMQ.Infra.IoC;

namespace MicroRabbitMQ.Transfer.Api.Extensions
{
    public static class Extensions
    {
        public static void RegisterServices(this IHostApplicationBuilder builder)
        {
            DependencyContainer.RegisterServices(builder.Services);
        }
    }
}
