using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDesignPattern
{
    public class BikeBuilder : IToyBuilder
    {
        private Toy _toy = new();

        public void Reset()
        {
            _toy = new Toy { Type = "Bike" };
        }

        public void BuildWheels()
        {
            _toy.AddPart("2 Wheels");
        }

        public void BuildBody()
        {
            _toy.AddPart("Bike Frame");
        }

        public void BuildSeat()
        {
            _toy.AddPart("Bike Seat");
        }

        public Toy GetToy()
        {
            return _toy;
        }
    }
}
