namespace Algorithms
{
    internal class Program
    {
        static void Main(string[] args)
        {
           foreach (var arg in UserList())
            {
                Console.WriteLine($"\nПривет, {arg.Name} ({arg.Login})!");
                if (arg.IsPremium == true)
                {
                    ShowAds();
                }
            }
           Console.ReadKey();
        }

        static void ShowAds()
        {
            Console.WriteLine("Посетите наш новый сайт с бесплатными играми free.games.for.a.fool.com");
            // Остановка на 1 с
            Thread.Sleep(1000);

            Console.WriteLine("Купите подписку на МыКомбо и слушайте музыку везде и всегда.");
            // Остановка на 2 с
            Thread.Sleep(2000);

            Console.WriteLine("Оформите премиум-подписку на наш сервис, чтобы не видеть рекламу.");
            // Остановка на 3 с
            Thread.Sleep(3000);
        }

        public static List<Users> UserList()
        {
            Users user1 = new Users()
            {
                Name = "Алексей",
                Login = "alex",
                IsPremium = false
            };

            Users user2 = new Users()
            {
                Name = "Михаил",
                Login = "miha",
                IsPremium = true
            };

            Users user3 = new Users()
            {
                Name = "Владимир",
                Login = "valdemar",
                IsPremium = false
            };

            List<Users> ListEmployee = new List<Users>();
            ListEmployee.Add(user1);
            ListEmployee.Add(user2);
            ListEmployee.Add(user3);

            return ListEmployee;    
        }
    }
}