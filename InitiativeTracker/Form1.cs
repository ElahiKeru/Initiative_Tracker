﻿using System;
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
    public partial class InitiativeTracker : Form
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
        int roundCount;
        int timeCount;
        int combatantCount;
        int selector;

        public InitiativeTracker()
        {
            InitializeComponent();

            InitContainer.DataSource = ec;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (ValidateEntry())
            {
                ec.Add(new Entity(txtName.Text, initHold, hpHold,
                                  acHold, strHold, dexHold,
                                  conHold, intHold, wisHold, chaHold));
                ClearTexts();
                combatantCount++;
                lblCombInd.Text = $"{selector + 1}/{combatantCount}";
            }
        }

        private void ClearTexts()
        {
            txtAC.Text = "";
            txtChaSav.Text = "";
            txtConSav.Text = "";
            txtDexSav.Text = "";
            txtHP.Text = "";
            txtInit.Text = "";
            txtIntSav.Text = "";
            txtName.Text = "";
            txtStrSav.Text = "";
            txtWisSav.Text = "";
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (InitContainer?.CurrentCell != null)
            {
                int containerRow = InitContainer.CurrentCell.RowIndex;

                var thing = InitContainer.CurrentCell.OwningRow.Cells[0].Value;
                foreach (DataRow dr in ec.Rows)
                {
                    if(dr[0].Equals(thing))
                    {
                        ec.Rows.Remove(dr);
                        break;
                    }
                }

                combatantCount--;
                if (containerRow < selector) selector--;
                lblCombInd.Text = $"{selector + 1}/{combatantCount}";
            }
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            if(ec.Rows.Count > 0)
            {
                InitContainer.Sort(InitContainer.Columns[1], ListSortDirection.Descending);
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            InitContainer.Dispose();
            this.Close();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (InitContainer.Rows.Count > 0)
            {
                lblPresentCom.Text = InitContainer["Name", 0].Value.ToString();
                roundCount = 0;
                timeCount = 0;
                selector = 0;

                lblRoundCount.Text = $"Round: {roundCount}";
                lblTimeElapsed.Text = $"Time Elapsed: {TimeSpan.FromMinutes(timeCount / 60).Minutes:00}:{TimeSpan.FromSeconds(timeCount % 60).Seconds:00}";
                lblCombInd.Text = $"{selector + 1}/{combatantCount}";
            }
        }

        private void btnNextCombatant_Click(object sender, EventArgs e)
        {
            selector++;

            if(selector > combatantCount-1)
            {
                selector -= combatantCount;
                roundCount++;
                timeCount += 6;
            }
            lblPresentCom.Text = InitContainer["Name", selector].Value.ToString();
            lblRoundCount.Text = $"Round: {roundCount}";
            lblCombInd.Text = $"{selector+1}/{combatantCount}";
            lblTimeElapsed.Text = $"Time Elapsed: {TimeSpan.FromMinutes(timeCount/60).Minutes:00}:{TimeSpan.FromSeconds(timeCount%60).Seconds:00}";
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            roundCount = 0;
            timeCount = 0;
            selector = 0;
            ec.Clear();
            lblPresentCom.Text = "(none)";
            lblRoundCount.Text = $"Round:";
            lblTimeElapsed.Text = $"Time Elapsed:";
            lblCombInd.Text = "";
            ClearTexts();
        }
    }
}
