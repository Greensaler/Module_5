using System;

namespace Module_5_6_itog
{
    class Program
    {
        static bool CheckNum(string number, out int corrnumber)
        {
            if (int.TryParse(number, out int intnum))
            {
                if (intnum > 0)
                {
                    corrnumber = intnum;
                    return false;
                }
                else
                    Console.WriteLine("Вы ввели некорректное значение");
            }

            {
                corrnumber = 0;
                return true;
            }
        }

        static string[] EnterPet()
        {
            string a;
            int intage;
            do
            {
                Console.WriteLine("Введите количество питомцев цифрами");
                a = Console.ReadLine();
            } while (CheckNum(a, out intage));

            string[] PetNames = new string[intage];
                for (int i = 0; i < PetNames.Length; i++)
                {
                    Console.WriteLine("Кличка вашего питомца № {0}", i + 1);
                    PetNames[i] = Console.ReadLine();
                }

            return PetNames;

        }
        static string[] ShowColor()
        {
            string a;
            int intage;
            do
            {
                Console.WriteLine("Введите количество ваших любимых цветов цифрами");
                a = Console.ReadLine();
            } while (CheckNum(a, out intage));

            string[] Colors = new string[intage];
            for (int i = 0; i < Colors.Length; i++)
            {
                Console.WriteLine("Ваш любимый цвет № {0}", i + 1);
                Colors[i] = Console.ReadLine();
            }

            return Colors;

        }
        static (string name, string LastName, int Age, string PetIs, string[] PetNames, string[] Colors) EnterUser()
        {
            (string Name, string LastName, int Age, string PetIs, string[] PetNames, string[] Colors) User;
            Console.WriteLine("Введите имя");
            User.Name = Console.ReadLine();

            Console.WriteLine("Введите фамилию");
            User.LastName = Console.ReadLine();

            string Age;
            int intage;
            do
            {
                Console.WriteLine("Введите возраст цифрами");
                Age = Console.ReadLine();
            } while (CheckNum(Age, out intage));

            User.Age = intage;

            Console.WriteLine("Есть ли у вас питомцы. Введите: (да/нет)");
            User.PetIs = Console.ReadLine();
            if (User.PetIs == "да" || User.PetIs == "Да" || User.PetIs == "ДА" || User.PetIs == "дА")
            {
                User.PetNames = EnterPet();
            }
            else
            {
                User.PetNames = null;
            }

            User.Colors = ShowColor();

            return User;
        }
        static void ShowInfoUser()
        {

            var User = EnterUser();

            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("АНКЕТА ПОЛЬЗОВАТЕЛСЯ:\n\nИмя: {0}", User.name);
            Console.WriteLine("Фамилия: {0}", User.LastName);
            Console.WriteLine("Возраст: {0} лет/года", User.Age);
            
            if (User.PetNames != null)
            {
                Console.WriteLine();
                Console.WriteLine("Список кличек питомцев:");
                for (int i = 0; i < User.PetNames.Length; i++)
                {
                    Console.WriteLine("Кличка питомца №{1}: {0}", User.PetNames[i], i + 1);
                }
            }
            else
            {
                Console.WriteLine("Питомцев нет");
            }

            Console.WriteLine();
            Console.WriteLine("Список любимых цветов");
            for (int i = 0; i < User.Colors.Length; i++)
            {
                Console.WriteLine("Любимый цвет №{1}: {0}", User.Colors[i], i + 1);
            }

        }
        static void Main(string[] args)
        {

            ShowInfoUser();
            
        }

    }
}
