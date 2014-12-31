using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleSpeedMeterApp
{
    class Vehicle
    {
        private string name;
        private string regNo;
        private double inputSpeed;
        private double minSpeed;
        private double maxSpeed;
        private double averagespeed;
        private double count;
        private double totalSpeed;

        public Vehicle(string name, string regNo)
        {
            Name = name;
            RegNo = regNo;
        }
        public string Name
        {
            set { name = value; }
        }

        public string RegNo
        {
            set { regNo = value; }
        }

        public double InputSpeed
        {
            set { inputSpeed = value; }
        }

        public double MinSpeed
        {
            get { return minSpeed; }
        }

        public void CalculateMinSpeed()
        {
            if (inputSpeed < minSpeed || minSpeed ==0)
            {
                minSpeed = inputSpeed;
            }
        }
        public double MaxSpeed
        {
            get { return maxSpeed; }
        }

        public void CalculationMaxSpeed()
        {
            if (inputSpeed > maxSpeed || maxSpeed ==0)
            {
                maxSpeed = inputSpeed;
            }
        }

        public double Averagespeed
        {
            get { return averagespeed; }
        }

        public void CalculationAverageSpeed()
        {
            count++;
            totalSpeed += inputSpeed;

            if (averagespeed == 0)
            {
                averagespeed = inputSpeed;
            }
            else
            {
                averagespeed = totalSpeed/count;
            }
        }
    }
}
