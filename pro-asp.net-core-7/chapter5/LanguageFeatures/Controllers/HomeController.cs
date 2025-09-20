namespace LanguageFeatures.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            ShoppingCart cart = new ShoppingCart
            {
                Products = Product.GetProducts()
            };

            return View(new string[] { 
                $"Cart total: {cart.TotalPrices()}"
             });
        }
    }
}