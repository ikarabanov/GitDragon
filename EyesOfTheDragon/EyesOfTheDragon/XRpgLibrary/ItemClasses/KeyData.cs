using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EyesOfTheDragon.XRpgLibrary.ItemClasses
{
    public class KeyData
    {
        #region Field Region
        public string Name;
        public string Type;
        #endregion

        #region Constructor Region
        public KeyData()
        {
        }
        #endregion

        #region Method Region
        public override string ToString()
        {
            string toString = Name + ", ";
            toString += Type;

            return toString;
        }
        #endregion
    }
}
