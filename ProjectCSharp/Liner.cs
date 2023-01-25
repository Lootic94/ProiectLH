using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCSharp
{
    internal class Liner : ProjectCSharp.Aircraft
    {
        //private float TotalIncome;
        private const int LinerFlightCostPerH = 9000;
        private int Seats = 300;
        private int TicketPrice = 300;
        private int Trips = 60;
        public int LinerProfit;

        public int TotalIncome { get; set; }
        public Liner(string name) : base(name, LinerFlightCostPerH)
        {
        }
        public override void CalculateProfit()
        {
            base.CalculateProfit();



           TotalIncome = Seats * TicketPrice * Trips;
            LinerProfit = TotalIncome - base.TotalFlightCost;
            
        }
        public override string ToString()
        {
            return "\nAircraftNames\r\n = " + AircraftNames
            + "\nLinerFlightCostPerH = " + LinerFlightCostPerH + "\nFlightHours = " + FlightHours
            + "\nTotalIncome = " + TotalIncome + "\nLinerProfit = " + LinerProfit;
       

        }
    }
}
