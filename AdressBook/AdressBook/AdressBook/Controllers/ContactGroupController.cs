using AdressBook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace AdressBook.Controllers
{
    [RoutePrefix("api/contactgroupapi")]
    public class ContactGroupController : ApiController
    {
        [HttpGet]
        [Route("allgroups")]
        public IHttpActionResult GetAllGroups()
        {
            IEnumerable<ContactGroup> contactGroups = Enumerable.Empty<ContactGroup>();
            try
            {
                contactGroups = ContactGroup.GetAll();
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }

            return Ok(contactGroups);
        }

        [HttpPost]
        [Route("savegroup")]
        public IHttpActionResult SaveGroup(ContactGroup contactGroup)
        {
            try
            {
                var isSaved = contactGroup.InsertOrUpdateContactGroup(contactGroup);               
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }

            return Ok(); ;
        }

        [HttpPost]
        [Route("deletegroup")]
        public IHttpActionResult DeleteGroup(ContactGroup contactGroup)
        {
            try
            {
                var isDeleted = contactGroup.DeleteContactGroup(contactGroup);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }

            return Ok();
        }
    }
}