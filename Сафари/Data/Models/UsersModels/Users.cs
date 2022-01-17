using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Сафари.Data.Models.MaterialsModels
{
    public class Users
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Email { get; set; }
        public string Pass { get; set; }
        public Users()
        {

        }
        public Users(string login, string email, string pass)
        {
            this.Login = login;
            this.Email = email;
            this.Pass = pass;
        }
    }
}
