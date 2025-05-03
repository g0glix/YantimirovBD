using Supabase.Postgrest.Models;
using Supabase.Postgrest.Attributes;

namespace ЯнтимировБД
{
    [Table("User")]
    public class User : BaseModel
    {
        [PrimaryKey("id")]
        public int Id { get; set; }

        [Column("password")]
        public string Password { get; set; }

        [Column("login")]
        public string Login { get; set; }

        [Column("age")]
        public int Age { get; set; }

    }
}



