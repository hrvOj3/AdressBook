using AdressBook.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace AdressBook.Controllers
{

    [RoutePrefix("api/contactapi")]
    public class ContactsController : ApiController
    {
        [HttpGet]
        [Route("allcontacts")]
        public string GetAllContacts()
        {
            
            IEnumerable<Contact> contacts = Contact.GetAll();

            var serializedContacts = JsonConvert.SerializeObject(contacts);

            if (contacts.Count() == 0)
            {
                return null;
            }

            return serializedContacts;

        }

        [HttpPost]
        [Route("lastcontacts")]
        public string LastContacts(int numOfContacts)
        {
            IEnumerable<Contact> contacts = new List<Contact>();
            contacts = Contact.GetLatestContacts(numOfContacts);

            var serializedContacts = JsonConvert.SerializeObject(contacts);
            if (contacts.Count() == 0)
            {
                return null;
            }

            return serializedContacts;
        }

        [HttpPost]
        [Route("savecontact")]
        public string SaveContact(Contact contact)
        {
            var isSaved = contact.InsertOdUpdateContact(contact);

            if (isSaved)
            {
                return "OK";
            }
            else
            {
                return null;
            }
        }

        [HttpPost]
        [Route("deletecontact")]
        public string DeleteContact(Contact contact)
        {
            var isDeleted = contact.DelteContact(contact);

            if (isDeleted)
            {
                return "OK"; 
            }
            else
            {
                return null;
            }
        }
    }
}