namespace DKC_Hack_Template
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel_template = new System.Windows.Forms.Panel();
            this.button_standardize = new System.Windows.Forms.Button();
            this.textBox_versionInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox_kkr = new System.Windows.Forms.CheckBox();
            this.menuStrip1.SuspendLayout();
            this.panel_template.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(602, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // panel_template
            // 
            this.panel_template.Controls.Add(this.checkBox_kkr);
            this.panel_template.Controls.Add(this.button_standardize);
            this.panel_template.Controls.Add(this.textBox_versionInput);
            this.panel_template.Controls.Add(this.label1);
            this.panel_template.Location = new System.Drawing.Point(0, 27);
            this.panel_template.Name = "panel_template";
            this.panel_template.Size = new System.Drawing.Size(606, 151);
            this.panel_template.TabIndex = 1;
            this.panel_template.Visible = false;
            // 
            // button_standardize
            // 
            this.button_standardize.Location = new System.Drawing.Point(244, 93);
            this.button_standardize.Name = "button_standardize";
            this.button_standardize.Size = new System.Drawing.Size(100, 23);
            this.button_standardize.TabIndex = 2;
            this.button_standardize.Text = "Save ROM";
            this.button_standardize.UseVisualStyleBackColor = true;
            this.button_standardize.Click += new System.EventHandler(this.button_standardize_Click);
            // 
            // textBox_versionInput
            // 
            this.textBox_versionInput.Location = new System.Drawing.Point(318, 61);
            this.textBox_versionInput.MaxLength = 34;
            this.textBox_versionInput.Name = "textBox_versionInput";
            this.textBox_versionInput.Size = new System.Drawing.Size(100, 20);
            this.textBox_versionInput.TabIndex = 1;
            this.textBox_versionInput.Text = "Version: ";
            this.textBox_versionInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_versionInput_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(350, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Text";
            // 
            // checkBox_kkr
            // 
            this.checkBox_kkr.AutoSize = true;
            this.checkBox_kkr.Checked = true;
            this.checkBox_kkr.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_kkr.Location = new System.Drawing.Point(180, 35);
            this.checkBox_kkr.Name = "checkBox_kkr";
            this.checkBox_kkr.Size = new System.Drawing.Size(85, 43);
            this.checkBox_kkr.TabIndex = 3;
            this.checkBox_kkr.Text = "K Rool\r\nFake Credits\r\nSkip";
            this.checkBox_kkr.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 176);
            this.Controls.Add(this.panel_template);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "DKC Hack Template";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel_template.ResumeLayout(false);
            this.panel_template.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Panel panel_template;
        private System.Windows.Forms.Button button_standardize;
        private System.Windows.Forms.TextBox textBox_versionInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox_kkr;
    }
}

