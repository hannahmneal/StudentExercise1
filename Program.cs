using System;

namespace StudentExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                1. Create 4, or more, exercises.
                2. Create 3, or more, cohorts.
                3. Create 4, or more, students and assign them to one of the cohorts.
                4. Create 3, or more, instructors and assign them to one of the cohorts.
                5. Have each instructor assign 2 exercises to each of the students.
             */

             Exercise exercise1 = new Exercise("Celebrity Tribute", "HTML and CSS");
             Exercise exercise2 = new Exercise("Welcome to Nashville", "Javascript");
             Exercise exercise3 = new Exercise("Nutshell", "Javascript");
             Exercise exercise4 = new Exercise("Nutshell", "React");

            Cohort cohort29 = new Cohort("Cohort 29", "Andy");
            Cohort cohort30 = new Cohort("Cohort 30", "Jisie");
            Cohort cohort31 = new Cohort("Cohort 31", "Joe");

            Student stu1 = new Student("Hannah", "Neal", "@hannahmneal", "29" );
            Student stu2 = new Student("Dek", "Haji", "@dekhaji", "31");
            Student stu3 = new Student("Brian", "Neal", "@brianbneal", "30");

        }
    }
}
