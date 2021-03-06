﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebAPI.Enumerations;

namespace WebAPI.Models
{
    public class Korisnici
    {
        public static List<Korisnik> Musterije { get; set; }
        public static List<Korisnik> Dispeceri { get; set; }
        public static List<Korisnik> Vozaci { get; set; }

        public static void Create()
        {
            Musterije = new List<Korisnik>();
            Dispeceri = new List<Korisnik>();
            Vozaci = new List<Korisnik>();

            Musterije.Add(new Musterija("musterija", "123", "Mušterija", "Mušterić", Enumerations.Pol.Zenski, "0365995931198", "+381654009687", "musterija@yahoo.com", Enumerations.Uloga.Musterija));

            string[] lines = System.IO.File.ReadAllLines(@"E:\FAX\III godina\2. semestar\Web programiranje [6 ESPB]\projekat\WP1718-PR87-2015\WebAPI_AJAX\WebAPI\WebAPI\dispeceri.txt");

            Pol p;

            if (lines[4].Equals("Muski"))
            {
                p = Pol.Muski;
            }
            else
                p = Pol.Zenski;

            Dispeceri.Add(new Dispecer(lines[0], lines[1], lines[2], lines[3], p, lines[5], lines[6], lines[7], Uloga.Dispecer));
        }
    }
}