using System.Web.Mvc;
using Andrienko_Lab8_Task3.Models;
using Ninject;
namespace Andrienko_Lab8_Task3.Controllers
{
    public class HomeController : Controller
    {
        private IValueCalculator calc;

        private Product[] products = {
            new Product {Name = "Каяк", Category = "Водные виды спорта", Price = 275M},
            new Product {Name = "Спасательный жилет", Category = "Водные виды спорта", Price = 48.95M},
            new Product {Name = "Мяч", Category = "Футбол", Price = 19.50M},
            new Product {Name = "Угловой флажок", Category = "Футбол", Price = 34.95M}
        };

        public HomeController(IValueCalculator calcParam, IValueCalculator calc2)
        {
            calc = calcParam;
        }

        public ActionResult Index()
        {
            ShoppingCart cart = new ShoppingCart(calc)
            {
                Products = products
            };
            decimal totalValue = cart.CalculateProductTotal();
            return View(totalValue);
        }
    }
}