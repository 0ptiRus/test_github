using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_del
{
    class Program
    {
        private static List<string> advices = new();
        private static void IvanSubscriber(string author, string message)
        {
            Console.WriteLine($"{author}: {message}");
        }

        private static void CatherineSubscriber(string author, string message)
        {
            advices.Add(message);
        }
        private static Random random = new Random();
        private static void OlgaSubscriber(string author, string message)
        {
            if(random.Next(2) == 0)
            {
                Console.WriteLine($"Olga is following the advice: {message}");
            }
        }

        static void Main(string[] args)
        {
            Publisher business_for_you = new Publisher();
            business_for_you.NewIssue += IvanSubscriber;
            business_for_you.NewIssue += CatherineSubscriber;
            business_for_you.NewIssue += OlgaSubscriber;

            business_for_you.MakeEvents();
        }
    }
}
