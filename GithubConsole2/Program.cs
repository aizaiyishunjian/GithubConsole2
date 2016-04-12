using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;

namespace GithubConsole2
{
    class Program
    {
        static void Main(string[] args)
        {
            var fileName = "Resource.txt";

            Console.WriteLine("Hello Git,I love you!");

            var path = AppDomain.CurrentDomain.BaseDirectory;
            Console.WriteLine("BaseDirectory :{0}",path);

            var filePath = string.Format("{0}\\ResourceFile\\{1}",path,fileName);
            var file=new FileStream(filePath,FileMode.Open);
            var reader=new StreamReader(file);
            
            Console.WriteLine(reader.ReadLine());

            Console.Read();
        }
    }
}
