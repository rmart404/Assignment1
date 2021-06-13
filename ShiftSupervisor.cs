using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryEmployees
{
    class ShiftSupervisor : Employee
    {
        private double annual_salary;
        private int shift;
        private double annualProdBonus;

        public ShiftSupervisor()
        {
            annual_salary = 0.0;
            shift = 0;
            annualProdBonus = 0.0;
        }

        public ShiftSupervisor(double annSalary, int _shift, double annual_productionBonus, string _empName, string _empID, string _hireDate)
        : base(_empName, _empID, _hireDate)
        {
            annual_salary = annSalary;
            shift = _shift;
            annualProdBonus = annual_productionBonus;
        }
           

        public double Annual_salary
        {
            get {return annual_salary;}

            set {annual_salary = value;}
        }

        public int Shift
        {
            get {return shift;}

            set {shift = value;}
        }

        public double AnProductionBonus
        {
            get {return annualProdBonus;}

            set {annualProdBonus = value;}
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
            Console.WriteLine("Annual Salary: {0:C}", annual_salary);
            Console.WriteLine("Annual Production Bonus: {0:C}", annualProdBonus);


        }
    }
}