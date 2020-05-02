using NPoco;

namespace AdressBook.Models
{
    [TableName(tableName: "Contacts")]
    public partial class Contacts
    {
        [Column]
        private int Id { get; set; }
        [Column]
        public string Title { get; set; }
        [Column]
        public string Name { get; set; }
        [Column]
        public string Email { get; set; }
        [Column]
        public int UserId { get; set; }
        [Column]
        public int PhoneNumberId { get; set; }
        [Column]
        public int ContactGroupId { get; set; }
    }
}