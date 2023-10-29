using ASP_First_Lesson.Entities;
using System.Collections.Generic;

namespace ASP_First_Lesson.Models
{
    public class RestorantViewModel
    {
        public List<Drink> Drinks { get; set; }
        public List<FastFood> FastFoods { get; set; }
        public List<HotMeal> HotMeals { get; set; }
    }
}
