using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fireman_Systemn.Controller
{
    class EmployeesController
    {
        public List<Employees> GetAll()
        {
            using (FiremanSysEntities fse = new FiremanSysEntities())
            {
                var employees = fse.Employees.ToList();
                return employees;
            }
        }

        public List<Employees> GetAllEmployeesByCases()
        {
            using (FiremanSysEntities fse = new FiremanSysEntities())
            {
                var employees = fse.Employees.OrderByDescending(employee => employee.number_of_answered_cases).ToList();
                return employees;
            }
        }

        public void Insert(Employees Employee)
        {
            using (FiremanSysEntities fse = new FiremanSysEntities())
            {
                Employee.employee_id = fse.Employees.Count() + 1;
                fse.Employees.Add(Employee);
                fse.SaveChanges();
            }
        }

        public void Update(Employees Employee)
        {
            using (FiremanSysEntities fse = new FiremanSysEntities())
            {
                fse.Employees.Attach(Employee);
                fse.Entry(Employee).State = System.Data.Entity.EntityState.Modified;
                fse.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            using (FiremanSysEntities fse = new FiremanSysEntities())
            {
                var employee = fse.Employees.Where(e => e.employee_id == id).FirstOrDefault();
                if (employee != null)
                {
                    fse.Employees.Remove(employee);
                    fse.SaveChanges();
                }
            }
        }
    }
}
