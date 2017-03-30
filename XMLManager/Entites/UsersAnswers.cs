using System;
using System.Collections.Generic;

namespace XML.Entites
{
    [Serializable]
    public class UsersAnswers
    {
        public long ID { get; set; } //Идентификационный номер
        public string FIO { get; set; } //Фамилия Имя Отчество
        public string EI { get; set; } //Учебное заведение
        public string Science { get; set; } //Название предмета
        public string Theme { get; set; } //Название теста
        public int MaxPoint { get; set; } //Максимальное количество баллов за тест
        public int Point { get; set; } //Набрано баллов
        public byte Mark { get; set; } //Оценка
        public int Time { get; set; } //Время прохождения теста
        public List<QuestionTestEntites> Questions { get; set; } //Список вопросов
        public UsersAnswers() { }

        /// <param name="id">Идентификационный номер</param>
        /// <param name="fio">Фамилия Имя Отчество</param>
        /// <param name="ei">Учебное заведение</param>
        /// <param name="science">Предмет</param>
        /// <param name="theme">Название теста</param>
        public UsersAnswers(long id, string fio, string ei, string science, string theme)
        {
            if (id <= 0 || string.IsNullOrEmpty(fio) || string.IsNullOrEmpty(ei) 
                || string.IsNullOrEmpty(science) || string.IsNullOrEmpty(theme))
                throw new ArgumentNullException();
            ID = id;
            FIO = fio;
            EI = ei;
            Science = science;
            Theme = theme;
            Questions = new List<QuestionTestEntites>();
            Point = Time = Mark = 0;
        }
    }
}