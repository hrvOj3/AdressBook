using NPoco;
using System.Collections.Generic;
using System.Configuration;

namespace AdressBook.Models
{
    [TableName(tableName:  "PhoneNumber")]
    public partial class PhoneNumber
    {
        [Column]
        private int Id { get; set; }
        [Column]
        public int Number { get; set; }
        [Column]
        public int DefaultNumber { get; set; }
        [Column]
        public int ContactId { get; set; }
    }
}