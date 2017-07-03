namespace Dictionary
{
    partial class DictionaryMain
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
            this.addWordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateWordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteWordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtSearch = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lvlMeaning = new MaterialSkin.Controls.MaterialLabel();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(466, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addWordToolStripMenuItem,
            this.updateWordToolStripMenuItem,
            this.displayToolStripMenuItem,
            this.deleteWordToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // addWordToolStripMenuItem
            // 
            this.addWordToolStripMenuItem.Name = "addWordToolStripMenuItem";
            this.addWordToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.addWordToolStripMenuItem.Text = "Add Word";
            this.addWordToolStripMenuItem.Click += new System.EventHandler(this.addWordToolStripMenuItem_Click);
            // 
            // updateWordToolStripMenuItem
            // 
            this.updateWordToolStripMenuItem.Name = "updateWordToolStripMenuItem";
            this.updateWordToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.updateWordToolStripMenuItem.Text = "Update Word";
            this.updateWordToolStripMenuItem.Click += new System.EventHandler(this.updateWordToolStripMenuItem_Click);
            // 
            // displayToolStripMenuItem
            // 
            this.displayToolStripMenuItem.Name = "displayToolStripMenuItem";
            this.displayToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.displayToolStripMenuItem.Text = "Display";
            this.displayToolStripMenuItem.Click += new System.EventHandler(this.displayToolStripMenuItem_Click);
            // 
            // deleteWordToolStripMenuItem
            // 
            this.deleteWordToolStripMenuItem.Name = "deleteWordToolStripMenuItem";
            this.deleteWordToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.deleteWordToolStripMenuItem.Text = "Delete Word";
            this.deleteWordToolStripMenuItem.Click += new System.EventHandler(this.deleteWordToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(466, 63);
            this.panel1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(110, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(252, 33);
            this.label2.TabIndex = 0;
            this.label2.Text = "MDES Dictionary";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(321, 140);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(43, 144);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(76, 19);
            this.materialLabel1.TabIndex = 8;
            this.materialLabel1.Text = "Find Word";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(43, 208);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(66, 19);
            this.materialLabel2.TabIndex = 9;
            this.materialLabel2.Text = "Meaning";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 334);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(466, 55);
            this.panel2.TabIndex = 10;
            // 
            // txtSearch
            // 
            this.txtSearch.Depth = 0;
            this.txtSearch.Hint = "";
            this.txtSearch.Location = new System.Drawing.Point(141, 140);
            this.txtSearch.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(165, 23);
            this.txtSearch.TabIndex = 11;
            // 
            // lvlMeaning
            // 
            this.lvlMeaning.AutoSize = true;
            this.lvlMeaning.Depth = 0;
            this.lvlMeaning.Font = new System.Drawing.Font("Roboto", 11F);
            this.lvlMeaning.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lvlMeaning.Location = new System.Drawing.Point(138, 208);
            this.lvlMeaning.MouseState = MaterialSkin.MouseState.HOVER;
            this.lvlMeaning.Name = "lvlMeaning";
            this.lvlMeaning.Size = new System.Drawing.Size(0, 19);
            this.lvlMeaning.TabIndex = 12;
            // 
            // DictionaryMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 389);
            this.Controls.Add(this.lvlMeaning);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "DictionaryMain";
            this.Text = "Dictionary";
            this.Load += new System.EventHandler(this.DictionaryMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addWordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateWordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteWordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSearch;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.Panel panel2;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtSearch;
        private MaterialSkin.Controls.MaterialLabel lvlMeaning;
        private System.Windows.Forms.ToolStripMenuItem displayToolStripMenuItem;
    }
}

