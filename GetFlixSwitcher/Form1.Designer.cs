namespace GetFlixSwitcher
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnLocal = new System.Windows.Forms.ToolStripButton();
            this.btnOverseas = new System.Windows.Forms.ToolStripButton();
            this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
            this.txtFact = new System.Windows.Forms.TextBox();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnLocal,
            this.btnOverseas});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(374, 27);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnLocal
            // 
            this.btnLocal.Image = global::GetFlixSwitcher.Properties.Resources.Australia_48;
            this.btnLocal.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLocal.Name = "btnLocal";
            this.btnLocal.Size = new System.Drawing.Size(68, 24);
            this.btnLocal.Text = "Local";
            this.btnLocal.Click += new System.EventHandler(this.btnLocal_Click);
            // 
            // btnOverseas
            // 
            this.btnOverseas.Image = global::GetFlixSwitcher.Properties.Resources.Sea_Waves_50;
            this.btnOverseas.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOverseas.Name = "btnOverseas";
            this.btnOverseas.Size = new System.Drawing.Size(92, 24);
            this.btnOverseas.Text = "Overseas";
            this.btnOverseas.Click += new System.EventHandler(this.btnOverseas_Click);
            // 
            // propertyGrid1
            // 
            this.propertyGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.propertyGrid1.Location = new System.Drawing.Point(0, 27);
            this.propertyGrid1.Name = "propertyGrid1";
            this.propertyGrid1.Size = new System.Drawing.Size(374, 231);
            this.propertyGrid1.TabIndex = 1;
            // 
            // txtFact
            // 
            this.txtFact.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtFact.Location = new System.Drawing.Point(0, 258);
            this.txtFact.Multiline = true;
            this.txtFact.Name = "txtFact";
            this.txtFact.ReadOnly = true;
            this.txtFact.Size = new System.Drawing.Size(374, 144);
            this.txtFact.TabIndex = 2;
            this.txtFact.TabStop = false;
            this.txtFact.DoubleClick += new System.EventHandler(this.txtFact_DoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 402);
            this.Controls.Add(this.propertyGrid1);
            this.Controls.Add(this.txtFact);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.Text = "Get Flix Switcher";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnLocal;
        private System.Windows.Forms.ToolStripButton btnOverseas;
        private System.Windows.Forms.PropertyGrid propertyGrid1;
        private System.Windows.Forms.TextBox txtFact;
    }
}

