using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WindowsFormsApplication1
{
    public static class Admin
    {
        public static void UnosKorisnika(string Ime,string Prezime,string Username,string Lozinka,int Krediti)
        {
            Korisnik a = new Korisnik();
            a.Ime = Ime;
            a.Prezime = Prezime;
            a.Username = Username;
            a.Lozinka = Lozinka;
            a.Krediti = Krediti;
            StreamWriter sw = File.AppendText(@"USERS.txt");
            string zapis = a.Ime + "|" + a.Prezime + "|"+a.Username+"|"+ a.Lozinka + "|" + a.Krediti;
            sw.WriteLine(zapis);
            sw.Close();
        }
        public static void UnosFilmova(string naziv,string godina,string zanr,string jezik,string opis,string url1,string url2)
        {
            StreamWriter sw = File.AppendText(@"FILMOVI.txt");
            string zapis = naziv +" . |" + godina + "|" + jezik + "|" + zanr + "|" + opis + "|" + url1 + "|" + url2;
            sw.WriteLine(zapis);
            sw.Close();
        }


        public static void UnosKredita(int Krediti,string Ime,string Prezime,string Username,string Lozinka)
        {
            string a=null,b=null;
            string line;
            StreamReader file=new StreamReader(@"USERS.txt");
            string newstr=null;
            while((line=file.ReadLine())!=null)
            {
                string[] razlomljenalinija=line.Split('|');
                if(razlomljenalinija[2]==Username&&razlomljenalinija[3]==Lozinka)
                {
                    a=razlomljenalinija[2];
                    b=razlomljenalinija[3];
                }
                else{newstr+=line+Environment.NewLine;}
            }
            file.Close();

            if (File.Exists(@"USERS.txt"))
            {

                StreamWriter sw=new StreamWriter("USERS.txt");
                if (a == Username && b == Lozinka)
                {
                    sw.WriteLine(Ime + "|" + Prezime + "|" + Username + "|" + Lozinka + "|" + Krediti);


                    sw.Write(newstr);
                    sw.Close();
                }

            }

        }
    }
}
