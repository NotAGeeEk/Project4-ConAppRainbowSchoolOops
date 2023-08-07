using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsAppRainbowSchoolOops
{
    public class SchoolData
    {
        private static SchoolData instance;
        private List<Student> students;
        private List<Teacher> teachers;
        private List<Subject> subjects;

        private SchoolData()
        {
            students = new List<Student>();
            teachers = new List<Teacher>();
            subjects = new List<Subject>();
        }

        public static SchoolData Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new SchoolData();
                }
                return instance;
            }
        }

        public List<Student> Students => students;
        public List<Teacher> Teachers => teachers;
        public List<Subject> Subjects => subjects;
    }
}
