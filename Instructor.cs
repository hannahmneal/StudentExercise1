using System;

namespace StudentExercises
{
    public class Instructor
    {
        /*
            Define instructor props.
            - "stu" is abbreviation for "student".
            - "Slack" is abbreviation for "SlackHandle".
            - "instruct" is abbreviation for "instrcutor".

         */

        public string instructFirstName { get; set; } = "";
        public string instructLastName { get; set; } = "";
        public string instructSlack { get; set; } = "";
        public int instructCohort { get; set; } = 0;

        public Instructor(string argInstructFirstName, string argInstructLastName, string argInstructSlack, int argInstructCohort)
        {
            instructFirstName = argInstructFirstName;
            instructLastName = argInstructLastName;
            instructSlack = argInstructSlack;
            instructCohort = argInstructCohort;

            /*
                You must also define a method to assign exercises to a student
             */
        }
    }
}