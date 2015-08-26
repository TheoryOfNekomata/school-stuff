namespace PointTracer {
    partial class CodeBox {
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
            this.panelFooter = new System.Windows.Forms.FlowLayoutPanel();
            this.btnOK = new System.Windows.Forms.Button();
            this.panelWorkspace = new System.Windows.Forms.Panel();
            this.txtboxCode = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.txtboxGraphics = new System.Windows.Forms.ToolStripTextBox();
            this.txtboxPen = new System.Windows.Forms.ToolStripTextBox();
            this.panelFooter.SuspendLayout();
            this.panelWorkspace.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelFooter
            // 
            this.panelFooter.AutoSize = true;
            this.panelFooter.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelFooter.BackColor = System.Drawing.SystemColors.Window;
            this.panelFooter.Controls.Add(this.btnOK);
            this.panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFooter.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.panelFooter.Location = new System.Drawing.Point(0, 246);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Padding = new System.Windows.Forms.Padding(6, 3, 6, 6);
            this.panelFooter.Size = new System.Drawing.Size(484, 38);
            this.panelFooter.TabIndex = 3;
            // 
            // btnOK
            // 
            this.btnOK.AutoSize = true;
            this.btnOK.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(413, 6);
            this.btnOK.Name = "btnOK";
            this.btnOK.Padding = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.btnOK.Size = new System.Drawing.Size(56, 23);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "O&K";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // panelWorkspace
            // 
            this.panelWorkspace.Controls.Add(this.txtboxCode);
            this.panelWorkspace.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelWorkspace.Location = new System.Drawing.Point(0, 27);
            this.panelWorkspace.Name = "panelWorkspace";
            this.panelWorkspace.Padding = new System.Windows.Forms.Padding(12, 12, 12, 6);
            this.panelWorkspace.Size = new System.Drawing.Size(484, 219);
            this.panelWorkspace.TabIndex = 4;
            // 
            // txtboxCode
            // 
            this.txtboxCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtboxCode.Font = new System.Drawing.Font("Consolas", 8.25F);
            this.txtboxCode.Location = new System.Drawing.Point(12, 12);
            this.txtboxCode.Multiline = true;
            this.txtboxCode.Name = "txtboxCode";
            this.txtboxCode.ReadOnly = true;
            this.txtboxCode.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtboxCode.Size = new System.Drawing.Size(460, 201);
            this.txtboxCode.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txtboxGraphics,
            this.txtboxPen});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(484, 27);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // txtboxGraphics
            // 
            this.txtboxGraphics.Name = "txtboxGraphics";
            this.txtboxGraphics.Size = new System.Drawing.Size(100, 23);
            this.txtboxGraphics.Text = "varGraphics";
            this.txtboxGraphics.Leave += new System.EventHandler(this.txtboxGraphics_TextChanged);
            // 
            // txtboxPen
            // 
            this.txtboxPen.Name = "txtboxPen";
            this.txtboxPen.Size = new System.Drawing.Size(100, 23);
            this.txtboxPen.Text = "varPen";
            this.txtboxPen.Leave += new System.EventHandler(this.txtboxPen_TextChanged);
            // 
            // CodeBox
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 284);
            this.ControlBox = false;
            this.Controls.Add(this.panelWorkspace);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panelFooter);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(500, 300);
            this.Name = "CodeBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "PointTracer";
            this.panelFooter.ResumeLayout(false);
            this.panelFooter.PerformLayout();
            this.panelWorkspace.ResumeLayout(false);
            this.panelWorkspace.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel panelFooter;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Panel panelWorkspace;
        private System.Windows.Forms.TextBox txtboxCode;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripTextBox txtboxGraphics;
        private System.Windows.Forms.ToolStripTextBox txtboxPen;

    }
}