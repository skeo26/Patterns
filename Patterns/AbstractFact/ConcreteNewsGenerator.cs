using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsAgregator.Patterns.AbstractFact
{
    public class ConcreteNewsGenerator : NewsGenerator
    {
        public override List<string> GenerateNews(string topic)
        {
            if (newsOnTheTopic.ContainsKey(topic.ToLower()))
                return newsOnTheTopic[topic.ToLower()];
            else
                return new List<string> { "Новостей на данную тему пока нет" };
        }

        public override List<string> GetAvailableTopics()
        {
            return new List<string>(newsOnTheTopic.Keys);
        }
    }
}
