﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPI.Models
{
    public class Lokacija
    {
        public string XKoordinata { get; set; }
        public string YKoordinata { get; set; }
        public Adresa Adresa { get; set; }

        public Lokacija() { }
        public Lokacija(string xKoordinata, string yKoordinata, Adresa adresa)
        {
            XKoordinata = xKoordinata;
            YKoordinata = yKoordinata;
            Adresa = adresa;
        }
    }
}