using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace com.Library.Web.Models
{
    [Table("BOOK_IDENTIFICATION")]
    public class BookIdentificationModel
    {
        [Key, Column("ID")]
        public int Id { get; set; }
        [Column("BOOK_ID")]
        public int BookId { get; set; }
        [Column("SERIAL_NO")]
        public string SN { get; set; }
        [Column("STATUS")]
        public BookStatus Status { get; set; }
    }


    public enum BookStatus
    {
        InLibrary,
        WithMember,
        Lost,

    }
}
