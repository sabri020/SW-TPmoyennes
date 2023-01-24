using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SW_TPmoyennes
{
    class Classe
    {
        //declarer les listes eleves et matieres
        public List<Eleve> eleves { get; set; }
        public List<Matiere> matieres { get; set; }

        public Classe(string nomClasse)
        {
            eleves = new List<Eleve>();
            matieres = new List<Matiere>();
            this.nomClasse = nomClasse;
        }

        public string nomClasse { get; set; }
        //function insertion eleve
        public void ajouterEleve(string prenom, string nom)
        {
            Eleve eleve = new Eleve(prenom, nom);
            if (eleves.Count < 30)
            {
                eleves.Add(eleve);
            }


        }
        //function insertion matiere

        public void ajouterMatiere(string nomMatiere)
        {
            Matiere matiere = new Matiere(nomMatiere);
            if (matieres.Count < 10)
            {
                matieres.Add(matiere);
            }


        }
        //function calculer la moyenne de la classe dans chaque matière

        public double moyenneDouble(int MatiereID)
        {


            double moyenneMatiere = 0;
            for (int i = 0; i < eleves.Count; i++)
            {
                double moyenneEleveMatiere = eleves[i].moyenneDouble(MatiereID);
                moyenneMatiere += moyenneEleveMatiere;
            }
            moyenneMatiere = moyenneMatiere / eleves.Count;
            return moyenneMatiere;
        }
        //function calculer la moyenne générale de classe

        public double moyenneDouble()
        {

            double moyenneClasse = 0;
            for (int i = 0; i < matieres.Count; i++)
            {
                double moyennematieregenerale = moyenneDouble(i);
                moyenneClasse += moyennematieregenerale;
            }
            moyenneClasse = moyenneClasse / matieres.Count;
            return moyenneClasse;


        }

        // formater l'affichage des notes

        public string Moyenne(int MatiereID)
        {
            return moyenneDouble(MatiereID).ToString("0.00");
        }
        public string Moyenne()
        {
            return moyenneDouble().ToString("0.00");
        }

    }
}
