using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EyesOfTheDragon.XRpgLibrary.SkillClasses
{
    public class SkillDataManager
    {
        #region Field Region
        readonly Dictionary<string, SkillData> skillData;
        #endregion

        #region Property Region
        public Dictionary<string, SkillData> SkillData
        {
            get { return skillData; }
        }
        #endregion

        #region Constructors Region
        public SkillDataManager()
        {
            skillData = new Dictionary<string, SkillData>();
        }
        #endregion

        #region Methods Region
        #endregion

        #region Virtual Method Region
        #endregion
    }
}
