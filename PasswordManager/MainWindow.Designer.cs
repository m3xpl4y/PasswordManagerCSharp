
namespace PasswordManager
{
    partial class MainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dateiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.neuesPasswortHinzufügenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.beendenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.einstellungenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ansichtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.neuesPasswortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.meinePasswörterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnControl = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.flPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.btnMenu = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dateiToolStripMenuItem,
            this.ansichtToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(884, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dateiToolStripMenuItem
            // 
            this.dateiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.neuesPasswortHinzufügenToolStripMenuItem,
            this.einstellungenToolStripMenuItem,
            this.beendenToolStripMenuItem});
            this.dateiToolStripMenuItem.Name = "dateiToolStripMenuItem";
            this.dateiToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.dateiToolStripMenuItem.Text = "Datei";
            // 
            // neuesPasswortHinzufügenToolStripMenuItem
            // 
            this.neuesPasswortHinzufügenToolStripMenuItem.MergeIndex = 1;
            this.neuesPasswortHinzufügenToolStripMenuItem.Name = "neuesPasswortHinzufügenToolStripMenuItem";
            this.neuesPasswortHinzufügenToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.neuesPasswortHinzufügenToolStripMenuItem.Text = "Neues Passwort";
            this.neuesPasswortHinzufügenToolStripMenuItem.Click += new System.EventHandler(this.neuesPasswortHinzufügenToolStripMenuItem_Click);
            // 
            // beendenToolStripMenuItem
            // 
            this.beendenToolStripMenuItem.MergeIndex = 3;
            this.beendenToolStripMenuItem.Name = "beendenToolStripMenuItem";
            this.beendenToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.beendenToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.beendenToolStripMenuItem.Text = "Beenden";
            // 
            // einstellungenToolStripMenuItem
            // 
            this.einstellungenToolStripMenuItem.MergeIndex = 2;
            this.einstellungenToolStripMenuItem.Name = "einstellungenToolStripMenuItem";
            this.einstellungenToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.einstellungenToolStripMenuItem.Text = "Einstellungen";
            // 
            // ansichtToolStripMenuItem
            // 
            this.ansichtToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.neuesPasswortToolStripMenuItem,
            this.meinePasswörterToolStripMenuItem});
            this.ansichtToolStripMenuItem.Name = "ansichtToolStripMenuItem";
            this.ansichtToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.ansichtToolStripMenuItem.Text = "Ansicht";
            // 
            // neuesPasswortToolStripMenuItem
            // 
            this.neuesPasswortToolStripMenuItem.Name = "neuesPasswortToolStripMenuItem";
            this.neuesPasswortToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.neuesPasswortToolStripMenuItem.Text = "Neues Passwort";
            // 
            // meinePasswörterToolStripMenuItem
            // 
            this.meinePasswörterToolStripMenuItem.Name = "meinePasswörterToolStripMenuItem";
            this.meinePasswörterToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.meinePasswörterToolStripMenuItem.Text = "Meine Passwörter";
            // 
            // pnControl
            // 
            this.pnControl.AutoSize = true;
            this.pnControl.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnControl.Location = new System.Drawing.Point(884, 24);
            this.pnControl.Name = "pnControl";
            this.pnControl.Size = new System.Drawing.Size(0, 426);
            this.pnControl.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(0, 53);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(135, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Neues Passwort";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // flPanel
            // 
            this.flPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.flPanel.Location = new System.Drawing.Point(141, 24);
            this.flPanel.Name = "flPanel";
            this.flPanel.Size = new System.Drawing.Size(743, 426);
            this.flPanel.TabIndex = 3;
            // 
            // btnMenu
            // 
            this.btnMenu.Location = new System.Drawing.Point(0, 24);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(135, 23);
            this.btnMenu.TabIndex = 4;
            this.btnMenu.Text = "Meine Passwörter";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(884, 450);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.flPanel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.pnControl);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWindow";
            this.Text = "Password Manager Pro";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dateiToolStripMenuItem;
        private System.Windows.Forms.Panel pnControl;        
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.FlowLayoutPanel flPanel;
        private System.Windows.Forms.ToolStripMenuItem neuesPasswortHinzufügenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem beendenToolStripMenuItem;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.ToolStripMenuItem einstellungenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ansichtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem neuesPasswortToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem meinePasswörterToolStripMenuItem;
    }

}

