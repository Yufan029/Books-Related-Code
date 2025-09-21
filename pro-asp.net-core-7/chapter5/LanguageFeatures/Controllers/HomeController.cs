namespace LanguageFeatures.Controllers
{
    public class HomeController : Controller
    {
        public async Task<ViewResult> Index()
        {
            //ShoppingCart cart = new ShoppingCart
            //{
            //    Products = Product.GetProducts()
            //};

            //IProductSelection cart = new ShoppingCart(
            //    new Product { Name = "Kayak", Price = 275M },
            //    new Product { Name = "Lifejacket", Price = 48.95M },
            //    new Product { Name = "Soccer ball", Price = 19.50M },
            //    new Product { Name = "Corner flag", Price = 34.95M }
            //);

            //long? length = await MyAsyncMethods.GetPageLength();

            List<string> output = new List<string>();
            await foreach (long? len in MyAsyncMethods.GetPageLengths(output, "manning.com", "microsoft.com", "amazon.com"))
            {
                output.Add($"Page length: {len}");
            }

            return View(output);
        }
    }
}