using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_CafeClasses
{
    public enum OurMenu
    {
        
         Salad = 1,
         Coffee,
         Soups,
         Desserts 
    }
    // poco
    public class Meal
    {
        //what the class looks like
        public int MealNumber { get; set; }
        public string MealName { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public OurMenu ourMenu { get; set; }
        public List<string> Ingredients { get; set; } = new List<string>();


        public Meal() { }

        // constructor 
        public Meal(int mealNumber, string mealName, string description, double price, OurMenu menu, List<string> ingredients)

        {
            MealNumber = mealNumber;
            MealName = mealName;
            Description = description;
            Price = price;
            ourMenu = menu;
            Ingredients = ingredients;
        }

        
    }
}
