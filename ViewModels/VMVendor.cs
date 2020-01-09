using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace terminus_webapi.ViewModels
{
    public class VMVendor
    {

        public int vendorID { get; set; }
        public string vendorName { get; set; }
        public string description { get; set; }
        public string address { get; set; }
        public string contactNo1 { get; set; }
        public string contactNo2 { get; set; }
        public string contactNo3 { get; set; }
        public string createdBy { get; set; }
        public DateTime createDate { get; set; }
        public string updatedBy { get; set; }
        public DateTime updateDate { get; set; }
        public string deleteSw { get; set; }

    }
}
