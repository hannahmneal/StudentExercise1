using System;

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
        public Cohort(string argCohortName, string argInstructInCohort)
        {
            cohortName = argCohortName;
            instructInCohort = argInstructInCohort;

            Console.WriteLine($"{cohortName}, Instructor: {instructInCohort}");
        }

        public string cohortName { get; set; } = "";
        public string instructInCohort { get; set; } = "";

        /*
            A student can only be in one cohort at a time
            A student can be working on many exercises at a time
         */

    }
}