using NPoco;
using System;

namespace AdressBook.Models
{
    [TableName ("dbo.Contact")]
    [PrimaryKey("Id")]
    public partial class Contact
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public string Organization { get; set; }

        public string Email { get; set; }

        public DateTime Modified_Datetime { get; set; }
    }
}