using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryEmployees
{
    class Program
    {


        static void Main(string[] args)
        {
            ProductionWorker juan = new ProductionWorker(1, 10.00, "Worker", "Juan", "12345", "12-12-2000");           
            juan.DisplayStats();
            Console.WriteLine();

            ShiftSupervisor hiram = new ShiftSupervisor(50000, 0, 1500, "Hiram", "67890", "11-11-2001" );
            hiram.DisplayStats();
            Console.WriteLine();

            TeamLeader milo = new TeamLeader(1000, 40, 60, 2, 40.00, "Team Leader", "Milo", "55555", "10-10-2002");
            milo.DisplayStats();
            Console.WriteLine();
        }
    }
}