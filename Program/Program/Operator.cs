using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Costumers;

namespace Operators
{
    class Operator
    {
        byte taxi_speed = 3;
        Costumer cos;
        Taxi taxi;
        public Operator(Costumer costumer, Taxi taxi)
        {
            this.cos = costumer;
            this.taxi = taxi;
            messageToCostumer();
        }

        public double feeCalculator()
        {
            double fee = cos.distanceCalculator(cos.Costumer_end_x, cos.Costumer_end_y) / 5;
            return fee;
        }

        public double taxiArrivalTime()
        {
            double time = cos.distanceCalculator(taxi.Taxi_start_x, taxi.Taxi_start_y) / taxi_speed;
            return Math.Ceiling(time);
        }

        public double destenationArrivalTime()
        {
            double time = cos.distanceCalculator(cos.Costumer_end_x, cos.Costumer_end_y) / taxi_speed;
            return Math.Ceiling(time);
        }

        public void messageToCostumer()
        {
            Console.WriteLine("\n" + "Hormetli " + cos.Name + ", taksiniz teyin edildi.Taksiniz "
                + this.taxiArrivalTime()
                + " deqe adresinizde olacaq, qeyd etdiyiniz adrese çatma vaxtiniz "
                + this.destenationArrivalTime()
                + " deqiqedir ve gediş haqqiniz "
                + this.feeCalculator()
                + " manat olacaqdir.Taxinizin nomresi " + taxi.CarNumber + ". Bizi seçdiyiniz ucun teşekkur edirik.");
        }
    }

    class Taxi
    {
        string carNumber;
        int taxi_start_x, taxi_start_y;

        public Taxi(string carNum, int x, int y)
        {
            this.carNumber = carNum;
            this.taxi_start_x = x;
            this.taxi_start_y = y;
        }

        public string CarNumber
        {
            get
            {
                return this.carNumber;
            }
        }

        public int Taxi_start_x
        {
            get
            {
                return this.taxi_start_x;
            }
        }

        public int Taxi_start_y
        {
            get
            {
                return this.taxi_start_y;
            }
        }


    }

}