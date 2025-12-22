using System;
using FilesMainClass;
namespace AudioFiles
{
    public class Audio : File
    {
        public string Song{get; set;} = "Waiting for the end";
        public string Artist{get; set;} = "Linkin park";
        public Audio(string fileName, int size, string extension, DateTime creationdate, bool isopen, string song, string artist) : base(fileName, size, extension, creationdate, isopen)
        {
            Song = song;
            Artist= artist;
        }
        public override void Open()
        {
            IsOpen = true;
            Console.WriteLine(Song);
            Console.WriteLine(Artist);
        }
    }
}