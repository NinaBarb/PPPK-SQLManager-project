namespace SqlManager
{
    partial class NewQueryForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.TbQuery = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.TabResults = new System.Windows.Forms.TabPage();
            this.Flp = new System.Windows.Forms.FlowLayoutPanel();
            this.TabMsg = new System.Windows.Forms.TabPage();
            this.LbMessage = new System.Windows.Forms.Label();
            this.StatusStrip = new System.Windows.Forms.StatusStrip();
            this.LbStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.TsExecute = new System.Windows.Forms.ToolStripButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.TabResults.SuspendLayout();
            this.TabMsg.SuspendLayout();
            this.StatusStrip.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.TbQuery, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tabControl1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.StatusStrip, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.747775F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55.50787F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35.62232F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.005723F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1227, 699);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // TbQuery
            // 
            this.TbQuery.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TbQuery.Location = new System.Drawing.Point(3, 36);
            this.TbQuery.Multiline = true;
            this.TbQuery.Name = "TbQuery";
            this.TbQuery.Size = new System.Drawing.Size(1221, 382);
            this.TbQuery.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.TabResults);
            this.tabControl1.Controls.Add(this.TabMsg);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(3, 424);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1221, 243);
            this.tabControl1.TabIndex = 1;
            // 
            // TabResults
            // 
            this.TabResults.Controls.Add(this.Flp);
            this.TabResults.Location = new System.Drawing.Point(4, 22);
            this.TabResults.Name = "TabResults";
            this.TabResults.Padding = new System.Windows.Forms.Padding(3);
            this.TabResults.Size = new System.Drawing.Size(1213, 217);
            this.TabResults.TabIndex = 0;
            this.TabResults.Text = "Results";
            this.TabResults.UseVisualStyleBackColor = true;
            // 
            // Flp
            // 
            this.Flp.AutoScroll = true;
            this.Flp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Flp.Location = new System.Drawing.Point(3, 3);
            this.Flp.Name = "Flp";
            this.Flp.Size = new System.Drawing.Size(1207, 211);
            this.Flp.TabIndex = 0;
            // 
            // TabMsg
            // 
            this.TabMsg.Controls.Add(this.LbMessage);
            this.TabMsg.Location = new System.Drawing.Point(4, 22);
            this.TabMsg.Name = "TabMsg";
            this.TabMsg.Padding = new System.Windows.Forms.Padding(3);
            this.TabMsg.Size = new System.Drawing.Size(1213, 217);
            this.TabMsg.TabIndex = 1;
            this.TabMsg.Text = "Messages";
            this.TabMsg.UseVisualStyleBackColor = true;
            // 
            // LbMessage
            // 
            this.LbMessage.AutoSize = true;
            this.LbMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LbMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LbMessage.ForeColor = System.Drawing.Color.Red;
            this.LbMessage.Location = new System.Drawing.Point(3, 3);
            this.LbMessage.Name = "LbMessage";
            this.LbMessage.Size = new System.Drawing.Size(0, 13);
            this.LbMessage.TabIndex = 0;
            // 
            // StatusStrip
            // 
            this.StatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LbStatus});
            this.StatusStrip.Location = new System.Drawing.Point(0, 677);
            this.StatusStrip.Name = "StatusStrip";
            this.StatusStrip.Size = new System.Drawing.Size(1227, 22);
            this.StatusStrip.TabIndex = 2;
            // 
            // LbStatus
            // 
            this.LbStatus.BackColor = System.Drawing.SystemColors.Window;
            this.LbStatus.Name = "LbStatus";
            this.LbStatus.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsExecute});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1227, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // TsExecute
            // 
            this.TsExecute.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TsExecute.Image = global::SqlManager.Properties.Resources.ExecuteBtn;
            this.TsExecute.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsExecute.Name = "TsExecute";
            this.TsExecute.Size = new System.Drawing.Size(23, 22);
            this.TsExecute.Text = "Execute query";
            this.TsExecute.Click += new System.EventHandler(this.TsExecute_Click);
            // 
            // NewQueryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Plum;
            this.ClientSize = new System.Drawing.Size(1227, 699);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.KeyPreview = true;
            this.Name = "NewQueryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NewQueryForm";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NewQueryForm_KeyDown);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.TabResults.ResumeLayout(false);
            this.TabMsg.ResumeLayout(false);
            this.TabMsg.PerformLayout();
            this.StatusStrip.ResumeLayout(false);
            this.StatusStrip.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox TbQuery;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage TabResults;
        private System.Windows.Forms.TabPage TabMsg;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.StatusStrip StatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel LbStatus;
        private System.Windows.Forms.ToolStripButton TsExecute;
        private System.Windows.Forms.Label LbMessage;
        private System.Windows.Forms.FlowLayoutPanel Flp;
    }
}