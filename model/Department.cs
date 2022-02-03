using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MunicipalityReports.model
{
    public class Department
    {
        public String name { get; set; }

        public int municipalities { get; set; }

        public Department(string name)
        {
            this.name = name;
        }

    }
}
