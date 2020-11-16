using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet_16112020.Model
{
    public class Palettier
    {
        // Classe cree par Raoul
        #region Attributs
        public static List<Palettier> CollClassePalettier = new List<Palettier>();
        private int _idPalettier;
        private string _allee;
        private int _chargeMaximale;
        private List<Alveole> _lesAlveole;
        #endregion

        #region Constructeur
        public Palettier(int idPalettier, string allee, int chargeMaximale, List<Alveole> lesAlveole)
        {
            IdPalettier = idPalettier;
            Allee = allee;
            ChargeMaximale = chargeMaximale;
            LesAlveole = lesAlveole;
        }
        #endregion

        #region Getters-Setters
        public int IdPalettier { get => _idPalettier; set => _idPalettier = value; }
        public string Allee { get => _allee; set => _allee = value; }
        public int ChargeMaximale { get => _chargeMaximale; set => _chargeMaximale = value; }
        internal List<Alveole> LesAlveole { get => _lesAlveole; set => _lesAlveole = value; }
        #endregion

        #region Méthodes
        /// <summary>
        /// extrair l'alveole d'indice i de la collection lesAlveole
        /// </summary>
        /// <param name="i"> les indice i entier </param>
        /// <returns> une alveole </returns>
        public Alveole ExtraireAlveole(int i)
        {
            return this.LesAlveole.ElementAt(i);
        }
        /// <summary>
        /// retourne le poids reel du paletiier avec son chargement
        /// </summary>
        /// <returns> un reel </returns>
        public int GetPoidsPalettier()
        {

        }
        /// <summary>
        ///retourne la charge (le poids) maximale autorisée sur ce palettier 
        /// </summary>
        /// <returns> un reel </returns>
        public int GetChargeMaximale()
        {
            return this.ChargeMaximale;
        }
        /// <summary>
        /// retourne le nombre d'alveoles du palettier
        /// </summary>
        /// <returns> un entier </returns>
        public int GetNbAlveoles()
        {
            return this.LesAlveole.Count();
        }
        #endregion
    }
}
