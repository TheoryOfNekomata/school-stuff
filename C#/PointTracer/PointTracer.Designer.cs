namespace PointTracer {
    partial class PointTracer {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.grpboxPoints = new System.Windows.Forms.GroupBox();
            this.listPoints = new System.Windows.Forms.ListView();
            this.colPtX = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPtY = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPtTerminal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnClearPts = new System.Windows.Forms.Button();
            this.grpboxCanvas = new System.Windows.Forms.GroupBox();
            this.canvas = new System.Windows.Forms.PictureBox();
            this.panelFooter = new System.Windows.Forms.FlowLayoutPanel();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnitmUndo = new System.Windows.Forms.ToolStripMenuItem();
            this.mnitmRedo = new System.Windows.Forms.ToolStripMenuItem();
            this.panelSplit = new System.Windows.Forms.SplitContainer();
            this.panelWorkspace = new System.Windows.Forms.Panel();
            this.grpboxPoints.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.grpboxCanvas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).BeginInit();
            this.panelFooter.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelSplit)).BeginInit();
            this.panelSplit.Panel1.SuspendLayout();
            this.panelSplit.Panel2.SuspendLayout();
            this.panelSplit.SuspendLayout();
            this.panelWorkspace.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpboxPoints
            // 
            this.grpboxPoints.Controls.Add(this.listPoints);
            this.grpboxPoints.Controls.Add(this.flowLayoutPanel2);
            this.grpboxPoints.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpboxPoints.Location = new System.Drawing.Point(0, 0);
            this.grpboxPoints.Name = "grpboxPoints";
            this.grpboxPoints.Size = new System.Drawing.Size(171, 254);
            this.grpboxPoints.TabIndex = 0;
            this.grpboxPoints.TabStop = false;
            this.grpboxPoints.Text = "Points";
            // 
            // listPoints
            // 
            this.listPoints.Alignment = System.Windows.Forms.ListViewAlignment.SnapToGrid;
            this.listPoints.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colPtX,
            this.colPtY,
            this.colPtTerminal});
            this.listPoints.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listPoints.FullRowSelect = true;
            this.listPoints.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listPoints.HideSelection = false;
            this.listPoints.Location = new System.Drawing.Point(3, 45);
            this.listPoints.MultiSelect = false;
            this.listPoints.Name = "listPoints";
            this.listPoints.Size = new System.Drawing.Size(165, 206);
            this.listPoints.TabIndex = 4;
            this.listPoints.UseCompatibleStateImageBehavior = false;
            this.listPoints.View = System.Windows.Forms.View.Details;
            // 
            // colPtX
            // 
            this.colPtX.Text = "X";
            this.colPtX.Width = 40;
            // 
            // colPtY
            // 
            this.colPtY.Text = "Y";
            this.colPtY.Width = 40;
            // 
            // colPtTerminal
            // 
            this.colPtTerminal.Text = "Terminal";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoSize = true;
            this.flowLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel2.Controls.Add(this.btnClearPts);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 16);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(165, 29);
            this.flowLayoutPanel2.TabIndex = 0;
            // 
            // btnClearPts
            // 
            this.btnClearPts.AutoSize = true;
            this.btnClearPts.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnClearPts.Location = new System.Drawing.Point(3, 3);
            this.btnClearPts.Name = "btnClearPts";
            this.btnClearPts.Size = new System.Drawing.Size(73, 23);
            this.btnClearPts.TabIndex = 3;
            this.btnClearPts.Text = "&Clear Points";
            this.btnClearPts.UseVisualStyleBackColor = true;
            this.btnClearPts.Click += new System.EventHandler(this.btnClearPts_Click);
            // 
            // grpboxCanvas
            // 
            this.grpboxCanvas.Controls.Add(this.canvas);
            this.grpboxCanvas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpboxCanvas.Location = new System.Drawing.Point(0, 0);
            this.grpboxCanvas.Name = "grpboxCanvas";
            this.grpboxCanvas.Size = new System.Drawing.Size(355, 254);
            this.grpboxCanvas.TabIndex = 0;
            this.grpboxCanvas.TabStop = false;
            this.grpboxCanvas.Text = "Canvas";
            // 
            // canvas
            // 
            this.canvas.BackColor = System.Drawing.Color.White;
            this.canvas.Cursor = System.Windows.Forms.Cursors.Cross;
            this.canvas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.canvas.Location = new System.Drawing.Point(3, 16);
            this.canvas.Name = "canvas";
            this.canvas.Size = new System.Drawing.Size(349, 235);
            this.canvas.TabIndex = 0;
            this.canvas.TabStop = false;
            this.canvas.MouseClick += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseClick);
            // 
            // panelFooter
            // 
            this.panelFooter.AutoSize = true;
            this.panelFooter.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelFooter.BackColor = System.Drawing.SystemColors.Window;
            this.panelFooter.Controls.Add(this.btnGenerate);
            this.panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFooter.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.panelFooter.Location = new System.Drawing.Point(0, 296);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Padding = new System.Windows.Forms.Padding(6, 3, 6, 6);
            this.panelFooter.Size = new System.Drawing.Size(562, 38);
            this.panelFooter.TabIndex = 2;
            // 
            // btnGenerate
            // 
            this.btnGenerate.AutoSize = true;
            this.btnGenerate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGenerate.Location = new System.Drawing.Point(458, 6);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(89, 23);
            this.btnGenerate.TabIndex = 1;
            this.btnGenerate.Text = "&Generate Code";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(562, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnitmUndo,
            this.mnitmRedo});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // mnitmUndo
            // 
            this.mnitmUndo.Enabled = false;
            this.mnitmUndo.Name = "mnitmUndo";
            this.mnitmUndo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.mnitmUndo.Size = new System.Drawing.Size(144, 22);
            this.mnitmUndo.Text = "&Undo";
            this.mnitmUndo.Click += new System.EventHandler(this.mnitmUndo_Click);
            // 
            // mnitmRedo
            // 
            this.mnitmRedo.Enabled = false;
            this.mnitmRedo.Name = "mnitmRedo";
            this.mnitmRedo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.mnitmRedo.Size = new System.Drawing.Size(144, 22);
            this.mnitmRedo.Text = "&Redo";
            this.mnitmRedo.Click += new System.EventHandler(this.mnitmRedo_Click);
            // 
            // panelSplit
            // 
            this.panelSplit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSplit.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.panelSplit.Location = new System.Drawing.Point(12, 12);
            this.panelSplit.Name = "panelSplit";
            // 
            // panelSplit.Panel1
            // 
            this.panelSplit.Panel1.Controls.Add(this.grpboxCanvas);
            this.panelSplit.Panel1MinSize = 200;
            // 
            // panelSplit.Panel2
            // 
            this.panelSplit.Panel2.Controls.Add(this.grpboxPoints);
            this.panelSplit.Size = new System.Drawing.Size(538, 254);
            this.panelSplit.SplitterDistance = 355;
            this.panelSplit.SplitterWidth = 12;
            this.panelSplit.TabIndex = 2;
            // 
            // panelWorkspace
            // 
            this.panelWorkspace.Controls.Add(this.panelSplit);
            this.panelWorkspace.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelWorkspace.Location = new System.Drawing.Point(0, 24);
            this.panelWorkspace.Name = "panelWorkspace";
            this.panelWorkspace.Padding = new System.Windows.Forms.Padding(12, 12, 12, 6);
            this.panelWorkspace.Size = new System.Drawing.Size(562, 272);
            this.panelWorkspace.TabIndex = 2;
            // 
            // PointTracer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 334);
            this.Controls.Add(this.panelWorkspace);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panelFooter);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "PointTracer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PointTracer";
            this.ResizeEnd += new System.EventHandler(this.PointTracer_ResizeEnd);
            this.grpboxPoints.ResumeLayout(false);
            this.grpboxPoints.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.grpboxCanvas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).EndInit();
            this.panelFooter.ResumeLayout(false);
            this.panelFooter.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelSplit.Panel1.ResumeLayout(false);
            this.panelSplit.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelSplit)).EndInit();
            this.panelSplit.ResumeLayout(false);
            this.panelWorkspace.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpboxPoints;
        private System.Windows.Forms.ListView listPoints;
        private System.Windows.Forms.ColumnHeader colPtX;
        private System.Windows.Forms.ColumnHeader colPtY;
        private System.Windows.Forms.GroupBox grpboxCanvas;
        private System.Windows.Forms.PictureBox canvas;
        private System.Windows.Forms.FlowLayoutPanel panelFooter;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button btnClearPts;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnitmUndo;
        private System.Windows.Forms.ToolStripMenuItem mnitmRedo;
        private System.Windows.Forms.ColumnHeader colPtTerminal;
        private System.Windows.Forms.SplitContainer panelSplit;
        private System.Windows.Forms.Panel panelWorkspace;
    }
}

