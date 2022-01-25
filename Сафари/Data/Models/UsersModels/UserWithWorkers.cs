using System;

namespace Сафари.Data.Models.UsersModels
{
    public class UserWithWorkers
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int WorkersId { get; set; }
        public int Salary { get; set; }
        public DateTime DataHire { get; set; }

        public UserWithWorkers()
        {

        }
        public UserWithWorkers(int User_id, int JobPerson_id, int Salary)
        {
            this.UserId = User_id;
            this.WorkersId = JobPerson_id;
            this.Salary = Salary;
            DataHire = DateTime.Now;
        }
    }
}
