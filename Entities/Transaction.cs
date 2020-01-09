using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace terminus_webapi.Entities
{
    [Table("Transactions")]
    public class Transaction
    {
        [Required]
        [Key]
        public int transactionID { get; set; }
        
        [MaxLength(50)]
        public string transactionCode { get; set; }

        [DataType(DataType.Date)]
        public DateTime transactionDate { get; set; }

        [MaxLength(50)]
        public string transactionType { get; set; }

        [MaxLength(100)]
        public string accountTitle { get; set; }

        [MaxLength(100)]
        public string vendor { get; set; }

        public decimal amount { get; set; }

        [MaxLength(100)]
        public string modeOfPayment { get; set; }

        [MaxLength(100)]
        public string receiptNo { get; set; }

        [MaxLength(100)]
        public string chequeNo { get; set; }

        [MaxLength(100)]
        public string referenceNo { get; set; }

        [MaxLength(100)]
        public string bank { get; set; }

        [MaxLength(100)]
        public string gLCode { get; set; }

        [DataType(DataType.Date)]
        public DateTime depDate { get; set; }

        [MaxLength(1000)]
        public string comment { get; set; }

        [MaxLength(50)]
        public string createdBy { get; set; }

        [DataType(DataType.Date)]
        public DateTime createDate { get; set; }

        [MaxLength(50)]
        public string updatedby { get; set; }

        [DataType(DataType.Date)]
        public DateTime updateDate { get; set; }

        [MaxLength(1)]
        public string deleteSw { get; set; }
    }
}
