using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;

namespace Fireman_Systemn.Controller
{
    class TeamsController
    {
        public List<Teams> GetAll()
        {
            using (FiremanSysEntities fse = new FiremanSysEntities())
            {
                var teams = fse.Teams.Include(t => t.FireTrucks).ToList();
                return teams;
            }
        }

        public void Insert(Cases Case)
        {
            using (FiremanSysEntities fse = new FiremanSysEntities())
            {
                Case.Case_id = fse.Cases.Count() + 1;
                fse.Cases.Add(Case);
                fse.SaveChanges();
            }
        }

        public void Update(Cases Case)
        {
            using (FiremanSysEntities fse = new FiremanSysEntities())
            {
                fse.Cases.Attach(Case);
                fse.Entry(Case).State = System.Data.Entity.EntityState.Modified;
                fse.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            using (FiremanSysEntities fse = new FiremanSysEntities())
            {
                var fireCase = fse.Cases.Where(c => c.Case_id == id).FirstOrDefault();
                if (fireCase != null)
                {
                    fse.Cases.Remove(fireCase);
                    fse.SaveChanges();
                }
            }
        }
    }
}
