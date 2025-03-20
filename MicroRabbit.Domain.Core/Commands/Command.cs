namespace MicroRabbit.Domain.Core.Commands
{
    public abstract class Command : Message
    {
        public DateTime Timestamp { get; protected set; }

        protected Command()
        {
            // Timestamp is set to the current date and time
            Timestamp = DateTime.Now;
        }
    }
}
