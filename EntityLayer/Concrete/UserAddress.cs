namespace MVCCoreProject.Models.Entities
{
    public class UserAddress
    {
        public int UserAddresID { get; set; }
        public string Title { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public int CustomerID { get; set; }
        public bool Active { get; set; }

        public virtual Customer Customer { get; set; }
    }
}
