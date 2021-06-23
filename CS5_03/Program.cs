using System;

namespace CS5_03
{
    public class Program
    {
        static void Main(string[] args)
        {
            int x = 10, y = 12, z = 3;
            double radius = 10;

            ShowAdditionResult(x, z);
            ShowTaskAResult(x, y, z);
            ShowTaskBResult(x, y, z);
            ShowTaskCResult(radius);
            ShowTaskDResult(10, 20);
            CheckVariableNames();
            Console.ReadKey();
        }

        public static void ShowAdditionResult(int x, int y)
        {
            Console.WriteLine("");
            Console.WriteLine("Task_00");

            string addition = $"Сложение \t\t- {x}+{y}={x + y}";
            string exclusion = $"Вычитание \t\t- {x}-{y}={x - y}";
            string multiplication = $"Умножение \t\t- {x}*{y}={x * y}";
            string division = $"Деление \t\t- {x}/{y}={x / y}";
            string reminder = $"Деление с остатком \t- {x}%{y}={x % y}";

            Console.WriteLine($"{addition}\n{exclusion}" +
                $"\n{multiplication}\n{division}\n{ reminder}");
            Console.WriteLine(new string('-', Console.WindowWidth));
        }

        public static void ShowTaskAResult(int x, int y, int z)
        {
            Console.WriteLine("");
            Console.WriteLine("Task_01");

            Console.WriteLine($"Origin x={x}, y={y}, z={z}");
            Console.WriteLine("--------------------------");

            Console.WriteLine($"IN  - x={x}, y={y}, z={z}");
            x += y - x++ * z;
            Console.WriteLine("x += y - x++ * z");
            Console.WriteLine($"OUT - x={x}, y={y}, z={z}");
            Console.WriteLine("--------------------------");

            Console.WriteLine($"IN - x={x}, y={y}, z={z}");
            z = --x - y * 5;
            Console.WriteLine("z = --x - y * 5;");
            Console.WriteLine($"OUT - x={x}, y={y}, z={z}");
            Console.WriteLine("--------------------------");

            Console.WriteLine($"IN  - x={x}, y={y}, z={z}");
            y /= x + 5 % z;
            Console.WriteLine("y /= x + 5 % z");
            Console.WriteLine($"OUT - x={x}, y={y}, z={z}");
            Console.WriteLine("--------------------------");

            Console.WriteLine($"IN  - x={x}, y={y}, z={z}");
            z = x++ + y * 5;
            Console.WriteLine("z = x++ + y * 5");
            Console.WriteLine($"OUT - x={x}, y={y}, z={z}");
            Console.WriteLine("--------------------------");

            Console.WriteLine($"IN  - x={x}, y={y}, z={z}");
            x = y - x++ * z;
            Console.WriteLine("x = y - x++ * z");            
            Console.WriteLine($"OUT - x={x}, y={y}, z={z}");
            Console.WriteLine("--------------------------");
        }

        public static void ShowTaskBResult(int x, int y, int z)
        {
            Console.WriteLine("");
            Console.WriteLine("Task_02");
            Console.WriteLine($"Origin x={x}, y={y}, z={z}");
            Console.WriteLine($"sum={x + y + z}");
            Console.WriteLine($"result=sum/3={(x + y + z) / 3}");
            Console.WriteLine("Видим, что пропала единица");
            Console.WriteLine("Вывод из задания - для нахождения среднего \nарифметического следует использовать тип double");
            Console.WriteLine("--------------------------");
        }

        public static void ShowTaskCResult(double radius)
        {
            Console.WriteLine("");
            Console.WriteLine("Task_03");

            const double pi = Math.PI;
            double circleArea = pi * Math.Pow(radius, 2);
            Console.WriteLine($"Площадь круга с радиусом {radius} будет равна {circleArea}");
            Console.WriteLine("--------------------------");
        }

        public static void ShowTaskDResult(double radius, double height)
        {
            Console.WriteLine("");
            Console.WriteLine("Task_04");

            double volume, square;
            volume = Math.PI * Math.Pow(radius, 2) * height;            
            square = (2 * Math.PI * radius) * (radius + height);
            Console.WriteLine($"Площадь цилиндра радиусом {radius} и высотой {height} \n" +
                $"будет равняться {square}");
            Console.WriteLine("--------------------------");
        }        

        public static void CheckVariableNames()
        {
            Console.WriteLine("");
            Console.WriteLine("Task_05");

            Console.WriteLine("uberflu? - не может быть названием переменной \n" +
                "так как содержит недопустимые символы ('?')");
            int _Identifier;
            int \u006fIdentifier;
            Console.WriteLine("&myVar - не может быть названием переменной \n" +
                "так как содержит недопустимые символы ('&')");
            int myVariab1le;

            Console.WriteLine("--------------------------");
        }
    }
}
