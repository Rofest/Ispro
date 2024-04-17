using System;
using System.IO;

public class FileOperations
{
    public void PO()
    {
        //Создание папок
        Directory.CreateDirectory(@"E:\temp\K1");
        Directory.CreateDirectory(@"E:\temp\K2");

        //Создание и запись в файлы
        File.WriteAllText(@"E:\temp\K1\t1.txt", "Этот текст записан в файле t1.txt");
        File.WriteAllText(@"E:\temp\K1\t2.txt", "Этот текст записан в файле t2.txt");

        //Чтение из файлов и запись в t3.txt
        string t1Text = File.ReadAllText(@"E:\temp\K1\t1.txt");
        string t2Text = File.ReadAllText(@"E:\temp\K1\t2.txt");
        File.WriteAllText(@"E:\temp\K2\t3.txt", t1Text + Environment.NewLine + t2Text);

        //Перенос файла t2.txt в папку K2
        File.Move(@"E:\temp\K1\t2.txt", @"E:\temp\K2\t2.txt");

        //Копирование файла t1.txt в папку K2
        File.Copy(@"E:\temp\K1\t1.txt", @"E:\temp\K2\t1.txt", true); // true - перезаписать, если файл уже существует

        //Переименование папки K2 в All и удаление папки K1 и удаление всех файлов из папки K1
        string[] filesInK1 = Directory.GetFiles(@"E:\temp\K1");
        foreach (string file in filesInK1)
        {
            File.Delete(file);
        }
        //Удаление папки K1
        Directory.Delete(@"E:\temp\K1");

        //Переименование папки K2 в All
        Directory.Move(@"E:\temp\K2", @"E:\temp\All");
    }
}
