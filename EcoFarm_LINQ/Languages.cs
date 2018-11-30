using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoFarm_LINQ
{
    class Languages
    {
        public Languages(string company, string language)
        {
            this.Company = company;
            this.Language = language;
        }

        public string Company { get; set; }
        public string Language { get; set; }
    }
}
