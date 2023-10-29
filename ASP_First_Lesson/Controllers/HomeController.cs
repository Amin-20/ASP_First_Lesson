using ASP_First_Lesson.Entities;
using ASP_First_Lesson.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ASP_First_Lesson.Controllers
{
    public class HomeController : Controller
    {
        public List<Drink> Drinkss { get; set; } = new List<Drink>
        {
            new Drink
            {
                Id = 1,
                Name = "Fanta",
                Price = 1.1
            },
            new Drink
            {
                Id=2,
                Name = "Cola",
                Price = 1.2
            },
            new Drink
            {
                Id = 3,
                Name = "Sprite",
                Price = 1.3
            }
        };
        public List<FastFood> FastFoodss { get; set; } = new List<FastFood>
        {
            new FastFood
            {
                Id = 1,
                Name = "Burger",
                Price = 4
            },
            new FastFood
            {
                Id = 2,
                Name = "Pizza",
                Price = 13
            },
            new FastFood
            {
                Id = 3,
                Name = "Fri",
                Price = 2
            }
        };
        public List<HotMeal> HotMealss { get; set; } = new List<HotMeal>
        {
            new HotMeal
            {
                Id = 1,
                Name = "Dolma",
                Price = 3
            },
            new HotMeal
            {
                Id = 2,
                Name = "Piti",
                Price = 4
            },
            new HotMeal
            {
                Id = 3,
                Name = "Sac",
                Price = 5
            }
        };

        public ViewResult Restorant()
        {
            var restorant = new RestorantViewModel
            {
                Drinks = Drinkss,
                FastFoods = FastFoodss,
                HotMeals = HotMealss,
            };

            return View(restorant);
        }

        public IActionResult Drinks()
        {
            return View(Drinkss);
        }

        public IActionResult FastFoods()
        {
            return View(FastFoodss);
        }

        public IActionResult HotMeals()
        {
            return View(HotMealss);
        }


    }
}
