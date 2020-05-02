using NPoco;
using System.Collections.Generic;
using System.Configuration;

namespace AdressBook.Models
{
    public partial class ContactGroup
    {
        public IEnumerable<ContactGroup> GetById(int id)
        {
            IDatabase db = new Database("myConnectionString");
            IEnumerable<ContactGroup> contactGroups = db.Query<ContactGroup>().Where(x => x.Id == id).ToList();

            return contactGroups;
        }
    }
}