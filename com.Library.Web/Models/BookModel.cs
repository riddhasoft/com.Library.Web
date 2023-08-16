using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace com.Library.Web.Models
{
    [Table("BOOK")]
    public class BookModel
    {
        [Key, Column("ID")]
        public int Id { get; set; }
        [Column("TITLE", TypeName = "VARCHAR(50)")]
        public string Title { get; set; }
        
        [Column("AUTHOR", TypeName = "VARCHAR(50)")]
        public string Author { get; set; }
        [Column("DESCRIPTION", TypeName = "VARCHAR(250)")]
        public string? Description { get; set; }
        [Column("EDITION", TypeName = "VARCHAR(50)")]
        public string? Edition { get; set; }
        [Column("YEAR", TypeName = "int")]
        public int? Year { get; set; }
        [Column("ISBN", TypeName = "VARCHAR(50)")]
        public string? ISBN { get; set; }
    }
}
