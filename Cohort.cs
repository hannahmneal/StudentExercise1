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

        public string cohortName { get; set; } = "";
        public int stuInCohort { get; set; } = 0;
        public string instructInCohort { get; set; } = "";

        /*
            A student can only be in one cohort at a time
            A student can be working on many exercises at a time
         */
        public Cohort(string argCohortName, int argStuInCohort, string argInstructInCohort)
        {
            cohortName = argCohortName;
            stuInCohort = argStuInCohort;
            instructInCohort = argInstructInCohort;
            Console.WriteLine($"{cohortName}; {stuInCohort} students, Instructor: {instructInCohort}");

        }
    }
}