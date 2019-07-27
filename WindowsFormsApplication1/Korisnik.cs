using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    public class Korisnik
    {

        private string ime, prezime, username, lozinka;
        private int krediti;
        public string Ime { set { ime = value; } get { return ime; } }
        public string Prezime { set { prezime = value; } get { return prezime; } }
        public string Username { set { username = value; } get { return username; } }
        public string Lozinka { set { lozinka = value; } get { return lozinka; } }
        public int Krediti { set { krediti = value; } get { return krediti; } }


    }
    
}
