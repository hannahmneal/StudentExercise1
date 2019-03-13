using System;
using System.Collections.Generic;

namespace StudentExercises
{
    public class Cohort
    {
        /*
            Define cohort props.
            - "stu" is abbreviation for "students"
            - the cohort type must include the cohort name, collection of students in cohort, and collection of instructors in cohort
            - "instruct" is abbreviation for "instructor"
         */
        public Cohort(string argCohortName)
        {
            cohortName = argCohortName;
            instructInCohort = new List<Instructor>();
            studentInCohort = new List<Student>();

            // Console.WriteLine($"{cohortName}");
        }

        public string cohortName { get; set; } = "";
        public List<Instructor> instructInCohort { get; set;}
        public List<Student> studentInCohort { get; set;}

        /*
            A student can only be in one cohort at a time
            A student can be working on many exercises at a time
         */

    }
}