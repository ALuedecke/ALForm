namespace ALForm
{
    partial class ALForm
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
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.rtxtQuery = new System.Windows.Forms.RichTextBox();
            this.btnRun = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.statStrip = new System.Windows.Forms.StatusStrip();
            this.tsProgBar = new System.Windows.Forms.ToolStripProgressBar();
            this.tsLabel = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.statStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvData
            // 
            this.dgvData.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgvData.Location = new System.Drawing.Point(6, 220);
            this.dgvData.Name = "dgvData";
            this.dgvData.Size = new System.Drawing.Size(979, 403);
            this.dgvData.TabIndex = 0;
            this.dgvData.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvData_RowPostPaint);
            // 
            // rtxtQuery
            // 
            this.rtxtQuery.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtQuery.ForeColor = System.Drawing.Color.Blue;
            this.rtxtQuery.Location = new System.Drawing.Point(6, 11);
            this.rtxtQuery.Name = "rtxtQuery";
            this.rtxtQuery.Size = new System.Drawing.Size(883, 203);
            this.rtxtQuery.TabIndex = 1;
            this.rtxtQuery.Text = "SELECT USER FROM Dual";
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(895, 11);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(90, 33);
            this.btnRun.TabIndex = 2;
            this.btnRun.Text = "Run Query";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            this.btnRun.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btnRun_KeyPress);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(895, 50);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(90, 33);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            this.btnExit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btnExit_KeyPress);
            // 
            // statStrip
            // 
            this.statStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsProgBar,
            this.tsLabel});
            this.statStrip.Location = new System.Drawing.Point(0, 626);
            this.statStrip.Name = "statStrip";
            this.statStrip.Size = new System.Drawing.Size(987, 22);
            this.statStrip.TabIndex = 4;
            this.statStrip.Text = "ALuedecke";
            // 
            // tsProgBar
            // 
            this.tsProgBar.Name = "tsProgBar";
            this.tsProgBar.Size = new System.Drawing.Size(100, 16);
            // 
            // tsLabel
            // 
            this.tsLabel.Name = "tsLabel";
            this.tsLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // ALForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 648);
            this.Controls.Add(this.statStrip);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.rtxtQuery);
            this.Controls.Add(this.dgvData);
            this.Name = "ALForm";
            this.Text = "ALForm";
            this.Resize += new System.EventHandler(this.ALForm_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.statStrip.ResumeLayout(false);
            this.statStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.RichTextBox rtxtQuery;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.StatusStrip statStrip;
        private System.Windows.Forms.ToolStripProgressBar tsProgBar;
        private System.Windows.Forms.ToolStripStatusLabel tsLabel;
    }
}

