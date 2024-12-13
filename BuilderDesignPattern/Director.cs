using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDesignPattern
{
    public class Director
    {
        private IToyBuilder _builder;

        public void SetBuilder(IToyBuilder builder)
        {
            _builder = builder;
        }

        public Toy ConstructToy()
        {
            _builder.Reset();
            _builder.BuildWheels();
            _builder.BuildBody();
            _builder.BuildSeat();
            return _builder.GetToy();
        }
    }
}
