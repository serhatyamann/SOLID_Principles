using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.SRP_Single_Responsibility.ViolatingExample
{
    public interface IOperations
    {
        //When a class inherits from this interface, all of these methods has to be implemented.
        //So that class will have more than one responsibility.
        string RegisterEmployee(string firstName, string lastName, string phoneNo);
        string DeleteEmployee(int id);
        string UpdateEmployee(int id, string firstName, string lastName, string phoneNo);


    }
}
