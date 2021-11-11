using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryCore;
namespace VirtualFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            FactoryCould ff = new FactoryCould();
            ff.Company = "Maxxis";
            ff.ProductName = "Tire";
            ff.Origin = @"E:\C#\ReferencePart2\VirtualFactory\VirtualFactory\bin\x64\DLL\";
            ff.StartProduce();

            ff = new FactoryCould();
            ff.Company = "BMW";
            ff.ProductName = "Car";
            ff.Origin = @"E:\C#\ReferencePart2\VirtualFactory\VirtualFactory\bin\x64\DLL\";
            ff.StartProduce();

            Console.ReadLine();
        }
    }
}
