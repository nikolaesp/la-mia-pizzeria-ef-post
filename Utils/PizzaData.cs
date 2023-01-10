using LaMiaPizzeria.Models;
using Microsoft.Extensions.Hosting;

namespace LaMiaPizzeria.Utils
{
    public class PizzaData
    {
        private static List<Pizza> pizzas= new();
        public static List<Pizza> GetPizzas()
        {
            for (int i = 0; i < 10; i++)
            {
                Pizza pizzaGenerato = new Pizza(i, "Pizza #" + i, "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.", "https://img.freepik.com/free-photo/top-view-pepperoni-pizza-with-mushroom-sausages-bell-pepper-olive-corn-black-wooden_141793-215"+i+".jpg?w=300");
                pizzas.Add(pizzaGenerato);
            }

            return pizzas;
        }
    }
}
