using CarRentalapi.Context;
using CarRentalapi.Models;

namespace CarRentalapi.Service
{
    public class EmployeeTypesServices
    {
        private readonly MyDbContext _context;
        public EmployeeTypesServices(MyDbContext dbContext)
        {
            _context=dbContext;
        }
        public List<EmployeeTypes> GetAllEmployeeTypes()
        {
            return _context.EmployeeTypes.ToList();
        }
        public EmployeeTypes GetEmployeeTypeById(int id)
        {
            return _context.EmployeeTypes.FirstOrDefault(c=>c.EmployeeTypesId==id); 
        }
        public void AddEmployeeType(EmployeeTypes employee)
        {
            _context.EmployeeTypes.Add(employee);
            _context.SaveChanges();
        }
        public void DeleteEmployeeType(int id)
        {
            var emp= _context.EmployeeTypes.FirstOrDefault(c=>c.EmployeeTypesId == id); 
            if (emp!=null)
            {
                _context.EmployeeTypes.Remove(emp);
                _context.SaveChanges();
            }
        }
        public EmployeeTypes UpdateEmployeetype(EmployeeTypes employee)
        {
            var emptype = _context.EmployeeTypes.FirstOrDefault(c => c.EmployeeTypesId == employee.EmployeeTypesId);
            if (emptype!=null)
            {
                emptype.Type=employee.Type;
                _context.SaveChanges();
            }
            return emptype;
        }
    }

}
