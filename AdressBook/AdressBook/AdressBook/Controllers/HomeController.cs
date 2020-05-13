
using System.Web.Mvc;

namespace AdressBook.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AllContacts()
        {
            ViewBag.Message = "All contacts page.";

            return View("AllContacts");
        }

        public ActionResult AllGroups()
        {
            ViewBag.Message = "All  contact groups page.";

            return View("AllGroups");
        }

        public ActionResult NewContact()
        {
            ViewBag.Message = "New contact Page.";

            return View("NewContact");
        }

        public ActionResult NewGroup()
        {
            ViewBag.Message = "New contact group Page.";

            return View("NewGroup");
        }

        
    }
}