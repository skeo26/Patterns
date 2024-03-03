using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsAgregator.Patterns.Decorator
{
    public class UpperNewsDisplay : NewsDisplayDecorator
    {
        public UpperNewsDisplay(NewsDisplay newsDisplay) : base(newsDisplay)
        {
        }

        public override void DisplayNews(List<string> news, string topic, SortContext sortStrategy)
        {
            Console.WriteLine($"=== {topic.ToUpper()} ===");
            base.DisplayNews(news, topic, sortStrategy);
        }
    }
}
