using System;
using System.Collections.Generic;

namespace StudentExercises
{
    public class Student
    {
        /*
            A student can only be in one cohort at a time
            A student can be working on many exercises at a time
         */
        public Student(string argStuFirstName, string argStuLastName, string argStuSlack, int argStuCohort, string argStuExercises) {
            stuFirstName = argStuFirstName;
            stuLastName = argStuLastName;
            stuSlack = argStuSlack;
            stuCohort = argStuCohort;
            stuExercises = argStuExercises;
            Assignment = new List<Exercise>();
        }
        /*
            Define student props.
            - "stu" is abbreviation for "student".
            - "Slack" is abbreviation for "SlackHandle".

         */

        public string stuFirstName {get; set;} = "";
        public string stuLastName {get; set;} = "";
        public string stuSlack {get; set;} = "";
        public int stuCohort {get; set;} = 0;
        public string stuExercises {get; set;} = "";
        public List<Exercise> Assignment {get; set;}

        public Student(string stuFirstName, string stuLastName, string stuSlack) {
            Console.WriteLine($"{stuFirstName} {stuLastName}, {stuSlack}, Cohort {stuCohort}");
        }
        public void ListStudentAssignments() {

            foreach (Exercise exercise in Assignment) {
                Console.WriteLine($"EXERCISE: {exercise.exerciseName} LANGUAGE: {exercise.exerciseLanguage}");
            }
        }



    }
}