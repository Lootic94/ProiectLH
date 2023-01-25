using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCSharp
{
    internal class ProfitPerMonth
    {
        private int Month;
        private int Year;
        
        enum MonthsOfYear { jan = 1, feb = 2, mar = 3, apr = 4, may = 5, jun = 6, jul = 7, aug = 8, sep = 9, oct = 10, nov = 11, dec = 12 }

        public ProfitPerMonth(int PayMonth, int PayYear)
        {
            Month = PayMonth;
            Year = PayYear;
        }
        public void GenerateProfitPerMonth(List<Aircraft> aircrafts)
        {
            string path;

            foreach (Aircraft f in aircrafts)
            {
                path = "C:\\Users\\horat\\OneDrive\\Desktop\\ProiectLH\\ProjectCSharp\\ProjectCSharp\\" + f.AircraftNames + ".txt";
                using (StreamWriter sw = new StreamWriter(path))
                {
                    sw.WriteLine("ProfitPerMonth FOR {0} {1}", (MonthsOfYear)Month, Year);
                    sw.WriteLine("**************************************");
                    sw.WriteLine("Name of Aircraft : {0}", f.AircraftNames);
                    sw.WriteLine("Hours of flight : {0}", f.FlightHours);
                    sw.WriteLine("");
                    sw.WriteLine("Flight cost: {0:C}", f.TotalFlightCost);
                    if (f.GetType() == typeof(PrivateJet))
                    {
                        sw.WriteLine("PrvJetRentCost: {0:C}", ((PrivateJet)f).PrvJetRentCost);
                        sw.WriteLine("JetProfit: {0:C}", ((PrivateJet)f).JetProfit);
                    }
                    else if (f.GetType() == typeof(Liner))
                    {
                        


                        sw.WriteLine("TotalIncome: {0:C}", ((Liner)f).TotalIncome);
                        sw.WriteLine("LinerProfit: {0:C}", ((Liner)f).LinerProfit);
                    }
                    sw.WriteLine("");
                    sw.WriteLine("**************************************");
                    sw.WriteLine("**************************************");
                    sw.Close();
                }
            }
        }
        public void GenerateSummary(List<Aircraft> aircrafts)
        {
            var result = from f in aircrafts where f.FlightHours > 100 orderby f.AircraftNames ascending select new { f.AircraftNames, f.FlightHours };
            string path = "C:\\Users\\horat\\OneDrive\\Desktop\\ProiectLH\\ProjectCSharp\\ProjectCSharp\\summary.txt";
            using (StreamWriter sw = new StreamWriter(path))
            {
                sw.WriteLine("Aircrafts with less than 100 flight hours");
                sw.WriteLine("");
                foreach (var f in result)
                    sw.WriteLine("Name of Aircraft: {0}, Hours in flight: {1}", f.AircraftNames, f.FlightHours);
                sw.Close();
            }
        }
        public override string ToString()
        {
            return "month = " + Month + "year = " + Year;
        }
    }
}
