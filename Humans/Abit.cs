using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Humans
{
    class Abit: Humans
    {
        protected float Zno1, Zno2, Zno3, Atest;
        public Abit()
        {
            Zno1 = 100;
            Zno2 = 100;
            Zno3 = 100;
            Atest = 2;
        }
        public Abit(Abit abit) : base(abit.Name, abit.Gender, abit.Birthday)
        {
            Zno1 = abit.Zno1;
            Zno2 = abit.Zno2;
            Zno3 = abit.Zno3;
            Atest = abit.Atest;
        }
        public Abit(string name, string gender, DateTime birthday, float zno1, float zno2, float zno3, float atest) : base(name, gender, birthday)
        {
            SetZno1(zno1);
            SetZno2(zno2);
            SetZno3(zno3);
            SetAtest(atest);
        }
        public Abit(Humans human, float zno1, float zno2, float zno3, float atest) : base(human)
        {
            SetZno1(zno1);
            SetZno2(zno2);
            SetZno3(zno3);
            SetAtest(atest);
        }
        public void SetZno1(float zno1)
        {
            if (zno1 < 100 || zno1 > 200)
                throw new Exception("Ошибка ввода");
            else Zno1 = zno1;
        }
        public void SetZno2(float zno2)
        {
            if (zno2 < 100 || zno2 > 200)
                throw new Exception("Ошибка ввода");
            else Zno2 = zno2;
        }
        public void SetZno3(float zno3)
        {
            if (zno3 < 100 || zno3 > 200)
                throw new Exception("Ошибка ввода");
            else Zno3 = zno3;
        }
        public void SetAtest(float atest)
        {
            if (atest < 2 || atest > 12)
                throw new Exception("Ошибка ввода");
            else Atest = atest;
        }
        public float GetZno1()
        {
            return Zno1;
        }
        public float GetZno2()
        {
            return Zno2;
        }
        public float GetZno3()
        {
            return Zno3;
        }
        public float GetAtest()
        {
            return Atest;
        }
    }
}
