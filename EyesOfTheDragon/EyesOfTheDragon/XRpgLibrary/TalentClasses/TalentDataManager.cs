using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EyesOfTheDragon.XRpgLibrary.TalentClasses
{
    public class TalentDataManager
    {
        #region Field Region
        readonly Dictionary<string, TalentData> talentData;
        #endregion

        #region Property Region
        public Dictionary<string, TalentData> TalentData
        {
            get { return talentData; }
        }
        #endregion

        #region Constructors Region
        public TalentDataManager()
        {
            talentData = new Dictionary<string, TalentData>();
        }
        #endregion

        #region Methods Region
        #endregion

        #region Virtual Method Region
        #endregion
    }
}
