using NPoco;

namespace AdressBook.Models
{
    [TableName("dbo.ContactGroup")]
    [PrimaryKey("Id")]
    public partial class ContactGroup
    {
        private int Id { get; set; }   

        public string Name { get; set; }

        public string Description { get; set; }
    }
}