using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CassandraDataLayer.QueryEntities
{
  public  class DUH //dnevni unos hrane
    {
        public string datum { get; set; }
       
        public string namirnica { get; set; }
        public string kalorijska_vrednost_namirnice { get; set; }
        public string obrok { get; set; }
        public string jmbg { get; set; }

    }
}
