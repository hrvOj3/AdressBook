
namespace AdressBook.Controllers
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Net;
    using System.Net.Http;
    using System.Web.Http;
    using AdressBook.Models;

    [RoutePrefix("api/contactgroupapi")]
    public class ContactGroupController : ApiController
    {
        [HttpGet]
        [Route("allgroups")]
        public IHttpActionResult GetAllGroups()
        {
            IEnumerable<ContactGroup> contactGroups = ContactGroup.GetAll();

            if (contactGroups.Count() == 0)
            {
                return NotFound();
            }
            else
            {
                return Ok(contactGroups);
            }
        }

        [HttpPost]
        [Route("savegroup")]
        public IHttpActionResult SaveGroup(ContactGroup contactGroup)
        {
            var isSaved = contactGroup.InsertOrUpdateContactGroup(contactGroup);

            if (isSaved)
            {
                return Ok(); ;
            }
            else
            {
                return NotFound();
            }
        }

        [HttpPost]
        [Route("deletegroup")]
        public IHttpActionResult DeleteGroup(ContactGroup contactGroup)
        {
            var isDeleted = contactGroup.DeleteContactGroup(contactGroup);

            if (isDeleted)
            {
                return Ok(); ;
            }
            else
            {
                return NotFound();
            }
        }
    }
}