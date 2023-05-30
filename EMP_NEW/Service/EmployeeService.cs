using EMP_NEW.Data;
using System.Collections.Generic;
using System.Linq;

namespace EMP_NEW.Service
{
    public class EmployeeService
    {
        private readonly ApplicationDBContext _dbContext;   
        private readonly Employee _employee;

        public EmployeeService(ApplicationDBContext dbContext)
        {
            _dbContext = dbContext;
        } 
        
        // get all employee list
        public List <Employee> GetEmployee() { 
        
            // get all employee data to list
            var empLoyeeList =_dbContext.Employees.ToList(); 
            // return all employee data
            return empLoyeeList;
        }
        // get employee by employee id 
        public Employee GetEmployee(int id)
        {
            // get  employee data using employee id
            Employee employee = _dbContext.Employees.FirstOrDefault(s => s.EmployeeId == id);
            // return employee data
            return _employee;
        }

        // insert Employee data
        public string CreateEmployee(Employee employee) {
            //Add employee data 
            _dbContext.Employees.Add(employee);
            //Update database employee data 
            _dbContext.SaveChanges();
            return employee.Name+" Added successfully";
        }
        //Update employee data 
        public string UpdateEmployee(Employee employee) {
            //Update employee data 
            _dbContext.Employees.Update(employee);
            //Update database employee data 
            _dbContext.SaveChanges();
            return employee.Name + " Updated successfully";
        }
        //Delete employee data 
        public string DeleteEmployee(Employee employee)
        {
            //Delete employee data 
            _dbContext.Employees.Remove(employee);
            //delete database data
            _dbContext.SaveChanges();
            return employee.Name + " Deleted successfully";
        }
    }       
}
