using NPoco;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Runtime.CompilerServices;

namespace AdressBook.Models
{
    public partial class PhoneNumber
    {
        private IDatabase db = new Database("myConnectionString");

        public IEnumerable<PhoneNumber> GetById(int id)
        {
            IEnumerable<PhoneNumber> phoneNumber = db.Query<PhoneNumber>().Where(x => x.Id == id).ToList();

            return phoneNumber;
        }

        public IEnumerable<PhoneNumber> GetAllByContactId(int contactId)
        {
            IEnumerable<PhoneNumber> numbers = db.Query<PhoneNumber>().ToList().Where(x =>x.ContactId == contactId);

            return numbers;
        }

        public bool UpdatePhoneNumber(PhoneNumber phoneNumber)
        {
            int isUpdated;
            var dbPhoneNumber = db.SingleById<PhoneNumber>(phoneNumber.Id);

            var snapshot = db.StartSnapshot(dbPhoneNumber);

            dbPhoneNumber.Number = phoneNumber.Number;
            dbPhoneNumber.DefaultNumber = phoneNumber.DefaultNumber;

            isUpdated = db.Update(dbPhoneNumber, snapshot.UpdatedColumns());        

            if (isUpdated > 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public bool InserthoneNumber(PhoneNumber phoneNumber)
        {
            PhoneNumber dbPhoneNumber = new PhoneNumber()
            {
                Number = phoneNumber.Number,

                DefaultNumber = phoneNumber.DefaultNumber,
            };

            db.Save(dbPhoneNumber);

            //if (isUpdated > 0)
            //{
                return true;
            //}
            //else
            //{
            //    return false;
            //}

        }

        public bool DeletePhoneNumber(PhoneNumber phoneNumber)
        {
            int isDeleted;
            var dbPhoneNumber = db.SingleById<PhoneNumber>(phoneNumber.Id);
            isDeleted = db.Delete(dbPhoneNumber);

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