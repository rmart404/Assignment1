using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryEmployees
{
    abstract partial class Employee 
    {
        private string empName;
        private string empID;
        private string hireDate;

        public Employee()
        {
            empName = null;
            empID = null;
            hireDate = null;
        }

        public Employee(string _empName, string _empID, string _hireDate)
        {
            empName = _empName;
            empID = _empID;
            hireDate = _hireDate;
        }

        public string EmpName
        {
            get {return empName;}

            set {empName = value;}
        }

        public string EmpID
        {
            get {return empID;}

            set {empID = value;}
        }

        public string HireDate
        {
            get {return hireDate;}

            set {hireDate = value;}
        }

        public virtual void DisplayStats()
        {
            Console.WriteLine("Name: {0}", empName);
            Console.WriteLine("ID: {0}", empID);
            Console.WriteLine("HireDate: {0}", hireDate);
            
        }
    }

}