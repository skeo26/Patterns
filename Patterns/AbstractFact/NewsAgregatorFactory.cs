using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsAgregator.Patterns.AbstractFact
{
    public class NewsAgregatorFactory : NewsFactory
    {
        public override NewsGenerator CreateNewsGenerator()
        {
            return new ConcreteNewsGenerator();
        }

        public override NewsDisplay GetNewsDisplay()
        {
            return new ConcreteNewsDisplay();
        }
    }
}
