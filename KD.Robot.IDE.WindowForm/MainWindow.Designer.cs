namespace KD.Robot.IDE.WindowForm
{
    partial class MainWindow
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
            this.Menu = new System.Windows.Forms.MenuStrip();
            this.TS_File = new System.Windows.Forms.ToolStripMenuItem();
            this.RTB_Commands = new System.Windows.Forms.RichTextBox();
            this.B_Execute = new System.Windows.Forms.Button();
            this.Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // Menu
            // 
            this.Menu.BackColor = System.Drawing.SystemColors.Control;
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TS_File});
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(593, 24);
            this.Menu.TabIndex = 0;
            this.Menu.Text = "Menu";
            // 
            // TS_File
            // 
            this.TS_File.Name = "TS_File";
            this.TS_File.Size = new System.Drawing.Size(37, 20);
            this.TS_File.Text = "File";
            // 
            // RTB_Commands
            // 
            this.RTB_Commands.BackColor = System.Drawing.SystemColors.ControlDark;
            this.RTB_Commands.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.RTB_Commands.ForeColor = System.Drawing.SystemColors.Info;
            this.RTB_Commands.Location = new System.Drawing.Point(13, 28);
            this.RTB_Commands.Name = "RTB_Commands";
            this.RTB_Commands.Size = new System.Drawing.Size(568, 292);
            this.RTB_Commands.TabIndex = 1;
            this.RTB_Commands.Text = "";
            this.RTB_Commands.TextChanged += new System.EventHandler(this.RTB_Commands_TextChanged);
            // 
            // B_Execute
            // 
            this.B_Execute.Location = new System.Drawing.Point(495, 326);
            this.B_Execute.Name = "B_Execute";
            this.B_Execute.Size = new System.Drawing.Size(85, 31);
            this.B_Execute.TabIndex = 2;
            this.B_Execute.Text = "Execute";
            this.B_Execute.UseVisualStyleBackColor = true;
            this.B_Execute.Click += new System.EventHandler(this.B_Execute_Click);
            // 
            // MainWindow
            // 
            this.AcceptButton = this.B_Execute;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(593, 369);
            this.Controls.Add(this.B_Execute);
            this.Controls.Add(this.RTB_Commands);
            this.Controls.Add(this.Menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.Menu;
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.Text = "KD.Robot.IDE";
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip Menu;
        private System.Windows.Forms.ToolStripMenuItem TS_File;
        private System.Windows.Forms.RichTextBox RTB_Commands;
        private System.Windows.Forms.Button B_Execute;
    }
}

