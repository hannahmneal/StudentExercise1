using System;
using System.Collections.Generic;

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
            /*
            Here, you are using the method in Cohort.cs to name a new cohort and create a list of students and instructors associated with the cohort you just named:
             */
            Cohort c29 = new Cohort("Cohort 29");

            Cohort c30 = new Cohort("Cohort 30");

            Cohort c31 = new Cohort("Cohort 31");

             Exercise exercise1 = new Exercise("Celebrity Tribute", "HTML and CSS");
             Exercise exercise2 = new Exercise("Welcome to Nashville", "Javascript");
             Exercise exercise3 = new Exercise("Nutshell", "Javascript");
             Exercise exercise4 = new Exercise("Nutshell", "React");
             Exercise exercise5 = new Exercise("Capstone", "React");
             Exercise exercise6 = new Exercise("LINQ Exercises", "C#");

            Instructor instruct1 = new Instructor("Andy", "Collins", "@andycollins", c29);
            Instructor instruct2 = new Instructor("Steve", "Brownley", "@steve", c30);
            Instructor instruct3 = new Instructor("Jisie", "David", "@jisiedavid", c31);


            Student stu1 = new Student("Hannah", "Neal", "@hannahmneal", c29 );
            Student stu2 = new Student("Joel", "Mondesir", "@joelmondesir", c31);
            Student stu3 = new Student("Brian", "Neal", "@brianbneal", c30);


            /*
            Here, you are creating a list of students and adding the student objects (created above) to it. These student lists will be used with the Instructor type to assign exercises to the students.
            */

            List<Student> studentList29 = new List<Student>() {
                stu1
            };

            // AssignExercise is in Instructor.cs; it is a method that adds the Exercise type from Exercise.cs to the Assignment list (type) in Student.cs; i.e., AssignExercise adds a new exercise to the Assignment list for each student object.

            instruct1.AssignExercise(exercise5, stu1);
            instruct1.AssignExercise(exercise6, stu1);

            List<Student> studentList30 = new List<Student>() {
                stu3
            };

            instruct2.AssignExercise(exercise4, stu3);
            instruct2.AssignExercise(exercise5, stu3);

            List<Student> studentList31 = new List<Student>() {
                stu2
            };

            instruct3.AssignExercise(exercise2, stu2);
            instruct3.AssignExercise(exercise3, stu2);

            List<Student> allStudents= new List<Student>() {
                stu1, stu2, stu3
            };

            /*
            Here, you are creating a list of Exercises and adding the student objects (created above) to it:
            */

            foreach(Student student in allStudents) {
                List<string> stuExercises = new List<string>();
                foreach(Exercise stuExercise in student.Assignment) {
                    stuExercises.Add(stuExercise.exerciseName);
                }
                Console.WriteLine($"{student.stuFirstName} {student.stuLastName} EXERCISE: {String.Join(", " ,stuExercises)} {student.Cohort.cohortName}");
            }

        }
    }
}
