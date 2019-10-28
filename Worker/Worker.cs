using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worker
{
    class Worker
    {
        protected string Name;
        protected int Yearth, Month;
        protected Company WorkPlace = new Company();

        public Worker()
        {
            Name = "Имя";
            Yearth = 1970;
            Month = 1;
            WorkPlace = new Company();
        }
        public Worker(Worker worker)
        {
            Name = worker.Name;
            Month = worker.Month;
            Yearth = worker.Yearth;
            WorkPlace = worker.WorkPlace;
        }
        public Worker(string name, int yearth, int month, int salary, string position = "Должность", string namec = "Компания")
        {
            SetWorkerName(name);
            SetWorkerYearth(yearth);
            SetWorkerMonth(month);
            SetWorkerWorkPlace(salary, position, namec);
        }
        public Worker(int yearth, int month, string name = "Имя")
        {
            SetWorkerName(name);
            SetWorkerYearth(yearth);
            SetWorkerMonth(month);
            WorkPlace = new Company();
        }
        public void SetWorkerName(string name)
        {
            if (name.Trim().Length < 1)
                throw new Exception("Ошибка ввода имени");
            else Name = name;
        }
        public void SetWorkerYearth(int yearth)
        {
            if (yearth < 1 || yearth > 2019)
                throw new Exception("Ошибка ввода имени");
            else Yearth = yearth;
        }
        public void SetWorkerMonth(int month)
        {
            if (month < 1 || month > 12)
                throw new Exception("Ошибка ввода имени");
            else Month = month;
        }
        public void SetWorkerWorkPlace(int salary, string position, string name)
        {
            WorkPlace = new Company(salary, position, name);
        }
        public string GetWorkerName()
        {
            return Name;
        }
        public int GetWorkerYearth()
        {
            return Yearth;
        }
        public int GetWorkerMonth()
        {
            return Month;
        }
        public Company GetWorkerWorkPlace()
        {
            return WorkPlace;
        }
        public int GetWorkerExperience()
        {
            return (DateTime.Now.Year - GetWorkerYearth()) * 12 + DateTime.Now.Month - GetWorkerMonth();
        }
        public int GetTotalMoney()
        {
            return GetWorkerExperience() * WorkPlace.GetCompanySalary();
        }
    }
}
