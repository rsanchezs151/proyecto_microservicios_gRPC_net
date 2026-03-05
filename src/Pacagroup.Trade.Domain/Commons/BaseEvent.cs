namespace Pacagroup.Trade.Domain.Commons
{
    public abstract class BaseEvent
    {
        public Guid MessageId { get; set; }

        public DateTime PlubishTime { get; set; }

    }
}
