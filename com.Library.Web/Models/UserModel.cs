using System.ComponentModel.DataAnnotations.Schema;

namespace com.Library.Web.Models
{
    [Table("USER")]
    public class UserModel
    {

        public int Id { get; set; }
        public string UserName { get; set; }
        public string Fullname { get; set; }
        [Column("CONTACT_NO")]
        public string ContactNo { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
