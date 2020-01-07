using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace terminus_webapi.Entities
{
    [Table("Companies")]
    public class Company
    {

        [Required]
        [MaxLength(10)]
        [Key]
        public string comapanyId { get; set; }

        [Required]
        [MaxLength(100)]
        public string companyName { get; set; }


    }
    
}
