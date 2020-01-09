using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace terminus_webapi.ViewModels
{
    public class VMUser
    {

        public int usersID { get; set; }

        public string userName { get; set; }

        public int employeeID { get; set; }

        public string lastName { get; set; }

        public string firstName { get; set; }

        public string middleName { get; set; }

        public string title { get; set; }

        public string createdBy { get; set; }

        public DateTime createDate { get; set; }

        public string updatedBy { get; set; }


        public DateTime updateDate { get; set; }

        public string deleteSw { get; set; }
    }

}
