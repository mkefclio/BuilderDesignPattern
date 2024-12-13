using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDesignPattern
{
    public interface IToyBuilder
    {
        void Reset();
        void BuildWheels();
        void BuildBody();
        void BuildSeat();
        Toy GetToy();
    }
}
