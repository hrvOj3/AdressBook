using AdressBook.Models;
using System;
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
            IEnumerable<Contact> contacts = new List<Contact>();

            try
            {
                contacts = Contact.GetAll();
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }

            return Ok(contacts);
        }

        [HttpGet]
        [Route("lastcontacts/{numofcontacts?}")]
        public IHttpActionResult LastContacts(int numOfContacts)
        {
            IEnumerable<Contact> contacts = new List<Contact>();

            try
            {
                contacts = Contact.GetLatestContacts(numOfContacts);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }

            return Ok(contacts);
        }

        [HttpPost]
        [Route("savecontact")]
        public IHttpActionResult SaveContact(Contact contact)
        {
            try
            {
                foreach (ContactPhoneNumber phoneNumber in contact.PhoneNumbers)
                {
                    ContactPhoneNumber.InsertOrUpdatePhoneNumber(phoneNumber);
                }

                var isSaved = contact.InsertOdUpdateContact(contact);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }

            return Ok();
        }

        [HttpPost]
        [Route("deletecontact")]
        public IHttpActionResult DeleteContact(Contact contact)
        {
            try
            {
                List<ContactPhoneNumber> contactPhoneNumbers = ContactPhoneNumber.GetAllByContactId(contact.Id).ToList();

                foreach (ContactPhoneNumber phoneNumber in contactPhoneNumbers)
                {
                    ContactPhoneNumber.DeletePhoneNumber(phoneNumber);
                }

                var isDeleted = contact.DelteContact(contact);
                        
            }
            catch (Exception ex )
            {
                return InternalServerError(ex); 
            }

            return Ok();
        }
    }
}