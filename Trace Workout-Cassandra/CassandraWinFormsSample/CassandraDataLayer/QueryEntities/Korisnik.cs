using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CassandraDataLayer.QueryEntities
{
   public  class Korisnik
    {
        public string ime { get; set; }
        public string prezime { get; set; }
        public string tezina{ get; set; }
        public string visina { get; set; }
        public string  godine_starosti { get; set; }
        public string jmbg { get; set; }
        public string pol { get; set; }

    }
}
