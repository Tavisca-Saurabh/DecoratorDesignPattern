using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ICar car = new Car();
            CarDecorator decorator = new OfferPrice(car);
            Console.WriteLine(string.Format("CarName :{0}  Price:{1} " +
                "DiscountPrice : {2}"
                , decorator.Name, decorator.Price().ToString(),
                decorator.GetDiscountedPrice().ToString()));
            Console.ReadLine();
        }
    }
}
