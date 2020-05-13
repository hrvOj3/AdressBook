using NPoco;
using System.Collections.Generic;
using System.Linq;

namespace AdressBook.Models
{
    public partial class ContactPhoneNumber
    {
        private static readonly NLog.Logger Logger = NLog.LogManager.GetCurrentClassLogger();
        public static IEnumerable<ContactPhoneNumber> GetById(int id)
        {
            try
            {
                IDatabase db = new Database("myConnectionString");
                IEnumerable<ContactPhoneNumber> phoneNumber = db.Query<ContactPhoneNumber>().Where(x => x.Id == id).ToList();
                return phoneNumber;
            }
            catch (System.Exception ex)
            {
                Logger.Error(ex);
                return null;
            }
        }

        public static IEnumerable<ContactPhoneNumber> GetAllByContactId(int contactId)
        {
            try
            {
                IDatabase db = new Database("myConnectionString");
                IEnumerable<ContactPhoneNumber> numbers = db.Query<ContactPhoneNumber>().Where(x => x.ContactId == contactId).ToList();
                return numbers;
            }
            catch (System.Exception ex)
            {
                Logger.Error(ex);
                return null;
            }
        }

        public static bool InsertOrUpdatePhoneNumber(ContactPhoneNumber phoneNumber)
        {
            try
            {
                IDatabase db = new Database("myConnectionString");
                ContactPhoneNumber dbPhoneNumber = new ContactPhoneNumber()
                {
                    PhoneNumber = phoneNumber.PhoneNumber,

                    DefaultNumber = phoneNumber.DefaultNumber,
                };

                db.Save(dbPhoneNumber);
                return true;
            }
            catch (System.Exception ex)
            {
                Logger.Error(ex);
                return false;
            }
        }

        public static bool DeletePhoneNumber(ContactPhoneNumber phoneNumber)
        {
            try
            {
                IDatabase db = new Database("myConnectionString");
                int isDeleted;
                var dbPhoneNumber = db.SingleById<ContactPhoneNumber>(phoneNumber.Id);
                isDeleted = db.Delete(dbPhoneNumber);
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