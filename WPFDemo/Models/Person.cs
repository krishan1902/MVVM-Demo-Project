using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFDemo.Models
{
    public record Person
    {
        //record -> performanter, für DTOs (DataTranferObjects) ausgelegt, halten nur Daten, Attribute
        //          nicht für Methoden
        //init   -> nur für einmalige zuweisen

        public string Vorname { get; init; }
        public string Nachname { get; init; }
        public int Alter {  get; init; }

        public Person(string vorname, string nachname, int alter)
        {
            Vorname = vorname;
            Nachname = nachname;
            Alter = alter;
        }   
    }
}
