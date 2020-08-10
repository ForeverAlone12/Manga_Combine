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

namespace Manga_Combine
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private DirectoryInfo FolderFrom;
        private DirectoryInfo FolderTo;

        void SelectForlderFrom()
        {
            FBDSelectFolder.ShowDialog();
            tbAddrFrom.Text = FBDSelectFolder.SelectedPath;
            FolderFrom = new DirectoryInfo(FBDSelectFolder.SelectedPath);
        }

        void SelectForlderTo()
        {
            FBDSelectFolder.ShowDialog();
            tbAddrTo.Text = FBDSelectFolder.SelectedPath;
            FolderTo = new DirectoryInfo(FBDSelectFolder.SelectedPath);
        }

        private void btnSelectFolderFrom_Click(object sender, EventArgs e)
        {
            SelectForlderFrom();
        }

        void GetStatistic()
        {
            FolderFrom.li
        }

        void MoveFiles(DirectoryInfo folderManga, DirectoryInfo to)
        {
            foreach (DirectoryInfo folderVolume in folderManga.GetDirectories())
            {
                (file);
            }
        }

        private void btnSelectFolderTo_Click(object sender, EventArgs e)
        {
            SelectForlderTo();
        }
    }
}
