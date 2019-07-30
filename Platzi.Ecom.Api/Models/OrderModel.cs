namespace Platzi.Ecom.Api.Controllers
{
    public class OrderModel
    {
        public int CustomerId { get; set; }
        public int[] Products { get; set; }
    }
}