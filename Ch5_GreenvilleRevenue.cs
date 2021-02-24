//Program written by: Heather, Liam, and McKenzie
//Program date: 2/23/21
//Program description: Ch5 case 1


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
            while(true) {
                Console.WriteLine("How many contestants were entered into this years competition? must be between 0 and 30");
                contestantsThisYr = Console.ReadLine();
                numPeopleThisYr = Convert.ToInt32(contestantsThisYr);
                if(numPeopleThisYr <= 30 && numPeopleThisYr >= 0)
                    break;
             }
            Console.WriteLine("Last year there were {0} contestants and this year there were {1}.", numPeopleLastYr, numPeopleThisYr);
            double revenue = numPeopleThisYr * 25;
            Console.WriteLine("The projected revenue for this year is {0}", revenue.ToString("c"));

            if (numPeopleThisYr > (numPeopleLastYr * 2))
                Console.WriteLine("The competition is more than twice as big this year!");

            if (numPeopleThisYr > numPeopleLastYr && !(numPeopleThisYr > (numPeopleLastYr * 2))
                Console.WriteLine("The competition is more than twice as big this year!");
            if (numPeopleThisYr < numPeopleLastYr)
                Console.WriteLine("A tighter race this year! Come out and cast your vote!");
        }
    }
}
