using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDesignPattern
{
    public abstract class CarDecorator : ICar
    {
        private ICar car;
        public CarDecorator(ICar Car)
        {
            car = Car;
        }
        public string Name { get { return car.Name; } }

        public double Price()
        {
            return car.Price(); //From Cache
        }
        public abstract double GetDiscountedPrice();
    }
}
