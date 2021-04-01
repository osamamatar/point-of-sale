using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POS.DB;
using System.Windows.Forms;
using POS.dto;
using POS.DAL;

namespace POS.BAL
{
    class UserBalImpl 
    { 

          DAL.UserDalImpl u =new DAL.UserDalImpl();
        DAL.RolDal rol = new DAL.RolDal();


        public int createUser(User user)
        {
            if(user.user_full_name.Length==0 || user.user_full_name==" "|| user.user_name.Length == 0 || user.user_name == " "||user.user_pass.Length==0||user.user_pass=="")
            {
                MessageBox.Show("من فضلك  ادخل  البيانات بشكل صحيح  ");
                return 0;
            }else
            {
                 u.createUser(user);
                return 1;
            }




        }

        public void deleteUser(string id)
        {
            u.deleteUser(id);
        }

        public List<userDto> listOfUsers()
        {
            List<userDto> li = new List<userDto>();
          

            for (int i = 0; i <= u.listOfUsers().Count() - 1; i++)
              {
                userDto user = new userDto();
                string role =rol.getRollById(u.listOfUsers()[i].role_id);
                user.user_id = u.listOfUsers()[i].user_id;
                user.user_name = u.listOfUsers()[i].user_name.ToString();
                user.user_full_name = u.listOfUsers()[i].user_full_name.ToString();
                user.user_pass = u.listOfUsers()[i].user_pass.ToString();
                user.user_role = role;

                li.Add(user);

                //Console.WriteLine(user.user_name);


             }

          
            return li;
        }

        public void updateUser(userDto user)
        {
            int role = rol.getRollByName(user.user_role);
            User u = new User();
            u.user_id = user.user_id;
            u.user_full_name = user.user_full_name;
            u.user_name = user.user_name;
            u.user_pass = user.user_pass;
            u.role_id = role;
            new UserDalImpl().updateUser(u);
        }
    }
}
