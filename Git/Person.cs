using System;
using System.Collections.Generic;
using System.Text;

namespace Git
{
    public class Person
    {
        public string Navn { get; set; }
        public int Alder { get; set; }

        public Person(string navn, int alder)
        {
            Navn = navn;
            Alder = alder;
        }
    }
}
