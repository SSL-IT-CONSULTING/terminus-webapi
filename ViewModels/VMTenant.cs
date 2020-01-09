using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace terminus_webapi.ViewModels
{
    public class VMTenant
    {

        public int TenantID { get; set; }

        public string lastName { get; set; }

        public string firstName { get; set; }

        public string middleName { get; set; }

        public string address1 { get; set; }

        public string address2 { get; set; }

        public string address3 { get; set; }

        public string contactNo1 { get; set; }

        public string contactNo2 { get; set; }

        public string contactNo3 { get; set; }

        public string emailAdd1 { get; set; }
  
        public string emailAdd2 { get; set; }

        public string contactPersonLastName { get; set; }

        public string contactPersonFirstName { get; set; }

        public string contactPersonMiddleName { get; set; }

        public string contactPersonRelationship { get; set; }

        public string contactPersonContactNo { get; set; }

        public string contactPersonEmailAdd { get; set; }

        public string createdBy { get; set; }

        public DateTime createDate { get; set; }

        public string updatedBy { get; set; }

        public DateTime updateDate { get; set; }

        public string deleteSw { get; set; }
    }
}
