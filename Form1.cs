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
    public partial class Form1 : Form
    {

        private String inputPath;
        private String outputPath;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            checkFolder(inputPath);
        }

        private void checkFolder(String pathToFolder)
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(pathToFolder);

            DirectoryInfo[] folders = directoryInfo.GetDirectories();

            if (folders.Length == 0)
            {
                FileInfo[] files = directoryInfo.GetFiles();
                foreach (FileInfo file in files)
                {
                    checkFile(file);
                }
            }
            else
            {
                foreach (DirectoryInfo folder in folders)
                {
                    Console.WriteLine("Название папки: {0}", folder.Name);
                    checkFolder(folder.FullName
                        );
                }
            }
        }

        private void checkFile(FileInfo fileInfo)
        {
            Console.WriteLine("Название файла: {0}", fileInfo.Name);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(folderBrowserDialog1.ShowDialog() == DialogResult.Cancel)
                return;

            inputPath = folderBrowserDialog1.SelectedPath;
            textBox1.Text = inputPath;
            textBox2.Text = inputPath;
            outputPath = inputPath;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.Cancel)
                return;

            outputPath = folderBrowserDialog1.SelectedPath;
            textBox2.Text = outputPath;
        }
    }
}
