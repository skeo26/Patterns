using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsAgregator.Patterns.Decorator
{
    public abstract class NewsDisplayDecorator : NewsDisplay
    {
        protected NewsDisplay newsDisplay;

        public NewsDisplayDecorator(NewsDisplay newsDisplay)
        {
            this.newsDisplay = newsDisplay;
        }

        public override void DisplayNews(List<string> news, string topic, SortContext sortStrategy)
        {
            newsDisplay.DisplayNews(news, topic, sortStrategy);
        }
    }
}
