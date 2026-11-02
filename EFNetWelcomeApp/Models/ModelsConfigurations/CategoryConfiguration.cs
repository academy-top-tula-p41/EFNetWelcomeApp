using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFNetWelcomeApp.Models.ModelsConfigurations
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            //FluentApiCategoryExample(builder);
        }

        void FluentApiCategoryExample(EntityTypeBuilder<Category> builder)
        {
            //builder
            //            .Property(c => c.Id)
            //            .HasColumnName("id_category");

            //builder
            //            .ToTable("categories_of_dishes");

            //builder
            //            .Property(c => c.Title)
            //            .HasColumnName("title_category");

            //builder
            //            .Property(c => c.Title)
            //            .HasColumnName("title_category")
            //            .HasMaxLength(60)
            //            .IsRequired();

            //builder
            //            .HasKey(c => c.Position)
            //            .HasName("PK_Categories_Position");

            //builder
            //            .HasKey(c => new { c.Id, c.Title });

            //builder
            //            .HasAlternateKey(c => c.Title);

            //builder
            //            .HasIndex(c => c.Title)
            //            .IsUnique();

            //builder
            //            .Property(c => c.Date)
            //            .HasDefaultValueSql("GETDATE()");
        }
    }
}
