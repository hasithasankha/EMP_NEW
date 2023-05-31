using EMP_NEW.Data;
using System.Collections.Generic;
using System.Linq;

namespace EMP_NEW.Service
{
    public class DepartmentService 
    {
        private readonly ApplicationDBContext _dbContext;
        private readonly Department _department; 

        public DepartmentService(ApplicationDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        // get all Department list
        public List<Department> GetDepartments()
        {

            // get all Department data to list
            var departmentList = _dbContext.Departments.ToList();
            // return all employee data
            return departmentList;
        }
        // get Department by Department id 
        public Department GetDepartmentById(int id)
        {
            // get  Department data using Department id
            Department department = _dbContext.Departments.FirstOrDefault(s => s.DepartmentId == id);
            // return employee data
            return _department;
        }

        // insert Department data
        public string CreateDepartment(Department department)
        {
            //Add department data 
            _dbContext.Departments.Add(department);
            //Update database Department data 
            _dbContext.SaveChanges();
            return department.DepartmentName + " Added successfully";
        }
        //Update Department data 
        public string UpdateDepartment(Department department)
        {
            //Update Department data 
            _dbContext.Departments.Update(department);
            //Update database Department data 
            _dbContext.SaveChanges();
            return department.DepartmentName + " Updated successfully";
        }
        //Delete Department data 
        public string DeleteDepartment (Department department)
        {
            //Delete Department data 
            _dbContext.Departments.Remove(department);
            //delete database data
            _dbContext.SaveChanges();
            return department.DepartmentName + " Deleted successfully";
        }
    }
}
