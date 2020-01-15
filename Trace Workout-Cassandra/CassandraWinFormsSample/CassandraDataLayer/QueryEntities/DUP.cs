using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CassandraDataLayer.QueryEntities
{
   public class DUP //dnevni unos pica
    {
        public string datum { get; set; }
        public string vrsta_pica { get; set; }
        public string jmbg { get; set; }
        public string kalorijska_vrednost { get; set; }
    }
}
