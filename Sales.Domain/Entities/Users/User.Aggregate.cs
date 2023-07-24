
using System.Collections.Generic;

namespace Sales.Domain.Users
{
    public partial class User
    {
        public User()
        {
            //Users = new HashSet<User>();
        }

        public User(string userName, string password,int documentType,string documentNumber  , string firstName,
            string lastName, string email, string phone) : this()
        {
            this.Update( userName,  password,  documentType,documentNumber,  firstName,
            lastName,  email,  phone);
        }

        public void Update(string userName, string password, int documentType, string documentNumber, string firstName,
            string lastName, string email, string phone)
        {
            UserName= userName;
            Password= password;
            DocumentType= documentType;
            DocumentNumber = documentNumber;
            FirstName= firstName;
            LastName= lastName;
            Email= email;
            Phone = phone;            
        }


    }
}