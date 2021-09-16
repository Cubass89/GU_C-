using System;

namespace Lesson_2
{
    class Program
    {
        static void Main(string[] args)
        {

            #region  Задание 1
            //Написать метод, возвращающий минимальное из трёх чисел.

            Console.WriteLine("Введите первое число:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число:");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите третье число:");
            int c = int.Parse(Console.ReadLine());

            int min = a;
            if (b <= min) min = b;
            if (c <= min) min = c;

            Console.WriteLine("Наименьшее число = " + min);
            Console.ReadLine();
            Console.Clear();

            #endregion


            #region  Задание 2
            //Написать метод подсчета количества цифр числа.

            Console.WriteLine("Введите произвольное число:");
            int number = int.Parse(Console.ReadLine());
            int count = 0;
            do
            {
                count++;
                number = number / 10;

            }
            while (number != 0);
            Console.WriteLine("Количество цыфр в числе равно: " + count);
            Console.ReadLine();
            Console.Clear();

            #endregion


            #region Задание 3
            //С клавиатуры вводятся числа, пока не будет введен 0.Подсчитать сумму всех нечетных положительных чисел.

            Console.WriteLine("Введите любое число:");
            int sol = int.Parse(Console.ReadLine());
            int dd = 0;
            while (sol != 0)
            {
                if (sol % 2 == 1) dd += sol;
                sol = int.Parse(Console.ReadLine());

            }

            Console.WriteLine("Сумма нечетных цифр равна " + dd);
            Console.ReadKey();
            Console.Clear();

            #endregion


            #region Задание 4
            //пользователь вводит логин и пароль, программа пропускает его дальше или не пропускает.
            //С помощью цикла do while ограничить ввод пароля тремя попытками.
           
            string login = "root";
            string password = "GeekBrains";
            int count1 = 0;

            do
            {
                Console.WriteLine("Введите ваш логин:");
                string checkLogin = Console.ReadLine();
                Console.WriteLine("Введите ваш пароль:");
                string checkPassword = Console.ReadLine();
                Console.WriteLine("Нажмите Enter для подтверждения проверки");
                Console.Clear();

                if (login == checkLogin && password == checkPassword)
                {
                    Console.WriteLine("Вы успешно прошли проверку");
                    Console.ReadLine();
                    break;
                }

                else

                {
                    Console.WriteLine("Вы неверно ввели Логин или Пароль. Попробуйте еще раз!");
                    Console.ReadLine();
                    Console.Clear();
                    count1++;
                }
                
            }
                while (count < 3);

            Console.ReadLine();
            Console.Clear();

            #endregion


            #region Задание 5
            //Программа которая вычисляет индекс массы и сообщает, нужно ли человеку похудеть, набрать вес или всё в норме.
            // *Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.

            Console.WriteLine("Введите Ваш вес");
            double weight = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите Ваш рост");
            double height = double.Parse(Console.ReadLine());

            double imt = weight / (height * height);
            Console.WriteLine("Ваш индекс массы тела: " + imt);

            if (imt <= 16)
            {
                Console.WriteLine("Вам необходимо поправится");
            }
            else if (imt > 18.5 && imt < 25)
            {
                Console.WriteLine("У вас нормальный вес");
            }
            else if (imt <= 30)
            {
                Console.WriteLine("Вам необходимо сбавить вес");
            }

            Console.ReadLine();
            Console.Clear();

            #endregion

        }
    }
}
