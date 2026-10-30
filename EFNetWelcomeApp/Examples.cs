using EFNetWelcomeApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFNetWelcomeApp
{
    static public class Examples
    {
        public static void AddContextExample(CafeDbContext context)
        {
            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();

            Category salad = new() { Title = "Salad" };
            Category soup = new() { Title = "Soup" };
            Category mainCourse = new() { Title = "Main Course" };

            context.Categories.Add(salad);
            context.Categories.AddRange(soup, mainCourse);

            List<Topping> toppings = new()
            {
                new() { Title = "Cheese" },
                new() { Title = "Sour Cream" },
                new() { Title = "Celery" }
            };
            context.Toppings.AddRange(toppings);

            Dish olivier = new()
            {
                Title = "Olivier",
                Category = salad,
                Toppings = new() { toppings[2] },
                Weight = 300,
                Price = 90
            };
            context.Dishes.Add(olivier);

            Dish shchi = new()
            {
                Title = "Cabbage Soup",
                Category = soup,
                Toppings = new() { toppings[0], toppings[2] },
                Weight = 350,
                Price = 70
            };

            Dish ragout = new()
            {
                Title = "Ragout",
                Category = mainCourse,
                Weight = 450,
                Price = 190
            };

            context.Dishes.AddRange(olivier, shchi, ragout);

            context.SaveChanges();
        }
    
        public static void SelectExample(CafeDbContext context)
        {
            //var categories = context.Categories;
            //Console.WriteLine("Categories:");
            //foreach(var category in categories)
            //    Console.WriteLine($"\t{category.Title}");

            var dishes = context.Dishes
                                .Include(d => d.Category)
                                .Include(d => d.Toppings);

            foreach (var dish in dishes)
            {
                Console.WriteLine($"Title: {dish.Title}, Price: {dish.Price}, Category: {dish.Category?.Title}");
                Console.WriteLine("Toppings:");
                foreach (var topping in dish.Toppings)
                    Console.WriteLine($"\t{topping.Title}");
            }
        }

        public static void CrudExample(CafeDbContext context)
        {
            // INSERT
            //Category dessert = new() { Title = "Desert" };
            //context.Categories.Add(dessert);


            // UPDATE
            //Category? category = context.Categories.FirstOrDefault(c => c.Title == "Desert");
            //if (category is null) return;
            //category.Title = "Dessert";

            // DELETE
            //Category? category = context.Categories
            //                            .FirstOrDefault(c => c.Title == "Dessert");
            //if (category is null) return;
            //context.Categories.Remove(category);

            //context.SaveChanges();
        }
    }
}
