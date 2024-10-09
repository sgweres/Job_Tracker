using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobTrackerWinForm
{
    internal class JobApplication
    {
       
        public int applicationNumber { get; set; }
        public string jobTitle { get; set; }
        public string location { get; set; }
        public string status { get; set; }
        public string jobUrl { get; set; }
        public string appCo { get; set; }
        public int coID { get; set; }

        public List<Company> Comps { get; set; }
    }
}
