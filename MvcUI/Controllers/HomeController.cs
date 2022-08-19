using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MvcUI.Controllers
{
    public class HomeController : Controller
    {
        // GET: HomeController
        ProductManager pm = new ProductManager(new EfProductRepository());
        public ActionResult Index()
        {
            var value = pm.GetProductListWithCategory();
            return View(value);
        }
    }
}
