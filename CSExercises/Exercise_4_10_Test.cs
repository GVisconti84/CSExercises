using System;
using System.Collections.Generic;
using System.Text;

namespace CSExercises
{
    class GradeBookTest
    {
        public static void LocalMain(string[] args)
        {
            GradeBook gradeBook = new GradeBook("Corso di c# fatto serio", "Gabriele Visconti");
            gradeBook.DisplayMessage();
        }
    }
}
