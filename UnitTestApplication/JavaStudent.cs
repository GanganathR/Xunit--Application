using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestApplication
{
   public   class JavaStudent:Student
    {
        public int CourseID { get; set; }

        public int GetCourseID()
        {
            return 200;
        }
    }
}
