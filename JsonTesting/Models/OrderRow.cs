namespace JsonTesting.Models
{
    public class OrderRow
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public virtual Order Order { get; set; }
        public int AmountOrdered { get; set; }
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }
        public decimal Price {get; set;}
        public int AmountShipped { get; set; }
    }
}