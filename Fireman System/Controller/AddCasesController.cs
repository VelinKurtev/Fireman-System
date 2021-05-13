using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fireman_Systemn.Controller
{
    public class AddCasesController
    {
        public List<Cases> GetAll()
        {
            using (FiremanSysEntities fse = new FiremanSysEntities())
            {
                var cases = fse.Cases.ToList();
                return cases;
            }
        }
        
        public void Insert(Cases Case)
        {
            using (FiremanSysEntities fse = new FiremanSysEntities())
            {
                Case.Id = fse.Cases.Count() + 1;
                fse.Cases.Add(Case);
                fse.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            using (FiremanSysEntities fse = new FiremanSysEntities())
            {
                var fireCase = fse.Cases.Where(c => c.Id == id).FirstOrDefault();
                if (fireCase != null)
                {
                    fse.Cases.Remove(fireCase);
                    fse.SaveChanges();
                }
            }
        }
    }
}
