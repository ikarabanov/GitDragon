using EyesOfTheDragon.XRpgLibrary.CharacterClasses;
using EyesOfTheDragon.XRpgLibrary.ConversationClasses;
using EyesOfTheDragon.XRpgLibrary.QuestClasses;
using EyesOfTheDragon.XRpgLibrary.SpriteClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace EyesOfTheDragon.XRpgLibrary.CharacterClassesX
{
    public class NonPlayerCharacter : Character
    {
        #region Field Region
        readonly List<Conversation> conversations;
        readonly List<Quest> quests;
        #endregion

        #region Property Region
        public List<Conversation> Conversations
        {
            get { return conversations; }
        }
        public List<Quest> Quests
        {
            get { return quests; }
        }
        public bool HasConversation
        {
            get { return (conversations.Count > 0); }
        }
        public bool HasQuest
        {
            get { return (quests.Count > 0); }
        }
        #endregion

        #region Constructors Region
        public NonPlayerCharacter(Entity entity, AnimatedSprite sprite) : base(entity, sprite)
        {
            conversations = new List<Conversation>();
            quests = new List<Quest>();
        }
        #endregion

        #region Methods Region
        #endregion

        #region Virtual Method Region
        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
        }
        public override void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            base.Draw(gameTime, spriteBatch);
        }
        #endregion
    }
}
