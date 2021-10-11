namespace SqlManager
{
    partial class MainForm
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
            this.CbDatabases = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.LbTables = new System.Windows.Forms.ListBox();
            this.LbTableColumns = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.LbViews = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.LbViewColumns = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.LbParameters = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.LbProcedures = new System.Windows.Forms.ListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TbDefinition = new System.Windows.Forms.TextBox();
            this.BtnSelectTable = new System.Windows.Forms.Button();
            this.BtnSelectView = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsNewQuery = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Databases:";
            // 
            // CbDatabases
            // 
            this.CbDatabases.FormattingEnabled = true;
            this.CbDatabases.Location = new System.Drawing.Point(98, 57);
            this.CbDatabases.Name = "CbDatabases";
            this.CbDatabases.Size = new System.Drawing.Size(223, 21);
            this.CbDatabases.TabIndex = 1;
            this.CbDatabases.SelectedIndexChanged += new System.EventHandler(this.CbDatabases_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tables:";
            // 
            // LbTables
            // 
            this.LbTables.FormattingEnabled = true;
            this.LbTables.Location = new System.Drawing.Point(98, 144);
            this.LbTables.Name = "LbTables";
            this.LbTables.Size = new System.Drawing.Size(223, 264);
            this.LbTables.TabIndex = 3;
            this.LbTables.SelectedIndexChanged += new System.EventHandler(this.LbTables_SelectedIndexChanged);
            // 
            // LbTableColumns
            // 
            this.LbTableColumns.FormattingEnabled = true;
            this.LbTableColumns.Location = new System.Drawing.Point(474, 144);
            this.LbTableColumns.Name = "LbTableColumns";
            this.LbTableColumns.Size = new System.Drawing.Size(223, 264);
            this.LbTableColumns.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(403, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Columns:";
            // 
            // LbViews
            // 
            this.LbViews.FormattingEnabled = true;
            this.LbViews.Location = new System.Drawing.Point(842, 144);
            this.LbViews.Name = "LbViews";
            this.LbViews.Size = new System.Drawing.Size(223, 264);
            this.LbViews.TabIndex = 7;
            this.LbViews.SelectedIndexChanged += new System.EventHandler(this.LbViews_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(771, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Views:";
            // 
            // LbViewColumns
            // 
            this.LbViewColumns.FormattingEnabled = true;
            this.LbViewColumns.Location = new System.Drawing.Point(1218, 144);
            this.LbViewColumns.Name = "LbViewColumns";
            this.LbViewColumns.Size = new System.Drawing.Size(223, 264);
            this.LbViewColumns.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1147, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Columns:";
            // 
            // LbParameters
            // 
            this.LbParameters.FormattingEnabled = true;
            this.LbParameters.Location = new System.Drawing.Point(1219, 453);
            this.LbParameters.Name = "LbParameters";
            this.LbParameters.Size = new System.Drawing.Size(223, 264);
            this.LbParameters.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1148, 453);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Parameters:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(403, 453);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Definition:";
            // 
            // LbProcedures
            // 
            this.LbProcedures.FormattingEnabled = true;
            this.LbProcedures.Location = new System.Drawing.Point(98, 453);
            this.LbProcedures.Name = "LbProcedures";
            this.LbProcedures.Size = new System.Drawing.Size(223, 264);
            this.LbProcedures.TabIndex = 11;
            this.LbProcedures.SelectedIndexChanged += new System.EventHandler(this.LbProcedures_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(27, 453);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Procedures:";
            // 
            // TbDefinition
            // 
            this.TbDefinition.Location = new System.Drawing.Point(474, 453);
            this.TbDefinition.Multiline = true;
            this.TbDefinition.Name = "TbDefinition";
            this.TbDefinition.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TbDefinition.Size = new System.Drawing.Size(602, 264);
            this.TbDefinition.TabIndex = 18;
            // 
            // BtnSelectTable
            // 
            this.BtnSelectTable.Location = new System.Drawing.Point(327, 300);
            this.BtnSelectTable.Name = "BtnSelectTable";
            this.BtnSelectTable.Size = new System.Drawing.Size(141, 36);
            this.BtnSelectTable.TabIndex = 19;
            this.BtnSelectTable.Text = "Select table";
            this.BtnSelectTable.UseVisualStyleBackColor = true;
            this.BtnSelectTable.Click += new System.EventHandler(this.SelectButtonClicked);
            // 
            // BtnSelectView
            // 
            this.BtnSelectView.Location = new System.Drawing.Point(1071, 300);
            this.BtnSelectView.Name = "BtnSelectView";
            this.BtnSelectView.Size = new System.Drawing.Size(141, 36);
            this.BtnSelectView.TabIndex = 20;
            this.BtnSelectView.Text = "Select view";
            this.BtnSelectView.UseVisualStyleBackColor = true;
            this.BtnSelectView.Click += new System.EventHandler(this.SelectButtonClicked);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsNewQuery});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1454, 25);
            this.toolStrip1.TabIndex = 21;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsNewQuery
            // 
            this.tsNewQuery.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsNewQuery.Image = global::SqlManager.Properties.Resources.NewQuery;
            this.tsNewQuery.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsNewQuery.Name = "tsNewQuery";
            this.tsNewQuery.Size = new System.Drawing.Size(23, 22);
            this.tsNewQuery.Text = "New query";
            this.tsNewQuery.Click += new System.EventHandler(this.tsNewQuery_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Plum;
            this.ClientSize = new System.Drawing.Size(1454, 754);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.BtnSelectView);
            this.Controls.Add(this.BtnSelectTable);
            this.Controls.Add(this.TbDefinition);
            this.Controls.Add(this.LbParameters);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.LbProcedures);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.LbViewColumns);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.LbViews);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LbTableColumns);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LbTables);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CbDatabases);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sql manager";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CbDatabases;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox LbTables;
        private System.Windows.Forms.ListBox LbTableColumns;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox LbViews;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox LbViewColumns;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox LbParameters;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox LbProcedures;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TbDefinition;
        private System.Windows.Forms.Button BtnSelectTable;
        private System.Windows.Forms.Button BtnSelectView;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsNewQuery;
    }
}

