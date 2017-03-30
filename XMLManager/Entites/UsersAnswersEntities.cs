using System;
using System.Collections.Generic;

namespace XML.Entites
{
    [Serializable]
    public class UsersAnswersEntities
    {
        public long ID { get; set; } 
        public string FIO { get; set; } 
        public string EI { get; set; }
        public string Science { get; set; } 
        public string Theme { get; set; } 
        public int MaxPoint { get; set; } 
        public int Point { get; set; }
        public byte Mark { get; set; }
        public int Time { get; set; }
        public List<AnswerUserEntites> Answer { get; set; } 
        public UsersAnswersEntities() { }

        /// <summary>
        /// Создаёт пользовательского результата:
        /// </summary>
        /// <param name="id">Идентификационный номер</param>
        /// <param name="fio">Фамилия Имя Отчество</param>
        /// <param name="ei">Учебное заведение</param>
        /// <param name="science">Предмет</param>
        /// <param name="theme">Название теста</param>
        public UsersAnswersEntities(long id, string fio, string ei, string science, string theme)
        {
            if (id <= 0 || string.IsNullOrEmpty(fio) || string.IsNullOrEmpty(ei) 
                || string.IsNullOrEmpty(science) || string.IsNullOrEmpty(theme))
                throw new ArgumentNullException();
            ID = id;
            FIO = fio;
            EI = ei;
            Science = science;
            Theme = theme;
            Answer = new List<AnswerUserEntites>();
            Point = Time = Mark = 0;
        }
    }
}