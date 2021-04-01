using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POS.DB;
using System.Data;

namespace POS.DAL
{
    class RolDal
    {
        Point_Of_SaleEntities1 db = new Point_Of_SaleEntities1();

        //get all rolles from database

        public List<Role> getAllRoll()
        {
            List<Role> arr = db.Roles.ToList();

         
                return arr;
        }
        //get role by id 
        public string getRollById(int id)
        {
            Role r = db.Roles.First(ro => ro.role_id == id);
            return r.role_description;
        }
        public int getRollByName(string name)
        {
            Role r = db.Roles.First(ro => ro.role_description == name);
            return r.role_id;
        }
    }
}
