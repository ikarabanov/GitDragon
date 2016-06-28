﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EyesOfTheDragon.XRpgLibrary.ItemClasses
{
    public class Chest : BaseItem
    {
        #region Field Region
        static Random Random = new Random();
        ChestData chestData;
        #endregion

        #region Property Region
        public bool isLocked
        {
            get { return chestData.IsLocked; }
        }
        public bool isTrapped
        {
            get { return chestData.IsTrapped; }
        }
        public int Gold
        {
            get
            {
                if (chestData.MinGold == 0 && chestData.MaxGold == 0)
                    return 0;
                int gold = Random.Next(chestData.MinGold, chestData.MaxGold);
                chestData.MinGold = 0;
                chestData.MaxGold = 0;

                return gold;
            }
        }
        #endregion

        #region Constructors Region
        public Chest(ChestData data) : base(data.Name, "", 0,0)
        {
            this.chestData = data;
        }
        #endregion

        #region Methods Region
        #endregion

        #region Virtual Method Region
        public override object Clone()
        {
            ChestData data = new ChestData();
            data.Name = chestData.Name;
            data.DifficultyLevel = chestData.DifficultyLevel;
            data.IsLocked = chestData.IsLocked;
            data.IsTrapped = chestData.IsTrapped;
            data.TrapName = chestData.TrapName;
            data.KeyName = chestData.KeyName;
            data.KeyType = chestData.KeyType;
            data.KeysRequired = chestData.KeysRequired;
            data.MinGold = chestData.MinGold;
            data.MaxGold = chestData.MaxGold;

            foreach (KeyValuePair<string, string> pair in chestData.ItemCollection)
                data.ItemCollection.Add(pair.Key, pair.Value);

            Chest chest = new Chest(data);
            return chest;
        }
        #endregion
    }
}
