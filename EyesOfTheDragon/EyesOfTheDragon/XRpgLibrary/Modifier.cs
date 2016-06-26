using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EyesOfTheDragon.XRpgLibrary
{
    public struct Modifier
    {
        #region Field Region
        public int Amount;
        public int Duration;
        public TimeSpan TimeLeft;
        #endregion

        #region Property Region
        #endregion

        #region Constructors Region
        public Modifier(int amount)
        {
            Amount = amount;
            Duration = -1; //-1 means lasts untill it is dispelled
            TimeLeft = TimeSpan.Zero;
        }
        public Modifier(int amount, int duration)
        {
            Amount = amount;
            Duration = duration;
            TimeLeft = TimeSpan.FromSeconds(duration);
        }
        #endregion

        #region Methods Region
        public void Update(TimeSpan elapsedTime)
        {
            if (Duration == -1)
                return;
            TimeLeft -= elapsedTime;
            if(TimeLeft.TotalMilliseconds < 0)
            {
                TimeLeft = TimeSpan.Zero;
                Amount = 0;
            }
        }
        #endregion

        #region Virtual Method Region
        #endregion
    }
}
