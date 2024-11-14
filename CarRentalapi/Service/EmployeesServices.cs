using CarRentalapi.Context;
using OnlineCarRentals.Models;

namespace CarRentalapi.Service
{
    public class EmployeesServices
    {
        private readonly MyDbContext _context;
        public EmployeesServices(MyDbContext context)
        {
            _context = context;
        }
        public List<Employee> GetAllEmployees() 
        {
            return _context.Employees.ToList();
        }
        public Employee GetEmployeeById(int id)
        {
            return _context.Employees.FirstOrDefault(e=>e.EmployeeId==id);
        }
        public void AddEmployee(Employee employee)
        {
            _context.Employees.Add(employee);
            _context.SaveChanges();
        }
        public void DeleteEmployee(int id)
        {
            var employee= _context.Employees.FirstOrDefault(e=>e.EmployeeId == id);
            if (employee!=null)
            {
                _context.Employees.Remove(employee);
                _context.SaveChanges();
            }
        }
        public Employee UpdateEmployee(Employee employee)
        {
            var existingemployee = _context.Employees.FirstOrDefault(e => e.EmployeeId == employee.EmployeeId);
            if(existingemployee!=null)
            {
                existingemployee.Name=employee.Name;
                existingemployee.Address1= employee.Address1;
                existingemployee.Address2=employee.Address2;
                existingemployee.Pincode=employee.Pincode;
                existingemployee.MobileNumber=employee.MobileNumber;
                existingemployee.PhoneNumber=employee.PhoneNumber;
                existingemployee.EmailAddress=employee.EmailAddress;
                existingemployee.BankName=employee.BankName;
                existingemployee.BankAccount=employee.BankAccount;
                existingemployee.PAN=employee.PAN;
                existingemployee.Username=employee.Username;
                existingemployee.Password=employee.Password;
                existingemployee.Vehicles=employee.Vehicles;
                existingemployee.VehicleMakes=employee.VehicleMakes;
                existingemployee.VehicleModels=employee.VehicleModels;
                existingemployee.Employees=employee.Employees;
                _context.SaveChanges();
            }
            return existingemployee;
        }
    }
}
