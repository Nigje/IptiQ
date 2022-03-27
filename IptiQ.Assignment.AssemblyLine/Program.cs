using IptiQ.Assignment.AssemblyLine.Models;
using IptiQ.Assignment.AssemblyLine.Models.Abstracts;
using IptiQ.Assignment.AssemblyLine.Models.Impl;
using System;
using System.Threading.Tasks;

namespace IptiQ.Assignment.AssemblyLine
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("\r\n\r\n//**************************************************************");

            //  Build and QA station.
            IQAStation qaStation = new QAStation();
            Console.WriteLine("Created: QA and buld-station.");

            //  AssemblyLine.
            IAssemblyLine assemblyLine = new Models.Impl.AssemblyLine(qaStation);
            Console.WriteLine("Created: Assembly Line.");

            //  Add stations (the sequence of add is not important).
            assemblyLine.AddStation(new AssemblyMechanicStation());
            assemblyLine.AddStation(new PaintingStation());
            assemblyLine.AddStation(new AssemblyInteriorStation());

            Console.WriteLine("Created & Added: Assembly Mechanic Station.");
            Console.WriteLine("Created & Added: Painting Station.");
            Console.WriteLine("Created & Added: Assembly Interior Station.");

            //  Produce a car.
            Car car =await assemblyLine.ProduceAsync(new AssemblyCarEntity());

            Console.WriteLine("The car produced");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
