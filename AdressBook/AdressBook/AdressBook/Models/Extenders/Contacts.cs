using NPoco;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;

namespace AdressBook.Models
{
    public partial class Contacts
    {
        public IEnumerable<Contacts> GetById(int id)
        {
            IDatabase db = new Database("myConnectionString");
            IEnumerable<Contacts> contacts = db.Query<Contacts>().Where(x => x.Id == id).ToList();

            return contacts;
        }

        public IEnumerable<Contacts> GetAll()
        {
            IDatabase db = new Database("myConnectionString");
            IEnumerable<Contacts> contacts = db.Query<Contacts>().ToList().OrderBy(x => x.Title);

            return contacts;
        }
    }
}