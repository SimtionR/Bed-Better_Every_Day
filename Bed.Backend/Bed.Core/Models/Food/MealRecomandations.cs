using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bed.Core.Models.Food
{
    public class MealRecomandations
    {
        public int Id { get; set; }
        public double TotalCaloriesPerDay { get; set; }
        public double TotalProteinPerDay { get; set; }
        public double TotalFatsPerDay { get; set; }
        public double TotalCarbsPerDay { get; set; }

    }
}
