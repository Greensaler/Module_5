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

        static (string PetIs, string[] PetNames) EnterPet()
        {
            (string PetIs, string[] PetNames) User;
            User.PetIs = Console.ReadLine();
            if (User.PetIs == "нет")
            {
                User.PetNames = new string[i];
                for (int i = 0; i < favcolors.Length; i++)
                {
                    Console.WriteLine("Введите любимый цвет номер {0}", i + 1);
                    favcolors[i] = Console.ReadLine();
                }
            }
            else
                Console.WriteLine("Питомцев нет");
            return User;
               
        }
        static (string name, string LastName, int Age, string Pet) EnterUser()
        {
            (string Name, string LastName, int Age) User;
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

            return User;
        }
        static void ShowInfoUser()
        {

            var User = EnterUser();

            Console.WriteLine("Анкета пользователя:\nИмя: {0}", User.name);
            Console.WriteLine("фамилия: {0}", User.LastName);
            Console.WriteLine("Возраст: {0} лет/года", User.Age);

        }
        static void Main(string[] args)
        {

            ShowInfoUser();
            
        }

    }
}
