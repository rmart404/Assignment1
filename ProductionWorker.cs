using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryEmployees
{
    class ProductionWorker : Employee
    {
        private int shift;
        private double payRate;
        private string teamAssignment;

        public ProductionWorker()
        {
            shift = 0;
            payRate = 0.0;
            teamAssignment = null;
        }

        public ProductionWorker (int _shift, double _payRate, string team_assignment, string _empName, string _empID, string _hireDate) 
            : base(_empName, _empID, _hireDate)
        {
            shift = _shift;
            payRate = _payRate;
            teamAssignment = team_assignment;
        }
        public int Shift
        {
            get {return shift;}

            set {
                if (value > 3 && value < 0)
                {
                    Console.WriteLine("Error! Not a valid shift!");
                }
                else
                {
                    shift = value;
                }
            }
        }

        public double PayRate
        {
            get {return payRate;}

            set {payRate = value;}
        }

        public string TeamAssignment
        {
            get {return teamAssignment;}

            set {teamAssignment = value;}
        }

        public override void DisplayStats()
        {
            base.DisplayStats();
            if (shift == 1)
            {
                Console.WriteLine("Shift: Day");

            }
            else if (shift == 2)
            {
                Console.WriteLine("Shift: Night");
            }

            else if (shift == 3)
            {
                Console.WriteLine("Shift: Weekend");
            }

            else
            {
                          
                    Console.WriteLine("Not A Valid Shift. Try Again. ");
                
            }



            Console.WriteLine("Pay Rate: {0:C}", payRate);
            Console.WriteLine("Team Assignment: {0}", teamAssignment);
            

        }
    }
}