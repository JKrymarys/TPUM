using System;
using TPUM.Data;

namespace TPUM.Logic
{
    class Program
    {
        static void Main(string[] args)
        {
            var tc = new TestConnection();
           int randomNumber =  tc.generateRandomNumber();
            Console.WriteLine("Hello World! " + randomNumber);
        }
    }
}
