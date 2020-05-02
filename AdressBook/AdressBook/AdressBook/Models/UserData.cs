using NPoco;

namespace AdressBook.Models
{
    [TableName(tableName: "UserData")]
    public partial class UserData 
    {
        [Column]
        private int Id { get; set; }
        [Column]
        public string UserName { get; set; }
        [Column]
        public string Password { get; set; }

    }
}