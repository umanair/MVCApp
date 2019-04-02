using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLibrary.Models;

namespace DataLibrary.Business_Logic
{
    public static class EmployeeProcessor
    {
        public static int CreateEmployee(int employeeId, string firstName, string lastName,
            string emailAddress, string password)
        {
            EmployeeModel model= new EmployeeModel
            {
                EmployeeId = employeeId,
                FirstName = firstName,
                LastName = lastName,
                EmailAddress = emailAddress,
                Password = password
            };

            string sql = @"insert into dbo.Employee (EmployeeId, FirstName, LastName, EmailAddress, Password) values (@EmployeeId, @FirstName, @LastName, @EmailAddress, @Password)";
            return SqlDataAccess.SqlDataAccess.SaveData(sql, model);
        }

        public static List<EmployeeModel> LoadEmployee()
        {
            string sql = @"select EmployeeId, FirstName, LastName, EmailAddress from dbo.Employee";
            return SqlDataAccess.SqlDataAccess.LoadData<EmployeeModel>(sql);
        }
    }
}
