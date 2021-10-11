namespace SqlManager
{
    partial class SelectResultsForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DgvResults = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DgvResults)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvResults
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Thistle;
            this.DgvResults.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvResults.Location = new System.Drawing.Point(0, 0);
            this.DgvResults.Name = "DgvResults";
            this.DgvResults.Size = new System.Drawing.Size(800, 450);
            this.DgvResults.TabIndex = 0;
            // 
            // SelectResultsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DgvResults);
            this.Name = "SelectResultsForm";
            this.Text = "SelectResultsForm";
            ((System.ComponentModel.ISupportInitialize)(this.DgvResults)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvResults;
    }
}