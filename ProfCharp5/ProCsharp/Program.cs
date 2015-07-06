using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.IO;

namespace ProCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("File Project!!");
            FileInfo file = new FileInfo(@"E:\bitbucket\authframework\src\AuthFramework.Web\Controllers\DeptController.cs");
            bool isExist = file.Exists;
            DirectoryInfo dirinfo = new DirectoryInfo(@"E:\bitbucket\authframework\src\AuthFramework.Web\Controllers");
            Console.WriteLine(Path.Combine(@"e:\file","cc.cs"));
            Console.ReadLine();
        }
    }
}
