using System;
using System.Collections.Generic;

namespace StudentExercises
{
    public class Exercise
    {
        /*
            Define exercise props.
         */

        public int exerciseId {get; set;} = 0;
        public string exerciseName { get; set; } = "";
        public string exerciseLanguage { get; set; } = "";
        // public List<Exercise> exerciseList {get; set;}

        /*
            An exericse can be assigned to many students
         */

        //Constructor:
        public Exercise(string argExerciseName, string argExerciseLanguage, int argExerciseId)
        {
            exerciseName = argExerciseName;
            exerciseLanguage = argExerciseLanguage;
            // exerciseList = new List<Exercise>();
            exerciseId = argExerciseId;

            Console.WriteLine($"EXERCISE: {exerciseName}, LANGUAGE: {exerciseLanguage}, Exercise ID: {exerciseId}");

        }
        //  public void ListExercises() {
        //      foreach (Exercise exercise in exerciseList) {
                //  Console.WriteLine($"EXERCISE: {exerciseName}, LANGUAGE: {exerciseLanguage}");
        //          // When other methods are defined, you can call them here.
        //      }
        //  }

    }
}