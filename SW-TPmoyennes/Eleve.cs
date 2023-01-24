using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SW_TPmoyennes
{
    class Eleve
    {
        public string prenom;
        public string nom;
        public List<Note> notes { get; set; }

        public Eleve(string prenom, string nom)
        {
            this.prenom = prenom;
            this.nom = nom;
            this.notes = new List<Note>();
        }

        internal void ajouterNote(Note note)
        {
            if (notes.Count < 200)
            {
                notes.Add(note);
            }

        }


        // fomater l'affichage des notes
        public string Moyenne(int MatiereID)
        {
            return moyenneDouble(MatiereID).ToString("0.00");
        }
        public string Moyenne()
        {
            return moyenneDouble().ToString("0.00");
        }

        //function calculer la moyenne d’un élève dans chaque matière

        public double moyenneDouble(int MatiereID)
        {
            double moyenneMatiere = 0;
            for (int i = 0; i < notes.Count; i++)
            {
                if (notes[i].matiere == MatiereID)
                {
                    moyenneMatiere += notes[i].note;
                }
            }
            moyenneMatiere = moyenneMatiere / 5;
            return moyenneMatiere;

        }


        //function calculer la moyenne générale d’un élève
        //resulat bizzare
        //je suis bloqué ici

        public double moyenneDouble()
        {
            double moyenneGenerale = 0;

            double moyenneMatiere;


            for (int i = 0; i < notes.Count; i++)
            {
                moyenneMatiere = notes[i].note;
                moyenneGenerale += moyenneMatiere;
            }

            moyenneGenerale = moyenneGenerale / notes.Count;
            return moyenneGenerale;
        }

    }
}
