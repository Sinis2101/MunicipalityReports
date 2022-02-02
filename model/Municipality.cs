using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MunicipalityReports.model
{
    public class Municipality
    {
        public String depID { get; set; }
        public String munID { get; set; }
        public String depName { get; set; }
        public String munName { get; set; }
        public String type { get; set; }

        public Municipality(String depID, String munID, String depName, String munName, String type)
        {
            this.depID = depID;
            this.munID = munID;
            this.depName = depName;
            this.munName = munName;
            this.type = type;
        }
    }

}
