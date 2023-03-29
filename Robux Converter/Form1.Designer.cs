namespace Robux_Converter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.selectCurrencyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uSDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cADToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eUROToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.britishPoundToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitProgramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(414, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectCurrencyToolStripMenuItem,
            this.quitProgramToolStripMenuItem});
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(38, 22);
            this.toolStripDropDownButton1.Text = "File";
            // 
            // selectCurrencyToolStripMenuItem
            // 
            this.selectCurrencyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uSDToolStripMenuItem,
            this.cADToolStripMenuItem,
            this.eUROToolStripMenuItem,
            this.britishPoundToolStripMenuItem});
            this.selectCurrencyToolStripMenuItem.Name = "selectCurrencyToolStripMenuItem";
            this.selectCurrencyToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.selectCurrencyToolStripMenuItem.Text = "Select Currency:";
            this.selectCurrencyToolStripMenuItem.Click += new System.EventHandler(this.selectCurrencyToolStripMenuItem_Click);
            // 
            // uSDToolStripMenuItem
            // 
            this.uSDToolStripMenuItem.Name = "uSDToolStripMenuItem";
            this.uSDToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.uSDToolStripMenuItem.Text = "USD";
            this.uSDToolStripMenuItem.Click += new System.EventHandler(this.uSDToolStripMenuItem_Click);
            // 
            // cADToolStripMenuItem
            // 
            this.cADToolStripMenuItem.Name = "cADToolStripMenuItem";
            this.cADToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cADToolStripMenuItem.Text = "CAD";
            this.cADToolStripMenuItem.Click += new System.EventHandler(this.cADToolStripMenuItem_Click);
            // 
            // eUROToolStripMenuItem
            // 
            this.eUROToolStripMenuItem.Name = "eUROToolStripMenuItem";
            this.eUROToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.eUROToolStripMenuItem.Text = "EURO";
            this.eUROToolStripMenuItem.Click += new System.EventHandler(this.eUROToolStripMenuItem_Click);
            // 
            // britishPoundToolStripMenuItem
            // 
            this.britishPoundToolStripMenuItem.Name = "britishPoundToolStripMenuItem";
            this.britishPoundToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.britishPoundToolStripMenuItem.Text = "British Pound";
            this.britishPoundToolStripMenuItem.Click += new System.EventHandler(this.britishPoundToolStripMenuItem_Click);
            // 
            // quitProgramToolStripMenuItem
            // 
            this.quitProgramToolStripMenuItem.Name = "quitProgramToolStripMenuItem";
            this.quitProgramToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.quitProgramToolStripMenuItem.Text = "Quit Program";
            this.quitProgramToolStripMenuItem.Click += new System.EventHandler(this.quitProgramToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(148, 50);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Convert!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(133, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Your robux is worth:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(148, 12);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(118, 20);
            this.numericUpDown1.TabIndex = 4;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(157, 79);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(100, 23);
            this.progressBar1.TabIndex = 5;
            this.progressBar1.Visible = false;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 223);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Robux Converter";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem selectCurrencyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitProgramToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uSDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cADToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eUROToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem britishPoundToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

