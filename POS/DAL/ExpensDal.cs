using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POS.dto;
using POS.DB;
namespace POS.DAL
{
    class ExpensDal
    {
        Point_Of_SaleEntities1 db = new Point_Of_SaleEntities1();
        UserDalImpl user = new UserDalImpl();
        public void createExpense(ExpensDto ex)
        {
            int id = user.getUserIdByName(ex.user_name);
            Expens e = new Expens();
            e.exp_description = ex.description;
            e.exp_cost = ex.cost;
            e.exp_date = ex.date;
            e.user_id = id;
            db.Expenses.Add(e);
            db.SaveChanges();
        }
        public List<ExpensDto> getListOfExpenses()
        {
           
            List<ExpensDto> li = new List<ExpensDto>();
            List<Expens> l = db.Expenses.ToList();
            for(int i = 0; i <= l.Count - 1; i++)
            {
                ExpensDto e = new ExpensDto();
                e.cost = (float)l[i].exp_cost;
                e.description = l[i].exp_description;
                e.date = (DateTime) l[i].exp_date;
                e.user_name = user.getUserNameById(Convert.ToInt32(l[i].user_id));
                e.id = l[i].exp_id;
                li.Add(e);
            }
            return li;
        }
        public void deleteEpense(ExpensDto e)
        {
            Expens ex = db.Expenses.Find(e.id);



            db.Expenses.Remove(ex);
            db.SaveChanges();
        }
        public double getTotalExpens()
        {
            double sum =(double) db.Expenses.Sum(e => e.exp_cost);
            return sum;
        }
        public List<ExpensDto> getSearchedListOfExpenses(DateTime t1,DateTime t2)
        {
            string t11 = t1.ToString("yyyy-MM-dd ");
            string t22 = t2.ToString("yyyy-MM-dd ");
            string sql = "select * from Expenses where exp_date >= ' " + t11 + "' AND exp_date <=' " + t22+" ' ";
            List<ExpensDto> li = new List<ExpensDto>();
            List<Expens> l = db.Expenses.SqlQuery(sql).ToList();
            if (l.Count !=0)
            {

                foreach (Expens ex in l)
                {
                    ExpensDto e = new ExpensDto();
                    e.cost = (float)ex.exp_cost;
                    e.description = ex.exp_description;
                    e.date = (DateTime)ex.exp_date;
                    e.user_name = user.getUserNameById(Convert.ToInt32(ex.user_id));
                    e.id = ex.exp_id;
                    li.Add(e);

                }
            }else
            {
                Console.Write("error ha");
            }


            return li;
        }
    }
}
