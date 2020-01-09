using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace terminus_webapi.Entities
{
    [Table("TenantProperties")]
    public class TenantProperty
    {

        [Required]
        [Key]
        public int tenantPropertyID { get; set; }

        [Required]
        public string tenantPropertyCode { get; set; }
        [Required]
        public int tenantID { get; set; }

        [Required]
        public int propertyID { get; set; }

        [DataType(DataType.Date)]
        public DateTime OwnershipStartDate { get; set; }

        [MaxLength(100)]
        public string formula { get; set; }

        public decimal dueAmount { get; set; }

        [MaxLength(100)]
        public string dueType { get; set; }

        [DataType(DataType.Date)]
        public DateTime dueDate { get; set; }

        [MaxLength(100)]
        public string assoFormula { get; set; }
        public decimal assoDueAmount { get; set; }

        [MaxLength(100)]
        public string assoDueType { get; set; }

        [DataType(DataType.Date)]
        public DateTime assoDueDate { get; set; }

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
