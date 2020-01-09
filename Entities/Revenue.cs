using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace terminus_webapi.Entities
{
    [Table("Revenues")]

    public class Revenue
    {
        [Required]
        [Key]
        public int revenuesID { get; set; }

        [Required]
        public string revenueCode { get; set; }

        [MaxLength(1000)]
        public string description { get; set; }

        [MaxLength(1000)]
        public string accountTitle { get; set; }

        [MaxLength(100)]
        public string gLCode { get; set; }

        [MaxLength(50)]
        public string createdBy { get; set; }

        [DataType(DataType.Date)]
        public DateTime createDate { get; set; }

        [MaxLength(20)]
        public string updatedBy { get; set; }

        [DataType(DataType.Date)]
        public DateTime updateDate { get; set; }

        [MaxLength(1)]
        public string deleteSw { get; set; }
    }
}
