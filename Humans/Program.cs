using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Humans
{
    class Program
    {
        static void Main(string[] args)
        {
            Humans zhorik = new Humans("Жорик", "Мужчина", 04, 01, 2002);
            Student Zhorik = new Student(zhorik, "ИПЗ-19-3", "ФИКТ", 1);
            Bibluser Maks = new Bibluser("Макс", "Мужчина", new DateTime(2000, 08, 06), 8, new DateTime(2020, 11, 22));
            Teacher Oksana = new Teacher("Оксана", "Женщина", new DateTime(1987, 04, 05), "Математика", "ФИКТ");
            Abit zhorik2 = new Abit(zhorik, 194, 189, 188, 10);
            Humans[] humans = { zhorik, Zhorik, Maks, Oksana, zhorik2 };
            for (int i = 0; i < humans.Length; i++)
            {
                Console.WriteLine(humans[i].GetName());
                Console.WriteLine(humans[i].GetGender());
                Console.WriteLine(humans[i].GetBirthday());
            }
            Console.WriteLine("--------");
            Console.WriteLine("Читацкий билет");
            Console.WriteLine("Имя: " + Maks.GetName());
            Console.WriteLine("Пол: " + Maks.GetGender());
            Console.WriteLine("Дата рождения: " + Maks.GetBirthday());
            Console.WriteLine("Кол-во книг на руках:" + Maks.GetBookAmt());
            Console.WriteLine("Билет действителен до:" + Maks.GetTicketDate());
        }
    }
}
