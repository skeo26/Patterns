using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsAgregator
{
    public class NewsGenerator
    {
        private readonly Dictionary<string, List<string>> newsOnTheTopic;

        public NewsGenerator()
        {
            newsOnTheTopic = new Dictionary<string, List<string>>
                {
                    {"политика", new List<string> { "Новый законопроект принят в парламенте.", "Политический скандал в правительстве.", "Президент подписал мирное соглашение." }},
                    {"спорт", new List<string> { "Манчестер Сити выиграли чемпионат Англии по футболу", "Известный спортсмен достиг нового рекорда.", "Новый тренер назначен в футбольной команде Манчестер Юнайтед." }},
                    {"технологии", new List<string> { "Крупная IT-компания представила новый продукт.","Искусственный интеллект победил в шахматной партии.", "В рейтинге смартфонов с самыми большими поставками — абсолютное доминирование iPhone и ни одной модели Plus." }},
                    {"наука", new List<string> { "Ученые обнаружили новую планету в солнечной системе.", "Медицинские исследования привели к новому открытию.", "Экспериментальный проект получил финансирование для дальнейших исследований." }}
                };

        }
        public List<string> GenerateNews(string topic)
        {
            if (newsOnTheTopic.ContainsKey(topic.ToLower()))
                return newsOnTheTopic[topic.ToLower()];
            else
                return new List<string> { "Новостей на данную тему пока нет" };
        }

        public List<string> GetAvailableTopics()
        {
            return new List<string>(newsOnTheTopic.Keys);
        }
    }
}
