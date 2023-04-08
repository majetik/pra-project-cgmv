using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entiteti
{
    public class Kolegij
    {
        public string Naziv { get; set; }

        //Sifra string u slucaju da zapocne s "0"
        public string Sifra { get; set; }
        public Osoba Predavac { get; set; }

        //mozda ne treba
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

    }
}
