using System;
using System.Collections.Generic;
using System.Text;

namespace CSExercises
{
    public class GradeBook
    {
        public string CourseName { get; set; }
        public string TeacherName { get;  set; }

        public GradeBook(string courseName, string teacherName)
        {
            CourseName = courseName;
            TeacherName = teacherName;
        }

        

        public void DisplayMessage()
        {
            Console.WriteLine("Welcome to the grade book for: {0}", CourseName);
            Console.WriteLine("The course is presented by: {0}", TeacherName);
        }
    }
}
