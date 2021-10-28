using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TestApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Выберите любую папку на своем компьютере, имеющую вложенные директории
             * Выведите на консоль ее содержимое и содержимое всех подкаталогов.*/

            Console.WriteLine("Введите существующий каталог для просмотра его содержимого:");
            string drivePath = Console.ReadLine(); //Определяем путь к папке с выводом

            if (Directory.Exists(drivePath)) // Проверка на существование
            {
                DirectoryInfo directory = new DirectoryInfo(drivePath);  //Класс для определенного пути
                FileInfo[] directories = directory.GetFiles("*", SearchOption.AllDirectories); //создаем массив содержимого с подпапками

                foreach (FileInfo s in directories) //Выводим на экран информацию 
                {
                    Console.WriteLine(" {0}", s.FullName);
                }
                Console.WriteLine("\nВывод содержимого каталога \"{0}\" завершен... Нажмите любую клавишу для закрытия окна...", drivePath);
            }
            else
            {
                Console.WriteLine("\nОшибка! Каталог \"{0}\" не существует. Нажмите любую клавишу для закрытия окна...", drivePath);
            }

            
            Console.ReadKey();
        }
    }
}
