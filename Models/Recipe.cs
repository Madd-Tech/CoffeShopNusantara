using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeShopNusantara.Models
{
    public class Recipe
    {
        public int IdRecipe { get; set; }
        public string Code { get; set; }
        public string? Name { get; set; }
        public string? Type { get; set; }
        public int IdItemA { get; set; }
        public int IdItemB { get; set; }
        public int IdItemC { get; set; }
        public int IdItemD { get; set; }
        public double QtyItemA { get; set; }
        public double QtyItemB { get; set; }
        public double QtyItemC { get; set; }
        public double QtyItemD { get; set; }
        public string RecipeInstruction { get; set; }
        public string SavingInstruction { get; set; }
        public DateTime LastUpdate { get; set; } 
        public string IsDeleted { get; set; }

    }

}
