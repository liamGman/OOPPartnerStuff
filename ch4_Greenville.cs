//Program written by: Heather, Liam, and McKenzie
//Program date: 2/16/21
//Program description: Ch4 case 1


using System;

namespace GreenvilleRevenue
{
    class Program
    {
        static void Main(string[] args)
        {
            string contestantsLastYr, contestantsThisYr;
            int numPeopleLastYr, numPeopleThisYr;
            
            Console.WriteLine("How many contestants were entered in to last years competition?");
            contestantsLastYr = Console.ReadLine();
            numPeopleLastYr = Convert.ToInt32(contestantsLastYr);
            Console.WriteLine("How many contestants were entered in to this years competition?");
            contestantsThisYr = Console.ReadLine();
            numPeopleThisYr = Convert.ToInt32(contestantsThisYr);
            Console.WriteLine("Last year there were {0} contestants and this year there were {1}.", numPeopleLastYr, numPeopleThisYr);
            double revenue = numPeopleThisYr * 25;
            Console.WriteLine("The projected revenue for this year is {0}", revenue.ToString("c"));

            if (numPeopleThisYr > (numPeopleLastYr * 2))
                Console.WriteLine("The competition is more than twice as big this year!");
            
            if (numPeopleThisYr > numPeopleLastYr && !(numPeopleThisYr > (numPeopleLastYr * 2))
                Console.WriteLine("The competition is more than twice as big this year!");

        }
    }
}
