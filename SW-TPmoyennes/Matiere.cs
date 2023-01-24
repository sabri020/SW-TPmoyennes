using System;
using System.Collections.Generic;
using System.Text;

namespace SW_TPmoyennes
{

    class Matiere
    {
        string nomMatiere;

        public Matiere(string nomMatiere)
        {
            this.nomMatiere = nomMatiere;

        }

        public override string ToString()
        {
            return nomMatiere;
        }

    }

}
