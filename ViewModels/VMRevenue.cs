using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace terminus_webapi.ViewModels
{
    public class VMRevenue
    {

        public int revenuesID { get; set; }

        public string revenueCode { get; set; }

        public string description { get; set; }

        public string accountTitle { get; set; }

        public string gLCode { get; set; }

        public string createdBy { get; set; }

        public DateTime createDate { get; set; }

        public string updatedBy { get; set; }

        public DateTime updateDate { get; set; }

        public string deleteSw { get; set; }
    }
}
