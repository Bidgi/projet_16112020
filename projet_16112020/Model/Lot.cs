using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet_16112020.Model
{
    public class Lot
    {
        //Classe cree par Raoul
        #region Attributs
        public static List<Lot> CollClasseLot = new List<Lot>();
        private int _idLot;
        private DateTime _datePeremption;
        private DateTime _dateReception;
        private string _etatLot;
        private List<Palette> _lesPalettes;
        #endregion

        #region Constructeur
        public Lot(int idLot, DateTime datePeremption, DateTime dateReception, string etatLot, List<Palette> lesPalettes)
        {
            IdLot = idLot;
            DatePeremption = datePeremption;
            DateReception = dateReception;
            EtatLot = etatLot;
            LesPalettes = lesPalettes;
        }
        #endregion

        #region Getters-Setters
        public int IdLot { get => _idLot; set => _idLot = value; }
        public DateTime DatePeremption { get => _datePeremption; set => _datePeremption = value; }
        public DateTime DateReception { get => _dateReception; set => _dateReception = value; }
        public string EtatLot { get => _etatLot; set => _etatLot = value; }
        internal List<Palette> LesPalettes { get => _lesPalettes; set => _lesPalettes = value; }
        #endregion

        #region Méthodes
        /// <summary>
        /// compare la date de peremption du lot avec la date du jour et, si nécessaire, destocke le lot,
        /// met les palettes et les colis encore stock qui les constituent en quarantaine
        /// </summary>
        public void VerifEnQuarantaine()
        {
            if(this.DatePeremption != DateTime.Now)
            {
                foreach (Palette unePalettes in this.LesPalettes)
                {
                    foreach (Colis unColis in unePalettes.LesColis) unColis.mettreEnQuarantaine();
                    unePalettes.EtatPalette = "déstockée";
                }
            }
            this.EtatLot = "désrockée";
        }
        /// <summary>
        /// range chaque palettes du lot dans une alveole du secteur passe en parametre.
        /// </summary>
        public void StockerElementsDuLot(Secteur unSecteur)
        {
            foreach (Palette unePalette in this.LesPalettes) foreach (Palettier unPalettier in unSecteur.LesPalettiers) foreach (Alveole uneAlveole in unPalettier.LesAlveole) if (uneAlveole.GetNbEmplacementDispo() > 0) uneAlveole.RangePalette(unePalette);
        }
        /// <summary>
        /// verif si l'etat du lot est bien "destockee"
        /// </summary>
        /// <returns> vrai si destockee </returns>
        public bool VerifDestockageLot()
        {
            if(this.EtatLot == "déstockée") return true;
            return false;
        }
        #endregion
    }
}
