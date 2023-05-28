using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entiteti
{
    public class Kolegij
    {
        private const char DEL = '|';
        public string Naziv { get; set; } = "";
        public string Sifra { get; set; } = "";
        public Osoba Predavac { get; set; }
        public override string ToString()
        {
            return $"{Naziv}";
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override bool Equals(object? obj)
        {
            return base.Equals(obj);
        }
        public string FormatForFileLine()
        {
            if (Predavac == null)
            {
                return $"{Naziv}{DEL}{Sifra}";
            }
            else
            {
                return $"{Naziv}{DEL}{Sifra}{DEL}{Predavac.FormatForFileLine()}";
            }
        } 
        public static Kolegij ParseFromFileLine(string line)
        {
            string[] details = line.Split(DEL);
            if (details.Length < 3)
            {
                return new Kolegij()
                {
                    Naziv = details[0],
                    Sifra = details[1],
                };
            }
            else
            {
                return new Kolegij()
                {
                    Naziv = details[0],
                    Sifra = details[1],
                    Predavac = new Osoba
                    {
                        Ime = details[2],
                        Prezime = details[3],
                        Email = details[4],
                        Lozinka = details[5],
                        JeAdmin = bool.Parse(details[6])
                    } 
                };
            }
            
        }
    }
}
