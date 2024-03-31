using System;

namespace UnitTestApplication
{
   public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }


        public int GetStudentID(string email)
        {
            if (string.IsNullOrEmpty(email))
            {
                throw new ArgumentException("Email is requied");
            }
            return 10;
        }


        public Student GetStudentByCourseID(int courseid)
        {
            if (courseid ==100)
            {
                return new CSharpStudent();
            }
            return new JavaStudent();
        }

        public bool IsOdd(int value)
        {
            if (value % 2 == 1)
            {
                return true;
            }

            return false;
        }
    }
}
