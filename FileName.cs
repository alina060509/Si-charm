
namespace ConsoleApp2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите ваше имя: ");
            string name = Console.ReadLine();

            Console.WriteLine("Введите вашу фамилию: ");
            string fam = Console.ReadLine();

            Console.WriteLine("Введите ваш возраст: ");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите ваш вес: ");
            double weight = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите ваш рост: ");
            double height = double.Parse(Console.ReadLine());
            Console.WriteLine($"Ваше имя: {name}, ваш возраст: {age}, ваша фамилия: {fam}, ваш рост: {height},Ваш вес:{weight}");

            Console.WriteLine("Введите ваш вес: ");
            double m = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите ваш рост: ");
            double h = double.Parse(Console.ReadLine());
            double I = m / (h * h);
            Console.WriteLine($"ИМТ:{I}");

            Console.WriteLine("x1: ");
            int x1 = int.Parse(Console.ReadLine());
            Console.WriteLine("y1: ");
            int y1 = int.Parse(Console.ReadLine());
            int x2 = int.Parse(Console.ReadLine());
            Console.WriteLine("x2: ");
            int y2 = int.Parse(Console.ReadLine());
            Console.WriteLine("y2: ");
            int r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2);
            Console.WriteLine($"результат:{r}");

            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine($"{a}-{b}");
            (a, b) = (b, a);
            Console.WriteLine($"{a}-{b}");

            Console.WriteLine("Введите ваше имя: ");
            string name2 = Console.ReadLine();
            Console.WriteLine("Введите вашу фамилию: ");
            string fam2 = Console.ReadLine();
            Console.WriteLine("Введите ваш город: ");
            string city = Console.ReadLine();
            Console.SetCursorPosition(Console.WindowWidth / 2, Console.WindowHeight / 2);
            Console.WriteLine($"Ваше имя: {name},ваша фамилия: {fam}, ваш город: {city}");
        }
    }
}


           