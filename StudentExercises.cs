using System;

namespace StudentExercises
{
    public class StudentExercise
    {

        public StudentExercise(int argAssignedExercise)
        {
            assignedExerciseId = argAssignedExercise;
        }
        public int assignedExerciseId {get; set;} = 0;
    }
}