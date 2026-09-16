namespace Lb1
{
    public class Program
    {
        static void Main()
        {
            Console.WriteLine("Сторони трикутника:");
            if (int.TryParse(Console.ReadLine(), out int a) && int.TryParse(Console.ReadLine(), out int b) && int.TryParse(Console.ReadLine(), out int c))
            {
                // чи всі сторони трикутника додатні
                if (a > 0 && b > 0 && c > 0)
                {
                    Console.WriteLine("Всі додатні");
                }
                else { Console.WriteLine("Не всі додатні"); return; }
                // чи трикутник утворюється 
                if (a + b > c && b + c > a && a + c > b)
                {
                    Console.WriteLine("Є такой");
                }
                else
                {
                    Console.WriteLine("Немає такого");
                    return;
                }
                // периметр трикутника 
                Console.WriteLine($"Периметр трикутника: {a + b + c}");
                // За формулою Герона
                double p = (a + b + c) / 2;
                double s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
                Console.WriteLine($"Площа трикутника: {s}");
                //Рівносторонній
                if (a == b && b == c && c == a)
                {
                    Console.WriteLine("рівносторонній");
                }
                else
                {
                    Console.WriteLine("не рівносторонній");
                }
                //Рівнобедрений
                if (a == b || b == c || a == c)
                {
                    Console.WriteLine("рівнобедрений");
                }
                else
                {
                    Console.WriteLine("не рівнобедрений");
                }
                //Прямокутний
                if (a * a + b * b == c * c || b * b + c * c == a * a || a * a + c * c == b * b)
                {
                    Console.WriteLine("прямокутний");
                }
                else
                {
                    Console.WriteLine("не прямокутний");
                }
                //Довільний
                if (a != b && b != c && a != c)
                {
                    Console.WriteLine("довільний");
                }
                else
                {
                    Console.WriteLine("не довільний");
                }
            }
        }
    }
}
