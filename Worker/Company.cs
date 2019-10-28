using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worker
{
    class Company
    {
        protected string Name, Position;
        protected int Salary;

        public Company()
        {
            Name = "Компания";
            Position = "Должность";
            Salary = 0;
        }
        public Company(Company company)
        {
            Name = company.Name;
            Position = company.Position;
            Salary = company.Salary;
        }
        public Company(string name, string position, int salary)
        {
            SetCompanyName(name);
            SetCompanyPosition(position);
            SetCompanySalary(salary);
        }
        public Company(int salary, string position = "Должность", string name = "Компания")
        {
            SetCompanyName(name);
            SetCompanyPosition(position);
            SetCompanySalary(salary);
        }
        public void SetCompanyName(string name)
        {
            if (name.Trim().Length < 1)
                throw new Exception("Ошибка ввода имени");
            else Name = name;
        }
        public void SetCompanyPosition(string position)
        {
            if (position.Trim().Length < 1)
                throw new Exception("Ошибка ввода должности");
            else Position = position;
        }
        public void SetCompanySalary(int salary)
        {
            if (salary <= 0)
                throw new Exception("Ошибка ввода зарплаты");
            else Salary = salary;
        }
        public string GetCompanyName()
        {
            return Name;
        }
        public string GetCompanyPosition()
        {
            return Position;
        }
        public int GetCompanySalary()
        {
            return Salary;
        }
    }
}
