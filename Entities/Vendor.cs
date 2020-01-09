using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace terminus_webapi.Entities
{
    [Table("Vendors")]
    public class Vendor
    {
        [Required]
        [Key]
        public int vendorID { get; set; }

        [MaxLength(1000)]
        public string vendorName { get; set; }

        [MaxLength(1000)]
        public string description { get; set; }

        [MaxLength(1000)]
        public string address { get; set; }

        [MaxLength(20)]
        public string contactNo1 { get; set; }

        [MaxLength(20)]
        public string contactNo2 { get; set; }

        [MaxLength(20)]
        public string contactNo3 { get; set; }

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
