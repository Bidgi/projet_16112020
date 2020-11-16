using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet_16112020.Model
{
    public class Alveole
    {
        // Classe cree par Raoul
        #region Attributs
        public static List<Alveole> CollClasseAlveole = new List<Alveole>();
        private int _idAlveole;
        private int _codeDetrompeur;
        private Zone _uneZone;
        private List<Palette> _lesPalettes;
        #endregion

        #region Constructeur
        public Alveole(int idAlveole, int codeDetrompeur, Zone uneZone, List<Palette> lesPalettes)
        {
            IdAlveole = idAlveole;
            CodeDetrompeur = codeDetrompeur;
            UneZone = uneZone;
            LesPalettes = lesPalettes;
            CollClasseAlveole.Add(this);
        }
        #endregion

        #region Getters-Setters
        public int IdAlveole { get => _idAlveole; set => _idAlveole = value; }
        public int CodeDetrompeur { get => _codeDetrompeur; set => _codeDetrompeur = value; }
        internal Zone UneZone { get => _uneZone; set => _uneZone = value; }
        internal List<Palette> LesPalettes { get => _lesPalettes; set => _lesPalettes = value; }
        #endregion

        #region Méthodes
        /// <summary>
        /// retourne le nombre d'emplacements disponible dans un alveole
        /// </summary>
        /// <returns> un entier </returns>
        public int GetNbEmplacementDispo()
        {
            return 3 - this.LesPalettes.Count();
        }
        /// <summary>
        /// ajoute a la collection lesPalettes d'une alveole la palette en parametre
        /// </summary>
        /// <param name="unePalette"> une palettes </param>
        public void RangePalette(Palette unePalette)
        {
            if(this.GetNbEmplacementDispo() > 0) this.LesPalettes.Add(unePalette);
        }
        /// <summary>
        /// retourne la zone de l'alveole
        /// </summary>
        /// <returns> une zone </returns>
        public Zone GetZone()
        {
            return this.UneZone;
        }
        #endregion
    }
}
