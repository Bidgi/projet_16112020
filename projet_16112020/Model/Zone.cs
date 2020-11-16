using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet_16112020.Model
{
    public class Zone
    {
        // Kylian
        #region Attributs
        public static List<Zone> collLesZones = new List<Zone>();

        private int _idZone;
        private string _libelleZone;
        #endregion

        #region Getters/Setters
        public int IdZone { get => _idZone; set => _idZone = value; }
        public string LibelleZone { get => _libelleZone; set => _libelleZone = value; }
        #endregion

        #region Constructeurs
        public Zone(int idZone, string libelleZone)
        {
            _idZone = idZone;
            _libelleZone = libelleZone;
        }
        #endregion

        #region Methodes

        #endregion

    }
}
