using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entiteti
{
    public class Obavijest
    {
        private const char DEL = '|';
        public string Naslov { get; set; }
        public string Opis { get; set; }
        public Osoba Autor { get; set; }
        public DateTime DatumObjave { get; set; }
        public DateTime DatumIsteka { get; set; }


        public override string ToString()
        {
            return $"{Naslov}";
        }

        public override bool Equals(object? obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public string FormatForFileLine() => $"{Naslov}{DEL}{Opis}{DEL}{Autor.FormatForFileLine()}{DEL}{DatumObjave.ToString("dd.MM.yyyy")}{DEL}{DatumIsteka.ToString("dd.MM.yyyy")}";
        public static Obavijest ParseFromFileLine(string line)
        {
            string[] details = line.Split(DEL);
            return new Obavijest()
            {
                Naslov = details[0],
                Opis = details[1],
                Autor = new Osoba
                {
                    Ime= details[2],
                    Prezime= details[3],
                    Email= details[4],
                    Lozinka= details[5],
                    JeAdmin = bool.Parse(details[6])
                },
                DatumObjave = DateTime.Parse(details[7]),
                DatumIsteka = DateTime.Parse(details[8])
            };
        }
    }
}
