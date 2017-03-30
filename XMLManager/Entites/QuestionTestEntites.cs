using System;
using System.Collections.Generic;

namespace XML.Entites
{
    [Serializable]
    public class QuestionTestEntites
    {
        public string TextQuestion { get; set; } //Вопрос
        public QuestionType Type { get; set; } //Тип вопроса
        public int Point { get; set; } //Количество баллов за вопрос || Количество баллов за ответ на вопрос 
        public List<string> TrueAnswer { get; set; } //Правильные ответы
        public List<string> Answer { get; set; } //Варианты ответа || Ответы пользователя

        public QuestionTestEntites() { }

        /// <summary>
        /// Создаёт вопрос(ответ) со следующими параметрами:
        /// </summary>
        /// <param name="question">Вопрос </param>
        /// <param name="point">Количесво баллов за вопрос</param>
        /// <param name="trueAnswer">Список правильных ответов</param>
        /// <param name="answer">Список вариантов ответов</param>
        /// <param name="type">Тип вопроса</param>
        public QuestionTestEntites(string question, int point, List<string> trueAnswer,
            List<string> answer, QuestionType type)
        {
            if (string.IsNullOrEmpty(question) || point < 0
                || trueAnswer == null || trueAnswer.Count == 0
                || (answer != null && answer.Count == 0))
                throw new ArgumentNullException();
            TextQuestion = question;
            Point = point;
            Type = type;
            TrueAnswer = trueAnswer;
            Answer = answer;
        }
        
        /// <summary>
        /// Создаёт вопрос(ответ) со следующими параметрами:
        /// </summary>
        /// <param name="question">Вопрос </param>
        /// <param name="point">Количесво баллов за вопрос</param>
        /// <param name="trueAnswer">Список правильных ответов</param>
        public QuestionTestEntites(string question, int point, List<string> trueAnswer)
            : this(question, point, trueAnswer, null, QuestionType.NoVariant)
        {
        }
    }
}