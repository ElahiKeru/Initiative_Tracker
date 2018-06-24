using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InitiativeEntryLibrary
{
    public class EntityContainer : DataTable
    {
        public EntityContainer()
        {
            this.Columns.Add("Name");
            this.Columns.Add("Initiative");
            this.Columns["Initiative"].DataType = typeof(int);
            this.Columns.Add("Hit Points");
            this.Columns.Add("Armor Class");
            this.Columns.Add("Str Save");
            this.Columns.Add("Dex Save");
            this.Columns.Add("Con Save");
            this.Columns.Add("Int Save");
            this.Columns.Add("Wis Save");
            this.Columns.Add("Cha Save");
        }

        public bool Add(Entity e)
        {
            DataRow dr = this.NewRow();

            dr["Name"] = e.EntityName;
            dr["Initiative"] = e.Initiative;
            dr["Hit Points"] = e.HitPoints;
            dr["Armor Class"] = e.ArmorClass;
            dr["Str Save"] = e.StrSave;
            dr["Dex Save"] = e.DexSave;
            dr["Con Save"] = e.ConSave;
            dr["Int Save"] = e.IntSave;
            dr["Wis Save"] = e.WisSave;
            dr["Cha Save"] = e.ChaSave;

            this.Rows.Add(dr);            

            return true;
        }

        public DataTable Sort()
        {
            DataView dv = this.DefaultView;
            dv.Sort = "Initiative DESC";
            return dv.ToTable();
        }
    }
}
