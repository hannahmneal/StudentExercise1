using System;

namespace StudentExercises
{
    public class Instructor
    {
        public Instructor(string argInstructFirstName, string argInstructLastName, string argInstructSlack, Cohort argInstructCohort)
        {
            instructFirstName = argInstructFirstName;
            instructLastName = argInstructLastName;
            instructSlack = argInstructSlack;
            Cohort = argInstructCohort;

            // Console.WriteLine($"{instructFirstName} {instructLastName}, SLACK: {instructSlack}, TEACHING: {instructCohort}");

            /*
                You must also define a method to assign exercises to a student
             */
        }

        /*
            Define instructor props.
            - "stu" is abbreviation for "student".
            - "Slack" is abbreviation for "SlackHandle".
            - "instruct" is abbreviation for "instrcutor".

         */

        public string instructFirstName { get; set; } = "";
        public string instructLastName { get; set; } = "";
        public string instructSlack { get; set; } = "";
        public Cohort Cohort {get; set;}

        /*
            Instructions say, "Have each instructor assign 2 exercises to each of the students". Define a method here to do that.
         */

         public void AssignExercise(Exercise assignment, Student student) {
             student.Assignment.Add(assignment);
         }

    }
}