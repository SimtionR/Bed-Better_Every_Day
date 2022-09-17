using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bed.Core.Models.Food
{
    public class Meal
    {
        public int Id { get; set; }
        public double Calories { get; set; }
        public double Carbs { get; set; }
        public double Proteins { get; set; }
        public double Fats { get; set; }
        public MealCategory MealCategory { get; set; }
        public DateTime MealTime { get; set; }
    }
}
