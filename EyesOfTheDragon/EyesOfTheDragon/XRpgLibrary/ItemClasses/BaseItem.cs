using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EyesOfTheDragon.XRpgLibrary.ItemClasses
{
    public enum Hands { One, Two }
    public enum ArmorLocation { Body, Head, Hands, Feed }

    public abstract class BaseItem
    {
        #region Field Region
        protected List<string> allowableClasses = new List<string>();

        string name;
        string type;
        int price;
        float weight;
        bool equipped;
        #endregion

        #region Property Region
        public List<string> AllowableClasses
        {
            get { return allowableClasses; }
            protected set { allowableClasses = value; }
        }
        public string Type
        {
            get { return type; }
            protected set { type = value; }
        }
        public string Name
        {
            get { return name; }
            protected set { name = value; }
        }
        public int Price
        {
            get { return price; }
            protected set { price = value; }
        }
        public float Weight
        {
            get { return weight; }
            protected set { weight = value; }
        }
        public bool IsEquiped
        {
            get { return equipped; }
            protected set { equipped = value; }
        }
        #endregion

        #region Cosntructor Region
        public BaseItem(string name, string type, int price, float weight, params string[] allowableClasses)
        {
            foreach (string t in allowableClasses)
                AllowableClasses.Add(t);

            Name = name;
            Type = type;
            Price = price;
            Weight = weight;
            IsEquiped = false;
        }
        #endregion

        #region Abstract Method Region
        public abstract object Clone();

        public virtual bool CanEquip(string characterString)
        {
            return allowableClasses.Contains(characterString);
        }
        public override string ToString()
        {
            string itemString = "";

            itemString += Name + ", ";
            itemString += Type + ", ";
            itemString += Price.ToString() + ", ";
            itemString += Weight.ToString();

            return itemString;
        }
        #endregion
    }
}
