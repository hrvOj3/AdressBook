using NPoco;

namespace AdressBook.Models
{
    [TableName("dbo.PhoneNumber")]
    [PrimaryKey("Id")]
    public partial class ContactPhoneNumber
    {      
        private int Id { get; set; }

        public string PhoneNumber { get; set; }

        public int DefaultNumber { get; set; }

        public int ContactId { get; set; }
    }
}