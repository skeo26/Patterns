using NewsAgregator.Patterns.AbstractFact;
using NewsAgregator.Patterns.Strategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsAgregator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Приветствуем Вас в новостном агрегаторе!\n");

            NewsFactory factory = new NewsAgregatorFactory();

            NewsGenerator newsGenerator = factory.CreateNewsGenerator();
            NewsDisplay newsDisplay = factory.GetNewsDisplay();


            Console.WriteLine("Выберите тему новостей:");

            for (int i = 0; i < newsGenerator.GetAvailableTopics().Count; i++)
            {
                Console.WriteLine($"{i + 1}. {newsGenerator.GetAvailableTopics()[i]}");
            }
            int choice;

            while ((!int.TryParse(Console.ReadLine(), out choice)) || choice > newsGenerator.GetAvailableTopics().Count || choice < 1)
            {
                Console.WriteLine("Некорректный вод!\n" +
                    "Попробуйте ещё раз"
                    );
            }

            string selectedTopic = newsGenerator.GetAvailableTopics()[choice - 1];

            List<string> news = newsGenerator.GenerateNews(selectedTopic);

            Console.WriteLine($"\nНовости по теме \"{selectedTopic}\":");
            foreach (string item in news)
            {
                Console.WriteLine("- " + item);
            }

            Console.WriteLine("\nВыберите стратегию сортировки новостей: \n" +
                "1. по алфавиту\n" +
                "2. по длине\n" +
                "3. по количеству слов"
                );

            while ((!int.TryParse(Console.ReadLine(), out choice)) || choice > 3 || choice < 1)
            {
                Console.WriteLine("Некорректный вод!\n" +
                    "Попробуйте ещё раз"
                    );
            }

            SortContext sortContext = SortContext.Instance;

            if (choice == 1)
            {
                //sortContext = new SortContext(new AlphabeticalSort());
                sortContext.SetSortStrategy(new AlphabeticalSort());
                newsDisplay.DisplayNews(news, selectedTopic, sortContext);
            }
            else if (choice == 2)
            {
                //sortContext = new SortContext(new LengthSort());
                sortContext.SetSortStrategy(new LengthSort());
                newsDisplay.DisplayNews(news, selectedTopic, sortContext);
            }
            else
            {
                //sortContext = new SortContext(new WordCountSort());
                sortContext.SetSortStrategy(new WordCountSort());
                newsDisplay.DisplayNews(news, selectedTopic, sortContext);
            }

            Console.ReadLine();
        }
    }
}
