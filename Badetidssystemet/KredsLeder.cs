using System;
using System.Collections.Generic;
using System.Text;

namespace Badetidssystemet
{
    class KredsLeder
    {
        private int _alder;
        private string _navn;
        private string _stjernetegn;
        private bool _erUddannet;

        public KredsLeder(int alder, string navn, string stjernetegn, bool erUddannet)
        {
            _alder = alder;
            _navn = navn;
            _stjernetegn = stjernetegn;
            _erUddannet = erUddannet;
        }

        public int Alder
        {
            get { return _alder; }
            set { _alder = value; }
        }
        public string Navn
        {
            get { return _navn; }
            set { _navn = value; }
        }
         public string Stjernetegn
        {
            get { return _stjernetegn; }
            set { _stjernetegn = value; }
        }
        public bool ErUddannet
        {
            get { return _erUddannet; }
            set { _erUddannet = value; }
        }

        public override string ToString()
        {
            return $"Navn: {Navn} - Alder: {Alder} - Stjernetegn: {Stjernetegn} - Uddannet leder: {ErUddannet}";
        }


    }
}
