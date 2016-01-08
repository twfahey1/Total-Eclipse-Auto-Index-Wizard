using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Total_Eclipse_Auto_Index_Wizard
{
    public partial class Form1 : Form
    {
        TEInfoModule teIM = new TEInfoModule();
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (teIM.ReadMainEclipseINI() == true)
            {
                foreach (EclipseObject ini in teIM.CURRENT_LOADED_INI_ECL_OBJS)
                {
                    ListViewItem iniItem = new ListViewItem();
                    
                    iniItem.Tag = ini.FILE_PATH;
                    iniItem.Text = ini.FILE_NAME;
                    iniList.Items.Add(iniItem);
                }
            }
        }

        private void iniList_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void iniList_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            
            
        }

        private void iniList_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (iniList.SelectedItems.Count > 0)
            {
                pghDataList.Items.Clear();    
                var item = iniList.SelectedItems[0];
                var iniDataRead = File.ReadAllLines(iniList.SelectedItems[0].Tag.ToString());
                foreach (string line in iniDataRead)
                {
                    if (line.StartsWith("PghFormat"))
                    {
                        var parts = line.Split('=');
                        var name = parts[1].Split('/');
                        ListViewItem iniItem = new ListViewItem();
                        var pghParts = parts[0].Split('t');
                        //iniItem.Tag = pghParts[1];
                        iniItem.Tag = parts[1];
                        iniItem.Text = name[0];
                        pghDataList.Items.Add(iniItem);
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addCustomIndexStyles();
        }

        private void addCustomIndexStyles()
        {
            /*
            int pghCount = 0;
            System.Text.StringBuilder sbPart1 = new System.Text.StringBuilder();
            System.Text.StringBuilder sbPart2 = new System.Text.StringBuilder();
            System.Text.StringBuilder sbPart3 = new System.Text.StringBuilder();

            bool part1 = true;
            bool part2 = false;
            bool part3 = false;

            int totalPghs = 0;

            var iniDataRead = File.ReadAllLines(iniList.SelectedItems[0].Tag.ToString());
            foreach (string line in iniDataRead)
            {
                if (part1)
                {

                    if (line.StartsWith("TotalPghFormats"))
                    {
                        var split = line.Split('=');
                        totalPghs = Int32.Parse(split[1]);
                        
                    }

                    else if (line.StartsWith("PghFormat"))
                    {
                        sbPart2.Append(line + "\n");
                        part1 = false;
                        part3 = false;
                        part2 = true;
                        pghCount += 1;
                        var parts = line.Split('=');
                        var name = parts[1].Split('/');
                        ListViewItem iniItem = new ListViewItem();
                        var pghParts = parts[0].Split('t');
                        iniItem.Tag = pghParts[1];
                        iniItem.Text = name[0];

                    }
                    else
                    {
                        sbPart1.Append(line + "\n");
                    }
                }
                else if (part2)
                {
                    if (!line.StartsWith("PghFormat"))
                    {
                        sbPart3.Append(line + "\n");
                        part1 = false;
                        part3 = true;
                        part2 = false;
                    }
                    else
                    {
                        sbPart2.Append(line + "\n");

                        pghCount += 1;
                        var parts = line.Split('=');
                        var name = parts[1].Split('/');
                        ListViewItem iniItem = new ListViewItem();
                        var pghParts = parts[0].Split('t');
                        iniItem.Tag = pghParts[1];
                        iniItem.Text = name[0];
                    }
                   
                    
                }
                else if (part3)
                {
                    sbPart3.Append(line + "\n");

                }

            }
            
            //Appends paragraphs to ini
            sbPart2.Append("PghFormat" + pghCount + "=xExbIndx/0/8064/0/1872/0/2/0/0/0/0/0/0/0/0/0/4320/5760/7200/7920/9072/0/0/0/0/0/0/0/0/0/0/");
            totalPghs += 1;
            sbPart2.Append("PghFormat" + pghCount + "=xExbIndxTitle/0/12960/0/0/0/2/0/0/0/0/0/0/0/0/0/1440/2880/4320/5184/6480/6624/7632/7920/9072/0/0/0/0/0/0/0");
            totalPghs += 1;


            //Now we update the TotalPghFormats part of the ini update
            sbPart1.Append("TotalPghFormats=" + (totalPghs));

            //Rewrites the users ini with added pghs
            File.WriteAllText(iniList.SelectedItems[0].Tag.ToString(), (sbPart1.ToString() + "\n" + sbPart2.ToString() + "\n" + sbPart3.ToString()));
            */

            string[] customPghs = { "xExbIndx/0/8064/0/1872/0/2/0/0/0/0/0/0/0/0/0/4320/5760/7200/7920/9072/0/0/0/0/0/0/0/0/0/0/", "xExbIndxTitle/0/12960/0/0/0/2/0/0/0/0/0/0/0/0/0/1440/2880/4320/5184/6480/6624/7632/7920/9072/0/0/0/0/0/0/0" };
            AddPghsToIni(iniList.SelectedItems[0].Tag.ToString(), customPghs);

            //Writes all the files to the blocks path
            string usersBlockPath = teIM.CURRENT_LOADED_INI_ECL_OBJS[iniList.Items.IndexOf(iniList.SelectedItems[0])].INI_BLOCK_PATH;
            File.WriteAllBytes(Path.Combine(usersBlockPath, "xDefendant.ecl"), Properties.Resources.titleTemplate);
            File.WriteAllBytes(Path.Combine(usersBlockPath, "xPlaintiff.ecl"), Properties.Resources.titleTemplate);
            File.WriteAllBytes(Path.Combine(usersBlockPath, "xIndex Templates.ecl"), Properties.Resources.titleTemplate);

            File.WriteAllBytes(Path.Combine(usersBlockPath, "xIndexMark.ecl"), Properties.Resources.xIndexMark);

            File.WriteAllBytes(Path.Combine(usersBlockPath, "indexNames.ecl"), Properties.Resources.indexNames);
            File.WriteAllBytes(Path.Combine(usersBlockPath, "separators.ecl"), Properties.Resources.separators);

            MessageBox.Show("Ini updated");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Total Eclipse Index Wizard v0.3");
        }

        private void howToUseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HowToUse howToUse = new HowToUse();
            howToUse.ShowDialog();

        }

        private void pghDataList_ItemMouseHover(object sender, ListViewItemMouseHoverEventArgs e)
        {
            displayInfo.Text = e.Item.Tag.ToString();
        }

        private void exportSelectedPghs_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            foreach (ListViewItem selectedPGH in pghDataList.SelectedItems)
            {
                sb.Append(selectedPGH.Tag + "\n");
            }

            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "pghExport |*.pgh";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filename = saveFileDialog1.FileName;
                File.WriteAllText(filename, sb.ToString());
                MessageBox.Show("File " + filename + " created.");

            }
        }

        private void importPGHbtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfileDialog = new OpenFileDialog();
            openfileDialog.Filter = "pghExport |*.pgh";
            openfileDialog.FilterIndex = 2;
            openfileDialog.RestoreDirectory = true;

            if (openfileDialog.ShowDialog() == DialogResult.OK)
            {
                string filename = openfileDialog.FileName;
                string[] openFile = File.ReadAllLines(filename);
                AddPghsToIni(iniList.SelectedItems[0].Tag.ToString(), openFile);
                MessageBox.Show("Imported Paragraphs");
            }

        }

        private void AddPghsToIni(string iniToReadPath, string[] pghsToLoad)
        {
            int pghCount = 0;
            System.Text.StringBuilder sbPart1 = new System.Text.StringBuilder();
            System.Text.StringBuilder sbPart2 = new System.Text.StringBuilder();
            System.Text.StringBuilder sbPart3 = new System.Text.StringBuilder();

            bool part1 = true;
            bool part2 = false;
            bool part3 = false;

            int totalPghs = 0;

            var iniDataRead = File.ReadAllLines(iniToReadPath);
            foreach (string line in iniDataRead)
            {
                if (part1)
                {

                    if (line.StartsWith("TotalPghFormats"))
                    {
                        var split = line.Split('=');
                        totalPghs = Int32.Parse(split[1]);

                    }

                    else if (line.StartsWith("PghFormat"))
                    {
                        sbPart2.Append(line + "\n");
                        part1 = false;
                        part3 = false;
                        part2 = true;
                        pghCount += 1;
                        var parts = line.Split('=');
                        var name = parts[1].Split('/');
                        ListViewItem iniItem = new ListViewItem();
                        var pghParts = parts[0].Split('t');
                        iniItem.Tag = pghParts[1];
                        iniItem.Text = name[0];

                    }
                    else
                    {
                        sbPart1.Append(line + "\n");
                    }
                }
                else if (part2)
                {
                    if (!line.StartsWith("PghFormat"))
                    {
                        sbPart3.Append(line + "\n");
                        part1 = false;
                        part3 = true;
                        part2 = false;
                    }
                    else
                    {
                        sbPart2.Append(line + "\n");

                        pghCount += 1;
                        var parts = line.Split('=');
                        var name = parts[1].Split('/');
                        ListViewItem iniItem = new ListViewItem();
                        var pghParts = parts[0].Split('t');
                        iniItem.Tag = pghParts[1];
                        iniItem.Text = name[0];
                    }


                }
                else if (part3)
                {
                    sbPart3.Append(line + "\n");

                }

            }

            foreach (string pgh in pghsToLoad)
            {
                //MessageBox.Show(pgh);
                
                sbPart2.Append("PghFormat" + totalPghs + "=" + pgh + "\n");
                totalPghs += 1;

            }          

            //Now we update the TotalPghFormats part of the ini update
            sbPart1.Append("TotalPghFormats=" + (totalPghs));

            //Rewrites the users ini with added pghs
            File.WriteAllText(iniList.SelectedItems[0].Tag.ToString(), (sbPart1.ToString() + "\n" + sbPart2.ToString() + "\n" + sbPart3.ToString()));


        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void addSpecialIndexStylesToSelectedIniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {

                addCustomIndexStyles();
            }
            catch (Exception addErr)
            {
                MessageBox.Show("Error adding styles, make sure Eclipse user is selected.");
            }
        }

        private void openPGHFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfileDialog = new OpenFileDialog();
            openfileDialog.Filter = "pghExport |*.pgh";
            openfileDialog.FilterIndex = 2;
            openfileDialog.RestoreDirectory = true;

            if (openfileDialog.ShowDialog() == DialogResult.OK)
            {
                pghDataList.Items.Clear();
                string[] openedFile = File.ReadAllLines(openfileDialog.FileName);
                foreach (string pgh in openedFile)
                {
                    ListViewItem item = new ListViewItem();
                    item.Tag = pgh;
                    string[] split = pgh.Split('/');
                    item.Text = split[0];
                    pghDataList.Items.Add(item);
                }
            }
        }

        private void FourColumnExamSelection_CheckedChanged(object sender, EventArgs e)
        {
            OneColumnExamSelection.Checked = false;
            FourColumnExamSelection.Checked = true;

            examPreview.Image = Properties.Resources.Exam_4_Col_Preview;
        }

        private void OneColumnExamSelection_CheckedChanged(object sender, EventArgs e)
        {
            OneColumnExamSelection.Checked = true;
            FourColumnExamSelection.Checked = false;

            examPreview.Image = Properties.Resources.Exam_1_Column_Preview;
        }

        private void FourColumnExamSelection_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void ExbSelection1_CheckedChanged(object sender, EventArgs e)
        {
            exhibitPreview.Image = Properties.Resources.Exhibit_Style_1_Preview;
        }

        private void ExbSelection2_CheckedChanged(object sender, EventArgs e)
        {
            exhibitPreview.Image = Properties.Resources.Exhibit_Style_2_Preview;

        }
    }

    
}
