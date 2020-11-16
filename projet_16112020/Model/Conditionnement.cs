using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet_16112020.Model
{
    public class Conditionnement
    {
        // Kylian
        #region Attributs
        public static List<Conditionnement> collLesConditionnements = new List<Conditionnement>();

        private int idConditionnement;
        private string designationConditionnement;
        #endregion

        #region Getters/Setters
        public int IdConditionnement { get => idConditionnement; set => idConditionnement = value; }
        public string DesignationConditionnement { get => designationConditionnement; set => designationConditionnement = value; }
        #endregion

        #region Constructeurs
        public Conditionnement(int idConditionnement, string designationConditionnement)
        {
            this.IdConditionnement = idConditionnement;
            this.DesignationConditionnement = designationConditionnement;
        }
        #endregion

        #region Methodes
        #endregion
    }
}
