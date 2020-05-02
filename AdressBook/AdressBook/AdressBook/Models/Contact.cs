using NPoco;

namespace AdressBook.Models
{
    [TableName(tableName: "Contacts")]
    public partial class Contact
    {
        [Column]
        public int Id { get; set; }
        [Column]
        public string Title { get; set; }
        [Column]
        public string Name { get; set; }
        [Column]
        public string Surname { get; set; }
        [Column]
        public string Organization { get; set; }
        [Column]
        public string Email { get; set; }
        [Column]
        public int UserId { get; set; }
    }
}