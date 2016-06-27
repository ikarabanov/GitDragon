using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EyesOfTheDragon.XRpgLibrary.ConversationClasses
{
    public class ConversationManager
    {
        #region Field Region
        readonly Dictionary<string, Conversation> conversations;
        #endregion

        #region Property Region
        public Dictionary<string, Conversation> Conversations
        {
            get { return conversations; }
        }
        #endregion

        #region Constructors Region
        public ConversationManager()
        {
            conversations = new Dictionary<string, Conversation>();
        }
        #endregion

        #region Methods Region
        #endregion

        #region Virtual Method Region
        #endregion
    }
}
