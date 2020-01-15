using Cassandra;
using CassandraDataLayer.QueryEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CassandraDataLayer
{
    public static class DataProvider
    {
        #region Korisnik
        public static Korisnik UcitajKorisnika(string jmbg)
        {
            ISession session = SessionManager.GetSession();
            Korisnik korisnik = new Korisnik();

            if (session == null)
                return null;

            Row korisnikData = session.Execute("select * from \"Korisnik\" where \"jmbg\"='1407997735060'").FirstOrDefault();
            if (korisnikData != null)
            {
                korisnik.jmbg = korisnikData["jmbg"] != null ? korisnikData["jmbg"].ToString() : string.Empty;
                korisnik.ime = korisnikData["ime"] != null ? korisnikData["ime"].ToString() : string.Empty;
                korisnik.prezime = korisnikData["prezime"] != null ? korisnikData["prezime"].ToString() : string.Empty;
                korisnik.tezina = korisnikData["tezina"] != null ? korisnikData["tezina"].ToString() : string.Empty;
                korisnik.visina = korisnikData["visina"] != null ? korisnikData["visina"].ToString() : string.Empty;
                korisnik.godine_starosti= korisnikData["godine_starosti"] != null ? korisnikData["godine_starosti"].ToString() : string.Empty;
                korisnik.pol = korisnikData["pol"] != null ? korisnikData["pol"].ToString() : string.Empty;
            }
            return korisnik;
        }
        public static void DodajKorisnika( Korisnik k)
        {
            ISession session = SessionManager.GetSession();

            if (session == null)
                return;

            RowSet korisnikData = session.Execute("insert into \"Korisnik\" (jmbg,ime,prezime,tezina,visina,godine_starosti,pol)  values ('" + k.jmbg+"','"+k.ime+ "','" + k.prezime + "','" + k.tezina+"','"+k.visina+"''"+k.visina+"','"+k.godine_starosti+"','"+k.pol+"')");
         
        }

        public static void ObrisiKorisnika(string jmbg)
        {
            ISession session = SessionManager.GetSession();

            if (session == null)
                return;

            RowSet korisnikData = session.Execute("delete from \"Korisnik\"where jmbg = '" + jmbg + "'");
            
        }
        
        //public static double IzracunajBMI(double visina, double tezina)
        //{
        //    double BMI = tezina / (visina * visina);
        //    return BMI;
            
        //}

        #endregion
        #region DUH
        public static DUH UcitajDuh(string datum, string jmbg)
        {
            ISession session = SessionManager.GetSession();
            DUH duh = new DUH();

            if (session == null)
                return null;

            Row duhData = session.Execute("select * from \"Duh\" where \"datum\"='" + datum + "' and \"jmbg\"='" + jmbg + "'").FirstOrDefault();

            if (duhData != null)
            {
              
                duh.datum = duhData["datum"] != null ? duhData["datum"].ToString() : string.Empty;
                duh.jmbg= duhData["jmbg"] != null ? duhData["jmbg"].ToString() : string.Empty;
               
                duh.jmbg = duhData["namirnica"] != null ? duhData["namirnica"].ToString() : string.Empty;
                duh.kalorijska_vrednost_namirnice =  duhData["kalorijska_vrednost_namirnice"] != null ? duhData["kalorijska_vrednost_namirnice"].ToString() : string.Empty;
                duh.obrok = duhData["obrok"] != null ? duhData["obrok"].ToString() : string.Empty;
             }

            return duh;
        }


        public static List<DUH> UzmiSveDuh()
        {
            ISession session = SessionManager.GetSession();
            List<DUH> duhs = new List<DUH>();

            if (session == null)
                return null;

            var duhData = session.Execute("select * from \"Dnevni_unos_hrane\"");

            foreach (var duhdata in duhData)
            {
                DUH duh = new DUH();
                duh.datum = duhdata["datum"] != null ? duhdata["datum"].ToString() : string.Empty;
                duh.jmbg = duhdata["jmbg"] != null ? duhdata["jmbg"].ToString() : string.Empty;
              
                duh.jmbg = duhdata["namirnica"] != null ? duhdata["namirnica"].ToString() : string.Empty;
                duh.kalorijska_vrednost_namirnice = duhdata["kalorijska_vrednost_namirnice"] != null ? duhdata["kalorijska_vrednost_namirnice"].ToString() : string.Empty;
                duh.obrok = duhdata["obrok"] != null ? duhdata["obrok"].ToString() : string.Empty;


                duhs.Add(duh);
            }

            return duhs;
        }
       

        public static void DodajDUH(DUH d)
        {
            ISession session = SessionManager.GetSession();

            if (session == null)
                return;

            RowSet duhData = session.Execute("insert into \"Dnevni_unos_hrane\"(jmbg, datum, namirnica, kalorijska_vrednost_namirnice, obrok) values ('" +d.jmbg + "', '" + d.datum + "',  '"+d.namirnica+"', '"+d.kalorijska_vrednost_namirnice+"', '"+d.obrok+"')");
          
        }

        public static void IzbrisiDUH( string jmbg)
        {
            ISession session = SessionManager.GetSession();

            if (session == null)
                return;

            RowSet duhData = session.Execute("delete from \"Dnevni_unos_hrane\" where jmbg= '" + jmbg + "'");

        }
        #endregion
        #region Fizicka_aktivnost

        public static Fizicka_aktivnost UcitajjFA(string jmbg)
        {
            ISession session = SessionManager.GetSession();
            Fizicka_aktivnost fa = new Fizicka_aktivnost();

            if (session == null)
                return null;

            Row faData = session.Execute("select * from \"Fizicka_altivnost\" where jmbg='" + jmbg + "'").FirstOrDefault();

            if (faData != null)
            {
                fa.jmbg = faData["jmbg"] != null ? faData["jmbg"].ToString() : string.Empty;
                fa.tip_aktivnosti = faData["tip_aktivnosti"] != null ? faData["tip_aktivnosti"].ToString() : string.Empty;
                fa.predjeni_km = faData["predjeni_km"] != null ? faData["predjeni_km"].ToString() : string.Empty;
                fa.datum = faData["datum"] != null ? faData["datum"].ToString() : string.Empty;
                fa.vreme = faData["vreme"] != null ? faData["vreme"].ToString() : string.Empty;
            }

            return fa;
        }

        public static List<Fizicka_aktivnost> UcitajSve()
        {
            ISession session = SessionManager.GetSession();
            List<Fizicka_aktivnost> fa = new List<Fizicka_aktivnost>();

            if (session == null)
                return null;

            var faData = session.Execute("select * from \"Fizicka_aktivnost\"");


            foreach (var row in faData)
            {
                Fizicka_aktivnost faa = new Fizicka_aktivnost();
                faa.jmbg = row["jmbg"] != null ? row["jmbg"].ToString() : string.Empty;

                faa.tip_aktivnosti = row["tip_aktivnosti"] != null ? row["tip_aktivnosti"].ToString() : string.Empty;
                faa.predjeni_km = row["predjeni_km"] != null ? row["predjeni_km"].ToString() : string.Empty;
                faa.datum = row["datum"] != null ? row["datum"].ToString() : string.Empty;
                faa.vreme = row["vreme"] != null ? row["vreme"].ToString() : string.Empty;

                fa.Add(faa);
            }


            return fa;
        }

        public static void DodajFA(Fizicka_aktivnost fizAk)
        {
            ISession session = SessionManager.GetSession();

            if (session == null)
                return;

            RowSet faData = session.Execute("insert into \"Fizicka_aktivnost\"(jmbg,datum, predjeni_km, tip_aktivnosti, vreme) values ('" +fizAk.jmbg + "', '"+fizAk.datum+"', '"+fizAk.predjeni_km+"', '"+fizAk.tip_aktivnosti+"', '"+fizAk.vreme+"')");
           
        }

        public static void ObrisiFA(string jmbg)
        {
            ISession session = SessionManager.GetSession();

            if (session == null)
                return;

            RowSet faData = session.Execute("delete from \"Fizicka_aktivnost\" where jmbg = '" + jmbg + "'");

            

        }

        #endregion 
        #region DUP
        public static DUP UcitajDUP(string jmbg)
        {
            ISession session = SessionManager.GetSession();
            DUP dup = new DUP();

            if (session == null)
                return null;

            Row dupData = session.Execute("select * from \"Dnevni_unos_pica\" where \"jmbg\"='1407997735060'").FirstOrDefault();
            if (dupData != null)
            {
                dup.jmbg =dupData["jmbg"] != null ? dupData["jmbg"].ToString() : string.Empty;
               
                dup.datum = dupData["prezime"] != null ? dupData["datum"].ToString() : string.Empty;
                dup.vrsta_pica = dupData["vrsta_pica"] != null ? dupData["vrsta_pica"].ToString() : string.Empty;
                dup.kalorijska_vrednost = dupData["kalorijska_vrednost"] != null ? dupData["kalorijska_vrednost"].ToString() : string.Empty;
              
            }
            return dup;
        }
        public static void DodajDup(DUP k)
        {
            ISession session = SessionManager.GetSession();

            if (session == null)
                return;

            RowSet dupData = session.Execute("insert into \"Dnevni_unos_pica\" (jmbg,datum,vrsta_pica,kalorijska_vrednost)  values ('" + k.jmbg + "','" + k.datum + "','" + k.vrsta_pica + "','" + k.kalorijska_vrednost + "')");

        }

        public static void ObrisiDup(string jmbg)
        {
            ISession session = SessionManager.GetSession();
            DUP dup = new DUP();

            if (session == null)
                return;
            

            RowSet DUPData = session.Execute("delete from \"Dnevni_unos_pica\" where jmbg = '" + jmbg + "'");

        }
        public static List<DUP> UzmiSveDup()
        {
            ISession session = SessionManager.GetSession();
            List<DUP> dups = new List<DUP>();

            if (session == null)
                return null;

            var dupData = session.Execute("select * from \"Dnevni_unos_pica\"");

            foreach (var row in dupData)
            {
                DUP dup = new DUP();
               
                dup.datum = row["datum"] != null ? row["datum"].ToString() : string.Empty;
                dup.jmbg = row["jmbg"] != null ? row["jmbg"].ToString() : string.Empty;
               
                
                dup.kalorijska_vrednost= row["kalorijska_vrednost"] != null ? row["kalorijska_vrednost"].ToString() : string.Empty;
                dup.vrsta_pica = row["vrsta_pica"] != null ? row["vrsta_pica"].ToString() : string.Empty;


                dups.Add(dup);
            }

            return dups;
        }


        #endregion
      
    }
}
