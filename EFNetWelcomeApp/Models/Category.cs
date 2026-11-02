using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFNetWelcomeApp.Models
{
    //[Table("dishes_categories")]
    //[Index("Title")]
    public class Category
    {
        //[Column("category_id")]
        //[Key]
        public int Id { get; set; }

        //[Column("title")]
        //[Required]
        //[MaxLength(50)]
        public string Title { get; set; } = null!;
        public List<Dish>? Dishes { get; set; } = new();
    }
}
