using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EyesOfTheDragon.XRpgLibrary.SkillClasses
{
    public class RecipeManager
    {
        #region Field Region
        readonly Dictionary<string, Recipe> recipies;
        #endregion

        #region Property Region
        public Dictionary<string, Recipe> Recipies
        {
            get { return recipies; }
        }
        #endregion

        #region Constructors Region
        public RecipeManager()
        {
            recipies = new Dictionary<string, Recipe>();
        }
        #endregion

        #region Methods Region
        #endregion

        #region Virtual Method Region
        #endregion
    }
}
