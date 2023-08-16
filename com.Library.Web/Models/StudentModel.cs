using System.ComponentModel.DataAnnotations.Schema;

namespace com.Library.Web.Models
{
    [Table("STUDENT")]
    public class StudentModel
    {
        public int Id { get; set; }
        [Column("NAME")]
        public string Name { get; set; }
        public string Faculty { get; set; }
        public string Semester { get; set; }
        [Column("CONTACT_NO")]
        public string ContactNo { get; set; }
        public string Address { get; set; }
        public string FatherName { get; set; }
        public bool IsActive { get; set; }
        public DateTime LastRenewDate { get; set; }
    }
}
