using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WDCheWei_task10
{
    class Opiskelijat
    {
        //Attributes
        public string Name { get; set; }
        public string Address { get; set; }
        public DateTime DateOfBirth { get; set; }
        //Constructors
        public Opiskelijat(string nimi, string osoite, DateTime syntymapaiva)
        {
            Name = nimi;
            Address = osoite;
            DateOfBirth = syntymapaiva;
        }
        public override string ToString()
        {
            return "Name: " + Name + " Address: " + Address + " Date of birth: " + DateOfBirth.ToShortDateString();
        }
    }
}
