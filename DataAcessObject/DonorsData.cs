using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
// this is create for data access
// 
namespace DataAcessObject
{
    public class DonorsData
    {
        public bool SaveUser(string userName, string userEmail, string password, string fullName, string contact, string address ) 
        {
            bool result = false;
            try
            {
                using (var db = new BloodBankDatabaseEntities()) 
                {
                    var user = new User() { UserName = userName, Email = userEmail, Password = password, Full_name = fullName, Contact = contact, Address = address, Added_date = DateTime.Now};
                    db.Users.Add(user);
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
