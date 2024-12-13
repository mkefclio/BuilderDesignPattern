using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDesignPattern
{
    public class CarBuilder : IToyBuilder
    {
        private Toy _toy = new();

        public void Reset()
        {
            _toy = new Toy { Type = "Car" };
        }

        public void BuildWheels()
        {
            _toy.AddPart("4 Wheels");
        }

        public void BuildBody()
        {
            _toy.AddPart("Car Body");
        }

        public void BuildSeat()
        {
            _toy.AddPart("Car Seat");
        }

        public Toy GetToy()
        {
            return _toy;
        }
    }
}
