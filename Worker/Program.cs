using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worker
{
    class Program
    {
        static void Main(string[] args)
        {
            Worker[] workers = ReadWorkerArray();
            GetWorkersInfo(workers, out int max, out int min);
            Console.WriteLine("Работники:");
            PrintWorkers(workers);
            Console.WriteLine($"Наименшяя зарплата: {min}\nНаибольшая зарплата: {max}");
            Console.WriteLine("Список работников по спаданию зарплаты:");
            SortWorkerBySalary(workers);
            for(int i = 0; i<workers.Length; i++)
                Console.WriteLine(workers[i].GetWorkerName());
            Console.WriteLine("Список работников по увелечению опыта:");
            SortWorkerByWorkExperience(workers);
            for (int i = 0; i < workers.Length; i++)
                Console.WriteLine(workers[i].GetWorkerName());
        }

        static Worker[] ReadWorkerArray()
        {
            string name, position, namec;
            int yearth, month, salary;
            int n;
            Console.Write("Введите кол-во работников: ");
            if (Int32.TryParse(Console.ReadLine(), out n) == false)
                Console.WriteLine("Ошибка ввода");
            Worker[] workers = new Worker[n];
            for(int i = 0; i<n; i++)
            {
                Console.WriteLine("Введите имя работника:");
                name = Console.ReadLine();
                Console.WriteLine("Введите год начала работы:");
                if (int.TryParse(Console.ReadLine(), out yearth) == false) { Console.WriteLine("Ошибка ввода. Будет присвоен 1970 год"); yearth = 1970; }
                Console.WriteLine("Введите месяц начала работы:");
                if (int.TryParse(Console.ReadLine(), out month) == false) { Console.WriteLine("Ошибка ввода. Будет присвоен 1 месяц"); month = 1; }
                Console.WriteLine("Введите зарплату работника:");
                if (int.TryParse(Console.ReadLine(), out salary) == false) { Console.WriteLine("Ошибка ввода. Зарплата будет равно 0"); salary = 0; }
                Console.WriteLine("Введите должность работника:");
                position = Console.ReadLine();
                Console.WriteLine("Введите название компании работника:");
                namec = Console.ReadLine();
                try
                {
                    workers[i] = new Worker(name, yearth, month, salary, position, namec);
                }
                catch(Exception ex)
                {
                    Console.WriteLine("Error:" + ex.Message + "\n Будут заданы значения по умолчанию");
                    workers[i] = new Worker();
                }
            }
            return workers;
        }
        static void PrintWorker(Worker worker)
        {
            Console.WriteLine($"Имя: {worker.GetWorkerName()}");
            Console.WriteLine($"Работает с {worker.GetWorkerMonth()}.{worker.GetWorkerYearth()}");
            Console.WriteLine($"Компания: {worker.GetWorkerWorkPlace().GetCompanyName()}");
            Console.WriteLine($"Должность: {worker.GetWorkerWorkPlace().GetCompanyPosition()}");
            Console.WriteLine($"Зарплата: {worker.GetWorkerWorkPlace().GetCompanySalary()}");
            Console.WriteLine($"Опыт: {worker.GetWorkerExperience()}");
            Console.WriteLine($"Всего заработано: {worker.GetTotalMoney()}");
        }
        static void PrintWorkers(Worker[] workers)
        {
            for (int i = 0; i < workers.Length; i++)
            {
                PrintWorker(workers[i]);
            }
        }
        static void GetWorkersInfo(Worker[] workers, out int maxsal, out int minsal)
        {
            int maxsali = 0;
            int minsali = 0;
            for(int i = 0; i < workers.Length; i++)
            {
                if (workers[i].GetWorkerWorkPlace().GetCompanySalary() > workers[maxsali].GetWorkerWorkPlace().GetCompanySalary())
                    maxsali = i;
                if (workers[i].GetWorkerWorkPlace().GetCompanySalary() < workers[minsali].GetWorkerWorkPlace().GetCompanySalary())
                    minsali = i;
            }
            maxsal = workers[maxsali].GetWorkerWorkPlace().GetCompanySalary();
            minsal = workers[minsali].GetWorkerWorkPlace().GetCompanySalary();
        }
        static void SortWorkerBySalary(Worker[] workers)
        {
            Worker tmp;
            bool bl;
            do
            {
                bl = false;
                for (int i = 1; i < workers.Length; i++)
                {
                    if (workers[i - 1].GetWorkerWorkPlace().GetCompanySalary() < workers[i].GetWorkerWorkPlace().GetCompanySalary())
                    {
                        tmp = new Worker(workers[i - 1]);
                        workers[i - 1] = new Worker(workers[i]);
                        workers[i] = new Worker(tmp);
                        bl = true;
                    }
                }
            } while (bl);
        }
        static void SortWorkerByWorkExperience(Worker[] workers)
        {
            Worker tmp;
            bool bl;
            do
            {
                bl = false;
                for (int i = 1; i > workers.Length; i++)
                {
                    if (workers[i - 1].GetWorkerExperience() < workers[i].GetWorkerExperience())
                    {
                        tmp = new Worker(workers[i - 1]);
                        workers[i - 1] = new Worker(workers[i]);
                        workers[i] = new Worker(tmp);
                        bl = true;
                    }
                }
            } while (bl);
        }
    }
}

