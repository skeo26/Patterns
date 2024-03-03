using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsAgregator.Patterns.AbstractFact
{
    public class ConcreteNewsDisplay : NewsDisplay
    {
        public override void DisplayNews(List<string> news, string topic, SortContext sortStrategy)
        {
            List<string> sortedNews = sortStrategy.SortNews(news);

            Console.WriteLine($"\nНовости на тему: {topic}");

            foreach (string item in sortedNews)
            {
                Console.WriteLine("-" + item);
            }
        }
    }
}
