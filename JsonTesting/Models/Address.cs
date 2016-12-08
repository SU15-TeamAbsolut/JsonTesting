namespace JsonTesting.Models
{
    public class Address
    {
        public int Id { get; set; }
        public string Street { get; set; }
        public string ZipNumber { get; set; }
        public string City { get; set; }
        public int CountryId { get; set; }
        public virtual Country Country { get; set; }
    }
}