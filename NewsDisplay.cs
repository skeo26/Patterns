﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsAgregator
{
    public abstract class NewsDisplay
    {
        public abstract void DisplayNews(List<string> news, string topic, SortContext sortStrategy);

        //public void DisplayNews(List<string> news, string topic, SortContext sortStrategy)
        //{
        //    List<string> sortedNews = sortStrategy.SortNews(news);
            
        //    Console.WriteLine($"\nНовости на тему: {topic}");

        //    foreach (string item in sortedNews)
        //    {
        //        Console.WriteLine("-" + item);
        //    }
        //}
    }
}
