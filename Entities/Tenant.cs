using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace terminus_webapi.Entities
{
    [Table("Tenants")]
    public class Tenant
    {
        [Key]
        public int id { get; set; }

       [Required]
        [MaxLength(100)] 
        public string lastName { get; set; }

        [Required]
        [MaxLength(100)]
        public string firstName { get; set; }

        [MaxLength(100)]
        public string middleName { get; set; }


    }
}
