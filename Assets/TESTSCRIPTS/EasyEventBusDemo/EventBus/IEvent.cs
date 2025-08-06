using EventBusOwnerDemo.OwnerSystem;

namespace EventBusOwnerDemo.EventBus {
    public interface IEvent {
        Owner owner { get; }
    }
}