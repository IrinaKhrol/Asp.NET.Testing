using Microsoft.AspNetCore.Mvc;
using static Testing.Models.Product;
using Testing.Models;
namespace SimpleApp.Controllers
{
    public class HomeController : Controller
    {
        public IDataSource dataSource = new ProductDataSource();
        public ViewResult Index()
        {
            return View(dataSource.Products);
        }
    }
}
