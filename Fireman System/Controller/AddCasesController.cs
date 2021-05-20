using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace Fireman_Systemn.Controller
{
    public class AddCasesController
    {
        public List<int> FillCombo()
        {
            using (FiremanSysEntities fse = new FiremanSysEntities())
            {
                var teamIds = fse.Teams.Select(t => t.team_id).ToList();
                cb_choosen_team.Items.Add(teamIds.ToString());
                return teamIds;
            }
        }

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
                Case.Case_id = fse.Cases.Count() + 1;
                fse.Cases.Add(Case);
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
