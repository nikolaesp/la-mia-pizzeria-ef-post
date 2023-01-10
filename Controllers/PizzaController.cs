using LaMiaPizzeria.Models;
using LaMiaPizzeria.Utils;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;

namespace LaMiaPizzeria.Controllers
{
    public class PizzaController : Controller
    {
      

        public IActionResult Index()
        {
            List<Pizza> listaDeiPost = PizzaData.GetPizzas();

            return View("Index", listaDeiPost);
        }

        public IActionResult Details(int id)
        {
            List<Pizza> listaDeiPost = PizzaData.GetPizzas();

            foreach (Pizza pizza in listaDeiPost)
            {
                if (pizza.Id == id)
                {
                    return View(pizza);
                }
            }

            return NotFound("Non ci sono pizze presenti");
        }
    }
}
