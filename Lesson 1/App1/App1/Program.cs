using System;

namespace App1
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Задание 1
            //Написать программу «Анкета».
            //Последовательно задаются вопросы (имя, фамилия, возраст, рост, вес). В результате вся информация выводится в одну строчку:

            /*

            Console.WriteLine("Добрый день. Как вас зовут?");
            string name = Console.ReadLine();
            Console.WriteLine("Приветствую тебя " + name + "," +
                " а фамилию свою скажешь?");
            string surname = Console.ReadLine();
            Console.WriteLine("Cколько же тебе лет " + name + "?");
            string age = Console.ReadLine();
            Console.WriteLine(age + " хороший возраст), " + " а какой у тебя рост " + name + "?");
            string height = Console.ReadLine();
            Console.WriteLine("Ты конечно не Леброн но и не Денни ДэВито)." + " Подскажи свой вес " + name + " и мы закончим.");
            string weight = Console.ReadLine();
            Console.WriteLine("В итоге у нас следующие данные:" + " Имя " + name + ", фамилия " + surname + ", тебе " + age + 
                ", твой рост " + height +
                ", ну и вес у тебя " + weight + "кг" + ". Думаю мы закончили)");
            Console.WriteLine($"В итоге у нас следующие данные: Имя {name}, фамилия {surname}, тебе {age}, твой рост составляет {height}см, а вес {weight}кг, Думаю мы закончили)");
            Console.WriteLine("В итоге у нас следующие данные: Имя {0}, фамилия {1}, тебе уже {2} что печально, рост у тебя {3}см, вес {4}кг. Думаю этого мне достаточно. Спасибо!",
                name, surname, age, height, weight);
            Console.ReadLine();

            */

            #endregion  


            #region Задание 2
            //Ввести вес и рост человека.
            //Рассчитать и вывести индекс массы тела (ИМТ) по формуле I=m/(h*h); где m — масса тела в килограммах, h — рост в метрах.

            /*

            Console.WriteLine("Привет дружище. какой у тебя вес?");
            double m = double.Parse(Console.ReadLine());
            Console.WriteLine("ну и рост скажи, хочу вывести твой индекс массы тела");
            double h = double.Parse(Console.ReadLine());
            double I = m * 10000 / (h * h);
            Console.WriteLine("Ваш индекс массы тела {0:F2} ", I);
            Console.ReadLine();

            */

            #endregion


            #region Задание 3 вариант 1
            //Написать программу, которая подсчитывает расстояние между точками с координатами x1, y1 и x2,y2
            //по формуле r=Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2).
            //Вывести результат, используя спецификатор формата .2f (с двумя знаками после запятой);

            /*

            Console.WriteLine("Ведите координаты X1:");
            double x1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ведите координаты Y1:");
            double y1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ведите координаты X2:");
            double x2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ведите координаты Y2:");
            double y2 = double.Parse(Console.ReadLine());
            double R = Distance(x1, y1, x2, y2);
            //double R = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

            Console.WriteLine("Расстояние между точками {0:F2} ", R);
            Console.ReadLine();

            */

            #endregion


            #region  Задание 4
            //Написать программу обмена значениями двух переменных типа int без использования вспомогательных методов.

            /*
             
            // С третей переменной

            Console.WriteLine("Ведите значения первой переменной:");
            int variable = int.Parse(Console.ReadLine());
            Console.WriteLine("Ведите значения второй переменной:");
            int variable2 = int.Parse(Console.ReadLine());
            Console.WriteLine("первая переменная " + variable);
            Console.WriteLine("вторая переменная " + variable2);
            int result = variable;
            variable = variable2;
            variable2 = result;
            Console.WriteLine("первая переменная после обмена " + variable);
            Console.WriteLine("вторая переменная после обмена " + variable2);

            // Без третей переменной

            variable = variable + variable2;
            variable2 = variable2 - variable;
            variable2 = -variable2;
            variable = variable - variable2;
            Console.WriteLine("первая переменная после второго обмена " + variable);
            Console.WriteLine("вторая переменная после второго обмена " + variable2);

            */

            #endregion


            #region  Задание 5
            //Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.

            /*

            Console.WriteLine("Добрый день. Как вас зовут?");
            string name = Console.ReadLine();
            Console.WriteLine("Введите фамилию");
            string surname = Console.ReadLine();
            Console.WriteLine("И в каком городе вы живете " + name);
            string city = Console.ReadLine();

            Console.SetCursorPosition(100, 100);
            Console.WriteLine(name);
            Console.SetCursorPosition(100, 100);
            Console.WriteLine(surname);
            Console.SetCursorPosition(100, 100);
            Console.WriteLine(city);

            */

            #endregion


        }


            #region Задание 3 вариант 2
            // * Выполнить предыдущее задание, оформив вычисления расстояния между точками в виде метода.

            /*

            static double Distance(double x1, double y1, double x2, double y2)

        {

            double R = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            return R;

        }
        
            */


            #endregion





    }


}





