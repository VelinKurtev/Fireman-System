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

        public void Insert(FireTrucks FireTruck)
        {
            using (FiremanSysEntities fse = new FiremanSysEntities())
            {
                FireTruck.fire_truck_id = fse.FireTrucks.Count() + 1;
                fse.FireTrucks.Add(FireTruck);
                fse.SaveChanges();
            }
        }

        public void Update(FireTrucks fireTruck)
        {
            using (FiremanSysEntities fse = new FiremanSysEntities())
            {
                fse.FireTrucks.Attach(fireTruck);
                fse.Entry(fireTruck).State = System.Data.Entity.EntityState.Modified;
                fse.SaveChanges();
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
