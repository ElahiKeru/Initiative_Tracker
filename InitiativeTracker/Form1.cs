using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InitiativeEntryLibrary;

namespace InitiativeTracker
{
    public partial class Form1 : Form
    {
        EntityContainer ec = new EntityContainer();
        int initHold;
        int hpHold;
        int acHold;
        int strHold;
        int dexHold;
        int conHold;
        int intHold;
        int wisHold;
        int chaHold;

        public Form1()
        {
            InitializeComponent();

            InitContainer.DataSource = ec;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(ValidateEntry())
            {
                ec.Add(new Entity(txtName.Text, initHold, hpHold,
                                  acHold, strHold, dexHold,
                                  conHold, intHold, wisHold, chaHold));
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (InitContainer.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow dr in InitContainer.SelectedRows)
                {
                    ec.Rows.Remove(ec.Rows[dr.Index]);
                }
            }
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            if(ec.Rows.Count > 0)
            {
                InitContainer.DataSource = ec.Sort();
            }
        }

        private bool ValidateEntry()
        {
            bool validated = true;
            
            StringBuilder errSB = new StringBuilder();

            if(string.IsNullOrEmpty(txtName.Text))
            {
                validated = false;
                errSB.AppendLine("Name must be set");
            }

            int.TryParse(txtInit.Text, out initHold);
            int.TryParse(txtHP.Text, out hpHold);
            int.TryParse(txtAC.Text, out acHold);
            int.TryParse(txtStrSav.Text, out strHold);
            int.TryParse(txtDexSav.Text, out dexHold);
            int.TryParse(txtConSav.Text, out conHold);
            int.TryParse(txtIntSav.Text, out intHold);
            int.TryParse(txtWisSav.Text, out wisHold);
            int.TryParse(txtChaSav.Text, out chaHold);

            if(!validated)
            {
                MessageBox.Show(errSB.ToString(), "Errors Validating", MessageBoxButtons.OK);
            }

            return validated;
        }
    }
}
