using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCSharp
{
    internal class PrivateJet : ProjectCSharp.Aircraft 
    {
        private const int PrivateJetFlightCostPerH = 150;
        public int JetProfit;
        public int PrvJetRentCost { get; set; }
        public PrivateJet(string name) : base(name, PrivateJetFlightCostPerH)
        {
        }
        public override void CalculateProfit()
        {
            base.CalculateProfit();

            PrvJetRentCost = 50000;

            
            
            JetProfit = PrvJetRentCost - base.TotalFlightCost;
            
            

        }
        public override string ToString()
        {
            return "\nAircraftNames = " + AircraftNames + "\nPrivateJetFlightCostPerH = "
            + PrivateJetFlightCostPerH + "\nFlightHours = " + FlightHours +
            "\nTotalFlightCost = " + TotalFlightCost + "\nPrvJetRentCost = " + PrvJetRentCost;
            
        }
    }
}
