using System;

 namespace  FilesMainClass
{
        public class File
        {
            public string FileName {get; set;}
            public int Size{get; set;}
            public string Extension{get; set;}
            public DateTime CreationDate{get; set;}
            public bool IsOpen {get; set;}
            public int Age => DateTime.Now.Day - CreationDate.Day;

            public File(string fileName, int size, string extension,DateTime creationdate, bool isopen)
            {
                FileName = fileName;        
                Size = size;               
                Extension = extension;      
                CreationDate = creationdate;
                IsOpen = false;    
            }

            public virtual void Open()
            {
            IsOpen = true;
            Console.WriteLine($"Open File {FileName}.{Extension}");
            }
        }
}