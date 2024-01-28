using System.Runtime.ConstrainedExecution;
using System.Numerics;
namespace AHUEEET
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Выберите действие:");
                Console.WriteLine("1. Сложить 2 числа.");
                Console.WriteLine("2. Вычесть первое из второго.");
                Console.WriteLine("3. Перемножить два числа.");
                Console.WriteLine("4. Разделить первое на второе.");
                Console.WriteLine("5. Возвести в степень N первое число.");
                Console.WriteLine("6. Найти квадратный корень из числа.");
                Console.WriteLine("7. Найти 1 процент от числа.");
                Console.WriteLine("8. Найти факториал из числа.");
                Console.WriteLine("9. Выйти из программы.");
                string choice = Console.ReadLine();
                if (choice == "1")
                {
                    Console.WriteLine("Введите первое число: ");
                    string one = Console.ReadLine();
                    int x = Convert.ToInt32(one);
                    Console.WriteLine("Введите второе число: ");
                    string two = Console.ReadLine();
                    int y = Convert.ToInt32(two);
                    Console.WriteLine(x + y);
                }
                if (choice == "2")
                {
                    Console.WriteLine("Введите первое число (из которого хотите вычесть): ");
                    string sad = Console.ReadLine();
                    int x = Convert.ToInt32(sad);
                    Console.WriteLine("Введите второе число (которое будете вычитать из первого: )");
                    string fun = Console.ReadLine();
                    int y = Convert.ToInt32(fun);
                    Console.WriteLine(x - y);
                }
                if (choice == "3")
                {
                    Console.WriteLine("Введите первое число: ");
                    string one = Console.ReadLine();
                    int x = Convert.ToInt32(one);
                    Console.WriteLine("Введите второе число: ");
                    string two = Console.ReadLine();
                    int y = Convert.ToInt32(two);
                    Console.WriteLine(x * y);
                }
                if (choice == "4")
                {
                    Console.WriteLine("Введите первое число (которое хотите разделить на второе): ");
                    string one = Console.ReadLine();
                    int x = Convert.ToInt32(one);
                    Console.WriteLine("Введите первое число (на которое хотите разделить первое): ");
                    string two = Console.ReadLine();
                    int y = Convert.ToInt32(two);
                    Console.WriteLine(x / y);
                }
                if (choice == "5")
                {
                    Console.WriteLine("Введите число, которое хотите возвести в степень: ");
                    string one = Console.ReadLine();
                    int x = Convert.ToInt32(one);
                    Console.WriteLine("Введите степень");
                    string two = Console.ReadLine();
                    int y = Convert.ToInt32(two);
                    double pow = Math.Pow(x, y);
                    Console.WriteLine(pow);
                }
                if (choice == "6")
                {
                    Console.WriteLine("Введите число, из которого хотите найти квадратный корень: ");
                    string one = Console.ReadLine();
                    int x = Convert.ToInt32(one);
                    double result = Math.Sqrt(x);
                    Console.WriteLine(result);
                }
                if (choice == "7")
                {
                    Console.WriteLine("Введите число из которого хотите найти процент");
                    string one = Console.ReadLine();
                    int x = Convert.ToInt32(one);
                    double result = (x / 100);
                    Console.WriteLine(result);
                }
                if (choice == "8")
                {
                    {
                        Console.Write("Введите число: ");
                        int number = Convert.ToInt32(Console.ReadLine());

                        int factorial = 1;
                        for (int i = 1; i <= number; i++)
                        {
                            factorial *= i;
                        }

                        Console.WriteLine("Факториал числа " + number + " равен " + factorial);

                    }
                }
                if (choice == "9")
                {
                    break;
                }
            }
        }

    }
}
