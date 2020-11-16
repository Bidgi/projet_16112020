using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet_16112020.Model
{
    public class Colis
    {
        // Melvin
        #region Attributs
        private int _idColis;
        private double _hauteur;
        private double _longueur;
        private double _largeur;
        private double _poids;
        // Nombre d'unités de conditionnement contenus dans le colis
        private int _quantiteConditionnement;
        // Permet de savoir si ce colis est toujours en stock ou non
        private bool _indicateurEnStock;
        // Permet de savoir si ce colis a été mis en quarantaine (si Quarantaine : true)
        private bool _indicateurQuarantaine;
        // Objet de la classe Conditionnement
        private Conditionnement _conditionnement;
        public static List<Colis> CollColis = new List<Colis>();
        #endregion

        #region Constructeur
        public Colis(int idColis, double hauteur, double longueur, double largeur, double poids, int quantiteConditionnement, bool indicateurEnStock, Conditionnement conditionnement)
        {
            _idColis = idColis;
            _hauteur = hauteur;
            _longueur = longueur;
            _largeur = largeur;
            _poids = poids;
            _quantiteConditionnement = quantiteConditionnement;
            _indicateurEnStock = indicateurEnStock;
            // Faux par défaut p-e à changer
            _indicateurQuarantaine = false;
            _conditionnement = conditionnement;
            CollColis.Add(this);
        }
        #endregion

        #region Getters-Setters
        public int IdColis { get => _idColis; set => _idColis = value; }
        public double Hauteur { get => _hauteur; set => _hauteur = value; }
        public double Longueur { get => _longueur; set => _longueur = value; }
        public double Largeur { get => _largeur; set => _largeur = value; }
        public double Poids { get => _poids; set => _poids = value; }        
        public int QuantiteConditionnement { get => _quantiteConditionnement; set => _quantiteConditionnement = value; }
        public bool IndicateurEnStock { get => _indicateurEnStock; set => _indicateurEnStock = value; }        
        public bool IndicateurQuarantaine { get => _indicateurQuarantaine; set => _indicateurQuarantaine = value; }
        public Conditionnement Conditionnement { get => _conditionnement; set => _conditionnement = value; }
        #endregion
        #region Méthodes
        // Met l'objet en quarantaine (à utiliser dans le cas où sa date de péremption est dépassée
        public void mettreEnQuarantaine()
        {
            this.IndicateurQuarantaine = true;
        }
        // Retourne l'état du stock 
        public bool enStock()
        {
            return this.IndicateurEnStock;
        }

        #endregion



    }
}
