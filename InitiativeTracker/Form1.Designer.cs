namespace InitiativeTracker
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.InitContainer = new System.Windows.Forms.DataGridView();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtInit = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAC = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtHP = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtStrSav = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDexSav = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtConSav = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtIntSav = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtWisSav = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtChaSav = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnSort = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.lblPresentCom = new System.Windows.Forms.Label();
            this.lblRoundCount = new System.Windows.Forms.Label();
            this.lblTimeElapsed = new System.Windows.Forms.Label();
            this.btnNextCombatant = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.lblCombInd = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.InitContainer)).BeginInit();
            this.SuspendLayout();
            // 
            // InitContainer
            // 
            this.InitContainer.AllowUserToAddRows = false;
            this.InitContainer.AllowUserToOrderColumns = true;
            this.InitContainer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.InitContainer.Location = new System.Drawing.Point(12, 12);
            this.InitContainer.Name = "InitContainer";
            this.InitContainer.Size = new System.Drawing.Size(1117, 333);
            this.InitContainer.TabIndex = 0;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(54, 352);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 355);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 381);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Init";
            // 
            // txtInit
            // 
            this.txtInit.Location = new System.Drawing.Point(54, 378);
            this.txtInit.Name = "txtInit";
            this.txtInit.Size = new System.Drawing.Size(100, 20);
            this.txtInit.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 433);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "AC";
            // 
            // txtAC
            // 
            this.txtAC.Location = new System.Drawing.Point(54, 430);
            this.txtAC.Name = "txtAC";
            this.txtAC.Size = new System.Drawing.Size(100, 20);
            this.txtAC.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 407);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "HP";
            // 
            // txtHP
            // 
            this.txtHP.Location = new System.Drawing.Point(54, 404);
            this.txtHP.Name = "txtHP";
            this.txtHP.Size = new System.Drawing.Size(100, 20);
            this.txtHP.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(180, 355);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Str Save";
            // 
            // txtStrSav
            // 
            this.txtStrSav.Location = new System.Drawing.Point(234, 352);
            this.txtStrSav.Name = "txtStrSav";
            this.txtStrSav.Size = new System.Drawing.Size(100, 20);
            this.txtStrSav.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(174, 381);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Dex Save";
            // 
            // txtDexSav
            // 
            this.txtDexSav.Location = new System.Drawing.Point(234, 378);
            this.txtDexSav.Name = "txtDexSav";
            this.txtDexSav.Size = new System.Drawing.Size(100, 20);
            this.txtDexSav.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(174, 407);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Con Save";
            // 
            // txtConSav
            // 
            this.txtConSav.Location = new System.Drawing.Point(234, 404);
            this.txtConSav.Name = "txtConSav";
            this.txtConSav.Size = new System.Drawing.Size(100, 20);
            this.txtConSav.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(347, 355);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Int Save";
            // 
            // txtIntSav
            // 
            this.txtIntSav.Location = new System.Drawing.Point(407, 352);
            this.txtIntSav.Name = "txtIntSav";
            this.txtIntSav.Size = new System.Drawing.Size(100, 20);
            this.txtIntSav.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(347, 381);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Wis Save";
            // 
            // txtWisSav
            // 
            this.txtWisSav.Location = new System.Drawing.Point(407, 378);
            this.txtWisSav.Name = "txtWisSav";
            this.txtWisSav.Size = new System.Drawing.Size(100, 20);
            this.txtWisSav.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(347, 407);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Cha Save";
            // 
            // txtChaSav
            // 
            this.txtChaSav.Location = new System.Drawing.Point(407, 404);
            this.txtChaSav.Name = "txtChaSav";
            this.txtChaSav.Size = new System.Drawing.Size(100, 20);
            this.txtChaSav.TabIndex = 19;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(526, 375);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 21;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(526, 404);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 22;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(526, 433);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(75, 23);
            this.btnSort.TabIndex = 23;
            this.btnSort.Text = "Sort";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(526, 462);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 24;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(679, 358);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(97, 13);
            this.label11.TabIndex = 25;
            this.label11.Text = "Present Combatant";
            // 
            // lblPresentCom
            // 
            this.lblPresentCom.AutoSize = true;
            this.lblPresentCom.Location = new System.Drawing.Point(737, 381);
            this.lblPresentCom.Name = "lblPresentCom";
            this.lblPresentCom.Size = new System.Drawing.Size(37, 13);
            this.lblPresentCom.TabIndex = 26;
            this.lblPresentCom.Text = "(none)";
            // 
            // lblRoundCount
            // 
            this.lblRoundCount.AutoSize = true;
            this.lblRoundCount.Location = new System.Drawing.Point(682, 413);
            this.lblRoundCount.Name = "lblRoundCount";
            this.lblRoundCount.Size = new System.Drawing.Size(42, 13);
            this.lblRoundCount.TabIndex = 27;
            this.lblRoundCount.Text = "Round:";
            // 
            // lblTimeElapsed
            // 
            this.lblTimeElapsed.AutoSize = true;
            this.lblTimeElapsed.Location = new System.Drawing.Point(685, 442);
            this.lblTimeElapsed.Name = "lblTimeElapsed";
            this.lblTimeElapsed.Size = new System.Drawing.Size(77, 13);
            this.lblTimeElapsed.TabIndex = 28;
            this.lblTimeElapsed.Text = "Time Elapsed: ";
            // 
            // btnNextCombatant
            // 
            this.btnNextCombatant.Location = new System.Drawing.Point(955, 401);
            this.btnNextCombatant.Name = "btnNextCombatant";
            this.btnNextCombatant.Size = new System.Drawing.Size(97, 23);
            this.btnNextCombatant.TabIndex = 29;
            this.btnNextCombatant.Text = "Next Combatant";
            this.btnNextCombatant.UseVisualStyleBackColor = true;
            this.btnNextCombatant.Click += new System.EventHandler(this.btnNextCombatant_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(955, 375);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 30;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(955, 458);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 31;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(682, 462);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(102, 13);
            this.label12.TabIndex = 32;
            this.label12.Text = "Combatant Indicator";
            // 
            // lblCombInd
            // 
            this.lblCombInd.AutoSize = true;
            this.lblCombInd.Location = new System.Drawing.Point(791, 462);
            this.lblCombInd.Name = "lblCombInd";
            this.lblCombInd.Size = new System.Drawing.Size(0, 13);
            this.lblCombInd.TabIndex = 33;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1142, 493);
            this.Controls.Add(this.lblCombInd);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnNextCombatant);
            this.Controls.Add(this.lblTimeElapsed);
            this.Controls.Add(this.lblRoundCount);
            this.Controls.Add(this.lblPresentCom);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtChaSav);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtWisSav);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtIntSav);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtConSav);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDexSav);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtStrSav);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtHP);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAC);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtInit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.InitContainer);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.InitContainer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView InitContainer;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtInit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtHP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtStrSav;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDexSav;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtConSav;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtIntSav;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtWisSav;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtChaSav;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblPresentCom;
        private System.Windows.Forms.Label lblRoundCount;
        private System.Windows.Forms.Label lblTimeElapsed;
        private System.Windows.Forms.Button btnNextCombatant;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblCombInd;
    }
}

