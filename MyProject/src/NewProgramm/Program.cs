using System;
using System.IO;

namespace NewProgramm
{
        class Program
    {
        static void Inspections(){
            Console.WriteLine("Режим приемки");
/* Режим приемки:
1. Указать компанию
2. Указать общее кол-во оборудования
3. Если разное обор+удование, то указать скольколько какого оборудования
4. Указать производителя
5. Указать модель

*/            MobileComputers newDev = new MobileComputers(""); // создание нового объекта
             //Сохранить в базу

             newDev.WriteToDB(newDev);
/*
            //
            //Создание каталога для файла
            string path = @"db";
            DirectoryInfo dirInfo = new DirectoryInfo(path);
            if (!dirInfo.Exists)
            {
                dirInfo.Create();
            }
            Console.WriteLine("Введите строку для записи в файл:");
            string text = Console.ReadLine();

            //Запись в файл
            using (FileStream fstream = new FileStream($"{path}\note.txt"))
            {
                //преобразуем строку в байты
                byte[] array = new byte[fstream.Length];
                //Считываем данные
                fstream.Read(array, 0, array.Length);
                //декодируем байты в строку
                string textFormFile = System.Text.Encoding.Default.GetString(array);
                Console.WriteLine($"Текст из файла: {textFromFile}");
            }
*/





        }
        static void Diagnostic(){
            Console.WriteLine("Режим диагностики");
        }

        static void Repair(){
            Console.WriteLine("Режим ремонта");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to test programm for diagnostic device");
            Console.WriteLine("Choose action:");
            Console.WriteLine("1. Inspections\n2. Diagnostic\n3. Repair\n0. Exit");
            
            switch (Convert.ToInt32(Console.ReadLine())) {
                case 0:
                break;
                case 1:
                Inspections(); //Приемка оборудования
                break;
                case 2:
                Diagnostic(); //Диагностика оборудования
                break;
                case 3:
                Repair(); //ремонт оборудования
                break;
                default:
                Console.WriteLine("Введено неверное значение");
                break;
            
            }

            
            Console.WriteLine("Производитель оборудования: {0}\nМодель оборудования:{1}\nНомер поставки:{2}");
            Console.WriteLine("Выход из программы");
            
            
            DataExchange de = new DataExchange();

            Console.ReadKey(true);
        }
    }
}
