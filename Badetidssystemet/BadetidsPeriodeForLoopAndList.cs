using System;
using System.Collections.Generic;
using System.Text;

namespace Badetidssystemet
{
    class BadetidsPeriodeForLoopAndList : BadetidsPeriode
    {

        List<Kreds> _kredseList;
        public BadetidsPeriodeForLoopAndList(string type, DayOfWeek ugeDag, DateTime starttidspunkt, DateTime sluttidspunkt)
            : base(type, ugeDag, starttidspunkt, sluttidspunkt)
        {
            _kredseList = new List<Kreds>();
        }
        public override void AdderKreds(string id, Kreds kreds)
        {
            base.AdderKreds(id, kreds);
        }
        public override void SletKreds(string id)
        {
            base.SletKreds(id);
        }
        public override string ToString()
        {
            string StrToReturn = string.Empty;
            for (int i = 0; i < 0; i++)
            {
                
                foreach (var o in Kredse)
                {

                    StrToReturn += o + "\n";

                }
               
            }
            return $"Type: {Type}\nUge dag: {UgeDag}\nStarttidspunkt: {StartTidspunkt}\nSluttidspunkt: {SlutTidspunkt}\nListe af kredse:\n{StrToReturn}";
        }
    }
}
