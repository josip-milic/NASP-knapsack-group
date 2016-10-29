namespace KnapsackGroupsProject
{
    partial class FormMain
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbDirAdd = new System.Windows.Forms.TextBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnDirAdd = new System.Windows.Forms.Button();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.tbBestCost = new System.Windows.Forms.TextBox();
            this.tbBestValue = new System.Windows.Forms.TextBox();
            this.lblRed = new System.Windows.Forms.Label();
            this.lblYellow = new System.Windows.Forms.Label();
            this.lblGreen = new System.Windows.Forms.Label();
            this.lblBestCost = new System.Windows.Forms.Label();
            this.lblBestValue = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.lbBest = new System.Windows.Forms.ListBox();
            this.lblBest = new System.Windows.Forms.Label();
            this.gridVC = new System.Windows.Forms.DataGridView();
            this.gridMain = new System.Windows.Forms.DataGridView();
            this.tbTarget = new System.Windows.Forms.TextBox();
            this.lblTarget = new System.Windows.Forms.Label();
            this.btnHelp = new System.Windows.Forms.Button();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridVC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridMain)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Datoteka s vrijednostima i cijenama:";
            // 
            // tbDirAdd
            // 
            this.tbDirAdd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDirAdd.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tbDirAdd.Location = new System.Drawing.Point(191, 6);
            this.tbDirAdd.Name = "tbDirAdd";
            this.tbDirAdd.Size = new System.Drawing.Size(508, 20);
            this.tbDirAdd.TabIndex = 4;
            // 
            // btnLoad
            // 
            this.btnLoad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoad.BackColor = System.Drawing.Color.Transparent;
            this.btnLoad.BackgroundImage = global::KnapsackGroupsGUI.Properties.Resources.load_icon;
            this.btnLoad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLoad.Location = new System.Drawing.Point(738, 3);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(25, 24);
            this.btnLoad.TabIndex = 13;
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnDirAdd
            // 
            this.btnDirAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDirAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnDirAdd.BackgroundImage = global::KnapsackGroupsGUI.Properties.Resources.dir_add_icon;
            this.btnDirAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDirAdd.Location = new System.Drawing.Point(706, 3);
            this.btnDirAdd.Name = "btnDirAdd";
            this.btnDirAdd.Size = new System.Drawing.Size(25, 24);
            this.btnDirAdd.TabIndex = 5;
            this.btnDirAdd.UseVisualStyleBackColor = false;
            this.btnDirAdd.Click += new System.EventHandler(this.btnDirAdd_Click);
            // 
            // pnlMain
            // 
            this.pnlMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMain.Controls.Add(this.tbBestCost);
            this.pnlMain.Controls.Add(this.tbBestValue);
            this.pnlMain.Controls.Add(this.lblRed);
            this.pnlMain.Controls.Add(this.lblYellow);
            this.pnlMain.Controls.Add(this.lblGreen);
            this.pnlMain.Controls.Add(this.lblBestCost);
            this.pnlMain.Controls.Add(this.lblBestValue);
            this.pnlMain.Controls.Add(this.btnRefresh);
            this.pnlMain.Controls.Add(this.lbBest);
            this.pnlMain.Controls.Add(this.lblBest);
            this.pnlMain.Controls.Add(this.gridVC);
            this.pnlMain.Controls.Add(this.gridMain);
            this.pnlMain.Controls.Add(this.tbTarget);
            this.pnlMain.Controls.Add(this.lblTarget);
            this.pnlMain.Location = new System.Drawing.Point(12, 36);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(785, 349);
            this.pnlMain.TabIndex = 15;
            // 
            // tbBestCost
            // 
            this.tbBestCost.Location = new System.Drawing.Point(610, 129);
            this.tbBestCost.Name = "tbBestCost";
            this.tbBestCost.ReadOnly = true;
            this.tbBestCost.Size = new System.Drawing.Size(55, 20);
            this.tbBestCost.TabIndex = 9;
            // 
            // tbBestValue
            // 
            this.tbBestValue.Location = new System.Drawing.Point(610, 107);
            this.tbBestValue.Name = "tbBestValue";
            this.tbBestValue.ReadOnly = true;
            this.tbBestValue.Size = new System.Drawing.Size(55, 20);
            this.tbBestValue.TabIndex = 9;
            // 
            // lblRed
            // 
            this.lblRed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblRed.AutoSize = true;
            this.lblRed.BackColor = System.Drawing.Color.Red;
            this.lblRed.Location = new System.Drawing.Point(3, 333);
            this.lblRed.Name = "lblRed";
            this.lblRed.Size = new System.Drawing.Size(137, 13);
            this.lblRed.TabIndex = 8;
            this.lblRed.Text = "Konačna ukupna vrijednost";
            // 
            // lblYellow
            // 
            this.lblYellow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblYellow.AutoSize = true;
            this.lblYellow.BackColor = System.Drawing.Color.Yellow;
            this.lblYellow.Location = new System.Drawing.Point(146, 333);
            this.lblYellow.Name = "lblYellow";
            this.lblYellow.Size = new System.Drawing.Size(212, 13);
            this.lblYellow.TabIndex = 8;
            this.lblYellow.Text = "Vrijednost jednaka prethodnoj (ne uzima se)";
            // 
            // lblGreen
            // 
            this.lblGreen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblGreen.AutoSize = true;
            this.lblGreen.BackColor = System.Drawing.Color.Green;
            this.lblGreen.Location = new System.Drawing.Point(364, 333);
            this.lblGreen.Name = "lblGreen";
            this.lblGreen.Size = new System.Drawing.Size(120, 13);
            this.lblGreen.TabIndex = 8;
            this.lblGreen.Text = "Vrijednost koja se uzima";
            // 
            // lblBestCost
            // 
            this.lblBestCost.AutoSize = true;
            this.lblBestCost.Location = new System.Drawing.Point(557, 132);
            this.lblBestCost.Name = "lblBestCost";
            this.lblBestCost.Size = new System.Drawing.Size(47, 13);
            this.lblBestCost.TabIndex = 7;
            this.lblBestCost.Text = "Max ΣC:";
            // 
            // lblBestValue
            // 
            this.lblBestValue.AutoSize = true;
            this.lblBestValue.Location = new System.Drawing.Point(557, 110);
            this.lblBestValue.Name = "lblBestValue";
            this.lblBestValue.Size = new System.Drawing.Size(47, 13);
            this.lblBestValue.TabIndex = 7;
            this.lblBestValue.Text = "Max ΣV:";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(3, 136);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 6;
            this.btnRefresh.Text = "Osvježi";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // lbBest
            // 
            this.lbBest.FormattingEnabled = true;
            this.lbBest.Location = new System.Drawing.Point(299, 110);
            this.lbBest.Name = "lbBest";
            this.lbBest.Size = new System.Drawing.Size(252, 69);
            this.lbBest.TabIndex = 5;
            this.lbBest.SelectedIndexChanged += new System.EventHandler(this.lbBest_SelectedIndexChanged);
            // 
            // lblBest
            // 
            this.lblBest.AutoSize = true;
            this.lblBest.Location = new System.Drawing.Point(249, 136);
            this.lblBest.Name = "lblBest";
            this.lblBest.Size = new System.Drawing.Size(53, 13);
            this.lblBest.TabIndex = 4;
            this.lblBest.Text = "Odabrani:";
            // 
            // gridVC
            // 
            this.gridVC.AllowUserToAddRows = false;
            this.gridVC.AllowUserToDeleteRows = false;
            this.gridVC.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridVC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridVC.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.gridVC.Location = new System.Drawing.Point(3, 3);
            this.gridVC.Name = "gridVC";
            this.gridVC.Size = new System.Drawing.Size(778, 101);
            this.gridVC.TabIndex = 3;
            // 
            // gridMain
            // 
            this.gridMain.AllowUserToAddRows = false;
            this.gridMain.AllowUserToDeleteRows = false;
            this.gridMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridMain.Location = new System.Drawing.Point(3, 185);
            this.gridMain.Name = "gridMain";
            this.gridMain.ReadOnly = true;
            this.gridMain.Size = new System.Drawing.Size(778, 145);
            this.gridMain.TabIndex = 2;
            // 
            // tbTarget
            // 
            this.tbTarget.Location = new System.Drawing.Point(33, 107);
            this.tbTarget.Name = "tbTarget";
            this.tbTarget.Size = new System.Drawing.Size(55, 20);
            this.tbTarget.TabIndex = 1;
            // 
            // lblTarget
            // 
            this.lblTarget.AutoSize = true;
            this.lblTarget.Location = new System.Drawing.Point(6, 110);
            this.lblTarget.Name = "lblTarget";
            this.lblTarget.Size = new System.Drawing.Size(24, 13);
            this.lblTarget.TabIndex = 0;
            this.lblTarget.Text = "ΣC:";
            // 
            // btnHelp
            // 
            this.btnHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHelp.BackColor = System.Drawing.Color.Transparent;
            this.btnHelp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHelp.Location = new System.Drawing.Point(770, 3);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(25, 24);
            this.btnHelp.TabIndex = 13;
            this.btnHelp.Text = "?";
            this.btnHelp.UseVisualStyleBackColor = false;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // FormMain
            // 
            this.AcceptButton = this.btnRefresh;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 396);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnDirAdd);
            this.Controls.Add(this.tbDirAdd);
            this.Controls.Add(this.label1);
            this.Name = "FormMain";
            this.Text = "Dinamičko programiranje za grupe";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridVC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbDirAdd;
        private System.Windows.Forms.Button btnDirAdd;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Label lblTarget;
        private System.Windows.Forms.TextBox tbTarget;
        private System.Windows.Forms.DataGridView gridMain;
        private System.Windows.Forms.DataGridView gridVC;
        private System.Windows.Forms.ListBox lbBest;
        private System.Windows.Forms.Label lblBest;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label lblBestCost;
        private System.Windows.Forms.Label lblBestValue;
        private System.Windows.Forms.Label lblRed;
        private System.Windows.Forms.Label lblYellow;
        private System.Windows.Forms.Label lblGreen;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.TextBox tbBestCost;
        private System.Windows.Forms.TextBox tbBestValue;
    }
}

