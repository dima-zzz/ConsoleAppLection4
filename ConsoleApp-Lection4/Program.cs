using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Lection4
{
    class Program
    {
        static void Main(string[] args)
        {
            //1) Написати метод з використанням масивів мінімум 3 типів, та використання їх методів
            //2) Написати 5 методів та їх перевантажені методи мінімум по 1(перевантаженому);
            //3) Написати метод з використанням трьох Nullable змінних, та використанням можливлстей які він пропонує;
            //4) Написати два методи з використанням опціональних параметрів та два з використанням named$
            //5) Написати по два методи з використанням out, ref, params;

            //6) Написати структуру Human(поля: ПІП, вік, стать);
            HumanStruct human1;
            human1.NameSurname = "Petro Petrovych";
            human1.Age = 50;
            human1.Sex = "Male";
            Console.WriteLine("name {0} age {1} sex {2}", human1.NameSurname, human1.Age, human1.Sex);

            //7) Написати клас аналогічний структурі вище в ньому стать має представлятись як перерахування;
            HumanClass human2 = new HumanClass();
            Console.WriteLine("name {0} age {1} sex {2}", human2.NameSurname, human2.Age, human2.Sex);

            HumanClass human3 = new HumanClass();
            human1.NameSurname = "Petro Petrovych";
            human1.Age = 50;
            human1.Sex = "Male";
            Console.WriteLine("name {0} age {1} sex {2}", human3.NameSurname, human3.Age, human3.Sex);

            //8) Написати клас Істота(Being) де як вище тільки придумати як відобразити що стать може бути не визначена;
            Being creature1 = new Being();
            Console.WriteLine("name {0} age {1} sex {2}", creature1.NameSurname, creature1.Age, creature1.Sex);

            Being dog = new Being("Bai", 6, SexType.Male);
            Console.WriteLine("name {0} age {1} sex {2}", dog.NameSurname, dog.Age, dog.Sex);

            Being Angel = new Being() { Age = 3, Sex = SexType.Female, NameSurname = "Yaroslava Voitovych" };
            Console.WriteLine("name {0} age {1} sex {2}", Angel.NameSurname, Angel.Age, Angel.Sex);

            //9) Замість використання цих трох типів(останніх) використати кортежі написати три методи по одному на кожен тип
        }



        //1) Написати метод з використанням масивів мінімум 3 типів, та використання їх методів
        public static void MethodsOfArray()
        {
            int[] arr1 = new int[];
            //System.Array.Copy
            //System.Array.Empty
            //System.Array.BinarySearch
            //System.Array.Clear
            //System.Array.ConvertAll
            //System.Array.Equals
            //System.Array.Exists
            //System.Array.Find
            //System.Array.ForEach
            //System.Array.LastIndexOf
            //System.Array.Reverse
            //System.Array.Sort



        }
        
        //2) Написати 5 методів та їх перевантажені методи мінімум по 1(перевантаженому);
        //тип вертаємого значення, типи параметрів, модифікатори (ін, реф) параметрів, кількість параметрів
        //послали бул  -метод для такого вертає тільки бул
        //послали ін - пише
        //3) Написати метод з використанням трьох Nullable змінних, та використанням можливлстей які він пропонує;
        //int?  string? string?
        //чи рівний стрін і стрінг коли вони нул;
        //інт гетВел'юОДефолт
        //інші
    }



    //2) Написати 5 методів та їх перевантажені методи мінімум по 1(перевантаженому);
    //3) Написати метод з використанням трьох Nullable змінних, та використанням можливлстей які він пропонує;
    //4) Написати два методи з використанням опціональних параметрів та два з використанням named$
    //5) Написати по два методи з використанням out, ref, params;

    //6) Написати структуру Human(поля: ПІП, вік, стать);
    struct HumanStruct
    {
        public string NameSurname;
        public int Age;
        public string Sex;
        public HumanStruct(string name, int age, string sex)
        {
            this.NameSurname = name;
            this.Age = age;
            this.Sex = sex;
        }
    }

    //7) Написати клас аналогічний структурі вище в ньому стать має представлятись як перерахування;
    class HumanClass
    {
        public string NameSurname;
        public int Age;
        public SexType Sex;

        public HumanClass(string name, int age, SexType sex)
        {
            this.NameSurname = name;
            this.Age = age;
            this.Sex = sex;
        }
        public HumanClass()
        {
            this.NameSurname = "John Johnovich";
            this.Age = 20;
            this.Sex = SexType.Male;
        }
    }

    enum SexType : byte
    {
        Male = 0, Female = 1
    }

    //8) Написати клас Істота(Being) де як вище тільки придумати як відобразити що стать може бути не визначена;
    class Being
    {
        public string NameSurname;
        public int Age;
        public SexType? Sex;

        public Being(string name, int age, SexType sex)
        {
            this.NameSurname = name;
            this.Age = age;
            this.Sex = sex;
        }
        public Being()
        {
            this.NameSurname = "Creature";
            this.Age = 1;
            this.Sex = null;
        }
    }

    //9) Замість використання цих трох типів(останніх) використати кортежі написати три методи по одному на кожен тип

}
