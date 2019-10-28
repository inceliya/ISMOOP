using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Humans
{
    class Teacher : Humans
    {
        protected string Subject, Faculte;
        public Teacher()
        {
            Subject = "subject";
            Faculte = "faculte";
        }
        public Teacher(Teacher teacher) : base(teacher.Name, teacher.Gender, teacher.Birthday)
        {
            Subject = teacher.Subject;
            Faculte = teacher.Faculte;
        }
        public Teacher(string name, string gender, DateTime birthday, string subject, string faculte) : base(name, gender, birthday)
        {
            SetSubject(subject);
            SetFaculte(faculte);
        }
        public Teacher(Humans human, string subject, string faculte) : base(human)
        {
            SetSubject(subject);
            SetFaculte(faculte);
        }
        public void SetSubject(string subject)
        {
            if (subject.Trim().Length < 2)
                throw new Exception("Ошибка ввода предмета");
            else Subject = subject;
        }
        public void SetFaculte(string faculte)
        {
            if (faculte.Trim().Length < 2)
                throw new Exception("Ошибка ввода факультета");
            else Faculte = faculte;
        }
        public string GetSubject()
        {
            return Subject;
        }
        public string GetFaculte()
        {
            return Faculte;
        }
    }
}
