using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace terminus_webapi.ViewModels
{
    public class VMTransaction
    {
        public int transactionID { get; set; }

        public string transactionCode { get; set; }

        public DateTime transactionDate { get; set; }

        public string transactionType { get; set; }

        public string accountTitle { get; set; }

        public string vendor { get; set; }

        public decimal amount { get; set; }

        public string modeOfPayment { get; set; }

        public string receiptNo { get; set; }

        public string chequeNo { get; set; }

        public string referenceNo { get; set; }

        public string bank { get; set; }

        public string gLCode { get; set; }

        public DateTime depDate { get; set; }

        public string comment { get; set; }

        public string createdBy { get; set; }

        public DateTime createDate { get; set; }

        public string updatedby { get; set; }

        public DateTime updateDate { get; set; }

        public string deleteSw { get; set; }
    }
}
