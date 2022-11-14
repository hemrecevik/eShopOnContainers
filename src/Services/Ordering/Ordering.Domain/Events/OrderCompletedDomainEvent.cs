namespace Microsoft.eShopOnContainers.Services.Ordering.Domain.Events;

/// <summary>
/// Event used when the order is completed
/// </summary>
public class OrderCompletedDomainEvent
    : INotification
{
    public int OrderId { get; }
    public IEnumerable<OrderItem> OrderItems { get; }

    public OrderCompletedDomainEvent(int orderId,
        IEnumerable<OrderItem> orderItems)
    {
        OrderId = orderId;
        OrderItems = orderItems;
    }
}