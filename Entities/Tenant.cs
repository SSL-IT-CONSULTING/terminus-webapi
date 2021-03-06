﻿using System;
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
        public int TenantID { get; set; }

        [Required]
        [MaxLength(100)] 
        public string lastName { get; set; }

        [Required]
        [MaxLength(100)]
        public string firstName { get; set; }

        [MaxLength(100)]
        public string middleName { get; set; }

        [MaxLength(500)]
        public string address1 { get; set; }

        [MaxLength(500)]
        public string address2 { get; set; }

        [MaxLength(500)]
        public string address3 { get; set; }

        [MaxLength(20)]
        public string contactNo1 { get; set; }

        [MaxLength(20)]
        public string contactNo2 { get; set; }

        [MaxLength(20)]
        public string contactNo3 { get; set; }

        [MaxLength(100)]
        public string emailAdd1 { get; set; }

        [MaxLength(100)]
        public string emailAdd2 { get; set; }

        [MaxLength(50)]
        public string contactPersonLastName { get; set; }

        [MaxLength(50)]
        public string contactPersonFirstName { get; set; }

        [MaxLength(50)]
        public string contactPersonMiddleName { get; set; }

        [MaxLength(50)]
        public string contactPersonRelationship { get; set; }

        [MaxLength(50)]
        public string contactPersonContactNo { get; set; }

        [MaxLength(50)]
        public string contactPersonEmailAdd { get; set; }

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
