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
            this.statStrip = new System.Windows.Forms.StatusStrip();
            this.tsProgBar = new System.Windows.Forms.ToolStripProgressBar();
            this.tsLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnRun = new System.Windows.Forms.Button();
            this.rtxtQuery = new System.Windows.Forms.RichTextBox();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.statStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.SuspendLayout();
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
            // splitContainer
            // 
            this.splitContainer.Location = new System.Drawing.Point(0, 0);
            this.splitContainer.Name = "splitContainer";
            this.splitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.btnExit);
            this.splitContainer.Panel1.Controls.Add(this.btnRun);
            this.splitContainer.Panel1.Controls.Add(this.rtxtQuery);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.dgvData);
            this.splitContainer.Size = new System.Drawing.Size(985, 623);
            this.splitContainer.SplitterDistance = 170;
            this.splitContainer.TabIndex = 5;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(892, 44);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(90, 33);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(892, 5);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(90, 33);
            this.btnRun.TabIndex = 5;
            this.btnRun.Text = "Run Query";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // rtxtQuery
            // 
            this.rtxtQuery.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtQuery.ForeColor = System.Drawing.Color.Blue;
            this.rtxtQuery.Location = new System.Drawing.Point(3, 5);
            this.rtxtQuery.Name = "rtxtQuery";
            this.rtxtQuery.Size = new System.Drawing.Size(883, 164);
            this.rtxtQuery.TabIndex = 4;
            this.rtxtQuery.Text = "SELECT USER FROM Dual";
            // 
            // dgvData
            // 
            this.dgvData.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgvData.Location = new System.Drawing.Point(6, 1);
            this.dgvData.Name = "dgvData";
            this.dgvData.Size = new System.Drawing.Size(976, 445);
            this.dgvData.TabIndex = 1;
            this.dgvData.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvData_RowPostPaint);
            // 
            // ALForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 648);
            this.Controls.Add(this.splitContainer);
            this.Controls.Add(this.statStrip);
            this.Name = "ALForm";
            this.Text = "ALForm";
            this.Resize += new System.EventHandler(this.ALForm_Resize);
            this.statStrip.ResumeLayout(false);
            this.statStrip.PerformLayout();
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip statStrip;
        private System.Windows.Forms.ToolStripProgressBar tsProgBar;
        private System.Windows.Forms.ToolStripStatusLabel tsLabel;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.RichTextBox rtxtQuery;
        private System.Windows.Forms.DataGridView dgvData;
    }
}

