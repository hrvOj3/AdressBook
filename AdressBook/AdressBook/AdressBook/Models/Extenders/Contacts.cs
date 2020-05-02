using NPoco;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;

namespace AdressBook.Models
{
    public partial class Contact
    {
        private IDatabase db = new Database("myConnectionString");
        public IEnumerable<Contact> GetById(int id)
        {
            IEnumerable<Contact> contacts = db.Query<Contact>().Where(x => x.Id == id).ToList();

            return contacts;
        }

        public IEnumerable<Contact> GetAll()
        {
            IEnumerable<Contact> contacts = db.Query<Contact>().ToList().OrderBy(x => x.Title);

            return contacts;
        }

        public bool UpdateContact(Contact contact)
        {
            int isUpdated;
            var dbContact = db.SingleById<Contact>(contact.Id);

            var snapshot = db.StartSnapshot(contact);

            dbContact.Name = contact.Name;
            dbContact.Title = contact.Title;
            dbContact.Email = contact.Email;

            isUpdated = db.Update(dbContact, snapshot.UpdatedColumns());

            if (isUpdated > 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public bool InserthoneNumber(Contact contact)
        {
            Contact dbContact = new Contact()
            {
                Title = contact.Title,

                Name = contact.Name,

                Surname = contact.Surname,

                Organization = contact.Organization,

                Email = contact.Email,


            };

            db.Save(dbContact);

            //if (isUpdated > 0)
            //{
            return true;
            //}
            //else
            //{
            //    return false;
            //}

        }

        public bool DeletePhoneNumber(Contact contact)
        {
            int isDeleted;
            var dbContact = db.SingleById<PhoneNumber>(contact.Id);
            isDeleted = db.Delete(dbContact);

            if (isDeleted > 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}