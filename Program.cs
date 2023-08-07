using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsAppRainbowSchoolOops
{
    class Program
    {
        static void Main(string[] args)
        {
           
            SchoolManager schoolManager = new SchoolManager();
            schoolManager.AddStudent("Aman Saxena ","Class 10A");
            schoolManager.AddStudent("Kc Singh", "Class 9B");
            schoolManager.AddTeacher("Mrs Mani Sharma", "Class 10A");
            schoolManager.AddTeacher("Mrs Indu Rastogi", "Class 9B");
            schoolManager.AddSubject("Math", "MAT101", SchoolData.Instance.Teachers[0]);
            schoolManager.AddSubject("Science", "SCI201", SchoolData.Instance.Teachers[1]);

            
            schoolManager.DisplayStudentsInClass("Class 10A");

            
            schoolManager.DisplaySubjectsTaughtByTeacher("Mrs Indu Rastogi");
        }
    }
}

