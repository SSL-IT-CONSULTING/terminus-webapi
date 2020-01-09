using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace terminus_webapi.Entities
{
    [Table("Expenses")]
    public class Expense
    {
        [Required]
        [Key]
        public int expensesID { get; set; }

        [Required]
        [MaxLength(50)]
        public string expenseCode { get; set; }

        [MaxLength(1000)]
        public string description { get; set; }

        [MaxLength(1000)]
        public string accountTitle { get; set; }

        [MaxLength(100)]
        public string gLCode { get; set; }

        [MaxLength(50)]
        public string createdBy { get; set; }

        public DateTime createDate { get; set; }

        [MaxLength(20)]
        public string updatedBy { get; set; }

        public DateTime updateDate { get; set; }

        [MaxLength(1)]
        public string deleteSw { get; set; }
    }
}
