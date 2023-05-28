using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entiteti
{
    public class Osoba
    {

        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Email { get; set; }
        public string Lozinka { get; set; }
        public bool JeAdmin { get; set; }

        private const char DEL = '|';


        //ToString za ispis u izbornike
        public override string ToString()
        {
            return $"{Ime} {Prezime}";
        }

        public override bool Equals(object? obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public string FormatForFileLine() => $"{Ime}{DEL}{Prezime}{DEL}{Email}{DEL}{Lozinka}{DEL}{JeAdmin}";

        public static Osoba ParseFromFileLine(string line)
        {
            string[] details = line.Split(DEL);
            return new Osoba
            {
                Ime = details[0],
                Prezime = details[1],
                Email = details[2],
                Lozinka = details[3],
                JeAdmin = bool.Parse(details[4])
            };
        }


    }

}

