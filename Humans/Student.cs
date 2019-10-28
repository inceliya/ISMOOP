using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Humans
{
    class Student: Humans
    {
        protected string Group, Faculte;
        protected byte Course;
        public Student()
        {
            Group = "group";
            Faculte = "faculte";
            Course = 1;
        }
        public Student(Student student) : base(student.Name, student.Gender, student.Birthday)
        {
            Group = student.Group;
            Faculte = student.Faculte;
            Course = student.Course;
        }
        public Student(string name, string gender, DateTime birthday, string group, string faculte, byte course) :base(name, gender, birthday)
        {
            SetGroup(group);
            SetFaculte(faculte);
            SetCourse(course);
        }
        public Student(Humans human, string group, string faculte, byte course) : base(human)
        {
            SetGroup(group);
            SetFaculte(faculte);
            SetCourse(course);
        }
        public void SetGroup(string group)
        {
            if (group.Trim().Length < 2)
                throw new Exception("Ошибка ввода группы");
            else Group = group;
        }
        public void SetFaculte(string faculte)
        {
            if (faculte.Trim().Length < 2)
                throw new Exception("Ошибка ввода факультета");
            else Faculte = faculte;
        }
        public void SetCourse(byte course)
        {
            if (course < 1 || course > 6)
                throw new Exception("Ошибка ввода курса");
            else Course = course;
        }
        public string GetGroup()
        {
            return Group;
        }
        public string GetFaculte()
        {
            return Faculte;
        }
        public byte GetCourse()
        {
            return Course;
        }

    }
}
