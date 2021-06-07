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

        public void Insert(Teams Team)
        {
            using (FiremanSysEntities fse = new FiremanSysEntities())
            {
                Team.team_id = fse.Teams.Count() + 1;
                fse.Teams.Add(Team);
                fse.SaveChanges();
            }
        }

        public void Update(Teams Team)
        {
            using (FiremanSysEntities fse = new FiremanSysEntities())
            {
                fse.Teams.Attach(Team);
                fse.Entry(Team).State = System.Data.Entity.EntityState.Modified;
                fse.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            using (FiremanSysEntities fse = new FiremanSysEntities())
            {
                var team = fse.Teams.Where(t =>t.team_id == id).FirstOrDefault();
                if (team != null)
                {
                    fse.Teams.Remove(team);
                    fse.SaveChanges();
                }
            }
        }
    }
}
