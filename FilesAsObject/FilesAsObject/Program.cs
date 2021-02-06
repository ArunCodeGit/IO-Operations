using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FilesAsObject
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "C:\\MySample\\";
            
            //Files in a directory
            string fileDetails = GetFilesInDirectory(path);

            //Files in a Directory
            string FileDetails = GetFilesInDirectory(path);
            Console.WriteLine(FileDetails);

            //Copy Files - overwrite if exists
            FileInfo f = new FileInfo(path + "demo1.txt");
            f.CopyTo(path + "demo3.txt", true);
            Console.WriteLine("Copy Successfull...");
            
            //Rename files
            FileInfo fnew = new FileInfo(path + "demo2.txt");
            fnew.MoveTo(path + "RenamedDemo2.txt");
            Console.WriteLine("Rename Successfull");
        }

        public static string GetFilesInDirectory(string path)
        {
            string fileDetails = "";
            DirectoryInfo dir = new DirectoryInfo(path);
            FileInfo[] files = dir.GetFiles();

            foreach (FileInfo file in files)
            {
                fileDetails += file.Name + "\t" + file.Length + "Bytes\t" + file.CreationTime + "\n";
            }
            return fileDetails;
        }
    }
}
