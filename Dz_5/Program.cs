using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int peopleInQueue;
            int timeOfReceipt = 10;
            int hoursInQueueLeft;
            int minutesInQueueLeft;
            int minutesInHour = 60;

            Console.Write("Введите кол-во людей в очереди: ");
            peopleInQueue = Convert.ToInt32(Console.ReadLine());

            hoursInQueueLeft = peopleInQueue * timeOfReceipt / minutesInHour;
            minutesInQueueLeft = peopleInQueue * timeOfReceipt % minutesInHour;

            Console.WriteLine($"Вы должны отстоять в очереди {hoursInQueueLeft} часа и {minutesInQueueLeft} минут");
        }
    }
}