using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsAppRainbowSchoolOops
{
    public class SchoolManager
    {
        public void AddStudent(string name, string classSection)
        {
            SchoolData.Instance.Students.Add(new Student { Name = name, ClassSection = classSection });
        }

        public void AddTeacher(string name, string classSection)
        {
            SchoolData.Instance.Teachers.Add(new Teacher { Name = name, ClassSection = classSection });
        }

        public void AddSubject(string name, string subjectCode, Teacher teacher)
        {
            SchoolData.Instance.Subjects.Add(new Subject { Name = name, SubjectCode = subjectCode, Teacher = teacher });
        }

        public void DisplayStudentsInClass(string classSection)
        {
            var students = SchoolData.Instance.Students.Where(s => s.ClassSection == classSection).ToList();
            Console.WriteLine($"Students in class {classSection}:");
            foreach (var student in students)
            {
                Console.WriteLine($"{student.Name}");
            }
        }

        public void DisplaySubjectsTaughtByTeacher(string teacherName)
        {
            var subjects = SchoolData.Instance.Subjects.Where(s => s.Teacher.Name == teacherName).ToList();
            Console.WriteLine($"{teacherName} teaches the following subjects:");
            foreach (var subject in subjects)
            {
                Console.WriteLine($"{subject.Name} (Subject Code: {subject.SubjectCode})");
            }
        }
    }
}
