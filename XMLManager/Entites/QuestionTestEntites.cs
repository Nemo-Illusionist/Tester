using System;
using System.Collections.Generic;

namespace XML.Entites
{
    [Serializable]
    public class QuestionTestEntites
    {
        public string TextQuestion { get; set; }
        public QuestionType Type { get; set; }
        public int Point { get; set; }
        public List<string> TrueAnswer { get; set; }
        public List<string> Answer { get; set; }

        public QuestionTestEntites() { }

        /// <summary>
        /// Создаёт вопрос со следующими параметрами:
        /// </summary>
        /// <param name="question">Вопрос </param>
        /// <param name="point">Количесво баллов за вопрос</param>
        /// <param name="trueAnswer">Список правильных ответов</param>
        /// <param name="answer">Список вариантов ответов</param>
        /// <param name="type">Тип вопроса</param>
        public QuestionTestEntites(string question, int point, List<string> trueAnswer,
            List<string> answer, QuestionType type)
        {
            if (string.IsNullOrEmpty(question) || point < 0 || trueAnswer == null
                || answer == null || answer.Count == 0) throw new ArgumentNullException();
            TextQuestion = question;
            Point = point;
            Type = type;
            TrueAnswer = trueAnswer;
            Answer = answer;
        }

        /// <summary>
        /// Создаёт вопрос со следующими параметрами:
        /// </summary>
        /// <param name="question">Вопрос </param>
        /// <param name="point">Количесво баллов за вопрос</param>
        /// <param name="trueAnswer">Список правильных ответов</param>
        public QuestionTestEntites(string question, int point, List<string> trueAnswer)
            : this(question, point, trueAnswer, new List<string>(), QuestionType.NoVariant) { }
    }
}