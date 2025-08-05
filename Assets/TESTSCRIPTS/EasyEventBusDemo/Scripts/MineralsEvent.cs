namespace EasyEventBusDemo
{
    public struct MineralsEvent : IEvent
    {
        public int Amount { get; private set; }

        public MineralsEvent(int amount)
        {
            Amount = amount;
        }
    }
}