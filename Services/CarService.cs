using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class CarService
    {
        private List<Car> cars;

        public CarService()
        {
            cars = new List<Car>();
        }

        public Car Add(Car car)
        {
            cars.Add(car);
            return car;
        }
    }
}
