namespace MVCCoreProject.Models.Entities
{
    public class Customer
    {
        public int CustomerID { get; set; }
        public string UserName { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public string MailAddress { get; set; }
        public string Password { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }

        public List<UserAddress> userAddresses { get; set; }
    }
}