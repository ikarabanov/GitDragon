using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EyesOfTheDragon.XRpgLibrary.QuestClasses
{
    public class QuestManager
    {
        #region Field Region
        readonly Dictionary<string, Quest> quests;
        #endregion

        #region Property Region
        public Dictionary<string, Quest> Quests
        {
            get { return quests; }
        }
        #endregion

        #region Constructors Region
        public QuestManager()
        {
            quests = new Dictionary<string, Quest>();
        }
        #endregion

        #region Methods Region
        #endregion

        #region Virtual Method Region
        #endregion
    }
}
