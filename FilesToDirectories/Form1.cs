using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using Shell32;
using System.Collections;
using System.Globalization;

namespace FilesToDirectories
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Shell shell = new Shell();
        Folder folder;
        FolderItem item;

        private void Select_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.Description = "Select the directory that you want to find photos and videos and to move them into new create date directories";
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                listBox_ListFiles.Items.Clear();
                string dir = fbd.SelectedPath;
                folder = shell.NameSpace(dir);

                label_SelectedDirectory.Text = dir;
                label_SelectedDirectory.ForeColor = Color.Green;

                string[] patterns = new string[] { "*.jpg", "*.jpeg", "*.png", "*.mp4", "*.mov", "*.mts" };
                listBox_ListFiles.BeginUpdate();
                foreach(string pattern in patterns)
                {
                    listBox_ListFiles.Items.AddRange(Directory.GetFiles(dir, pattern));
                }
                listBox_ListFiles.EndUpdate();
                label_CountFiles.Text = listBox_ListFiles.Items.Count.ToString();
                label_CountSelectedFiles.Text = listBox_ListFiles.SelectedItems.Count.ToString();
            }
            fbd.Dispose();
        }

        private void Start_Click(object sender, EventArgs e)
        {
            listBox_ListFiles.Enabled = false;
            listBox_ListFiles.BeginUpdate();
            List<int> removing = new List<int>();
            foreach(int i in listBox_ListFiles.SelectedIndices)
            {
                string fileName = listBox_ListFiles.Items[i].ToString();
                string curFolder = fileName.Substring(0, fileName.LastIndexOf("\\") + 1);
                string file = fileName.Remove(0, curFolder.Length);
                item = folder.ParseName(file);

                List<string> dt;
                if (folder.GetDetailsOf(item, 12) != "")
                {
                    dt = folder.GetDetailsOf(item, 12).Split(new char[] { '.',' ', ':'}).ToList();
                }
                else
                {
                    dt = folder.GetDetailsOf(item, 4).Split(new char[] { '.',' ', ':'}).ToList();
                }

                string newFolder = $"{curFolder}{dt[2]}-{dt[1]}-{dt[0]}\\";
                Directory.CreateDirectory(newFolder);
                File.Move(fileName, $"{newFolder}{file}");
                removing.Add(i);
            }
            for(int i=removing.Count-1; i >= 0; i--)
            {
                listBox_ListFiles.Items.RemoveAt(removing[i]);
            }
            listBox_ListFiles.EndUpdate();
            label_CountFiles.Text = listBox_ListFiles.Items.Count.ToString();
            listBox_ListFiles.Enabled = true;
        }

        private void ListBox_SelectedItemsChanged(object sender, EventArgs e)
        {
            label_CountSelectedFiles.Text = listBox_ListFiles.SelectedItems.Count.ToString();
            if(listBox_ListFiles.SelectedItems.Count == 1)
            {
                string fileName = listBox_ListFiles.SelectedItem.ToString();
                string curFolder = fileName.Substring(0, fileName.LastIndexOf("\\") + 1);
                string file = fileName.Remove(0, curFolder.Length);
                item = folder.ParseName(file);
                textBox_InformationFile.Text = "";
                for (int i = 0; i < 1000; i++)
                {
                    string propValue = folder.GetDetailsOf(item, i);
                    if (propValue != "")
                    {
                        textBox_InformationFile.Text += i + ". " + folder.GetDetailsOf(null, i) + ": " + propValue + "\r\n";
                    }
                }

            }
            else
            {
                textBox_InformationFile.Text = "To look information about a file select one file";

            }
        }
    }
}
