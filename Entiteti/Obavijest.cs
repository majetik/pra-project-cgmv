using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entiteti
{
    public class Obavijest
    {
        public string Naslov { get; set; }
        public string Opis { get; set; }
        public Osoba Autor { get; set; }
        public DateTime DatumObjave { get; set; }
        public DateTime DatumIsteka { get; set; }

        //mozda nepotrebno
        public override string ToString()
        {
            return $"{Naslov}: {Opis}";
        }

        public override bool Equals(object? obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

    }
}
