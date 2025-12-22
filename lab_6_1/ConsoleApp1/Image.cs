using System;
using FilesMainClass;
namespace ImageFiles
{
    public class Image : File
    {
        public int Width{get; set;} 
        public int Height{get; set;} 
        public string Format{get; set;}
        public Image(string fileName, int size, string extension, DateTime creationdate, bool isopen, int width, int height,string format) : base(fileName, size, extension, creationdate, isopen)
        {
            Width= width;
            Height= height;
            Format = format;
        }
        public override void Open()
        {
            IsOpen = true;
            Console.WriteLine(Width);
            Console.WriteLine(Height);
            Console.WriteLine(Format);
        }
    }
}