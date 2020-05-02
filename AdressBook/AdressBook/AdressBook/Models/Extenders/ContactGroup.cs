using NPoco;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;

namespace AdressBook.Models
{
    public partial class ContactGroup
    {
        private IDatabase db = new Database("myConnectionString");
        public IEnumerable<ContactGroup> GetById(int id)
        {
            IEnumerable<ContactGroup> contactGroups = db.Query<ContactGroup>().Where(x => x.Id == id).ToList();

            return contactGroups;
        }

        public IEnumerable<ContactGroup> GetAll()
        {
            IEnumerable<ContactGroup> contactGroups = db.Query<ContactGroup>().ToList().OrderBy(x => x.Name);

            return contactGroups;
        }

        public bool UpdateContactGroup(ContactGroup contactGroup)
        {
            int isUpdated;
            var dbcontactGroup = db.SingleById<ContactGroup>(contactGroup.Id);

            var snapshot = db.StartSnapshot(dbcontactGroup);

            dbcontactGroup.Name = contactGroup.Name;
            dbcontactGroup.Description = contactGroup.Description;

            isUpdated = db.Update(dbcontactGroup, snapshot.UpdatedColumns());

            if (isUpdated > 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public bool InsertContactGroup(ContactGroup contactGroup)
        {
            ContactGroup dbcontactGroup = new ContactGroup()
            {
                Name = contactGroup.Name,

                Description = contactGroup.Description,
            };

            db.Save(dbcontactGroup);

            //if (isUpdated > 0)
            //{
            return true;
            //}
            //else
            //{
            //    return false;
            //}

        }

        public bool DeleteContactGroup(ContactGroup contactGroup)
        {
            int isDeleted;
            var dbcontactGroup = db.SingleById<ContactGroup>(contactGroup.Id);
            isDeleted = db.Delete(dbcontactGroup);

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