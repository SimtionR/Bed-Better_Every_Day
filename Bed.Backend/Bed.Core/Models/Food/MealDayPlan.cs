using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bed.Core.Models.Food
{
    public class MealDayPlan
    {
        public int Id { get; set; }
        public int NumberOfMeals { get; set; }
        public List<Meal> Meals { get; set; }
        public MealRecomandations MealRecomandations { get; set; }
    }
}
