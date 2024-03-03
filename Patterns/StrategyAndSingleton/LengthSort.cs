﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsAgregator.Patterns.Strategy
{
    public class LengthSort : ISort
    {
        public List<string> SortNews(List<string> newsOnTheTopic)
        {
            return newsOnTheTopic.OrderBy(x => x.Length).ToList();
        }
    }
}
