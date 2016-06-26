using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EyesOfTheDragon.XRpgLibrary.ItemClasses
{
    public class Reagent : BaseItem
    {
        #region Field Region
        #endregion

        #region Property Region
        #endregion

        #region Constructors Region
        public Reagent(string reagentName, string reagentType, int price, float weight)
            : base(reagentName, reagentType, price, weight, null)
        {
        }
        #endregion

        #region Methods Region
        #endregion

        #region Virtual Method Region
        public override object Clone()
        {
            Reagent reagent = new Reagent(Name, Type, Price, Weight);

            return reagent;
        }
        #endregion
    }
}
