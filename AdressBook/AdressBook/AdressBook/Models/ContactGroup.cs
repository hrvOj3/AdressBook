using NPoco;

namespace AdressBook.Models
{
    public partial class ContactGroup
    {
        [Column]
        private int Id { get; set; }

        [Column]
        public string Name { get; set; }

        [Column]
        public string Description { get; set; }

        [Column]
        public int ContactId { get; set; }
    }
}