using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.IO;

namespace TESTER
{
    [Serializable]
    public class XML_TEST
    {
        static XmlSerializer formatter = new XmlSerializer(typeof(XML_TEST));
        public string Science { get; set;} //Название предмета
        public string Theme { get; set;} //Название теста
        public int MaxPoint { get; set; } //Всего баллов
        public int Point5 { get; set; } //Баллов на 5
        public int Point4 { get; set; } //Баллов на 4
        public int Point3 { get; set; } //Баллов на 3
        public int Time { get; set; } //Время на тест
        public List<Question> Questions { get; set; } //Список вопросов

        public XML_TEST() { }

        /// <param name="MaxPoint">Максимальный балл за тест</param>
        /// <param name="Point3">Минимальное количество баллов на 3</param>
        /// <param name="Point4">Минимальное количество баллов на 4</param>
        /// <param name="Point5">Винимальное количество баллов на 5</param>
        /// <param name="Time">Общее время на тест</param>
        /// <param name="question">Массив вопросов</param>
        public XML_TEST(int MaxPoint, int Point3, int Point4, int Point5, int Time, List<Question> question){
            this.MaxPoint = MaxPoint;
            this.Point3 = Point3;
            this.Point4 = Point4;
            this.Point5 = Point5;
            this.Time = Time;
            this.Questions = question;
        }

        /// <summary>
        /// Сериализует объект в XML и помещает его в указанную папку с указанным именем
        /// </summary>
        /// <param name="NameFolder">Имя папки</param>
        /// <param name="NameFile">Имя файла</param>
        public void Serialize(string NameFolder, string NameFile){
            Science = NameFolder;
            Theme = NameFile;
            int k = Directory.GetFiles(Environment.CurrentDirectory + "\\TEST\\" + NameFolder + "\\").Length + 1;
            using (FileStream fs = new FileStream("TEST\\" + NameFolder + "\\" + k + ". "+ NameFile + ".xml", FileMode.OpenOrCreate)){
                formatter.Serialize(fs, this);
            }
        }

        /// <summary>
        /// Десериализует объект типа XML находящегося в указанной папке с указанным именем
        /// </summary>
        /// <param name="NameFolder">Имя папки</param>
        /// <param name="NameFile">Имя файла</param>
        public void DeSerialize(string NameFolder, string NameFile)
        {
            using (FileStream fs = new FileStream("TEST\\" + NameFolder + "\\" + NameFile + ".xml", FileMode.OpenOrCreate)){
                XML_TEST Test = (XML_TEST)formatter.Deserialize(fs);
                MaxPoint = Test.MaxPoint;
                Point5 = Test.Point5;
                Point4 = Test.Point4;
                Point3 = Test.Point3;
                Time = Test.Time;
                Questions = Test.Questions;
                Science = Test.Science;
                Theme = Test.Theme;
            }
        }
    }

    [Serializable]
    public class XML_USER
    {
        static XmlSerializer formatter = new XmlSerializer(typeof(XML_USER));
        public long ID { get; set; } //Идентификационный номер
        public string FIO { get; set; } //Фамилия Имя Отчество
        public string EI { get; set; } //Учебное заведение
        public string Science { get; set; } //Название предмета
        public string Theme { get; set; } //Название теста
        public int MaxPoint { get; set; } //Максимальное количество баллов за тест
        public int Point { get; set; } //Набрано баллов
        public byte Mark { get; set; } //Оценка
        public int Time { get; set; } //Время прохождения теста
        public List<Question> Questions { get; set; } //Список вопросов

        public XML_USER() { }

        /// <param name="ID">Идентификационный номер</param>
        /// <param name="FIO">Фамилия Имя Отчество</param>
        /// <param name="EI">Учебное заведение</param>
        /// <param name="Science">Предмет</param>
        /// <param name="Theme">Название теста</param>
        public XML_USER(long ID, string FIO, string EI, string Science, string Theme)
        {
            this.ID = ID;
            this.FIO = FIO;
            this.EI = EI;
            this.Science = Science;
            this.Theme = Theme;
            Questions = new List<Question>();
            Point = 0;
        }

        /// <summary>
        /// Сериализует объект в XML c именем вида: ID_Science_Theme
        /// </summary>
        public void Serialize(){  
            string path = ID + "_" + Science + "_" + Theme;
            string s = path;
            int k = 1;
            while (true){
                int l = k;
                string[] Files = Directory.GetFiles(Environment.CurrentDirectory + "\\UserTest\\");
                foreach (var file in Files){
                    if (k == 0 && file == Environment.CurrentDirectory + "\\UserTest\\" + path + ".xml"){
                        s += "(" + k + ")";
                        k++;
                        break;
                    }
                    if (file == Environment.CurrentDirectory + "\\UserTest\\" + s + ".xml" && k != 0){
                        s = path + "(" + k + ")";
                        k++;
                        break;
                    }
                }
                if (l == k)
                    break;
            }
            using (FileStream fs = new FileStream("UserTest\\" + s +".xml", FileMode.OpenOrCreate)){
                formatter.Serialize(fs, this);
            }
        }

        /// <summary>
        /// Десериализует объект типа XML с именем
        /// </summary>
        /// <param name="NameFile">Имя файла</param>
        public void DeSerialize(string NameFile){
            using (FileStream fs = new FileStream("UserTest\\" + NameFile + ".xml", FileMode.OpenOrCreate)){
                XML_USER User = (XML_USER)formatter.Deserialize(fs);
                MaxPoint = User.MaxPoint;
                ID = User.ID;
                FIO = User.FIO;
                EI = User.EI;
                Science = User.Science;
                Theme = User.Theme;
                Point = User.Point;
                Mark = User.Mark;
                Time = User.Time;
                Questions = User.Questions;
            }
        }

    }
      
    [Serializable]
    public class Question
    {
        public string question { get; set; } //Вопрос
        public int Type { get; set; } //Тип вопроса
        public int Point { get; set; } //Количество баллов за вопрос || Количество баллов за ответ на вопрос 
        public List<string> TrueAnswer { get; set; } //Правильный ответ
        public List<string> Answer { get; set; } //Варианты ответа || Ответы пользователя

        public Question() { }

        /// <param name="question">Вопрос </param> 
        /// <param name="Point">Количесво баллов за вопрос</param>
        /// <param name="Type">Тип вопроса</param>
        /// <param name="TrueAnswer">Список правильных ответов</param>
        /// <param name="Answer">Список вариантов ответов</param>
        public Question(string question, int Point, int Type, List<string> TrueAnswer, List<string> Answer){
            this.question = question;
            this.Point = Point;
            this.Type = Type;
            this.TrueAnswer = TrueAnswer;
            this.Answer = Answer;
        }

        /// <summary>
        /// Создаёт вопрос типа 2(пустое поле для ввода) со следующими параметрами:
        /// </summary>
        /// <param name="question">Вопрос </param> 
        /// <param name="Point">Количество баллов за вопрос</param>
        /// <param name="TrueAnswer">Список правильных ответов</param>
        public Question(string question, int Point, List<string> TrueAnswer){
            this.question = question;
            this.Point = Point;
            this.Type = 2;
            this.TrueAnswer = TrueAnswer;
        }

    }
}
