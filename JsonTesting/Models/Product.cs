namespace JsonTesting.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int ProductNumber { get; set; }
        public int Volume { get; set; }
        public int PackageAmount { get; set; }
        public decimal AlcoholPercentage { get; set; }
        public int AccountingCode { get; set; }
        public int VatCode { get; set; }
        public int ProductCategoryId { get; set; }
        public virtual ProductCategory ProductCategory { get; set; }        
    }
}