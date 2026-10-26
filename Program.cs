using System.Text;
namespace Hunter_game
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;
            Hunter hunter = new Hunter();
            while (true) { 
            Console.WriteLine("---------Меню---------");
            Console.WriteLine("1. Статистика ");
            Console.WriteLine("2. Піти до магазину ");
            Console.WriteLine("3. Піти на полювання ");
            Console.WriteLine("4. Завершити гру ");
            string choice = Console.ReadLine();
            
           

          
                switch (choice)
                {
                case "1":
                    hunter.ShowStats();
                    break;

                case "2":
                    hunter.VisitShop();

                    break;

                case "3":
                    hunter.HuntRabbit();
                    break;

                case "4":
                    Console.WriteLine("Гру завершено.");
                    break;

                default:
                    Console.WriteLine("Невірний вибір.");
                    break;
                }
                            }
        }
    }
}
