using System;
using System.Collections.Generic;
using System.Text;

namespace CarApp
{
    public class CarInput
    {
        public List<Car> CarList { get; set; }
        

        public CarInput()
        {
            CarList = new List<Car>();
            
        }
    }
}
