using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EyesOfTheDragon.XRpgLibrary.ItemClasses
{
    public class ReagentData
    {
        #region Field Region
        public string Name;
        public string Type;
        public int Price;
        public float Weight;
        #endregion

        #region Property Region
        #endregion

        #region Constructors Region
        public ReagentData()
        { }
        #endregion

        #region Methods Region
        public override string ToString()
        {
            string toString = Name + ", ";
            toString += Type + ", ";
            toString += Price.ToString() + ", ";
            toString += Weight.ToString();

            return toString;
        }
        #endregion

        #region Virtual Method Region
        #endregion
    }
}
