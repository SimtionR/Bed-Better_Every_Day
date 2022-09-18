using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bed.Core.Models.Gym
{
    public class WorkoutExercise
    {
        public int Id { get; set; }
        public int ExerciseId { get; set; }
        public Exercise Exercise { get; set; }
        public int DesiredNumberOfReps { get; set; }
        public int SuccessfulReps { get; set; }
        public double Weight { get; set; }
        public TimeSpan ExerciseTime { get; set; }
    }
}
