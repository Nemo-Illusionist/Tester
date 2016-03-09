﻿using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.IO;
using System.Windows.Forms;

namespace TESTER
{
    [Serializable]
    public class XML_TEST
    {
        static XmlSerializer formatter = new XmlSerializer(typeof(XML_TEST));
        public string Science { get; set;} //Название предмета
        public string Theme { get; set;} //Название теста
        public int QuantityQuestion { get; set; } //Количество вопросов
        public int MaxPoint { get; set; } //Всего баллов
        public int Point5 { get; set; } //Баллов на 5
        public int Point4 { get; set; } //Баллов на 4
        public int Point3 { get; set; } //Баллов на 3
        public int Time { get; set; } //Время на тест
        public List<Question> Questions { get; set; } //список вопросов

        public XML_TEST() { }

        /// <param name="QuantityQuestion">Количество вопросов в тесте</param>
        /// <param name="MaxPoint">Максимальный балл за тест</param>
        /// <param name="Point3">Минимальное количество баллов на 3</param>
        /// <param name="Point4">Минимальное количество баллов на 4</param>
        /// <param name="Point5">Винимальное количество баллов на 5</param>
        /// <param name="Time">Общее время на тест</param>
        /// <param name="question">Массив вопросов</param>
        public XML_TEST(int QuantityQuestion, int MaxPoint, int Point3, int Point4, int Point5, int Time, List<Question> question){
            this.QuantityQuestion = QuantityQuestion;
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
                QuantityQuestion = Test.QuantityQuestion;
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
        public long ID { get; set; } //Индификационный номер
        public string FIO { get; set; } //Фамилия Имя Очество
        public string EI { get; set; } //Учебное заведение
        public string Science { get; set; } //Название предмета
        public string Theme { get; set; } //Название теста
        public int Point { get; set; } //Наброно баллов
        public byte Mark { get; set; } //Оценка
        public int Time { get; set; } //Время прохождения теста
        public List<Question> Questions { get; set; } //список вопросов

        public XML_USER() { }

        /// <param name="ID">Индификационный номер</param>
        /// <param name="FIO">Фамилия Имя Очество</param>
        /// <param name="EI">Учебное завидение</param>
        /// <param name="Science">Предмет</param>
        /// <param name="Theme">Название теста</param>
        /// <param name="Point">Наброно баллов</param>
        /// <param name="Mark">Оценка</param>
        /// <param name="Time">Время прохождения</param>
        /// <param name="Questions">Список вопросов</param>
        public XML_USER(long ID, string FIO, string EI, string Science, string Theme, int Point, byte Mark, 
            int Time, List<Question> Questions) {
                this.ID = ID;
                this.FIO = FIO;
                this.EI = EI;
                this.Science = Science;
                this.Time = Time;
                this.Theme = Theme;
                this.Questions = Questions;
        }

        /// <summary>
        /// Сериализует объект в XML c именем ID_Science_Theme
        /// </summary>
        public void Serialize(){
            //int k = Directory.GetFiles(Environment.CurrentDirectory + "\\UserTest\\").Length + 1;
            using (FileStream fs = new FileStream("UserTest\\" + ID + "_" + Science + "_" + Theme +".xml", FileMode.OpenOrCreate)){
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
        public int Point { get; set; } //количество баллов за вопрос || сколько балов набрали за вопрос
        public List<string> TrueAnswer { get; set; } //Правильный ответ
        public List<string> Answer { get; set; } //Варианты ответа || ваши ответы

        public Question() { }

        /// <summary>
        /// Создаёт вопро типа один ответ||несколько ответов со следующими пораметрами:
        /// </summary>
        /// <param name="question">Вопрос </param> 
        /// <param name="Point">Количетсво баллов за вопрос</param>
        /// <param name="Type">Тип вопроса(0 - один ответ, 1 - несколько ответов)</param>
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
        /// Создаёт вопро типа 2(пустое поле для ввода) со следующими пораметрами:
        /// </summary>
        /// <param name="question">Вопрос </param> 
        /// <param name="Point">Количество баллов за вопрос</param>
        /// <param name="TrueAnswer">Список правельных ответов</param>
        public Question(string question, int Point, List<string> TrueAnswer){
            this.question = question;
            this.Point = Point;
            this.Type = 2;
            this.TrueAnswer = TrueAnswer;
        }
    }
}