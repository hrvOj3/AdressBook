using NPoco;
using System.Collections.Generic;
using System.Linq;

namespace AdressBook.Models
{
    public partial class Contact
    {
        private static readonly NLog.Logger Logger = NLog.LogManager.GetCurrentClassLogger();
        [ResultColumn]
        public List<ContactPhoneNumber> PhoneNumbers { get; set; }

        public static Contact GetById(int id)
        {
            try
            {
                IDatabase db = new Database("myConnectionString");
                Contact contact = db.Query<Contact>().Where(x => x.Id == id).FirstOrDefault();
                contact.PhoneNumbers = ContactPhoneNumber.GetAllByContactId(contact.Id).ToList();
                return contact;
            }
            catch (System.Exception ex)
            {
                Logger.Error(ex);
                return null;
            }
        }

        public static IEnumerable<Contact> GetAll()
        {
            try
            {
                IDatabase db = new Database("myConnectionString");
                IEnumerable<Contact> contacts = db.Query<Contact>().Where(x => x.Name != "").ToList();

                foreach (Contact contact in contacts)
                {
                    contact.PhoneNumbers = ContactPhoneNumber.GetAllByContactId(contact.Id).ToList();
                }

                return contacts;
            }
            catch (System.Exception ex)
            {
                Logger.Error(ex);
                return null;
            }
        }

        public static IEnumerable<Contact> GetLatestContacts(int numOfContacts)
        {
            try
            {
                IDatabase db = new Database("myConnectionString");
                IEnumerable<Contact> contacts = db.Query<Contact>().Where(x => x.Title != null).ToList();

                foreach (Contact contact in contacts)
                {
                    contact.PhoneNumbers = ContactPhoneNumber.GetAllByContactId(contact.Id).ToList();
                }

                return contacts;
            }
            catch (System.Exception ex)
            {
                Logger.Error(ex);
                return null;
            }
        }

        public bool DelteContact(Contact contact)
        {
            IDatabase db = new Database("myConnectionString");
            try
            {
                var dbContact = db.SingleById<Contact>(contact.Id);

                foreach (ContactPhoneNumber phoneNumber in dbContact.PhoneNumbers)
                {
                    ContactPhoneNumber.DeletePhoneNumber(phoneNumber);
                }

                db.Delete(dbContact);
                return true;
            }
            catch (System.Exception ex)
            {
                Logger.Error(ex);
                return false;
            }
        }

        public bool InsertOdUpdateContact(Contact contact)
        {
            IDatabase db = new Database("myConnectionString");
            try
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

                return true;
            }
            catch (System.Exception ex)
            {
                Logger.Error(ex);
                return false;
            }
        }
    }
}