using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace terminus_webapi.ViewModels
{
    public class VMTenantProperty
    {
        public int tenantPropertyID { get; set; }

        public string tenantPropertyCode { get; set; }

        public int tenantID { get; set; }

        public int propertyID { get; set; }

        public DateTime OwnershipStartDate { get; set; }

        public string formula { get; set; }

        public decimal dueAmount { get; set; }

        public string dueType { get; set; }

        public DateTime dueDate { get; set; }

        public string assoFormula { get; set; }
        public decimal assoDueAmount { get; set; }

        public string assoDueType { get; set; }

        public DateTime assoDueDate { get; set; }

        public string createdBy { get; set; }

        public DateTime createDate { get; set; }

        public string updatedBy { get; set; }

        public DateTime updateDate { get; set; }

        public string deleteSw { get; set; }
    }
}
