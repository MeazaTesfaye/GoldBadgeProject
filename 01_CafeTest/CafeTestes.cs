﻿using System;
using System.Collections.Generic;
using _01_CafeClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _01_CafeTest
{
    [TestClass]
    public class CafeTestes
    {
        private Meal _meal;
        private CafeRepo _cafeRepo;


        [TestInitialize]
        public void MealTest()
        {
            _meal = new Meal(1, "Taco Salad", "Mixed Greens", 8.95,
              OurMenu.Salad, new List<string>()
            { "Chile, Sour Cream, Tomatoes" });
            _cafeRepo = new CafeRepo();
            _cafeRepo.AddMealToMenu(_meal);
            
        }
       // Add
        [TestMethod]
        public void AddToListNotNull()
        {
            //Arrange
            Meal meal = new Meal();
            meal.MealName = "Salad";
            CafeRepo cafe = new CafeRepo();

            //Act
            cafe.AddMealToMenu(meal);
            Meal mealFromDirectory = cafe.GetMealByMealName("Salad");

            //Assert
            List<Meal> meaDirectory = cafe.GetListOfMeals();
            Assert.IsNotNull(mealFromDirectory);

        }

        //delete
        [TestMethod]
        public void RemoveMealFromList()
        {
            //Arrange

            //Act
            bool deleteMeal = _cafeRepo.RemoveMealFromList(_meal.MealName);

            //Assert
            Assert.IsTrue(deleteMeal);
        }

    }

}
