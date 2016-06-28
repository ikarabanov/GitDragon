using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EyesOfTheDragon.XRpgLibrary.ItemClasses
{
    public class Key : BaseItem
    {
        #region Field Region
        #endregion

        #region Property Region
        #endregion

        #region Constructor Region
        public Key(string name, string type) : base(name, type, 0,0,null)
        {
        }
        #endregion

        #region Virtual Method Region
        public override object Clone()
        {
            Key key = new Key(this.Name, this.Type);

            return key;
        }
        #endregion
    }
}
