using System.Collections.Generic;
using System.Linq;
using System.Windows;
using Сафари.Data.MainData;
using Сафари.Data.Models.MaterialsModels;
using Сафари.Views;

namespace Сафари.Data.DataWorker.ForUsers
{
    public class DataUsers
    {
        public List<Users> GetAllUsers()
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                return db.Users.ToList();
            }
        }
        public static Users findUser(string usersLogin, string usersPassword)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                return db.Users.Where(u => u.Login == usersLogin && u.Pass == usersPassword).FirstOrDefault();

            }
        }
        public static void addUser(string login, string password, string email)
        {
            using (ApplicationContext db = new ApplicationContext())
            {

                Users user = new Users(login, email, password);
                db.Users.Add(user);

                db.SaveChanges();

                MessageBoxResult result = MessageBox.Show("Успішно!");

            }
            
        }
    }
}
