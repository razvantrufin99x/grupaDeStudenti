using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace grupaDeStudenti
{
    public class grupaDeStudenti
    {
        public List<student> studenti = new List<student>();
        public int nrstudenti;
        public int notebune = 0;
        public int integralista = 1;

        public void numarulDeStudenti(int x) { this.nrstudenti = x; }
        public void loadNoteStudenti(ref List<float> notele)
        {
            for (int i = 0; i < notele.Count; i++)
            {
                studenti[i].nota1 = notele[i];
                if (notele[i] < 5) { this.integralista = 0; }
                if (notele[i] >= 8) { notebune += 1; }

            }
        }

        public void calculareDate()
        {
            for (int i = 0; i < studenti.Count; i++)
            {
               
                if (studenti[i].nota1 < 5) { this.integralista = 0; }
                if (studenti[i].nota1  >= 8) { notebune += 1; }

            }
        }
        public void loadNotaStudent(float nota, int idstudent)
        {
            studenti[idstudent].nota1 = nota;
        }
        public void loadNotaStudent(float nota)
        {
            studenti.Add(new student());
            studenti[studenti.Count-1].nota1= nota;
        }

        public bool eIntegralista() {
            if (integralista == 1) { return true; }
            else { return false; }
        }
        public double procentajDeNoteFoarteBune()
        { 
            return (double)notebune / (double)nrstudenti;
        }
        public void printStudenti(ref string rez)
        {

            for (int i = 0; i < studenti.Count; i++)
            {
                rez += studenti[i].printstudent() + "\r\n";    
            }
        }
    }
}
