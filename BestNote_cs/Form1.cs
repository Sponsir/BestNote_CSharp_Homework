using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BestNote_cs
{
    public partial class MainWindow : Form, MainFunctions
    {
        private DataManager dataManager;

        /// <summary>
        /// Interface implement
        /// </summary>
        public void showFolderList()
        {
            ArrayList folderList = dataManager.getFolderList();
            ListViewItem[] items = new ListViewItem[folderList.Count];
            for (int i = 0; i < folderList.Count; i++)
            {
                items[i] = new ListViewItem((string)folderList[i]);
            }
            folderListView.Items.AddRange(items);
        }

        public void showFileList(string folderName)
        {
            fileListView.Clear();
            noteEditor.Clear();
            ArrayList fileList = dataManager.getFileList(folderName);
            ListViewItem[] items = new ListViewItem[fileList.Count];
            for (int i = 0; i < fileList.Count; i++)
            {
                items[i] = new ListViewItem((string)fileList[i]);
            }
            fileListView.Items.AddRange(items); 
        }

        public void showFileContent(string folderName, string fileName)
        {
            DataManager.FileStructure file = new DataManager.FileStructure();
            file = dataManager.getFileContent(fileName, folderName);
            noteEditor.Text = file.content;
        }

        public void newFolder()
        {
            RenameDialog renameDialog = new RenameDialog();
            DialogResult result = renameDialog.ShowDialog();
            if (result == DialogResult.Yes)
            {
                string folderName = renameDialog.getInputedName();

                try {
                    if (!dataManager.newFolder(folderName))
                    {
                        showErrorDialog("新建文件夹失败");
                    }
                }
                catch (Exception e)
                {
                    showErrorDialog(e.Message);
                }
                folderListView.Items.Clear();
                showFolderList();
            }
        }

        public void renameFolder()
        {
            if (isFolderSelected())
            {
                string folderName = folderListView.SelectedItems[0].Text;
                RenameDialog renameDialog = new RenameDialog();
                DialogResult result = renameDialog.ShowDialog();
                if (result == DialogResult.Yes)
                {
                    string newName = renameDialog.getInputedName();
                    try
                    {
                        if (!dataManager.renameFolder(folderName, newName))
                        {
                            showErrorDialog("重命名失败");
                        }
                    }
                    catch (Exception e)
                    {
                        showErrorDialog(e.Message);
                    }
                }
                folderListView.Items.Clear();
                showFolderList();
            }
        }

        public void deleteFolder()
        {
            if (isFolderSelected())
            {
                if (!dataManager.deleteFolder(folderListView.SelectedItems[0].Text))
                {
                    showErrorDialog("删除失败");
                }
            }
            folderListView.Items.Clear();
            fileListView.Items.Clear();
            showFolderList();
        }

        public void newFile()
        {
            if (isFolderSelected())
            {
                RenameDialog renameDialog = new RenameDialog();
                DialogResult result = renameDialog.ShowDialog();
                if (result == DialogResult.Yes)
                {
                    string fileName = renameDialog.getInputedName();
                    string folderName = folderListView.SelectedItems[0].Text;

                    noteEditor.Text = "";

                    try {
                        if (!dataManager.newFile(fileName, folderName, ""))
                        {
                            showErrorDialog("新建文件失败");
                        }
                    }
                    catch (Exception e)
                    {
                        showErrorDialog(e.Message);
                    }
                    fileListView.Items.Clear();
                    showFileList(folderListView.SelectedItems[0].Text);
                }
            }
        }

        public void renameFile()
        {
            if (isFileSelected())
            {
                string fileName = fileListView.SelectedItems[0].Text;
                string folderName = folderListView.SelectedItems[0].Text;
                RenameDialog renameDialog = new RenameDialog();
                DialogResult result = renameDialog.ShowDialog();
                if (result == DialogResult.Yes)
                {
                    string newName = renameDialog.getInputedName();
                    try
                    {
                        if (!dataManager.renameFile(fileName, newName, folderName))
                        {
                            showErrorDialog("重命名失败");
                        }
                    }
                    catch (Exception e)
                    {
                        showErrorDialog(e.Message);
                    }
                }
                fileListView.Items.Clear();
                showFolderList();
            }
        }

        public void deleteFile()
        {
            if (isFileSelected())
            {
                if (!dataManager.deleteFile(fileListView.SelectedItems[0].Text, folderListView.SelectedItems[0].Text))
                {
                    showErrorDialog("删除失败");
                }
            }
            fileListView.Items.Clear();
            showFileList(folderListView.SelectedItems[0].Text);
        }

        public void saveFile()
        {
            if (isFolderSelected() && isFileSelected())
            {
                string folderName = folderListView.SelectedItems[0].Text;
                string fileName = fileListView.SelectedItems[0].Text;
                string fileContent = noteEditor.Text;
                if (dataManager.updateContent(fileName, folderName, fileContent))
                {
                    MessageBox.Show("保存成功！", "提示", MessageBoxButtons.OK);
                }
                else
                {
                    showErrorDialog("保存失败");
                }
            }
        }

        private bool isFolderSelected()
        {
            if (folderListView.SelectedItems.Count == 0)
            {
                showAlertDialog("请先选择一个文件夹");
                return false;
            }
            else
            {
                return true;
            }
        }

        private bool isFileSelected()
        {
            if (folderListView.SelectedItems.Count == 0)
            {
                showAlertDialog("请先选择一个文件");
                return false;
            }
            else
            {
                return true;
            }
        }

        private void showErrorDialog(string text)
        {
            MessageBox.Show(text, "错误", MessageBoxButtons.OK);
        }

        private void showAlertDialog(string text)
        {
            MessageBox.Show(text, "警告", MessageBoxButtons.OK);
        }

        /// <summary>
        /// Form Event
        /// </summary>

        // When create MainWindow
        public MainWindow()
        {
            InitializeComponent();
            dataManager = DataManagerFactor.createDataManager(DataManagerFactor.DATASAVE_MODE_MYSQL);
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            folderListView.Columns.Add("Folder", "文件夹", folderListView.Width);
            fileListView.Columns.Add("File", "笔记", fileListView.Width);

            showFolderList();
        }

        private void newNoteButton_Click(object sender, EventArgs e)
        {
            newFile();
        }

        private void newNoteMenu_Click(object sender, EventArgs e)
        {
            newFile();
        }

        private void newFolderButton_Click(object sender, EventArgs e)
        {
            newFolder();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            saveFile();
        }

        private void saveMenu_Click(object sender, EventArgs e)
        {
            saveFile();
        }

        private void exitMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void abouttMenu_Click(object sender, EventArgs e)
        {
            AboutBox1 aboutBox = new AboutBox1();
            aboutBox.Show();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            dataManager.close();
        }

        private void folderListView_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (folderListView.SelectedItems.Count != 0)
            {
                showFileList(e.Item.Text);
            }
        }

        private void fileListView_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (fileListView.SelectedItems.Count != 0 && folderListView.SelectedItems.Count != 0)
            {
                showFileContent(folderListView.SelectedItems[0].Text, e.Item.Text);
            }
        }

        private void deleteFolderListItem_Click(object sender, EventArgs e)
        {
            deleteFolder();
        }

        private void renameFolderListItem_Click(object sender, EventArgs e)
        {
            renameFolder();
        }

        private void deleteFileListItem_Click(object sender, EventArgs e)
        {
            deleteFile();
        }

        private void renameFileListItem_Click(object sender, EventArgs e)
        {
            renameFile();
        }
    }
}
