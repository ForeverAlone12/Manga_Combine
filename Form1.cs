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

            SetNameVolume();
            SetNamePart();
            SetCreditsName();
        }

        private DirectoryInfo FolderFrom;
        private DirectoryInfo FolderTo;
        string CreditsName;
        string VolumeName;
        string PartName;

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
            //FolderFrom.li
        }

        void MoveFiles(DirectoryInfo folderManga, DirectoryInfo folderTo)
        {
            string NewFileName;
            foreach (DirectoryInfo folderVolume in folderManga.GetDirectories())
            {
                foreach (DirectoryInfo folderPart in folderVolume.GetDirectories())
                {
                    foreach (FileInfo file in folderPart.GetFiles())
                    {
                        if (file.Name != CreditsName)
                        {
                            NewFileName = folderVolume.Name + '_' + folderPart + '_' + file.Name;
                            file.MoveTo(folderTo.FullName + '/' + NewFileName);
                        }
                    }
                }
            }
        }

        void PrepareFoldres(DirectoryInfo folderManga)
        {
            DirectoryInfo NewFolder;
            String NumVolume;
            String NumPart;
            int pos;
            foreach (DirectoryInfo folder in folderManga.GetDirectories())
            {
                pos = folder.Name.IndexOf(VolumeName) + VolumeName.Length + 1;
                NumVolume = folder.Name.Substring(pos, folder.Name.IndexOf(' ', pos) - pos);
                NumVolume = NumVolume.PadLeft(4, '0');

                pos = folder.Name.IndexOf(PartName) + PartName.Length + 1;
                NumPart = folder.Name.Substring(pos, folder.Name.IndexOf(' ', pos) - pos);
                NumPart = NumPart.PadLeft(7, '0');

                NewFolder = new DirectoryInfo(folderManga + "\\Folders" + '\\' + NumVolume);
                NewFolder.Create();

                NewFolder = new DirectoryInfo(folderManga + "\\Folders" + '\\' + NumVolume +'\\' + NumPart);

                Directory.Move(folder.FullName, NewFolder.FullName);
            }
        }

        private void btnSelectFolderTo_Click(object sender, EventArgs e)
        {
            SelectForlderTo();
        }

        void SetNameVolume()
        {
            VolumeName = tbVolumeName.Text;
        }

        void SetNamePart()
        {
            PartName = tbPartName.Text;
        }

        void SetCreditsName()
        {
            CreditsName = tbCreditsName.Text;
        }

        private void btnPrepareFolders_Click(object sender, EventArgs e)
        {
            PrepareFoldres(FolderFrom);
        }

        private void tbVolumeName_TextChanged(object sender, EventArgs e)
        {
            SetNameVolume();
        }

        private void tbPartName_TextChanged(object sender, EventArgs e)
        {
            SetNamePart();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            MoveFiles(FolderFrom, FolderTo);
        }

        private void tbCreditsName_TextChanged(object sender, EventArgs e)
        {
            SetCreditsName();
        }
    }
}
