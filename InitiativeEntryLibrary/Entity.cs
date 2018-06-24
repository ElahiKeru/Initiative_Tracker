using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InitiativeEntryLibrary
{
    public class Entity
    {
        
        #region properties
        //name
        public string EntityName { get; set; }
        //init
        public int Initiative { get; set; }
        //hp
        public int HitPoints { get; set; }
        //ac
        public int ArmorClass { get; set; }
        //str save
        public int StrSave { get; set; }
        //dex save
        public int DexSave { get; set; }
        //con save
        public int ConSave { get; set; }
        //int save
        public int IntSave { get; set; }
        //wis save
        public int WisSave { get; set; }
        //cha save
        public int ChaSave { get; set; }
        #endregion

        #region constructors
        public Entity(string name, int initHold, int hpHold, 
            int acHold, int strHold, int dexHold, int conHold, 
            int intHold, int wisHold, int chaHold)
        {
            EntityName = name;
            Initiative = initHold;
            HitPoints = hpHold;
            ArmorClass = acHold;
            StrSave = strHold;
            DexSave = dexHold;
            ConSave = conHold;
            IntSave = intHold;
            WisSave = wisHold;
            ChaSave = chaHold;
        }
        #endregion
    }
}
