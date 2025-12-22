using System;
using FilesMainClass;
namespace VideoFiles
{
    public class Video : File
    {
        public int DurationSecond{get; set;}
        public string Quality{get; set;} 
        public Video(string fileName, int size, string extension, DateTime creationdate, bool isopen, int duration, string quality) : base(fileName, size, extension, creationdate, isopen)
        {
            DurationSecond = duration;
            Quality= quality;
        }
        public override void Open()
        {
            IsOpen = true;
            Console.WriteLine(DurationSecond);
            Console.WriteLine(Quality);
        }
    }
}