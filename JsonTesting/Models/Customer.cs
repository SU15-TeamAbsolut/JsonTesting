namespace JsonTesting.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public int CreditLine { get; set; }
        public int PaymentTerm { get; set; }
        public int AccountingCode { get; set; }
        public long OrganizationNumber { get; set; }
        public int InvoiceAddressId { get; set; }
        public virtual Address InvoiceAddress { get; set; }
        public int VisitingAddressId { get; set; }
        public virtual Address VisitingAddress { get; set; }
    }
}