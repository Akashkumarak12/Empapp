using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace Empapp
{
    class Program
    {
        public static List<Employee> emps=new List<Employee>();
        static void Main(string[] arg)
        {
           
           IEmployee<Employee> obj=new Employee();
            int result = obj.add(5, 4);
            Console.WriteLine(result);
            //emps=obj.getEmplist();
            Employee e1 = obj.getEmployee(1);
            Console.WriteLine(e1.EName+""+e1.Salary);
        }
    }
}