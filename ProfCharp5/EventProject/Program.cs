using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventProject
{
    class Program
    {
        private delegate string GetString();
        static void Main(string[] args)
        {
            Console.WriteLine("Event Project!");
            int x = 40;

            Console.Read();
        }
    }

    struct Currency
    {
        public uint Dollats;
        public uint Cents;


    }
}
