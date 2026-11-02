using EFNetWelcomeApp;
using EFNetWelcomeApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.Extensions.Configuration;

using(CafeDbContext context = new())
{
    context.Database.EnsureDeleted();
    context.Database.EnsureCreated();

    Category salad = new() { Title = "Salad" };
    Category soup = new() { Title = "Soup" };
    Category mainCourse = new() { Title = "Main Course" };

    context.Categories.AddRange(salad, soup, mainCourse);
    context.SaveChanges();

    Dish olivier = new()
    {
        Title = "Olivier",
        CategoryId = salad.Id,
        Weight = 300,
        Price = 90
    };

    context.Dishes.Add(olivier);
    context.SaveChanges();
}



