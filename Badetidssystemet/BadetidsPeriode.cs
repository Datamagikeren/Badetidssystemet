using System;
using System.Collections.Generic;
using System.Text;

namespace Badetidssystemet
{
    class BadetidsPeriode
    {
        
        private string _type;
        private DayOfWeek _ugeDag;
        private DateTime _startTidspunkt;
        private DateTime _slutTidspunkt;
        public Dictionary<string, Kreds> Kredse = new Dictionary<string, Kreds>();

        public BadetidsPeriode(string type, DayOfWeek ugeDag, DateTime starttidspunkt, DateTime sluttidspunkt)
        {
            _type = type;
            _ugeDag = ugeDag;
            _startTidspunkt = starttidspunkt;
            _slutTidspunkt = sluttidspunkt;
            Kredse = new Dictionary<string, Kreds>();
        }

        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }
        public DayOfWeek UgeDag
        {
            get { return _ugeDag; }
            set { _ugeDag = value; }
        }
        public DateTime StartTidspunkt
        {
            get { return _startTidspunkt; }
            set { _startTidspunkt = value; }
        }
        public DateTime SlutTidspunkt
        {
            get { return _slutTidspunkt; }
            set { _slutTidspunkt = value; }
        }

        public override string ToString()
        {
            string StrToReturn = string.Empty;
            foreach (var i in Kredse)
            {

                StrToReturn += i + "\n";

            }
            return $"Type: {Type}\nUge dag: {UgeDag}\nStarttidspunkt: {StartTidspunkt}\nSluttidspunkt: {SlutTidspunkt}\nListe af kredse:\n{StrToReturn}";
        }
       public void AdderKreds (string id, Kreds kreds)
        {
            Kredse.Add(id, kreds);
        }
        public void SletKreds(string id)
        {
            Kredse.Remove(id);
        }
    }
}
