using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace terminus_webapi.ViewModels
{
    public class VMProperty
    {

        public int propertyID { get; set; }

        public string propertyDesc { get; set; }

        public string propertyType { get; set; }

        public int floor { get; set; }

        public decimal size { get; set; }

        public decimal rateBySize { get; set; }

        public decimal rate { get; set; }

        public decimal associationRateBySize { get; set; }

        public decimal associationRate { get; set; }

        public string createdBy { get; set; }

        public DateTime createDate { get; set; }

        public string updatedBy { get; set; }

        public DateTime updateDate { get; set; }

        public string deleteSw { get; set; }
        
    }
}
