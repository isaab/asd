using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Operators;

namespace Costumers
{
    class Costumer
    {
        string name;
        int costumer_start_x, costumer_start_y, costumer_end_x, costumer_end_y;

        public Costumer(string name, int start_x, int start_y, int end_x, int end_y)
        {
            this.name = name;
            this.costumer_start_x = start_x;
            this.costumer_start_y = start_y;
            this.costumer_end_x = end_x;
            this.costumer_end_y = end_y;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
        }

        public int Costumer_end_x
        {
            get
            {
                return this.costumer_end_x;
            }
        }

        public int Costumer_end_y
        {
            get
            {
                return this.costumer_end_y;
            }
        }

        public string costumerInputs()
        {
            return this.name + "-" + this.costumer_start_x + "-" + this.costumer_start_y;
        }

        public double distanceCalculator(int end_x, int end_y)
        {
            double distance = Math.Sqrt(Math.Pow(end_x - this.costumer_start_x, 2) + Math.Pow(end_y - this.costumer_start_y, 2));
            return Math.Round(distance);
        }

        public int taxiSelection(List<Taxi> taxiList, List<double> distanceList, Costumer cos)
        {
            int position = 0;
            double minDistance;
            for (int i = 0; i < taxiList.Count; i++)
            {
                distanceList.Add(cos.distanceCalculator(taxiList[i].Taxi_start_x, taxiList[i].Taxi_start_y));
            }

            minDistance = distanceList[0];
            for (int i = 0; i < distanceList.Count; i++)
            {
                if (distanceList[i] < minDistance)
                {
                    position = i;

                }
            }

            distanceList.Clear();
            return position;
        }
    }
}
