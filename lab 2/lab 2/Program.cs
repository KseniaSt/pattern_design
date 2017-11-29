using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Component fileSystem = new Directory("Файловая система");

            Component diskD = new Directory("Диск D");

            Component jpgFile = new File("Photo.jpg");
            Component docFile = new File("Document.docx");

            diskD.Add(jpgFile);
            diskD.Add(docFile);
            fileSystem.Add(diskD);

            fileSystem.Print();
            Console.WriteLine();
           
            diskD.Remove(jpgFile);

            Component docsFolder = new Directory("Мои Документы");
            Component txtFile = new File("readme.txt");
            Component csFile = new File("Lab_2.cs");
            docsFolder.Add(txtFile);
            docsFolder.Add(csFile);
            diskD.Add(docsFolder);

            fileSystem.Print();

            Console.Read();
        }
    }
}
