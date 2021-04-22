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
        
        public void Insert(Cases c)
        {
            using (FiremanSysEntities fse = new FiremanSysEntities())
            {
                c.Id = fse.Cases.Count() + 1;
                fse.Cases.Add(c);
                fse.SaveChanges();
            }
        }
    }
}
