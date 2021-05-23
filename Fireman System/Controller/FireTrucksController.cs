using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fireman_Systemn.Controller
{
    public class FireTrucksController
    {
        public List<FireTrucks> GetAll()
        {
            using (FiremanSysEntities fse = new FiremanSysEntities())
            {
                var fireTrucks = fse.FireTrucks.ToList();
                return fireTrucks;
            }
        }

        public void Delete(int id)
        {
            using (FiremanSysEntities fse = new FiremanSysEntities())
            {
                var fireTruck = fse.FireTrucks.Where(c => c.fire_truck_id == id).FirstOrDefault();
                if (fireTruck != null)
                {
                    fse.FireTrucks.Remove(fireTruck);
                    fse.SaveChanges();
                }
            }
        }
    }
}
