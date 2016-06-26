using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EyesOfTheDragon.XRpgLibrary.SkillClasses
{
    public struct Reagents
    {
        #region Field Region
        public string ReagentName;
        public ushort AmountRequired;
        #endregion

        #region Property Region
        #endregion

        #region Constructors Region
        public Reagents(string reagent, ushort number)
        {
            ReagentName = reagent;
            AmountRequired = number;
        }
        #endregion

        #region Methods Region
        #endregion

        #region Virtual Method Region
        #endregion
    }
    public class Recipe
    {
        #region Field Region
        public string Name;
        public Reagents[] Reagents;
        #endregion

        #region Property Region
        #endregion

        #region Constructors Region
        private Recipe()
        { }
        public Recipe(string name, params Reagents[] reagents)
        {
            Name = name;
            Reagents = new Reagents[reagents.Length];

            for (int i = 0; i < reagents.Length; i++)
                Reagents[i] = reagents[i];
        }
        #endregion

        #region Methods Region
        #endregion

        #region Virtual Method Region
        #endregion
    }
}
