using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EyesOfTheDragon.XRpgLibrary.SpellClasses
{
    public class SpellDataManager
    {
        #region Field Region
        readonly Dictionary<string, SpellData> spellData;
        #endregion

        #region Property Region
        public Dictionary<string, SpellData> SpellData
        {
            get { return spellData; }
        }
        #endregion

        #region Constructors Region
        public SpellDataManager()
        {
            spellData = new Dictionary<string, SpellData>();
        }
        #endregion

        #region Methods Region
        #endregion

        #region Virtual Method Region
        #endregion
    }
}
