using System;
using FilesMainClass;
namespace TextFiles
{
    public class Text : File
    {
        public string Content{get; set;} = "Текст файла";
        public Text(string fileName, int size, string extension, DateTime creationdate, bool IsOpen, string content) : base(fileName, size, extension, creationdate, IsOpen)
        {
            Content = content;
        }
        public override void Open()
        {
            IsOpen = true;
            Console.WriteLine(Content);
        }
    }
}