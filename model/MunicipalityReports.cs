using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MunicipalityReports.model
{
    public class MR
    {

        public List<Municipality> municipalities { get; set; }

        public MR()
        {
            municipalities = new List<Municipality>();
        }

        public void addMunicipality(String line)
        {
            String[] lineData = line.Split(',');
            Municipality m = new Municipality(lineData[0], lineData[1], lineData[2], lineData[3], lineData[4]);
            municipalities.Add(m);
        }

    }
}
