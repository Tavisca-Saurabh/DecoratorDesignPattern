using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDesignPattern
{
    public interface ICar
    {
        string Name { get; }
        double Price();
    }
}
