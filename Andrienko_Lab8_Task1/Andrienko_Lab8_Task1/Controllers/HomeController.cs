using System.Web.Mvc;
using Andrienko_Lab8_Task1.Models;

namespace Andrienko_Lab8_Task1.Controllers
{

    public class HomeController : Controller
    {
        Product myProduct = new Product
        {
            ProductID = 1,
            Name = "Каяк",
            Description = "Лодка на одного человека",
            Category = "Водные виды спорта",
            Price = 275M
        };

        public ActionResult Index()
        {
            return View(myProduct);
        }

        public ActionResult NameAndPrice()
        {
            return View(myProduct);
        }
        public ActionResult DemoExpression()
        {

            ViewBag.ProductCount = 1;
            ViewBag.ExpressShip = true;
            ViewBag.ApplyDiscount = false;
            ViewBag.Supplier = null;

            return View(myProduct);
        }
        public ActionResult DemoArray()
        {
            Product[] array = {
                new Product {Name = "Каяк", Price = 275M},
                new Product {Name = "Спасательный жилет", Price = 48.95M},
                new Product {Name = "Футбольной мяч", Price = 19.50M},
                new Product {Name = "Угловой флажок", Price = 34.95M}
            };
            return View(array);
        }
    }
}
