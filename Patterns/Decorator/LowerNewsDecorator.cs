using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsAgregator.Patterns.Decorator
{
    public class LowerNewsDecorator : NewsDisplayDecorator
    {
        public LowerNewsDecorator(NewsDisplay newsDisplay) : base(newsDisplay)
        {
        }

        public override void DisplayNews(List<string> news, string topic, SortContext sortStrategy)
        {
            Console.WriteLine($"--- {topic.ToLower()} ---");
            base.DisplayNews(news, topic, sortStrategy);
        }
    }
}
