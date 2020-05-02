using NPoco;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;

namespace AdressBook.Models
{
    public partial class PhoneNumber
    {
        public IEnumerable<PhoneNumber> GetById(int id)
        {
            IDatabase db = new Database("myConnectionString");
            IEnumerable<PhoneNumber> phoneNumber = db.Query<PhoneNumber>().Where(x => x.Id == id).ToList();

            return phoneNumber;
        }
    }
}