using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Humans
{
    class Humans
    {
        protected string Name, Gender;
        protected DateTime Birthday;
        public Humans()
        {
            Name = "Human";
            Gender = "Men";
            Birthday = DateTime.Now.Date;
        }
        public Humans(Humans human)
        {
            Name = human.Name;
            Gender = human.Gender;
            Birthday = human.Birthday;
        }
        public Humans(string name, string gender, DateTime birthday)
        {
            SetName(name);
            SetGender(gender);
            SetBirthday(birthday);
        }
        public Humans(string name, string gender, int day, int month, int year)
        {
            SetName(name);
            SetGender(gender);
            SetBirthday(day, month, year);
        }
        public void SetName(string name)
        {
            if (name.Trim().Length < 1)
                throw new Exception("Ошибка вводка имени");
            else Name = name;
        }
        public void SetGender(string gender)
        {
            if (gender.Trim().Length < 3)
                throw new Exception("Ошибка вводка пола");
            else Gender = gender;
        }
        public void SetBirthday(DateTime birthday)
        {
            if (birthday.Year > 2019 || birthday.Year<1900)
                throw new Exception("Ошибка вводка даты рождения");
            else Birthday = birthday;
        }
        public void SetBirthday(int day, int month, int year)
        {
            if (year > 2019 || year < 1900 || day < 1 || day > 31 || month < 1 || month > 12)
                throw new Exception("Ошибка вводка даты рождения");
            else Birthday = new DateTime(year, month, day);
        }
        public string GetName()
        {
            return Name;
        }
        public string GetGender()
        {
            return Gender;
        }
        public DateTime GetBirthday()
        {
            return Birthday;
        }
    }
}
