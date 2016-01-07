namespace Total_Eclipse_Auto_Index_Wizard
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
            System.Windows.Forms.ColumnHeader Paragraphs;
            this.iniList = new System.Windows.Forms.ListView();
            this.userClmn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.howToUseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pghDataList = new System.Windows.Forms.ListView();
            this.displayInfo = new System.Windows.Forms.Label();
            this.exportSelectedPghs = new System.Windows.Forms.Button();
            this.importPGHbtn = new System.Windows.Forms.Button();
            this.addSpecialIndexStylesToSelectedIniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openPGHFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            Paragraphs = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Paragraphs
            // 
            Paragraphs.Text = "Paragraphs";
            Paragraphs.Width = 500;
            // 
            // iniList
            // 
            this.iniList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.userClmn});
            this.iniList.Location = new System.Drawing.Point(12, 27);
            this.iniList.MultiSelect = false;
            this.iniList.Name = "iniList";
            this.iniList.Size = new System.Drawing.Size(371, 207);
            this.iniList.TabIndex = 2;
            this.iniList.UseCompatibleStateImageBehavior = false;
            this.iniList.View = System.Windows.Forms.View.Details;
            this.iniList.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.iniList_ItemSelectionChanged);
            this.iniList.SelectedIndexChanged += new System.EventHandler(this.iniList_SelectedIndexChanged_1);
            // 
            // userClmn
            // 
            this.userClmn.Text = "Users";
            this.userClmn.Width = 406;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(307, 316);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 47);
            this.button1.TabIndex = 4;
            this.button1.Text = "Add Index Styles";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(754, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addSpecialIndexStylesToSelectedIniToolStripMenuItem,
            this.openPGHFileToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(295, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.howToUseToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // howToUseToolStripMenuItem
            // 
            this.howToUseToolStripMenuItem.Name = "howToUseToolStripMenuItem";
            this.howToUseToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.howToUseToolStripMenuItem.Text = "How To Use";
            this.howToUseToolStripMenuItem.Click += new System.EventHandler(this.howToUseToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // pghDataList
            // 
            this.pghDataList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            Paragraphs});
            this.pghDataList.Location = new System.Drawing.Point(389, 27);
            this.pghDataList.Name = "pghDataList";
            this.pghDataList.Size = new System.Drawing.Size(359, 207);
            this.pghDataList.TabIndex = 6;
            this.pghDataList.UseCompatibleStateImageBehavior = false;
            this.pghDataList.View = System.Windows.Forms.View.Details;
            this.pghDataList.ItemMouseHover += new System.Windows.Forms.ListViewItemMouseHoverEventHandler(this.pghDataList_ItemMouseHover);
            // 
            // displayInfo
            // 
            this.displayInfo.AutoSize = true;
            this.displayInfo.Location = new System.Drawing.Point(605, 306);
            this.displayInfo.Name = "displayInfo";
            this.displayInfo.Size = new System.Drawing.Size(35, 13);
            this.displayInfo.TabIndex = 7;
            this.displayInfo.Text = "label1";
            // 
            // exportSelectedPghs
            // 
            this.exportSelectedPghs.Location = new System.Drawing.Point(503, 241);
            this.exportSelectedPghs.Name = "exportSelectedPghs";
            this.exportSelectedPghs.Size = new System.Drawing.Size(169, 47);
            this.exportSelectedPghs.TabIndex = 8;
            this.exportSelectedPghs.Text = "Export Selected";
            this.exportSelectedPghs.UseVisualStyleBackColor = true;
            this.exportSelectedPghs.Click += new System.EventHandler(this.exportSelectedPghs_Click);
            // 
            // importPGHbtn
            // 
            this.importPGHbtn.Location = new System.Drawing.Point(118, 241);
            this.importPGHbtn.Name = "importPGHbtn";
            this.importPGHbtn.Size = new System.Drawing.Size(151, 47);
            this.importPGHbtn.TabIndex = 9;
            this.importPGHbtn.Text = "Import Paragraphs";
            this.importPGHbtn.UseVisualStyleBackColor = true;
            this.importPGHbtn.Click += new System.EventHandler(this.importPGHbtn_Click);
            // 
            // addSpecialIndexStylesToSelectedIniToolStripMenuItem
            // 
            this.addSpecialIndexStylesToSelectedIniToolStripMenuItem.Name = "addSpecialIndexStylesToSelectedIniToolStripMenuItem";
            this.addSpecialIndexStylesToSelectedIniToolStripMenuItem.Size = new System.Drawing.Size(290, 22);
            this.addSpecialIndexStylesToSelectedIniToolStripMenuItem.Text = "Add Special Index Styles To Selected User";
            this.addSpecialIndexStylesToSelectedIniToolStripMenuItem.Click += new System.EventHandler(this.addSpecialIndexStylesToSelectedIniToolStripMenuItem_Click);
            // 
            // openPGHFileToolStripMenuItem
            // 
            this.openPGHFileToolStripMenuItem.Name = "openPGHFileToolStripMenuItem";
            this.openPGHFileToolStripMenuItem.Size = new System.Drawing.Size(290, 22);
            this.openPGHFileToolStripMenuItem.Text = "Open PGH file";
            this.openPGHFileToolStripMenuItem.Click += new System.EventHandler(this.openPGHFileToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 296);
            this.Controls.Add(this.importPGHbtn);
            this.Controls.Add(this.exportSelectedPghs);
            this.Controls.Add(this.displayInfo);
            this.Controls.Add(this.pghDataList);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.iniList);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Total Eclipse Paragraph Wizard";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView iniList;
        private System.Windows.Forms.ColumnHeader userClmn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem howToUseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ListView pghDataList;
        private System.Windows.Forms.Label displayInfo;
        private System.Windows.Forms.Button exportSelectedPghs;
        private System.Windows.Forms.Button importPGHbtn;
        private System.Windows.Forms.ToolStripMenuItem addSpecialIndexStylesToSelectedIniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openPGHFileToolStripMenuItem;
    }
}

