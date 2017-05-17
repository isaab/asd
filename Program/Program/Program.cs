using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Costumers;
using Operators;

namespace taxi_service
{
    class Program
    {
        static void Main(string[] args)
        {
            Costumer senem = new Costumer("Senem", 40, 50, 100, 150);
           // Costumer nigar = new Costumer("Nigar", 15, 15, 40, 100);
           // Costumer ferid = new Costumer("Ferid", 25, 70, 5, 25);

            List<Taxi> taxiList = new List<Taxi>();
            List<double> distanceList = new List<double>();

            taxiList.Add(new Taxi("10-HY-123", 50, 60));
            taxiList.Add(new Taxi("10-XD-562", 10, 35));
            taxiList.Add(new Taxi("10-UR-821", 25, 55));
            taxiList.Add(new Taxi("10-XS-821", 15, 20));

            int positionS = senem.taxiSelection(taxiList, distanceList, senem);
            //int positionN = nigar.taxiSelection(taxiList, distanceList, nigar);
           // int positionF = ferid.taxiSelection(taxiList, distanceList, ferid);

            Console.WriteLine("\n" + "Costumer inputs: " + senem.costumerInputs());
            Operator operatorS = new Operator(senem, taxiList[positionS]);

           // Console.WriteLine("\n" + "Costumer inputs: " + nigar.costumerInputs());
            //Operator operatorN = new Operator(nigar, taxiList[positionN]);

           //Console.WriteLine("\n" + "Costumer inputs: " + ferid.costumerInputs());
            //Operator operatorF = new Operator(ferid, taxiList[positionF]);

            Console.ReadKey();
        }
    }
}
