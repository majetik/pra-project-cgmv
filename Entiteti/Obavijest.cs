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
        public string Sadrzaj { get; set; }
        public DateTime DatumObjave { get; set; }
        public DateTime DatumIsteka { get; set; }
        public Osoba Autor { get; set; }

        //mozda nepotrebno
        public override string ToString()
        {
            return $"{Naslov}: {Sadrzaj}";
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
