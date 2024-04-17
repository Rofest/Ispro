using System;
using System.IO;

class Program
{
    static void Main()
    {
        FileOperations fileOperations = new FileOperations();
        fileOperations.PO();

        //Вывод информации о создании файлов
        string[] allFiles = Directory.GetFiles(@"E:\temp", "*", SearchOption.AllDirectories);
        Console.WriteLine("Созданные файлы:");
        foreach (string file in allFiles)
        {
            Console.WriteLine(file);
        }

        //Вывод информации о файлах в папке All
        Console.WriteLine("\nИнформация о файлах в папке All:");
        string[] allFilesInAllFolder = Directory.GetFiles(@"E:\temp\All", "*", SearchOption.AllDirectories);
        foreach (string file in allFilesInAllFolder)
        {
            FileInfo fileInfo = new FileInfo(file);
            Console.WriteLine($"Имя файла: {fileInfo.Name}");
            Console.WriteLine($"Расширение файла: {fileInfo.Extension}");
            Console.WriteLine($"Полный путь: {fileInfo.FullName}");
            Console.WriteLine($"Размер файла (в байтах): {fileInfo.Length}");
            Console.WriteLine($"Дата создания: {fileInfo.CreationTime}");
            Console.WriteLine($"Дата последнего изменения: {fileInfo.LastWriteTime}");
            Console.WriteLine($"Проверка на существование файла: {fileInfo.Exists}");
            Console.WriteLine();
        }
    }
}
