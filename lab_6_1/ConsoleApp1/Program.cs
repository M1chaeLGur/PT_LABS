using System;
using FilesMainClass;
using TextFiles;
using AudioFiles;
using VideoFiles;
using ImageFiles;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            File[] files = new File[]
            {
                new Text("doc1", 100, "txt", DateTime.Now.AddDays(-10), false,"Пример текста"),

                new Audio("song1", 5000, "mp3", DateTime.Now.AddDays(-20), false, "Waiting for the end", "Linkin park"),

                new Video("video1", 15000, "mp4", DateTime.Now.AddDays(-30), false, 3600, "Full HD"),

                new Image("photo1", 2000, "jpg", DateTime.Now.AddDays(-5), false, 1920, 1080, "JPEG"),

                new Text("doc2", 120, "txt", DateTime.Now.AddDays(-12), false,"Продам гараж"),

                new Audio("song2", 2000, "mp3", DateTime.Now.AddDays(-2), false, "The Real Slim Shady", "Eminem"),

                new Video("video2", 15400, "mp4", DateTime.Now.AddDays(-7), false, 3600, "1080p"),

                new Image("photo2", 2520, "jpg", DateTime.Now.AddDays(-52), false, 1920, 1080, "png"),

                new Audio("song3", 2000, "mp3", DateTime.Now.AddDays(-24), false, "Around the fur", "Deftones"),

                new Video("video3", 15400, "mp4", DateTime.Now.AddDays(-17), false, 3600, "360p")

            };

            int totalsize = 0;
            foreach(File file in files)
            {
                totalsize += file.Size;
            }
            Console.WriteLine($"Total Size: {totalsize}");

            File oldest = files[0];
            foreach (File file in files)
            {
                if (file.CreationDate < oldest.CreationDate)
                oldest = file;
            }
            Console.WriteLine($"The oldest file is {oldest.FileName}, created: {oldest.CreationDate}");


            foreach (File file in files)
            {
       
            Console.WriteLine($"Тип: {file.GetType().Name}");
            Console.WriteLine($"Имя: {file.FileName}.{file.Extension}");
            Console.WriteLine($"Размер: {file.Size}");
            Console.WriteLine($"Дата создания: {file.CreationDate}");
            Console.WriteLine($"Открыт: {file.IsOpen}");
            }
        }

    }
}
