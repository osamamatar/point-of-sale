using POS.DB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.DAL
{
    class UserDalImpl 
    {
        Point_Of_SaleEntities1 db = new Point_Of_SaleEntities1();

        public void createUser(User user)
        {
            db.Users.Add(user);
            db.SaveChanges();
           

        }
        public int getUserIdByName(string name)
        {
            User user = db.Users.First(u => u.user_full_name == name);
            return user.user_id;
               
        }
        public string getUserNameById(int us_id)
        {
            User user = db.Users.First(u => u.user_id == us_id);

            return user.user_full_name;
        }
        public List<string> getListOfUsersNames()
        {

            return db.Users.Select(u => u.user_full_name).ToList();
        }
        public User getUserById(string id)
        {
           
           int us_id = Convert.ToInt32(id);

            User user = db.Users.First(u => u.user_id == us_id);
            return user;
        }

        public void deleteUser(string id)
        {

            db.Users.Remove(getUserById(id));
            db.SaveChanges();
        }

       

        public List<User> listOfUsers()
        {

           
            List<User> arr = db.Users.ToList();
            return arr;

        }

     

        public void updateUser(User user)
        {
            User result = db.Users.SingleOrDefault(b => b.user_id==user.user_id);
            if (result != null)
            {
                result.user_name = user.user_name;
                result.user_full_name = user.user_full_name;
                result.user_pass =user.user_pass;
                result.role_id=user.role_id;
                db.SaveChanges();
            }
        }
    }
}
