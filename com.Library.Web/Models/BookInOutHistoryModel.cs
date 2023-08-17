using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace com.Library.Web.Models
{
    public class BookInOutHistoryModel
    {
        [Key, Column("ID")]
        public int Id { get; set; }
        [Column("BOOK_IDENTIFICATION_ID")]

        public int BookIdentificationId { get; set; }
        [Column("USER_ID")]
        public int UserId { get; set; }
        [Column("ISSUED_TO")]
        public int IssuedTo { get; set; }
        [Column("TRAN_DATE")]
        public int TranDate { get; set; }
        [Column("BOOK_IN_OUT")]
        public BookInOut BookInOut { get; set; }
    }

    public enum BookInOut
    {
        Return,
        Issue,
        Renew
        
    }
}
