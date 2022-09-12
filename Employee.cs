using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empapp
{
    public class Employee : IEmployee<Employee>
    {
        public int EId { get; set; }
        public string EName { get; set; }
        public int Salary { get; set; }
        public Employee() { }
        public Employee(int eid, string Ename, int salary)
        {
            EId = eid;
            EName =Ename;
            Salary = salary;
        }


        public static List<Employee> employees = new List<Employee>();
       
        public  List<Employee> getEmplist()
        {
            employees.Add(new Employee(1,"John",25000));
            employees.Add(new Employee(2,"Kumar",50000));
           
            return employees;
        }
        public bool AddEmployee(Employee e)
        {
           employees.Add(e);
            return true;
        }

        public bool checksal(int sal)
        {
            int result = add(sal, 20);
            if(result > 50)
                return true;
            else
                return false;
        }
        public int add(int a , int b)
        {
            return a + b;
        }

        public  Employee getEmployee(int id)
        {
            employees=getEmplist();
            Employee e = employees.Where(x => x.EId == id).SingleOrDefault();
            return e;
        }

        public string message(string name)
        {
            return "Hello" + name;
        }

        public bool RemoveEmployee(int id)
        {
            Employee e= getEmployee(id);
            employees.Remove(e);
            return true;
        }

       
    }
}
