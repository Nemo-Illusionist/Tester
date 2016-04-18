using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.IO;
using System.Security.Cryptography;

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

        #region пароль
        const int salt_length = 16;         // Длина соли
        const int key_length = 16;          // Длина ключа
        string password = "Qg76R_Tu";       // Пароль
        #endregion

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
            #region Получение ключа
            // Вообще говоря, ключ и пароль — разные вещи. Пароль — это текст произвольной длины,
            // а ключ имеет определённую длину в байтах. К тому же пароль использует только текстовые символы,
            // а для ключа желательно чтобы байты были поразнообразнее. Однако пароль удобнее для человека,
            // поэтому на практике используют пароль, а ключ получают (derive) из него специальным алгоритмом.
            // Есть несколько алгоритмов для этого, один из них — RFC2898. Чтобы при получении пароля одинаковые
            // пароли давали разные ключи, к ним примешивают случайные данные — «соль». Соль не обязатольно
            // держать в секрете, но она должна быть одинаковой при шифровании и расшифровке. Можно записывать её
            // в первые байты файла с шифром, а при декодировании считывать.

            // Случайным образом сгенерируем соль.
            // Обычный псевдослучайный Random тут не подходит — в его числах есть закономерности,
            // что снижает стойкость шифра.
            byte[] salt = new byte[salt_length];  // Байты соли. Должно быть 8 байт или больше. У нас — 16 байт
            using (var rng = new RNGCryptoServiceProvider()) {    // Используем надёжный генератор случайных чисел
                rng.GetBytes(salt);
            }
            // Получим ключ из пароля
            byte[] key;     // Байты ключа
            var keygenerator = new Rfc2898DeriveBytes(password, salt);
            key = keygenerator.GetBytes(key_length);    // AES принимает ключи длиной 128/192/256 бит, т.е. 16, 24 и 32 байта
            #endregion

            #region Подготовка алгоритма
            // Создаём объект, который будет заниматься шифрованием.
            Aes aes = Aes.Create();

            // Для работы алгоритма нужен не только ключ, но и вектор инициализации. Дело в том,
            // он шифрует данные по блокам, которые сцепючтся друг с другом с помощью XOR. Вектор
            // инициализации — это случайные данные, с которыми сцепляется первый блок.
            // Его не обязательно держать в секрете и можно либо задать самому случайно, либо
            // сгенерировать самим объектом aes.
            // Для каждого сообщения лучше использовать свой IV.
            aes.GenerateIV();
            byte[] iv = aes.IV;     // Запоминаем вектор инициализации
            aes.Key = key;          // Задаём ключ
            #endregion

            #region Подготовка данных
            // Для начала шифрования нужно преобразовать исходную строку в набор байтов
            byte[] data;

            // Можно просто преобразовать её в кодировку UTF-8

            // data = Encoding.UTF8.GetBytes(text);

            // Если text — это не просто строка, а сложный объект, то его можно сериализовать.
            // Можно в XML, например. Но в этом уже особо смысла нет, так как на диске
            // данные всё равно шифрованые и преимуществ XML иметь не будет.
            // Здесь приведён пример сериализации в XML, для бинарной сериализации используйте
            // класс BinaryFormatter.

            // Сериализатор должен складывать данные в какой-то поток, поэтому
            // создадим MemoryStream — поток, хранящий байты в памяти.
            using (var ms = new MemoryStream())
            {
                formatter.Serialize(ms, this);                  // Выполняем сериализацию
                data = ms.ToArray();                            // Преобразуем поток в массив байтов
            }
            #endregion

            // Создаём шифровальщик
            var encryptor = aes.CreateEncryptor();

            Science = NameFolder;
            Theme = NameFile;
            int k = Directory.GetFiles(Environment.CurrentDirectory + "\\TEST\\" + NameFolder + "\\").Length + 1;
            string file = "TEST\\" + NameFolder + "\\" + k + "." + NameFile + ".xml";
            using (var fs = new FileStream(file, FileMode.Create)){
                fs.Write(salt, 0, salt.Length);
                fs.Write(iv, 0, iv.Length);
                // Создаём шифрованный поток поверх нашего файла
                using (var cs = new CryptoStream(fs, encryptor, CryptoStreamMode.Write))
                {
                    cs.Write(data, 0, data.Length); // Записываем данные
                }
            }
        }

        /// <summary>
        /// Десериализует объект типа XML находящегося в указанной папке с указанным именем
        /// </summary>
        /// <param name="NameFolder">Имя папки</param>
        /// <param name="NameFile">Имя файла</param>
        public void DeSerialize(string NameFolder, string NameFile)
        {
            string file = "TEST\\" + NameFolder + "\\" + NameFile + ".xml";
            using (var f = new FileStream(file, FileMode.Open)){
                #region Получение соли и вектора инициализации из файла
                // Выделяем память под ключ и IV
                byte[] salt = new byte[salt_length];
                byte[] iv = new byte[key_length]; // Длина IV равна размеру блока и равна длине ключа

                f.Read(salt, 0, salt.Length);
                f.Read(iv, 0, iv.Length);
                #endregion

                #region Получение ключа
                // Получим ключ из пароля
                byte[] key;     // Байты ключа
                var keygenerator = new Rfc2898DeriveBytes(password, salt);
                key = keygenerator.GetBytes(key_length);
                #endregion

                #region Подготовка алгоритма
                // Создаём объект, который будет заниматься дешифровкой.
                Aes aes = Aes.Create();

                aes.Key = key;          // Задаём ключ
                aes.IV = iv;            // Задаём вектор инициализации
                #endregion

                #region Дешифровка
                // Создаём дешифровшик
                var decryptor = aes.CreateDecryptor();

                // Переменная для дешифрованных данных
                byte[] data;

                // Поместим дешифрованный текст в переменную text
                string text;

                // Создаём шифрованный поток поверх нашего файла и читаем данные
                // Заранее размер неизместен, поэтму сперва копируем в MemoryStream
                // Копирование выполняется побайтово, но лучше блоками
                using (var ms = new MemoryStream())
                using (var cs = new CryptoStream(f, decryptor, CryptoStreamMode.Read))
                {
                    int b;
                    while (true)
                    {
                        b = cs.ReadByte();
                        if (b == -1) break;     // Если достигнут конец потока
                        ms.WriteByte((byte)b);
                    }

                    // Если мы сохраняли текст в UTF-8, то декодируем
                    // data = ms.ToArray();
                    // text = Encoding.UTF8.GetString(data);

                    // Если мы использовали сериализацию, то десериализуем
                    ms.Seek(0, SeekOrigin.Begin);                   // Перематываем поток на начало
                    XML_TEST Test = (XML_TEST)formatter.Deserialize(ms);
                    MaxPoint = Test.MaxPoint;
                    Point5 = Test.Point5;
                    Point4 = Test.Point4;
                    Point3 = Test.Point3;
                    Time = Test.Time;
                    Questions = Test.Questions;
                    Science = Test.Science;
                    Theme = Test.Theme;
                }
                #endregion
            }
            /*
            using (FileStream fs = new FileStream(file, FileMode.OpenOrCreate)){
                XML_TEST Test = (XML_TEST)formatter.Deserialize(fs);
                MaxPoint = Test.MaxPoint;
                Point5 = Test.Point5;
                Point4 = Test.Point4;
                Point3 = Test.Point3;
                Time = Test.Time;
                Questions = Test.Questions;
                Science = Test.Science;
                Theme = Test.Theme;
            }*/
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

        #region пароль
        const int salt_length = 16;         // Длина соли
        const int key_length = 16;          // Длина ключа
        string password = "Qg76R_Tu";       // Пароль
        #endregion

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
            /*string s = path;
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
            }*/
            string FileName = "UserTest\\" + path + ".xml";

            #region Получение ключа
            // Вообще говоря, ключ и пароль — разные вещи. Пароль — это текст произвольной длины,
            // а ключ имеет определённую длину в байтах. К тому же пароль использует только текстовые символы,
            // а для ключа желательно чтобы байты были поразнообразнее. Однако пароль удобнее для человека,
            // поэтому на практике используют пароль, а ключ получают (derive) из него специальным алгоритмом.
            // Есть несколько алгоритмов для этого, один из них — RFC2898. Чтобы при получении пароля одинаковые
            // пароли давали разные ключи, к ним примешивают случайные данные — «соль». Соль не обязатольно
            // держать в секрете, но она должна быть одинаковой при шифровании и расшифровке. Можно записывать её
            // в первые байты файла с шифром, а при декодировании считывать.

            // Случайным образом сгенерируем соль.
            // Обычный псевдослучайный Random тут не подходит — в его числах есть закономерности,
            // что снижает стойкость шифра.
            byte[] salt = new byte[salt_length];  // Байты соли. Должно быть 8 байт или больше. У нас — 16 байт
            using (var rng = new RNGCryptoServiceProvider())
            {    // Используем надёжный генератор случайных чисел
                rng.GetBytes(salt);
            }
            // Получим ключ из пароля
            byte[] key;     // Байты ключа
            var keygenerator = new Rfc2898DeriveBytes(password, salt);
            key = keygenerator.GetBytes(key_length);    // AES принимает ключи длиной 128/192/256 бит, т.е. 16, 24 и 32 байта
            #endregion

            #region Подготовка алгоритма
            // Создаём объект, который будет заниматься шифрованием.
            Aes aes = Aes.Create();

            // Для работы алгоритма нужен не только ключ, но и вектор инициализации. Дело в том,
            // он шифрует данные по блокам, которые сцепючтся друг с другом с помощью XOR. Вектор
            // инициализации — это случайные данные, с которыми сцепляется первый блок.
            // Его не обязательно держать в секрете и можно либо задать самому случайно, либо
            // сгенерировать самим объектом aes.
            // Для каждого сообщения лучше использовать свой IV.
            aes.GenerateIV();
            byte[] iv = aes.IV;     // Запоминаем вектор инициализации
            aes.Key = key;          // Задаём ключ
            #endregion

            #region Подготовка данных
            // Для начала шифрования нужно преобразовать исходную строку в набор байтов
            byte[] data;

            // Можно просто преобразовать её в кодировку UTF-8

            // data = Encoding.UTF8.GetBytes(text);

            // Если text — это не просто строка, а сложный объект, то его можно сериализовать.
            // Можно в XML, например. Но в этом уже особо смысла нет, так как на диске
            // данные всё равно шифрованые и преимуществ XML иметь не будет.
            // Здесь приведён пример сериализации в XML, для бинарной сериализации используйте
            // класс BinaryFormatter.

            // Сериализатор должен складывать данные в какой-то поток, поэтому
            // создадим MemoryStream — поток, хранящий байты в памяти.
            using (var ms = new MemoryStream())
            {
                formatter.Serialize(ms, this);                  // Выполняем сериализацию
                data = ms.ToArray();                            // Преобразуем поток в массив байтов
            }
            #endregion

            // Создаём шифровальщик
            var encryptor = aes.CreateEncryptor();

            using (var fs = new FileStream(FileName, FileMode.Create))
            {
                fs.Write(salt, 0, salt.Length);
                fs.Write(iv, 0, iv.Length);
                // Создаём шифрованный поток поверх нашего файла
                using (var cs = new CryptoStream(fs, encryptor, CryptoStreamMode.Write))
                {
                    cs.Write(data, 0, data.Length); // Записываем данные
                }
            }


            /*using (FileStream fs = new FileStream(FileName, FileMode.OpenOrCreate)){
                formatter.Serialize(fs, this);
            }*/
        }

        /// <summary>
        /// Десериализует объект типа XML с именем
        /// </summary>
        /// <param name="NameFile">Имя файла</param>
        public void DeSerialize(string NameFile){

            string file = "UserTest\\" + NameFile + ".xml";
            using (var f = new FileStream(file, FileMode.Open))
            {
                #region Получение соли и вектора инициализации из файла
                // Выделяем память под ключ и IV
                byte[] salt = new byte[salt_length];
                byte[] iv = new byte[key_length]; // Длина IV равна размеру блока и равна длине ключа

                f.Read(salt, 0, salt.Length);
                f.Read(iv, 0, iv.Length);
                #endregion

                #region Получение ключа
                // Получим ключ из пароля
                byte[] key;     // Байты ключа
                var keygenerator = new Rfc2898DeriveBytes(password, salt);
                key = keygenerator.GetBytes(key_length);
                #endregion

                #region Подготовка алгоритма
                // Создаём объект, который будет заниматься дешифровкой.
                Aes aes = Aes.Create();

                aes.Key = key;          // Задаём ключ
                aes.IV = iv;            // Задаём вектор инициализации
                #endregion

                #region Дешифровка
                // Создаём дешифровшик
                var decryptor = aes.CreateDecryptor();

                // Переменная для дешифрованных данных
                byte[] data;

                // Поместим дешифрованный текст в переменную text
                string text;

                // Создаём шифрованный поток поверх нашего файла и читаем данные
                // Заранее размер неизместен, поэтму сперва копируем в MemoryStream
                // Копирование выполняется побайтово, но лучше блоками
                using (var ms = new MemoryStream())
                using (var cs = new CryptoStream(f, decryptor, CryptoStreamMode.Read))
                {
                    int b;
                    while (true)
                    {
                        b = cs.ReadByte();
                        if (b == -1) break;     // Если достигнут конец потока
                        ms.WriteByte((byte)b);
                    }

                    // Если мы сохраняли текст в UTF-8, то декодируем
                    // data = ms.ToArray();
                    // text = Encoding.UTF8.GetString(data);

                    // Если мы использовали сериализацию, то десериализуем
                    ms.Seek(0, SeekOrigin.Begin);                   // Перематываем поток на начало
                    XML_USER User = (XML_USER)formatter.Deserialize(ms);
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
                #endregion
            }

            /*
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
            }*/
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
