using System;
using System.Collections.Generic;

namespace StudentExercises
{
    public class Exercise
    {
        //Constructor:
        public Exercise(string argExerciseName, string argExerciseLanguage)
        {
            exerciseName = argExerciseName;
            exerciseLanguage = argExerciseLanguage;
            exerciseList = new List<Exercise>();

            // Console.WriteLine($"EXERCISE: {exerciseName} LANGUAGE: {exerciseLanguage}");
        }

        /*
            Define props.
         */

        public string exerciseName { get; set; } = "";
        public string exerciseLanguage { get; set; } = "";
        public List<Exercise> exerciseList {get; set;}

        /*
            An exericse can be assigned to many students
         */

    }
}