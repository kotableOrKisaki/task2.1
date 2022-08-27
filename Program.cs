using System;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Напиши свое послание:\t");
            string message = Console.ReadLine();

            Console.Write("Сколько раз еще отправить?\t");
            int countMessage = Convert.ToInt32(Console.ReadLine());

            while (countMessage > 0)
            {
                countMessage--;
                Console.WriteLine(message);
            }
        }
    }
}
