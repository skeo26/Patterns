using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsAgregator
{
    public interface ISort
    {
        List<string> SortNews(List<string> newsOnTheTopic);
    }
}
