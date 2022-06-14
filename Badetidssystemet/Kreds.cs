﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Badetidssystemet
{
    class Kreds
    {
        private string _id;
        private string _navn;
        private string _adresse;
        private int _antalDeltagere;

        

        public Kreds(string id, string navn, string adresse, int antalDeltagere)
        {
            _id = id;
            _navn = navn;
            _adresse = adresse;
            _antalDeltagere = antalDeltagere;
            
        }

        public string Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public string Navn
        {
            get { return _navn; }
            set { _navn = value; }
        }
        public string Adresse
        {
            get { return _adresse; }
            set { _adresse = value; }
        }
        public int AntalDeltagere
        {
            get { return _antalDeltagere; }
            set { _antalDeltagere = value; }
        }

        public override string ToString()
        {
          

            return $"ID: {Id}\nNavn: {Navn}\nAdresse: {Adresse}\nAntal Deltagere: {AntalDeltagere}\n";
        }

        
    }
}
