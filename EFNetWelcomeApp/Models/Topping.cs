using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFNetWelcomeApp.Models
{
    public class Topping
    {
        public int Id { get; set; }
        public string Title { get; set; } = null!;

        public List<Dish>? Dishes { get; set; } = new();
    }
}
