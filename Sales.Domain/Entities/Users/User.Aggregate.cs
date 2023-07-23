
using System.Collections.Generic;

namespace Sales.Domain.Users
{
    public partial class User
    {
        public User()
        {
            //Users = new HashSet<User>();
        }

        public User(string userName, string password, string dni, string firstName,
            string lastName, string email, string phone) : this()
        {
            this.Update( userName,  password,  dni,  firstName,
            lastName,  email,  phone);
        }

        public void Update(string userName, string password, string dni, string firstName,
            string lastName, string email, string phone)
        {
            UserName= userName;
            Password= password;
            DNI= dni;
            FirstName= firstName;
            LastName= lastName;
            Email= email;
            Phone = phone;            
        }


        //public string UserName { get; set; }
        //public string Password { get; set; }

        //public string DNI { get; set; }
        //public string FirstName { get; internal set; }
        //public string LastName { get; internal set; }
        //public string Email { get; set; }
        //public string Phone { get; set; }
    }
}