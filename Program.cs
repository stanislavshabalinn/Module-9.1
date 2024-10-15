using System;
using System.Security.Cryptography.X509Certificates;

namespace Module_9._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер исключения:");
            string n = Console.ReadLine();
            int i = 0;
            try
            {
                i = Convert.ToInt32(n);
            }
            catch
            {
                i = 0;
            }
            Exception[] ayex = new Exception[5];
            ayex[0] = new Exception("Ошибка:Мой тип исключения");
            ayex[1] = new DirectoryNotFoundException("Недопустимая часть пути к каталогу");
            ayex[2] = new DriveNotFoundException("Диск недоступен или не существует");
            ayex[3] = new FileNotFoundException("Файл не существует");
            ayex[4] = new IndexOutOfRangeException("Индекс находится за пределами границ массива или коллекции");
            ayex[5] = new PathTooLongException("Длина пути или имени файла превышает максимальную длину, определенную системой");
            ayex[1].HelpLink = "www.google.com";
            ayex[1].HResult = 1;
            ayex[2].HResult = 2;
            ayex[3].HResult = 3;
            ayex[4].HResult = 4;

            try
            {
                if (i >= 1 && i <= 5)

                {
                    throw ayex[i];
                }
                else
                {
                    throw ayex[0];
                }
            }
            catch
            {
                Console.WriteLine("Произошло исключение: ayex[i].Messege");
            }
        }

        public class MyError : ArgumentException

        { 
            public MyError(string _exeptionMessege) : base(_exeptionMessege)
            { }
            }
        }
    }