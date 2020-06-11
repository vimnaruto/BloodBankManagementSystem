using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    // create data access clzand insertion process
   public class UserDataAccess
    {
        public bool SaveUser(string userName, string userEmail, string password, string fullName, string contact, string address)
        {
            bool result = false;
            try
            {
                using (var db = new BloodBankDatabaseEntities()) // create database here we access database
                {
                    //create new user using Datamodel User class
                    //create new user object
                    var user = new User() { UserName = userName, Email = userEmail, Password = password, Full_name = fullName, Contact = contact, Address = address, Added_date = DateTime.Now };
                    // add employee to database
                    //data insertion process 
                    db.Users.Add(user);//
                    db.SaveChanges();
                    result = true;

                }

            }

            catch (Exception ex)
            {

                throw ex;
            }
            return result;
        }


    }
}


// 

