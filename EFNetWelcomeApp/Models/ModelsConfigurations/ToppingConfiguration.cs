using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFNetWelcomeApp.Models.ModelsConfigurations
{
    public class ToppingConfiguration : IEntityTypeConfiguration<Topping>
    {
        public void Configure(EntityTypeBuilder<Topping> builder)
        {
            

            builder.HasKey(t => t.Id);

            builder.HasAlternateKey(t => t.Title);

            builder.Property(t => t.Title)
                   .HasMaxLength(100)
                   .IsRequired();
                   
        }
    }
}
