using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet_16112020.Model
{
    class Entrepot
    {
        #region Attribut
        private int _idEntrepot;
        private List<Secteur> _lesSecteurs;
        #endregion

        #region Constructeur
        public Entrepot(int IdEntrepot, List<Secteur> LesSecteurs)
        {
            this._idEntrepot = IdEntrepot;
            this._lesSecteurs = LesSecteurs;
        }
        #endregion

        #region Get/Set
        public int IdEntrepot { get => _idEntrepot; set => _idEntrepot = value; }
        public List<Secteur> LesSecteurs { get => _lesSecteurs; set => _lesSecteurs = value; }
        #endregion

        #region Methodes
        public Secteur ExtraireSecteur(int param)
        {
            return LesSecteurs[param - 1];
        }

        public int GetNbSecteur()
        {
            return LesSecteurs.Count();
        }
        #endregion
    }
}
