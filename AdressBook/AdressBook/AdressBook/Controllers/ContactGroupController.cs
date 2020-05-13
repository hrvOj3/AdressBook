
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
        public HttpResponseMessage GetAllGroups()
        {
            IEnumerable<ContactGroup> contactGroups = ContactGroup.GetAll();

            if (contactGroups.Count() == 0)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest); ;
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.OK);
            }
        }

        [HttpPost]
        [Route("savegroup")]
        public HttpResponseMessage SaveGroup(ContactGroup contactGroup)
        {
            var isSaved = contactGroup.InsertOrUpdateContactGroup(contactGroup);

            if (isSaved)
            {
                return Request.CreateResponse(HttpStatusCode.OK); ;
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest);
            }
        }

        [HttpPost]
        [Route("deletegroup")]
        public HttpResponseMessage DeleteGroup(ContactGroup contactGroup)
        {
            var isDeleted = contactGroup.DeleteContactGroup(contactGroup);

            if (isDeleted)
            {
                return Request.CreateResponse(HttpStatusCode.OK); ;
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest);
            }
        }
    }
}