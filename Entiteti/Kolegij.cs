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
            return $"{Naziv}, sifra: {Sifra}";
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override bool Equals(object? obj)
        {
            return base.Equals(obj);
        }
        public string FormatForFileLine() => $"{Naziv}{DEL}{Sifra}";
        public static Kolegij ParseFromFileLine(string line)
        {
            string[] details = line.Split(DEL);
            return new Kolegij()
            {
                Naziv = details[0],
                Sifra = details[1],
            };
        }
    }
}
