using System;
using System.Collections.Generic;

namespace XML.Entites
{
    [Serializable]
    public class TestEntites
    {
        public string Science { get; set; } 
        public string Theme { get; set; }
        public int MaxPoint { get; set; }
        public int Point5 { get; set; } 
        public int Point4 { get; set; } 
        public int Point3 { get; set; }
        public int Time { get; set; } 
        public List<QuestionTestEntites> Questions { get; set; } 

        public TestEntites() { }

        /// <summary>
        /// Создаёт тест:
        /// </summary>
        /// <param name="science">Придмет</param>
        /// <param name="theme">Название теста</param>
        /// <param name="maxPoint">Максимальный балл за тест</param>
        /// <param name="point5">Винимальное количество баллов на 5</param>
        /// <param name="point4">Минимальное количество баллов на 4</param>
        /// <param name="point3">Минимальное количество баллов на 3</param>
        /// <param name="time">Общее время на тест</param>
        /// <param name="question">Массив вопросов</param>
        public TestEntites(string science, string theme, int maxPoint, int point5, int point4, int point3,
            int time, List<QuestionTestEntites> question)
        {
            if (string.IsNullOrEmpty(science) || string.IsNullOrEmpty(theme)
                || point3 > point4 || point4 > point5 || maxPoint < point5 || time <= 0
                || question == null || question.Count == 0)
                throw new ArgumentNullException();
            Science = science;
            Theme = theme;
            MaxPoint = maxPoint;
            Point3 = point3;
            Point4 = point4;
            Point5 = point5;
            Time = time;
            Questions = question;
        }
    }
}