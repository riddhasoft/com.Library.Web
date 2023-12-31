﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace com.Library.Web.Models
{
    [Table("BOOK_IN_OUT_HISTORY")]
    public class BookInOutHistoryModel
    {
        [Key, Column("ID")]
        public int Id { get; set; }
        [Column("BOOK_IDENTIFICATION_ID")]

        public int BookIdentificationId { get; set; }
        /// <summary>
        /// Logged in User
        /// Add this id in identity after login
        /// </summary>
        [Column("USER_ID")]
        public int UserId { get; set; }
        /// <summary>
        /// member id (student)
        /// </summary>
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
