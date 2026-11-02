using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace EFNetWelcomeApp.Models
{
    //[Index("Title", "CategoryId")]
    public class Dish
    {
        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public int Weight { get; set; }

        //[ForeignKey(nameof(CategoryId))]
        public Category? Category { get; set; }
        public int? CategoryId { get; set; }
        public decimal Price { get; set; }

        public List<Topping>? Toppings { get; set; } = new();
    }
}
