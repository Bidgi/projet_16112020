using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet_16112020.Model
{
    class Secteur
    {
        #region Attribut
        public static List<Secteur> CollSecteur = new List<Secteur>();
        private List<Palettier> _lesPalettiers;
        private int _idSecteur;
        #endregion

        #region Constructeur
        public Secteur(int IdSecteur, List<Palettier> LesPalettiers)
        {
            this._idSecteur = IdSecteur;
            this._lesPalettiers = LesPalettiers;
            CollSecteur.Add(this);
        }
        #endregion

        #region Get/Set
        public int IdSecteur { get => _idSecteur; set => _idSecteur = value; }
        public List<Palettier> LesPalettiers { get => _lesPalettiers; set => _lesPalettiers = value; }
        #endregion

        #region Methodes
        public Palettier ExtrairePalettier(int param)
        {
            return LesPalettiers[param - 1];
        }

        public int getNbPalettier()
        {
            return LesPalettiers.Count;
        }
        #endregion
    }
}
