using EyesOfTheDragon.XRpgLibrary;
using EyesOfTheDragon.XRpgLibrary.Controls;
using EyesOfTheDragon.XRpgLibrary.SkillClasses;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EyesOfTheDragon.GameScreens
{
    internal class SkillLabelSet
    {
        internal Label Label;
        internal LinkLabel LinkLabel;
        internal SkillLabelSet(Label label, LinkLabel linkLabel)
        {
            Label = label;
            LinkLabel = linkLabel;
        }
    }
    public class SkillScreen : BaseGameState
    {
        #region Field Region
        int skillPoints;
        int unassignedPoints;

        PictureBox backgroundImage;
        Label pointsRemaining;

        List<SkillLabelSet> skillLabels = new List<SkillLabelSet>();
        Stack<string> undoSkill = new Stack<string>();
        EventHandler linkLabelHandler;
        #endregion

        #region Property Region
        public int SkillPoints
        {
            get { return skillPoints; }
            set
            {
                skillPoints = value;
                unassignedPoints = value;
            }
        }
        #endregion

        #region Constructors Region
        public SkillScreen(EyesOfTheDragon game, GameStateManager manager) : base (game, manager)
        {
            linkLabelHandler = new EventHandler(addSkillLabel_Selected);
        }
        #endregion

        #region Methods Region
        #endregion

        #region Virtual Method Region
        #endregion

        #region XNA MEthod Region
        public override void Initialize()
        {
            base.Initialize();
        }
        protected override void LoadContent()
        {
            base.LoadContent();

            ContentManager Content = GameRef.Content;

            CreateControls(Content);
        }
        private void CreateControls(ContentManager Content)
        {
            backgroundImage = new PictureBox(Game.Content.Load<Texture2D>(@"Backgrounds\titlescreen"),
                GameRef.ScreenRectangle);
            ControlManager.Add(backgroundImage);

            string skillPath = Content.RootDirectory + @"\Game\Skills";
            string[] skillFiles = Directory.GetFiles(skillPath, "*xnb");

            for (int i = 0; i < skillFiles.Length; i++)
                skillFiles[i] = @"Game\Skills\" + Path.GetFileNameWithoutExtension(skillFiles[i]);

            List<SkillData> skillData = new List<SkillData>();

            Vector2 nextControlPosition = new Vector2(300, 150);

            pointsRemaining = new Label();

        }
        #endregion
    }
}
