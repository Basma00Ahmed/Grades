using System;

namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            GradeBook book=new GradeBook();
            book.AddGrade(91);
            book.AddGrade(81.5f);
            GradeBook book2 = new GradeBook();
            book2.AddGrade(75);

        }
    }
}
