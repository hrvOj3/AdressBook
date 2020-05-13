using NPoco;
using System.Collections.Generic;

namespace AdressBook.Models
{
    public partial class ContactGroup
    {
        private static readonly NLog.Logger Logger = NLog.LogManager.GetCurrentClassLogger();
        public IEnumerable<ContactGroup> GetById(int id)
        {
            try
            {
                IDatabase db = new Database("myConnectionString");
                IEnumerable<ContactGroup> contactGroups = db.Query<ContactGroup>().Where(x => x.Id == id).ToList();

                return contactGroups;
            }
            catch (System.Exception ex)
            {
                Logger.Error(ex);
                return null;
            }
        }

        public static IEnumerable<ContactGroup> GetAll()
        {
            try
            {
                IDatabase db = new Database("myConnectionString");
                IEnumerable<ContactGroup> contactGroups = db.Query<ContactGroup>().Where(x => x.Name != "").ToList();

                return contactGroups;
            }
            catch (System.Exception ex)
            {
                Logger.Error(ex);
                return null;
            }
        }

        public bool InsertOrUpdateContactGroup(ContactGroup contactGroup)
        {
            try
            {
                IDatabase db = new Database("myConnectionString");
                ContactGroup dbcontactGroup = new ContactGroup()
                {
                    Name = contactGroup.Name,

                    Description = contactGroup.Description,
                };

                db.Save(dbcontactGroup);
                return true;
            }
            catch (System.Exception ex)
            {
                Logger.Error(ex);
                return false;
            }
        }

        public bool DeleteContactGroup(ContactGroup contactGroup)
        {
            try
            {
                IDatabase db = new Database("myConnectionString");
                var dbcontactGroup = db.SingleById<ContactGroup>(contactGroup.Id);
                db.Delete(dbcontactGroup);
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