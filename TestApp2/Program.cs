using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TestApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Программно создайте текстовый файл и запишите в него 10 случайных чисел. 
             * Затем программно откройте созданный файл, рассчитайте сумму чисел в нем, 
             * ответ выведите на консоль.*/

            Console.WriteLine("Введите имя файла для записи, без расширения:");
            string fileName = Console.ReadLine(); //Считываем Имя файла
            fileName = fileName + ".txt"; //Добавляем расширение

            StreamWriter writer = new StreamWriter(fileName); //Создаем файд
            Random random = new Random();

            for (int i = 0; i < 10; i++) //Пишем случайные значения в файл
            {
                writer.Write(random.Next(0,100)+" ");
            }
            writer.Close();  // Сохраняем

            StreamReader reader = new StreamReader(fileName); //Начинаем читаль файл
            string str = reader.ReadToEnd(); //перегнали строку в память
            str = str.Trim();
            //Console.WriteLine("Итого в файл записаны следующие данные: {0}", str); //Можно разлочить для контроля

            string[] arr = str.Split(' '); //Считываем данные в массив
            int sum = 0;

            for (int i = 0; i < arr.Length; i++) //Подсчет суммы
            {
                sum = sum + Convert.ToInt32(arr[i]);
            }

            Console.WriteLine("Сумма записанных в файл данных равна: {0}", sum);
            Console.ReadKey();
        }
    }
}
