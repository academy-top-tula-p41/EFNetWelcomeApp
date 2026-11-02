using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFNetWelcomeApp.Models.ModelsConfigurations
{
    public class DishConfiguration : IEntityTypeConfiguration<Dish>
    {
        public void Configure(EntityTypeBuilder<Dish> builder)
        {
            builder.HasOne(d => d.Category)
                   .WithMany(c => c.Dishes)
                   .HasForeignKey(d => d.CategoryId);

        }

        void FluentApiDishExample(EntityTypeBuilder<Dish> builder)
        {
            //builder
            //            .HasIndex(d => new { d.Title, d.CategoryId })
            //            .HasDatabaseName("IX_dishes_title_category_id");

            //builder
            //            .ToTable(t => t.HasCheckConstraint("CH_dishes_price", "Price >= 0"));

            //builder
            //            .Property(d => d.Price)
            //            .HasDefaultValue(0);
        }
    }
}
