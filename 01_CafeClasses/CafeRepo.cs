﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_CafeClasses
{
    // holds CRUD method
    public class CafeRepo
    {
        //class level variable 
        private List<Meal> _listOfMeals = new List<Meal>();
        //create 
        public void AddMealToMenu(Meal meal)
        {
            _listOfMeals.Add(meal);
        }

        //Read
        public List<Meal> GetListOfMeals()
        {
            return _listOfMeals;
        }
        
        //Delete
        public bool RemoveMealFromList(string mealName)
        {
            Meal order = GetMealByMealName(mealName);
            if (order == null)
            {
                return false;
            }
            //check if it removes it
             int intialCount = _listOfMeals.Count;
            _listOfMeals.Remove(order);
            if (intialCount > _listOfMeals.Count)
            {
                return true;
            }
            else return false;
        }

        //Helper - to get the correct 
        private Meal GetMealByMealName(string mealName)
        {
            //go for each meals to find the right meal
            foreach(Meal order in _listOfMeals)
            {
                if (order.MealName == mealName)
                    return order;
            }
            //if can't find it
            return null;
        }

    }
}
