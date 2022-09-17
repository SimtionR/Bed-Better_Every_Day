using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bed.Core.Models.Gym
{
    public class WorkoutDayPlan
    {
        public int Id { get; set; }
        public WorkoutType WorkoutType { get; set; }
        public List<WorkoutExercise> WorkoutExercises { get; set; } = new();
        public DateTime Start { get; set; }
        public DateTime End { get; set; }


    }
}
