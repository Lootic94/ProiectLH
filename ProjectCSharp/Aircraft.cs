using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCSharp
{
    internal class Aircraft
    {
        private int FlightCostPerH;
        private int FHours;

        public int TotalFlightCost { get; set; }
        public string AircraftNames { get; set; }
        public int FlightHours
        {
            get { return FHours; }
            set
            {
                if (value > 0)
                {
                    FHours = value;
                }
                else
                {
                    FHours = 0;
                }
            }
        }
        public Aircraft(string name, int rate)
        {
            AircraftNames = name;
            FlightCostPerH = rate;
        }

        public virtual void CalculateProfit()
        {
            Console.WriteLine("Calculate cost ...");

            TotalFlightCost = FHours * FlightCostPerH;
        
            
        }

        public override string ToString()
        {
            return "\nAircraftNames = " + AircraftNames
            + "\nFlightCostPerH = " + FlightCostPerH + "\nFHours = " + FHours
            + "\nTotalFlightCost = " + TotalFlightCost;
        }
    }
}
