using System;
using System.Collections.Generic;

namespace XML.Entites
{
    [Serializable]
    public class TestEntites
    {
        public string Science { get; set; } //Название предмета
        public string Theme { get; set; } //Название теста
        public int MaxPoint { get; set; } //Всего баллов
        public int Point5 { get; set; } //Баллов на 5
        public int Point4 { get; set; } //Баллов на 4
        public int Point3 { get; set; } //Баллов на 3
        public int Time { get; set; } //Время на тест
        public List<QuestionEntites> Questions { get; set; } //Список вопросов

        public TestEntites() { }

        /// <param name="science">Предмет</param>
        /// <param name="theme">Название теста</param>
        /// <param name="maxPoint">Максимальный балл за тест</param>
        /// <param name="point3">Минимальное количество баллов на 3</param>
        /// <param name="point4">Минимальное количество баллов на 4</param>
        /// <param name="point5">Винимальное количество баллов на 5</param>
        /// <param name="time">Общее время на тест</param>
        /// <param name="question">Массив вопросов</param>
        public TestEntites(string science, string theme, int maxPoint, int point3, int point4, int point5,
            int time, List<QuestionEntites> question)
        {
            if (string.IsNullOrEmpty(science) || string.IsNullOrEmpty(theme) 
                || point3 > point4 || point4 > point5 || maxPoint < point5 || time<=0 
                || question == null || question.Count ==0)
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