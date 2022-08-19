namespace EntityLayer.Concrete
{
    public class Company
    {
        public int CompanyID { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public int AboutID { get; set; }
        public virtual About About { get; set; }

        public List<Product> Products { get; set; }
    }
}
