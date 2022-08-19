using EntityLayer.Concrete;

namespace MVCCoreProject.Models.Entities
{
    public class ProductDiscount
    {
        public int ProductDiscountID { get; set; }
        public int ProductID { get; set; }
        public decimal Discount { get; set; }
        public virtual Product Product { get; set; }
    }
}
