using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CassandraDataLayer.QueryEntities
{
    public class Fizicka_aktivnost
    {
        public string jmbg { get; set; }
        public string tip_aktivnosti { get; set; }
        public string predjeni_km { get; set; }
       
        public string datum { get; set; }
        public string vreme { get; set; }
    }
}
