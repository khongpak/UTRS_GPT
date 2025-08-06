namespace EventBusOwnerDemo.OwnerSystem
{

    public enum OwnerType
    {
        Player1,
        Player2,
        AI
    }

    public class Owner
    {
        public OwnerType type;

        public Owner(OwnerType type)
        {
            this.type = type;
        }

        public override bool Equals(object obj)
        {
            if (obj is not Owner other) return false;
            return type == other.type;
        }

        public override int GetHashCode()
        {
            return (int)type;
        }
    }
}