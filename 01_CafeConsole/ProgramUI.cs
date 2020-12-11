
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
                "5. Exit");
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
            Console.WriteLine("Enter for meal number");
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
                "2.Soupsn" +
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
            List<Meal> listOfMeal = _cafeRepo.GetListOfMeals();
        }
        //View menu By Meal Name
        private void ViewMenuByMealName()
        {

        }

        //Delete Existing Menu
        private void DeleteExistingMenu()
        {

        }
    }

    
}
