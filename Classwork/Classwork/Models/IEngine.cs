using System;
using System.Collections.Generic;
using System.Text;

namespace Classwork.Models
{
    interface IEngine
    {
        public double HorsePower { get; set; }
        public double TankSize { get; set; }
        public double CurrentOil { get; set; }
        public double FuelType { get; set; }
        public void LeftFuelAmount()
        {

        }
    }
}
