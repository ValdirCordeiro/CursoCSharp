using System;
using System.IO;

namespace ArquivosDiretorios
{
    class Program
    {
        static void Main(string[] args)
        {
            FileInfo file1 = new FileInfo(@"E:\Programas\CursoCSharp\ArquivosDiretorios\arq1.txt");
            //file1.Create();

            //File.Create(@"E:\Programas\CursoCSharp\ArquivosDiretorios\arq2.txt");

            //file1.CopyTo(@"E:\Programas\CursoCSharp\ArquivosDiretorios\copia1.txt");

            //Console.WriteLine("Nome: " + file1.Name);
            //Console.WriteLine("Extensão: " + file1.Extension);
            //Console.WriteLine("Diretorio: "+ file1.Directory);

            DirectoryInfo dir1 = new DirectoryInfo(@"E:\Programas\CursoCSharp\ArquivosDiretorios\subdir");
            dir1.Create();

            string[] files = Directory.GetFiles(@"E:\Programas\CursoCSharp\ArquivosDiretorios\");

            foreach(string file in files)
            {
                Console.WriteLine(file);
            }
        }
    }
}
