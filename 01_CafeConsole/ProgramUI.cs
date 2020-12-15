
using _01_CafeClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_CafeConsole
{
    public class ProgramUI
    {
        private CafeRepo _cafeRepo = new CafeRepo();
       
        //method that runs/starts the application
        public void Run()
        {
            SeedMealList();
            Menu();
        }

        //Menu
        private void Menu()
        {
            //Display option to the user
            Console.WriteLine("Select a menu option:\n" +
                "1.Create a new menu\n" +
                "2.View all menu\n" +
                "3.View menu By Meal Name\n" +
                "4.Delete Existing menu\n" +
                "5.Exit");
            string input = Console.ReadLine();
            //Evaluate the user's input and act accordingly
            switch (input)
            {
                case "1":
                    //create a menu
                    CreateNewMenu();
                    break;
                case "2":
                    ViewCurrentMemu();
                    //Display all Menu
                    break;
                case "3":
                    //View menu BY Meal Name
                    ViewMenuByMealName();
                    break;
                case "4":
                    DeleteExistingMenu();
                    //Delet existing menu
                    break;
                case "5":
                    //Exist
                    Console.WriteLine("Goodbye");
                    break;

                default:
                    Console.WriteLine("please Enter a valid number");
                    break;

            }
            Console.WriteLine("Enter any key to continue");
            Console.ReadLine();
            Console.Clear();
        }
        //Create new Menu
        private void CreateNewMenu()
        {
            Console.Clear();
            Meal newMeal = new Meal();
            //MealNumber
            Console.WriteLine("Enter for a meal number");
            string mNum = Console.ReadLine();
            newMeal.MealNumber = int.Parse(mNum);
            
            // Meal Name
            Console.WriteLine("Please enter the meal name");
            newMeal.MealName = Console.ReadLine();

            //description
            Console.WriteLine("Enter the description for the menu:");
            newMeal.Description = Console.ReadLine();
            
            //price 
            Console.WriteLine("Please enter price ");
            string priceAsString = Console.ReadLine();
            newMeal.Price = double.Parse(priceAsString);
            
            //our menu
            Console.WriteLine("Enter the Menu nember\n" +
                "1.CooffeDrinks\n" +
                "2.Soupsn\n" +
                "3.Salads\n" +
                "4.Desserts");
            string ourMenuAsString = Console.ReadLine();
            int ourMenuAsInt = int.Parse(ourMenuAsString);
            newMeal.ourMenu = (OurMenu)ourMenuAsInt;
           
            //Ingridients 
            bool AddIngredient = true;
            while(AddIngredient)
            {
                Console.WriteLine("Would like to add an ingredient?");
                string input = Console.ReadLine().ToLower();
                if (input == "y" || input == "yes")
                {
                    Console.WriteLine("Please enter one ingredient");
                    string ingredientInput = Console.ReadLine();
                    newMeal.Ingredients.Add(ingredientInput);
                    AddIngredient = true;
                }
                else
                {
                    AddIngredient = false;
                }
            }
            Console.WriteLine("Please press any key to exist ");
            _cafeRepo.AddMealToMenu(newMeal);
        }
        //View all Menu
        private void ViewCurrentMemu()
        {
            Console.Clear();
            List<Meal> listOfMeal = _cafeRepo.GetListOfMeals();
            foreach(Meal newMeal in listOfMeal)
            {
                Console.WriteLine($"Meal: {newMeal.MealName}\n" +
                    $"Description: {newMeal.Description}");
            }
        }
        //View menu By Meal Name
        private void ViewMenuByMealName()
        {
            Console.Clear();
            Console.WriteLine("Please enter the Meal number you like to order:");
            string mealName = Console.ReadLine();
            Meal newMeal = _cafeRepo.GetMealByMealName(mealName);

            if(newMeal!= null)
            {
                Console.WriteLine($"Meal: {newMeal.MealNumber}\n" +
                    $"Meal Name: {newMeal.MealName}" +
                    $"Description: {newMeal.Description}\n" +
                    $"Price: {newMeal.Price}\n" +
                    $"Our Menu: {newMeal.ourMenu}\n" +
                    $"Ingredients: {newMeal.Ingredients}");
            }

            else
            {
                Console.WriteLine("There is no menu name by that name");
              
            }
        }

        //Delete Existing Menu
        private void DeleteExistingMenu()
        {
             Console.Clear();
            ViewCurrentMemu();
            Console.WriteLine("Please enter the menu you would like to delete?");
            string input = Console.ReadLine();
            bool wasDeleted = _cafeRepo.RemoveMealFromList(input);
            if (wasDeleted)
            {
                Console.WriteLine("The menu was successfully deleted.");
            }
            else
            {
                Console.WriteLine("The menu could not be deleted.");
            }
           
        }

            private void SeedMealList()
        {
            
            
            Meal tacoSalad = new Meal(1, "Taco Salad", "Mixed Greens", 8.95, OurMenu.Salad, new List<string>() { "Chile, Sour Cream, Tomatoes" });
            Meal coffee = new Meal(2, "Cappuccino", "Hot", 2.79, OurMenu.Coffee, new List<string>(){ "milk froth, steamed milk"} );
            Meal soup = new Meal(3, "Cream Of Chicken", "Thick Creamy soup Made with stock and pieces", 13.23, OurMenu.Soups, new List<string>() { "chicken, butter" });

            _cafeRepo.AddMealToMenu(tacoSalad);
            _cafeRepo.AddMealToMenu(coffee);
            _cafeRepo.AddMealToMenu(soup);

        }
    }

    
}
