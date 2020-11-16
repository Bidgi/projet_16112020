using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet_16112020.Model
{
    public class Palette
    {
        // Melvin
        #region Attributs
        private int _idPalette;
        /* 4 états possible :
         * 
         * "en réception"
         * "stockée"
         * "en picking"
         * "déstockée"
         * 
         */
        private string _etatPalette;        
        private List<Colis> _lesColis;
        public static List<Palette> CollPalette = new List<Palette>();

        #endregion
        #region Constructeur
        public Palette(int idPalette, string etatPalette, List<Colis> lesColis)
        {
            _idPalette = idPalette;
            _etatPalette = etatPalette;
            LesColis = new List<Colis>();
            LesColis = lesColis;
            CollPalette.Add(this);
        }
        #endregion
        #region Getters-Setters
        public int IdPalette { get => _idPalette; set => _idPalette = value; }
        public string EtatPalette { get => _etatPalette; set => _etatPalette = value; }
        public List<Colis> LesColis { get => _lesColis; set => _lesColis = value; }
        #endregion
        #region Méthodes
        // Retourne le poids de la palette
        public double getPoidsPalette()
        {
            double poidsPalette = 0;
            //Parcours de chaque colis de la palette afin d'additionner leurs poids
            foreach (Colis element in LesColis) poidsPalette = poidsPalette + element.Poids; return poidsPalette;
        }
        // Retourne l'état de la palette
        public string getEtatPalette()
        {
            return this.EtatPalette;
        }
        // Modifie l'état de la palette
        public void setEtatPalette(string Etat /*Etat à modifier*/)
        {
            this.EtatPalette = Etat;
        }
        // Extrait le colis d'indice i de la collection lesColis
        public Colis extraireColis(int i)
        {
            return this.LesColis[i];
        }
        // Retourne le nombre de colis contenu dans la palette
        public int getNbColis()
        {
            return this.LesColis.Count();
        }
        #endregion
    }
}
