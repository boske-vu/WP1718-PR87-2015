﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebAPI.Enumerations;

namespace WebAPI.Models
{
    public class Korisnik
    {
        public string KorisnickoIme{ get; set; }
        public string Lozinka { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public Pol Pol { get; set; }
        public string Jmbg { get; set; }
        public string KontaktTelefon { get; set; }
        public string Email { get; set; }
        public Uloga Uloga { get; set; }
        public List<Voznja> Voznje { get; set; }
    }
}