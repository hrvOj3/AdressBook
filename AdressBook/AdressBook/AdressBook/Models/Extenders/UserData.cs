using NPoco;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;

namespace AdressBook.Models
{
    public partial class UserData 
    {
        public IEnumerable<UserData> GetById(int id)
        {
            IDatabase db = new Database("myConnectionString");
            IEnumerable<UserData> userData = db.Query<UserData>().Where(x => x.Id == id).ToList();

            return userData;
        }

    }
}