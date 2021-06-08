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

        public void Insert(Employees Employee)
        {
            using (FiremanSysEntities fse = new FiremanSysEntities())
            {
                Employee.employee_id = fse.Employees.Count() + 1;
                fse.Employees.Add(Employee);
                fse.SaveChanges();
            }
        }

        //public void Update(Cases Case)
        //{
        //    using (FiremanSysEntities fse = new FiremanSysEntities())
        //    {
        //        fse.Cases.Attach(Case);
        //        fse.Entry(Case).State = System.Data.Entity.EntityState.Modified;
        //        fse.SaveChanges();
        //    }
        //}

        //public void Delete(int id)
        //{
        //    using (FiremanSysEntities fse = new FiremanSysEntities())
        //    {
        //        var fireCase = fse.Cases.Where(c => c.case_id == id).FirstOrDefault();
        //        if (fireCase != null)
        //        {
        //            fse.Cases.Remove(fireCase);
        //            fse.SaveChanges();
        //        }
        //    }
        //}
    }
}
