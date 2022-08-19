using MVCCoreProject.Models.Entities;

namespace EntityLayer.Concrete
{
    public class Product
    {
        public int ProductID { get; set; }
        public string Color { get; set; }
        public string ProductName { get; set; }
        public string QuantityPerUnit { get; set; }
        public decimal UnitPrice { get; set; }
        public int UnitsInStock { get; set; }
        public bool Discontinued { get; set; }

        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }

        public int CompanyID { get; set; }
        public virtual Company Company { get; set; }

        public List<Comment> Comments { get; set; }

        public int ProductDiscountID { get; set; }
        public virtual ProductDiscount ProductDiscount { get; set; }
    }
}
