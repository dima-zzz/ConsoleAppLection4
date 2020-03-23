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
            // тут три масива різних типів + два метода з перезавантаженнями - по пунтку 2
            MethodsOfArray();

            //2) Написати 5 методів та їх перевантажені методи мінімум по 1(перевантаженому);
            //два метода з перезавантаженнями (FillArray) i (WriteArray)  викликались в першому пункті MethodsOfArray

            //для тварин - метод з перезавантаженням AnimalActivity (третій метод з перезавантаженням)
            Animal cat1 = new Animal("Murka", AnimalType.Cat);
            Animal cat2 = new Animal("Pushinka", AnimalType.Cat);
            AnimalActivity(cat1, 3, true, true);
            AnimalActivity(cat2, 5, false, true);
            Animal dog1 = new Animal("Tuzik", AnimalType.Dog);
            AnimalActivity(dog1, 10, true, true);
            Animal horse1 = new Animal("NightMare", AnimalType.Hourse);
            AnimalActivity(horse1, 10, true, true);
            Animal ameba1 = new Animal();
            AnimalActivity(ameba1, 1, false, false);

            //четвертий метод - боротьба з коронавірусом
            WarWithCoronavirus(12300);
            WarWithCoronavirus(999999);
            WarWithCoronavirus(60_000_000, 10);
            WarWithCoronavirus(60_000_000, 100);

            //пятий метод - оцінка по документації проекта
            ProjectDocumentation("This is project NNN");//Header
            ProjectDocumentation("This is project RRR", "some comment /n some comment /n some comment /n some comment");//Header,Comments
            ProjectDocumentation("This is project GGG", "some comment /n some comment ", "So u can see this is seriuos big project");//Header,Comments, Results


            //3) Написати метод з використанням трьох Nullable змінних, та використанням можливлстей які він пропонує;

            string Name1 = "Person1";
            bool? gender1 = null;
            int? childrenQuantity1 = null;
            decimal? Fee1 = null;
            if (RegistrationForm(Name1, gender1, childrenQuantity1, Fee1) == false)
            {
                Console.WriteLine("Can not register {0}! Check required properties!", Name1);
            }
            string Name2 = "Person2";
            bool? gender2 = true;
            int? childrenQuantity2 = null;
            decimal? Fee2 = null;
            if (RegistrationForm(Name2, gender2, childrenQuantity2, Fee2) == false)
            {
                Console.WriteLine("Can not register {0}! Check required properties!", Name2);
            }
            string Name3 = "Person3";
            bool? gender3 = false;
            int? childrenQuantity3 = 1;
            decimal? Fee3 = null;
            if (RegistrationForm(Name3, gender3, childrenQuantity3, Fee3) == false)
            {
                Console.WriteLine("Can not register {0}! Check required properties!", Name3);
            }
            string Name4 = "Person4";
            bool? gender4 = true;
            int? childrenQuantity4 = 2;
            decimal? Fee4 = null;
            if (RegistrationForm(Name4, gender4, childrenQuantity4, Fee4) == false)
            {
                Console.WriteLine("Can not register {0}! Check required properties!", Name4);
            }
            string Name5 = "Person5";
            bool? gender5 = false;
            int? childrenQuantity5 = 5;
            decimal? Fee5 = 100m;
            if (RegistrationForm(Name5, gender5, childrenQuantity5, Fee5) == false)
            {
                Console.WriteLine("Can not register {0}! Check required properties!", Name5);
            }


            //4) Написати два методи з використанням опціональних параметрів та два з використанням named$

            //опціональний 1 + він же і з іменованим параметром 
            SendPlane("Boeing");
            SendPlane("An", "Jacky Chan", "China");
            SendPlane(pilot: "Ivan Sirko", countryDestination: "Turkey");
            //опціональний 2 + named
            PlayOrchestra(nameOfPerformance: "Lakme", authorName: "Leo Delib", cityOfOrchestra: "Paris");
            PlayOrchestra();


            //5) Написати по два методи з використанням out, ref, params;
            ParamsVoid1("Snow White", "Dwarf1", "Dwarf #2", "Dwarf-that-is-smaller-than-other");
            ParamsVoid1("Prince", "Dwarf1", "Dwarf-who-is-the-oldest-one");

            ParamsVoid2(10, 9, 8, 7, 6, 5, 4);
            ParamsVoid2(1, 2, 3);
            ParamsVoid2(0, 1);

            int z;
            OutVoid1(2, 6, out z);
            int t;
            OutVoid2(7, 4, out t);

            int coints = 0;
            RefVoid1(ref coints);
            bool registered = true;
            RefVoid2(ref registered);
            RefVoid2(ref registered);




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
            int[] arr1 = new int[9];
            WriteArrayValues(arr1);
            int[] arr2 = { 10 };
            arr1.CopyTo(arr2, 0);
            WriteArrayValues(arr2);
            Console.WriteLine("Average " + arr2.Average());

            string[] arrStr = new string[5];
            FillArray(arrStr, 3, new string[] { "Book", "Digital book", "Smartphone" });
            WriteArrayValues(arrStr);
            string[] arrStr2 = (string[])(object[])arrStr.Clone();
            Console.WriteLine("String arrays are: " + ((arrStr.Equals(arrStr2) ? "" : "not ")) + "equal");
            arrStr2.SetValue(arrStr2[1], arrStr2.Length);
            arrStr2.SetValue("Laptop", 1);
            WriteArrayValues(arrStr2);

            string[] arrStrDefault = new string[10];
            FillArray(arrStrDefault);
            Console.WriteLine(" arrStrDefault.IsFixedSize : " + arrStrDefault.IsFixedSize);
            WriteArrayValues(arrStrDefault);

            bool[] arrBool = new bool[15];
            FillArray(arrBool, 14);
            Console.WriteLine("arrBool IsReadOnly: " + arrBool.IsReadOnly);
            Console.WriteLine("arrBool IsFixedSize: " + arrBool.IsFixedSize);
            Console.WriteLine("arrBool Rank: " + arrBool.Rank);
            WriteArrayValues(arrBool);

        }



        //2) Написати 5 методів та їх перевантажені методи мінімум по 1(перевантаженому);

        //overloaded method #1.1
        public static void FillArray(int[] arr, int LengthOfArray = 0)
        {
            if (LengthOfArray == 0)
            {
                LengthOfArray = arr.Length;
            }
            for (int i = 0; i < LengthOfArray; i++)
            {
                arr[i] = i + 1;
            }
        }
        //overloaded method #1.2  
        public static void FillArray(bool[] arr, int LengthOfArray = 0)
        {
            if (LengthOfArray == 0)
            {
                LengthOfArray = arr.Length;
            }
            for (int i = 0; i < LengthOfArray; i++)
            {
                arr[i] = (i % 3 == 0) ? true : false;
            }
        }

        //overloaded method #1.3
        public static void FillArray(string[] arr, int LengthOfArray = 0, string[] ValuesToFill = null)
        {
            if (LengthOfArray == 0)
            {
                LengthOfArray = arr.Length;
            }
            for (int i = 0; i < LengthOfArray; i++)
            {
                if (ValuesToFill == null)
                {
                    arr[i] = "" + (i + 1);
                }
                else
                {
                    arr[i] = Convert.ToString(ValuesToFill[i]);
                }
            }
        }


        //overloaded method #2.1
        public static void WriteArrayValues(int[] arr)
        {
            Console.WriteLine();
            foreach (var item in arr)
            {
                Console.Write(" " + item);
            }
            Console.WriteLine();
        }
        //overloaded method #2.2
        public static void WriteArrayValues(string[] arr)
        {
            Console.WriteLine();
            foreach (var item in arr)
            {
                Console.Write(" \"" + item + "\"");
            }
            Console.WriteLine();
        }
        //overloaded method #2.3
        public static void WriteArrayValues(bool[] arr)
        {
            Console.WriteLine();
            foreach (var item in arr)
            {
                Console.Write(" Value of element " + Array.IndexOf(arr, item) + " is : \"" + item + "\"");
            }
            Console.WriteLine();
        }




        //overloaded method #3.1
        public static void AnimalActivity(Animal animal, int rankOfEating)
        {
            for (int i = 0; i < rankOfEating; i++)
            {
                AnimalLife(animal, true);
            }
        }
        //overloaded method #3.2
        public static void AnimalActivity(Animal animal, int rankOfEating, bool harmfullCreature)
        {
            AnimalActivity(animal, rankOfEating);
            AnimalLife(animal, false, false, false, true);
        }
        public static void AnimalActivity(Animal animal, int rankOfEating, bool harmfullCreature, bool noice)
        {
            AnimalActivity(animal, rankOfEating, harmfullCreature);
            AnimalLife(animal, false, false, true, false);
        }
        //overloaded method #3.3
        public enum AnimalType { Cat, Dog, Hourse, Ameba }
        public class Animal
        {
            private String name;
            public String Name
            {
                get { return name; }
                set { name = value; }
            }

            private AnimalType typeOfAnimal;
            public AnimalType TypeOfAnimal
            {
                get { return typeOfAnimal; }
                set { typeOfAnimal = value; }
            }



            public Animal()
            {
                Name = "No name";
                typeOfAnimal = AnimalType.Ameba;
            }
            public Animal(AnimalType typeAnim) : base()
            {
                typeOfAnimal = typeAnim;
            }
            public Animal(string name, AnimalType aniType)
            {
                this.typeOfAnimal = aniType;
                this.name = name;
            }
        }
        public static void AnimalLife(Animal animal, bool eat = true, bool sleep = true, bool noice = true, bool makeHarm = true)
        {
            if (eat)
            {
                if (animal.TypeOfAnimal == AnimalType.Cat)
                {
                    Console.WriteLine("kitycat if finishing");
                }
                else if (animal.TypeOfAnimal == AnimalType.Dog)
                {
                    Console.WriteLine("Sugar bones are finishing");
                }
                else if (animal.TypeOfAnimal == AnimalType.Hourse)
                {
                    Console.WriteLine("Grass and wheat  are finishing");
                }
                else if (animal.TypeOfAnimal == AnimalType.Ameba)
                {
                    Console.WriteLine("Nothing changes");
                }
            }
            if (sleep)
            {
                if (animal.TypeOfAnimal == AnimalType.Cat)
                {
                    Console.WriteLine("You can use it as a pillow");
                }
                else if (animal.TypeOfAnimal == AnimalType.Dog)
                {
                    Console.WriteLine("Dog moves his legs like running");
                }
                else if (animal.TypeOfAnimal == AnimalType.Hourse)
                {
                    Console.WriteLine("Horse standing when sleeping");
                }
                else if (animal.TypeOfAnimal == AnimalType.Ameba)
                {
                    Console.WriteLine("Nothing changes");
                }
            }
            if (noice)
            {
                if (animal.TypeOfAnimal == AnimalType.Cat)
                {
                    Console.WriteLine("you can stand it");
                }
                else if (animal.TypeOfAnimal == AnimalType.Dog)
                {
                    Console.WriteLine("Asking dog to shut up");
                }
                else if (animal.TypeOfAnimal == AnimalType.Hourse)
                {
                    Console.WriteLine("Not so much as dog");
                }
                else if (animal.TypeOfAnimal == AnimalType.Ameba)
                {
                    Console.WriteLine("You hear nothing");
                }
            }
            if (makeHarm)
            {
                if (animal.TypeOfAnimal == AnimalType.Cat)
                {
                    Console.WriteLine("Your home plants suffer");
                }
                else if (animal.TypeOfAnimal == AnimalType.Dog)
                {
                    Console.WriteLine("Everything destroyed");
                }
                else if (animal.TypeOfAnimal == AnimalType.Hourse)
                {
                    Console.WriteLine("Nothing special");
                }
                else if (animal.TypeOfAnimal == AnimalType.Ameba)
                {
                    Console.WriteLine("You see no harm");
                }
            }

        }


        //overloaded method #4.1
        public static void WarWithCoronavirus(int masksQuantity)
        {
            if (masksQuantity > 0 && masksQuantity < 10_000)
            {
                Console.WriteLine("Masks not enough");
            }
            else if (masksQuantity > 10_000 && masksQuantity < 10_000_000)
            {
                Console.WriteLine("Masks almost enough");
            }
            else
            {
                Console.WriteLine("Masks enough");
            }
        }
        //overloaded method #4.2
        public static void WarWithCoronavirus(int masksQuantity, int CarantinPeriod)
        {

            WarWithCoronavirus(masksQuantity);

            if (CarantinPeriod > 0 && CarantinPeriod < 14)
            {
                Console.WriteLine("CarantinPeriod IS too SMALL");
            }
            else if (CarantinPeriod > 14 && CarantinPeriod < 24)
            {
                Console.WriteLine("CarantinPeriod IS still too SMALL");
            }
            else
            {
                Console.WriteLine("CarantinPeriod minimal enough");
            }
        }

        //overloaded method #5.1
        public static void ProjectDocumentation(string Header)//Header
        {
            Console.WriteLine("Header");
            Console.WriteLine(Header);
            Console.WriteLine("Not enough documentation, it only has header of project");
        }
        //overloaded method #5.2
        public static void ProjectDocumentation(string Header, string Comments)//Header,Comments
        {
            Console.WriteLine("Header");
            Console.WriteLine(Header);
            Console.WriteLine("Comments:");
            Console.WriteLine(Comments);
            Console.WriteLine("Nice documentation, header of project and comments in code");
        }
        //overloaded method #5.3
        public static void ProjectDocumentation(string Header, string Comments, string Results)//Header,Comments, Results
        {
            Console.WriteLine("Header");
            Console.WriteLine(Header);
            Console.WriteLine("Comments:");
            Console.WriteLine(Comments);
            Console.WriteLine("Results:");
            Console.WriteLine(Results);
            Console.WriteLine("Excellent documentation, header of project and comments in code + the results as summary - this project is well-documentated!");
        }



        //3) Написати метод з використанням трьох Nullable змінних, та використанням можливлстей які він пропонує;
        public static bool RegistrationForm(string name, bool? gender, int? childrenQuantity, decimal? MembershipFee)
        {
            if (!gender.HasValue)
            {
                Console.WriteLine("Can not register person without gender!");
                return false;
            }
            if (!childrenQuantity.HasValue)
            {
                Console.WriteLine("Please enter quantity of children to register in project!");
                return false;
            }
            if (!MembershipFee.HasValue)
            {
                Console.WriteLine("CaPlease enter you membership fee or zero if non!");
                return false;
            }
            Console.WriteLine("Registered person {0} with gender {1} with children quantity {2} that paied {3} fee !", name, gender, childrenQuantity, MembershipFee);
            return true;
        }

        //4) Написати два методи з використанням опціональних параметрів та два з використанням named$

        //4.1 named + optional
        public static void SendPlane(string PlaneModel = "Il", string pilot = "Ostap Stupka", string countryDestination = "Ukraine")
        {
            Console.WriteLine("Plane with model {0} fly to {1} with pilot {2}", PlaneModel, countryDestination, pilot);
        }
        //4.2 named + optional
        public static void PlayOrchestra(string cityOfOrchestra = "Lviv", string nameOfPerformance = "NatalkaPoltavka", string authorName = "Mykola Lysenko")
        {
            Console.WriteLine("Now satisfy your hears by lisening to \"{0}\" opera of \"{1}\" played by \"{2}\" orchestra!", nameOfPerformance, authorName, cityOfOrchestra);
        }


        //5) Написати по два методи з використанням out, ref, params;

        public static void ParamsVoid1(string mainHero, params string[] nameOfDwarfes)
        {
            string stringWithDwarfesNames = "";
            foreach (string nameDwarf in nameOfDwarfes)
            {
                stringWithDwarfesNames += " " + nameDwarf;
            }
            Console.WriteLine("{0} went to walk with {1}", mainHero, stringWithDwarfesNames);
        }
        public static void ParamsVoid2(params int[] arrayOfIntegers)
        {
            foreach (int item in arrayOfIntegers)
            {
                Console.Write(" " + item); ;
            }
        }

        public static void OutVoid1(int x, int y, out int a)
        {
            a = x + y;
        }
        public static void OutVoid2(int x, int y, out int a)
        {
            a = x * y;
        }

        public static void RefVoid1(ref int coints)
        {
            Console.WriteLine("you have {0} coints", ++coints);
        }
       public static void RefVoid2(ref bool registered)
        {
            registered = !registered;
            Console.WriteLine("Your registration is {0}", registered );
        }

    }





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
