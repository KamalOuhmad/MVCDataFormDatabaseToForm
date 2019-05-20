using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLibrary.Models;
using DataLibrary.DataAccess;

namespace DataLibrary.BusinessLogic
{
     public static class EmployeeProcessor
     {
        public static int CreateEmployee(int employeeId, string firstName, string lastName, string emailAddress)
        {
            EmployeeModel Data = new EmployeeModel
            {
                FirstName = firstName,
                LastName = lastName,
                EmailAddress = emailAddress,
            };
             string Sql = @"insert into dbo.Employee (EmployeeId, FirstName, LastName, EmailAddress) values (@employeeId, @firstName,@lastName,@emailAddress)";

             return SqlDataAccess.SaveData(Sql, Data);
        }

        public static List<EmployeeModel> LoadEmployees()
        {
            string Sql = @"select Id, EmployeeId, FirstName, LastName, EmailAddress 
                           from dbo.Employee;";

            return SqlDataAccess.LoadData<EmployeeModel>(Sql);
        }
     }
}
