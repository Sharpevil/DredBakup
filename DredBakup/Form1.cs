using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace DredBakup
{
    public partial class Form1 : Form
    {
        private int backupCount = 1;

        FolderBrowserDialog sourceFolder = new FolderBrowserDialog();
        FolderBrowserDialog destinationFolder = new FolderBrowserDialog();

        Timer timer = new Timer();

        Color control = new Color();

        public Form1()
        {
            InitializeComponent();
            sourceFolder.SelectedPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            sourceFolder.SelectedPath += @"\Gaslamp Games\Dungeons of Dredmor";
            control = btnAutoStart.BackColor;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sourceFolder.ShowDialog();
            tbxSource.Text = sourceFolder.SelectedPath;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            destinationFolder.ShowDialog();
            tbxDestination.Text = destinationFolder.SelectedPath;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown1.Value < 1)
                numericUpDown1.Value = 1;
        }

        private void btnBakNow_Click(object sender, EventArgs e)
        {
            backup();
        }

        private void btnAutoStart_Click(object sender, EventArgs e)
        {
            backup();
            timer.Interval = 60*1000* (int)numericUpDown1.Value;
            timer.Tick += timerTick;
            timer.Start();
            btnAutoStart.BackColor = Color.Chartreuse;
        }

        void timerTick(object sender, EventArgs e)
        {
            backup();
        }

        private void btnAutoStop_Click(object sender, EventArgs e)
        {
            timer.Stop();
            btnAutoStart.BackColor = control;
        }

    private void btnNuke_Click(object sender, EventArgs e)
        {
            NukeTheDiggles();
        }



        private void backup()
        {
            DirectoryInfo source = new DirectoryInfo(sourceFolder.SelectedPath);

            if (!source.Exists)
            {
                throw new DirectoryNotFoundException(
                    "Source directory does not exist or could not be found: "
                    + sourceFolder.SelectedPath);
            }

            if (!Directory.Exists(destinationFolder.SelectedPath))
                Directory.CreateDirectory(destinationFolder.SelectedPath);

            Directory.CreateDirectory(destinationFolder.SelectedPath + @"\backup" + backupCount.ToString());
            string finalDest = destinationFolder.SelectedPath + @"\backup" + backupCount.ToString();

            if (backupCount > 5)
            {
                string outdated = destinationFolder.SelectedPath + @"\backup" + (backupCount - 5).ToString();
                Directory.Delete(outdated, true);
            }

            FileInfo[] files = source.GetFiles();
            foreach (FileInfo file in files)
            {
                string temppath = Path.Combine(finalDest, file.Name);
                file.CopyTo(temppath, false);
            }

            backupCount++;
        }

        private void NukeTheDiggles()
        {
            if (destinationFolder.SelectedPath == "" || !Directory.Exists(destinationFolder.SelectedPath))
                return;

            DialogResult nuke = MessageBox.Show(
                "This will delete the Directory " + destinationFolder.SelectedPath +
                "! Are you sure you want to continue?", "Dag, yo.", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (nuke == DialogResult.Yes)
                Directory.Delete(destinationFolder.SelectedPath, true);
        }
    }
}
