using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Aircraft> aircrafts = new List<Aircraft>();
            FileReader fr = new FileReader();
            int Month = 0, Year = 0;
            while(Year == 0)
            {
                Console.WriteLine("Please enter the year : ");  //Tratare de exceptii
                try
                {
                    Year = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message + "Please insert again !");
                }
            }
            while (Month == 0)
            {
                Console.WriteLine("Please enter the month : ");
                try
                {
                    Month = Convert.ToInt32(Console.ReadLine());
                    if (Month < 1 || Month > 12)
                    {
                        Console.WriteLine("Please insert again a correct month !");
                        Month = 0;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message + "Please insert again !");
                }
            }
            aircrafts = fr.ReadFile();
            for (int i = 0; i < aircrafts.Count; i++)
            {
                try
                {
                    Console.WriteLine("Enter hours worked for {0}: ", aircrafts[i].AircraftNames);
                    aircrafts[i].FlightHours = Convert.ToInt32(Console.ReadLine());
                    aircrafts[i].CalculateProfit();
                    Console.WriteLine(aircrafts[i].ToString());
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    i--;
                }
            }
            ProfitPerMonth ps = new ProfitPerMonth(Month, Year);
            ps.GenerateProfitPerMonth(aircrafts);
            ps.GenerateSummary(aircrafts);
            Console.Read();
        }
    }
}
        


    



