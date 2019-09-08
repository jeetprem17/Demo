using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20181017
{
    class Employee : CollegeStaff
    {
        string _employeeName;
        int _employeeId;
        double _employeeSalary;

        public string EmployeeName
        {
            get { return this._employeeName; }
            set { this._employeeName = value; }
        }
        public int EmployeeId
        {
            get { return this._employeeId; }
            set { this._employeeId = value; }
        }
        public double EmployeeSalary
        {
            get { return this._employeeSalary; }
            set { this._employeeSalary = value; }
        }
    }
    class CollegeStaff : Employee
    {
        string _staffpro;
        public string StaffPro
        {
            get {return this._staffpro;}
            set {this._staffpro=value;}
        }
        
    class College : Employee
    {
        string _collegeName;

        public string CollgeName
        {
            get {return this._collegeName;}
            set {this._collegeName=value;}
        }
    
        static void Main(string[] args)
        {
            Employee employeeObj = new Employee();
            employeeObj.EmployeeName = "Ram";
            employeeObj.EmployeeId = 123456789;
            employeeObj.EmployeeSalary = 10000.00;
            employeeObj.StaffPro="dot Net";
            collegeObj.CollgeName = "Dev Bhoomi Group of Institute";
            CollegeStaff collegeStafObj = new CollegeStaff();
            collegeStafObj.StaffPro = "Null";
            collegeStafObj.StaffPro= 0;

            Console.WriteLine("=======================================\n\n");
            Console.WriteLine("============Employee Details===========\n\n");
            Console.WriteLine("=======================================\n");
            Console.WriteLine("Company Name Is : "+collegeObj._collegeName);
            Console.WriteLine("Employee Name Is : "+employeeObj.EmployeeName);
            Console.WriteLine("Employee Id Is : "+employeeObj.EmployeeId);
            Console.WriteLine("Salary Is : "+employeeObj.EmployeeSalary);
            Console.ReadLine();
        }
    }
}
