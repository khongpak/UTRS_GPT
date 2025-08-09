namespace GameDevTV.RTS.EasyEventBusDemo 
{
    public class UnitDiedEvent : IGameEvent
    {
        public int unitId;

        public UnitDiedEvent(int unitId)
        {
            this.unitId = unitId;
        }
    }
}