using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace terminus_webapi.Entities
{
    [Table("Properties")]
    public class Property
    {
        [Required]
        [MaxLength(10)]
        [Key]
        public int propertyID { get; set; }

        [MaxLength(500)]
        public string propertyDesc { get; set; }

        [MaxLength(100)]
        public string propertyType { get; set; }

        public int floor { get; set; }

        public decimal size { get; set; }

        public decimal rateBySize { get; set; }

        public decimal rate { get; set; }

        public decimal associationRateBySize { get; set; }

        public decimal associationRate { get; set; }

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
