using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.IO;
using System.Windows.Forms;

namespace TESTER
{
    [Serializable]
    public class XML_TEST
    {
        static XmlSerializer formatter = new XmlSerializer(typeof(TestData));
        public TestData testdata;
        public List<Question> question;
        public int QuantityQuestion;
        public int MaxPoint;
        public int Point5;
        public int Point4;
        public int Point3;
        public int Time;

        public XML_TEST() { }

        /// <param name="QuantityQuestion">Количество вопросов в тесте</param>
        /// <param name="MaxPoint">Максимальный балл за тест</param>
        /// <param name="Point3">Минимальное количество баллов на 3</param>
        /// <param name="Point4">Минимальное количество баллов на 4</param>
        /// <param name="Point5">Винимальное количество баллов на 5</param>
        /// <param name="Time">Общее время на тест</param>
        /// <param name="question">Массив вопросов</param>
        public XML_TEST(int QuantityQuestion, int MaxPoint, int Point3, int Point4, int Point5, int Time, List<Question> question)
        {
            this.QuantityQuestion = QuantityQuestion;
            this.MaxPoint = MaxPoint;
            this.Point3 = Point3;
            this.Point4 = Point4;
            this.Point5 = Point5;
            this.Time = Time;
            this.question = question;
        }

        /// <summary>
        /// Сериализует объект в XML и помещает его в указанную папку с указанным именем
        /// </summary>
        /// <param name="NameFolder">Имя папки</param>
        /// <param name="NameFile">Имя файла</param>
        public void Serialize(string NameFolder, string NameFile)
        {
            int k = Directory.GetFiles(Environment.CurrentDirectory + "\\TEST\\" + NameFolder + "\\").Length + 1;
            testdata = new TestData(QuantityQuestion, MaxPoint, Point3, Point4, Point5, Time, question);
            using (FileStream fs = new FileStream("TEST\\" + NameFolder + "\\" + k + ". "+ NameFile + ".xml", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, testdata);
            }
        }

        /// <summary>
        /// Десериализует объект типа XML находящегося в указанной папке с указанным именем
        /// </summary>
        /// <param name="NameFolder">Имя папки</param>
        /// <param name="NameFile">Имя файла</param>
        public void DeSerialize(string NameFolder, string NameFile)
        {
            using (FileStream fs = new FileStream("TEST\\" + NameFolder + "\\" + NameFile + ".xml", FileMode.OpenOrCreate))
            {
                testdata = (TestData)formatter.Deserialize(fs);
                QuantityQuestion = testdata.QuantityQuestion;
                MaxPoint = testdata.MaxPoint;
                Point5 = testdata.Point5;
                Point4 = testdata.Point4;
                Point3 = testdata.Point3;
                Time = testdata.Time;
                question = testdata.Question;
            }
        }
    }

    [Serializable]
    public class XML_USER
    {
        static XmlSerializer formatter = new XmlSerializer(typeof(User));

        public void Serialize(User user)
        {
            int k = Directory.GetFiles(Environment.CurrentDirectory + "\\UserTest\\").Length + 1;
            using (FileStream fs = new FileStream("UserTest\\" + k + "_" + user.Test_Name + "_" +
                user.Name + ".xml", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, user);
            }
        }

        public User DeSerialize(string s)
        {
            User user;
            using (FileStream fs = new FileStream("UserTest\\" + s + ".xml", FileMode.OpenOrCreate))
            {
                user = (User)formatter.Deserialize(fs);
            }
            return user;
        }

    }

    [Serializable]
    public class TestData
    {
        public int QuantityQuestion { get; set; } //Количество вопросов
        public int MaxPoint { get; set; } //Всего баллов
        public int Point3 { get; set; } //Баллов на 3
        public int Point4 { get; set; } //Баллов на 4
        public int Point5 { get; set; } //Баллов на 5
        public int Time { get; set; } //Общее время
        public List<Question> Question { get; set; } //тест

        public TestData() { }


        /// <param name="QuantityQuestion">Количество вопросов в тесте</param>
        /// <param name="MaxPoint">Максимальный бал за тест</param>
        /// <param name="Point3">Минимальное количество баллов на 3</param>
        /// <param name="Point4">Минимальное количество баллов на 4</param>
        /// <param name="Point5">Минимальное количество баллов на 5</param>
        /// <param name="Time">Время на тест</param>
        /// <param name="Question">Список вопросов</param>
        public TestData(int QuantityQuestion, int MaxPoint, int Point3, int Point4, int Point5, int Time, List<Question> Question)
        {
            this.QuantityQuestion = QuantityQuestion;
            this.MaxPoint = MaxPoint;
            this.Point3 = Point3;
            this.Point4 = Point4;
            this.Point5 = Point5;
            this.Time = Time;
            this.Question = Question;
        }
    }

    [Serializable]
    public class Question
    {
        public string question { get; set; } //Вопрос
        public int Type { get; set; } //Тип вопроса
        public int Point { get; set; } //количество баллов за вопрос
        public List<string> TrueAnswer { get; set; } //Правильный ответ
        public List<string> Answer { get; set; } //Варианты ответа

        public Question() { }

        /// <param name="question">Вопрос </param> 
        /// <param name="Point">Количетсво баллов за вопрос</param>
        /// <param name="Type">Тип вопроса(0 - один ответ, 1 - несколько ответов)</param>
        /// <param name="TrueAnswer">Список правильных ответов</param>
        /// <param name="Answer">Список вариантов ответов</param>
        public Question(string question, int Point, int Type, List<string> TrueAnswer, List<string> Answer)
        {
            this.question = question;
            this.Point = Point;
            this.Type = Type;
            this.TrueAnswer = TrueAnswer;
            this.Answer = Answer;
        }

        /// <param name="question">Вопрос </param> 
        /// <param name="Point">Количество баллов за вопрос</param>
        /// <param name="Type">Тип вопроса(2 - пустое поле)</param>
        /// <param name="TrueAnswer">Список правельных ответов</param>
        public Question(string question, int Point, int Type, List<string> TrueAnswer)
        {
            this.question = question;
            this.Point = Point;
            this.Type = Type;
            this.TrueAnswer = TrueAnswer;
        }
    }

    [Serializable]
    public class User
    {
        public string Name { get; set; } //Имя
        public string EI { get; set; } //Учебное заведение
        public string Test_Name { get; set; } //Предмет_имя теста
        public int Point { get; set; } //Количество баллов
        public int Mark { get; set; } //Оценка
        public int Time { get; set; } //Время
        public List<string> TrueAnswer { get; set; } //Правильные ответы
        public List<string> Answer { get; set; } //Пользовательские ответы

        public User() { }

        /// <param name="Name">Имя </param>
        /// <param name="EI">Учебное заведение</param>
        /// <param name="Test_Name">Предмет_Имя теста</param>
        /// <param name="Point">Количество баллов за тест</param>
        /// <param name="Mark">Оценка</param>
        /// <param name="Time">Время</param>
        /// <param name="TrueAnswer">Список правильных ответов</param>
        /// <param name="Answer">Список ответов пользователя</param>
        public User(string Name, string EI, string Test_Name, int Point, int Mark, int Time, List<string> TrueAnswer, List<string> Answer)
        {
            this.Name = Name;
            this.EI = EI;
            this.Test_Name = Test_Name;
            this.Point = Point;
            this.Mark = Mark;
            this.Time = Time;
            this.TrueAnswer = TrueAnswer;
            this.Answer = Answer;
        }

    }
}
