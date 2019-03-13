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
        public Student(string argStuFirstName, string argStuLastName, string argStuSlack, Cohort argStuCohort) {
            stuFirstName = argStuFirstName;
            stuLastName = argStuLastName;
            stuSlack = argStuSlack;
            Cohort = argStuCohort;
            Assignment = new List<Exercise>();
            // Without a Cohort type defined here, the student cannot be sorted by the "string cohort" or stuCohort defined as a property below.

            // Console.WriteLine($"{stuFirstName} {stuLastName}, {stuSlack}, Cohort {Cohort.cohortName}");
        }
        /*
            Define student props.
            1. First name
            2. Last name
            3. Slack handle
            4. The student's cohort
            5. The collection of exercises that the student is currently working on (this will be an "Exercise List"/"Assignment List")
         */

        public string stuFirstName {get; set;} = "";
        public string stuLastName {get; set;} = "";
        public string stuSlack {get; set;} = "";
        public Cohort Cohort {get; set;}
        // The collection of exercises the student is currently working on:
        public List<Exercise> Assignment {get; set;}

    }
}