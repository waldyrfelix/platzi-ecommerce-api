namespace Platzi.Ecom.Core.Orders
{
    public enum OrderStatus
    {
        Placed,
        PaymentPending,
        PaymentApproved,
        PaymentRejected,
        Invoiced,
        Cancelled
    }
}