using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace terminus_webapi.Entities
{
    [Table("Users")]
    public class User
    {
        [Required]
        [Key]
        public int usersID { get; set; }

        [Required]
        [MaxLength(100)]
        public string userName { get; set; }

        public int employeeID { get; set; }

        [MaxLength(50)]
        public string lastName { get; set; }

        [MaxLength(50)]
        public string firstName { get; set; }

        [MaxLength(50)]
        public string middleName { get; set; }

        [MaxLength(100)]
        public string title { get; set; }

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
