using AdressBook.Models;
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
        public IHttpActionResult GetAllContacts()
        {
            IEnumerable<Contact> contacts = Contact.GetAll();


            if (contacts.Count() == 0)
            {
                return NotFound();
            }

            return Ok(contacts);

        }

        [HttpGet]
        [Route("lastcontacts/{numofcontacts?}")]
        public IHttpActionResult LastContacts(int numOfContacts)
        {
            IEnumerable<Contact> contacts = new List<Contact>();
            contacts = Contact.GetLatestContacts(numOfContacts);

            if (contacts.Count() == 0)
            {
                return NotFound();
            }

            return Ok(contacts);
        }

        [HttpPost]
        [Route("savecontact")]
        public IHttpActionResult SaveContact(Contact contact)
        {
            var isSaved = contact.InsertOdUpdateContact(contact);

            if (isSaved)
            {
                return Ok();
            }
            else
            {
                return NotFound();
            }
        }

        [HttpPost]
        [Route("deletecontact")]
        public IHttpActionResult DeleteContact(Contact contact)
        {
            var isDeleted = contact.DelteContact(contact);

            if (isDeleted)
            {
                return Ok(); 
            }
            else
            {
                return NotFound();
            }
        }
    }
}