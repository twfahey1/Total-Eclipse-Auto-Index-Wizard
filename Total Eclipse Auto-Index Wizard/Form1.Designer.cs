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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ColumnHeader Paragraphs;
            this.iniList = new System.Windows.Forms.ListView();
            this.userClmn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addSpecialIndexStylesToSelectedIniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openPGHFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.howToUseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pghDataList = new System.Windows.Forms.ListView();
            this.displayInfo = new System.Windows.Forms.Label();
            this.exportSelectedPghs = new System.Windows.Forms.Button();
            this.importPGHbtn = new System.Windows.Forms.Button();
            this.FourColumnExamSelection = new System.Windows.Forms.RadioButton();
            this.ExbSelection2 = new System.Windows.Forms.RadioButton();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.ExbSelection1 = new System.Windows.Forms.RadioButton();
            this.OneColumnExamSelection = new System.Windows.Forms.RadioButton();
            this.exhibitPreview = new System.Windows.Forms.PictureBox();
            this.examPreview = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            Paragraphs = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exhibitPreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.examPreview)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
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
            this.iniList.Size = new System.Drawing.Size(523, 207);
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
            this.button1.Location = new System.Drawing.Point(407, 675);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(290, 94);
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
            this.menuStrip1.Size = new System.Drawing.Size(1176, 24);
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
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(290, 22);
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
            this.pghDataList.Location = new System.Drawing.Point(601, 27);
            this.pghDataList.Name = "pghDataList";
            this.pghDataList.Size = new System.Drawing.Size(508, 207);
            this.pghDataList.TabIndex = 6;
            this.pghDataList.UseCompatibleStateImageBehavior = false;
            this.pghDataList.View = System.Windows.Forms.View.Details;
            this.pghDataList.ItemMouseHover += new System.Windows.Forms.ListViewItemMouseHoverEventHandler(this.pghDataList_ItemMouseHover);
            // 
            // displayInfo
            // 
            this.displayInfo.AutoSize = true;
            this.displayInfo.Location = new System.Drawing.Point(1115, 275);
            this.displayInfo.Name = "displayInfo";
            this.displayInfo.Size = new System.Drawing.Size(35, 13);
            this.displayInfo.TabIndex = 7;
            this.displayInfo.Text = "label1";
            this.displayInfo.Visible = false;
            // 
            // exportSelectedPghs
            // 
            this.exportSelectedPghs.Location = new System.Drawing.Point(601, 241);
            this.exportSelectedPghs.Name = "exportSelectedPghs";
            this.exportSelectedPghs.Size = new System.Drawing.Size(508, 47);
            this.exportSelectedPghs.TabIndex = 8;
            this.exportSelectedPghs.Text = "Export Selected";
            this.exportSelectedPghs.UseVisualStyleBackColor = true;
            this.exportSelectedPghs.Click += new System.EventHandler(this.exportSelectedPghs_Click);
            // 
            // importPGHbtn
            // 
            this.importPGHbtn.Location = new System.Drawing.Point(12, 240);
            this.importPGHbtn.Name = "importPGHbtn";
            this.importPGHbtn.Size = new System.Drawing.Size(523, 47);
            this.importPGHbtn.TabIndex = 9;
            this.importPGHbtn.Text = "Import Paragraphs";
            this.importPGHbtn.UseVisualStyleBackColor = true;
            this.importPGHbtn.Click += new System.EventHandler(this.importPGHbtn_Click);
            // 
            // FourColumnExamSelection
            // 
            this.FourColumnExamSelection.AutoSize = true;
            this.FourColumnExamSelection.Location = new System.Drawing.Point(14, 96);
            this.FourColumnExamSelection.Name = "FourColumnExamSelection";
            this.FourColumnExamSelection.Size = new System.Drawing.Size(69, 17);
            this.FourColumnExamSelection.TabIndex = 10;
            this.FourColumnExamSelection.TabStop = true;
            this.FourColumnExamSelection.Text = "4-Column";
            this.FourColumnExamSelection.UseVisualStyleBackColor = true;
            this.FourColumnExamSelection.CheckedChanged += new System.EventHandler(this.FourColumnExamSelection_CheckedChanged_1);
            this.FourColumnExamSelection.Click += new System.EventHandler(this.FourColumnExamSelection_CheckedChanged);
            // 
            // ExbSelection2
            // 
            this.ExbSelection2.AutoSize = true;
            this.ExbSelection2.Location = new System.Drawing.Point(13, 95);
            this.ExbSelection2.Name = "ExbSelection2";
            this.ExbSelection2.Size = new System.Drawing.Size(91, 17);
            this.ExbSelection2.TabIndex = 11;
            this.ExbSelection2.TabStop = true;
            this.ExbSelection2.Text = "Exhibit Style 2";
            this.ExbSelection2.UseVisualStyleBackColor = true;
            this.ExbSelection2.CheckedChanged += new System.EventHandler(this.ExbSelection2_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(14, 38);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(92, 17);
            this.checkBox1.TabIndex = 12;
            this.checkBox1.Text = "Add this index";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(13, 37);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(92, 17);
            this.checkBox2.TabIndex = 13;
            this.checkBox2.Text = "Add this index";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Examination";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Exhibits";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // ExbSelection1
            // 
            this.ExbSelection1.AutoSize = true;
            this.ExbSelection1.Location = new System.Drawing.Point(13, 72);
            this.ExbSelection1.Name = "ExbSelection1";
            this.ExbSelection1.Size = new System.Drawing.Size(91, 17);
            this.ExbSelection1.TabIndex = 18;
            this.ExbSelection1.TabStop = true;
            this.ExbSelection1.Text = "Exhibit Style 1";
            this.ExbSelection1.UseVisualStyleBackColor = true;
            this.ExbSelection1.CheckedChanged += new System.EventHandler(this.ExbSelection1_CheckedChanged);
            // 
            // OneColumnExamSelection
            // 
            this.OneColumnExamSelection.AutoSize = true;
            this.OneColumnExamSelection.Location = new System.Drawing.Point(14, 73);
            this.OneColumnExamSelection.Name = "OneColumnExamSelection";
            this.OneColumnExamSelection.Size = new System.Drawing.Size(69, 17);
            this.OneColumnExamSelection.TabIndex = 19;
            this.OneColumnExamSelection.TabStop = true;
            this.OneColumnExamSelection.Text = "1-Column";
            this.OneColumnExamSelection.UseVisualStyleBackColor = true;
            this.OneColumnExamSelection.Click += new System.EventHandler(this.OneColumnExamSelection_CheckedChanged);
            // 
            // exhibitPreview
            // 
            this.exhibitPreview.Location = new System.Drawing.Point(601, 429);
            this.exhibitPreview.Name = "exhibitPreview";
            this.exhibitPreview.Size = new System.Drawing.Size(565, 204);
            this.exhibitPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.exhibitPreview.TabIndex = 17;
            this.exhibitPreview.TabStop = false;
            // 
            // examPreview
            // 
            this.examPreview.Location = new System.Drawing.Point(12, 429);
            this.examPreview.Name = "examPreview";
            this.examPreview.Size = new System.Drawing.Size(537, 204);
            this.examPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.examPreview.TabIndex = 16;
            this.examPreview.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.FourColumnExamSelection);
            this.panel1.Controls.Add(this.OneColumnExamSelection);
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 293);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(121, 130);
            this.panel1.TabIndex = 20;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ExbSelection2);
            this.panel2.Controls.Add(this.checkBox2);
            this.panel2.Controls.Add(this.ExbSelection1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(601, 294);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(209, 129);
            this.panel2.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 799);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.exhibitPreview);
            this.Controls.Add(this.examPreview);
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
            this.Text = "`";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exhibitPreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.examPreview)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
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
        private System.Windows.Forms.RadioButton FourColumnExamSelection;
        private System.Windows.Forms.RadioButton ExbSelection2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox examPreview;
        private System.Windows.Forms.PictureBox exhibitPreview;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.RadioButton ExbSelection1;
        private System.Windows.Forms.RadioButton OneColumnExamSelection;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}

