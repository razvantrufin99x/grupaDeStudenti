using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace grupaDeStudenti
{
    public class student
    {
        public string nume;
        public string prenume;
        public float nota1;
        public student() { }
        public student(string pn, string pp, float n1) {
            this.nume = pn;
            this.prenume = pp;
            this.nota1 = n1;
        }
        public string printstudent()
        { 
            string rez = this.nume + " , " + this.prenume;
            rez += nota1.ToString();

            return rez;
        }
    }
}
