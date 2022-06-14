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
            try
            {
                
                if (_startTidspunkt >= _slutTidspunkt)
                {
                    
                    throw new ArgumentException();
                }
            }
            catch (ArgumentException)
            {
                
                Console.WriteLine($"Fejl fundet på: {_type}: Starttidspunkt må ikke være senere end sluttidspunkt!");
            }
            try
            {
                if (_type.Length < 4)
                {
                    throw new ArgumentException();
                }
            }
            catch (ArgumentException)
            {
                Console.WriteLine($"Fejl fundet på {_type}: Type skal være mere end 4 bogstaver!");
            }

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
            set {  _startTidspunkt = value;  }
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
       public virtual void AdderKreds (string id, Kreds kreds)
        {
            Kredse.Add(id, kreds);
        }
        public virtual void SletKreds(string id)
        {
            Kredse.Remove(id);
        }
        
    }
}
