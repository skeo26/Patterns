using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsAgregator
{
    public sealed class SortContext
    {
        private ISort _sortStrategy;

        private static readonly Lazy<SortContext> _instance = new Lazy<SortContext>(() => new SortContext());

        private SortContext() { }

        public static SortContext Instance { get { return _instance.Value; } }

        public void SetSortStrategy(ISort sortStrategy)
        {
            _sortStrategy = sortStrategy;
        }

        public List<string> SortNews(List<string> newsOnTheTopic)
        {
            return _sortStrategy.SortNews(newsOnTheTopic);
        }
    }
}
