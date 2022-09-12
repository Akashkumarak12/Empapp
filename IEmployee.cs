using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empapp
{
    public interface IEmployee<Employee>
    {
         List<Employee> getEmplist();
        bool AddEmployee(Employee e);
        bool RemoveEmployee(int id);
        Employee getEmployee(int id);
        string message(string name);
        bool checksal(int sal);
        int add (int a,int b);
    }
}
