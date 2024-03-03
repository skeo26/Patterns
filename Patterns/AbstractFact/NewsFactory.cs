using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsAgregator.Patterns.AbstractFact
{
    public abstract class NewsFactory
    {
        public abstract NewsGenerator CreateNewsGenerator();
        public abstract NewsDisplay GetNewsDisplay();
    }
}
