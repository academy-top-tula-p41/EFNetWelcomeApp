using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFNetWelcomeApp.Models
{
    public class Dish
    {
        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public int Weight { get; set; }
        public Category? Category { get; set; }
        public decimal Price { get; set; }

        public List<Topping>? Toppings { get; set; }
    }
}
