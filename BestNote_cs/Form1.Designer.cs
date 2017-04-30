namespace BestNote_cs
{
    partial class MainWindow
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.文件FToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newNoteMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.saveMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.exitMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.编辑EToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助HToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abouttMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.newNoteButton = new System.Windows.Forms.ToolStripButton();
            this.newFolderButton = new System.Windows.Forms.ToolStripButton();
            this.saveButton = new System.Windows.Forms.ToolStripButton();
            this.folderListView = new System.Windows.Forms.ListView();
            this.folderContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteFolderListItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renameFolderListItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noteEditor = new System.Windows.Forms.TextBox();
            this.fileListView = new System.Windows.Forms.ListView();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.fileContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteFileListItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renameFileListItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.folderContextMenu.SuspendLayout();
            this.fileContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件FToolStripMenuItem,
            this.编辑EToolStripMenuItem,
            this.帮助HToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(939, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 文件FToolStripMenuItem
            // 
            this.文件FToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newNoteMenu,
            this.saveMenu,
            this.exitMenu});
            this.文件FToolStripMenuItem.Name = "文件FToolStripMenuItem";
            this.文件FToolStripMenuItem.Size = new System.Drawing.Size(58, 21);
            this.文件FToolStripMenuItem.Text = "文件(&F)";
            // 
            // newNoteMenu
            // 
            this.newNoteMenu.Name = "newNoteMenu";
            this.newNoteMenu.Size = new System.Drawing.Size(142, 22);
            this.newNoteMenu.Text = "新建笔记(&N)";
            this.newNoteMenu.Click += new System.EventHandler(this.newNoteMenu_Click);
            // 
            // saveMenu
            // 
            this.saveMenu.Name = "saveMenu";
            this.saveMenu.Size = new System.Drawing.Size(142, 22);
            this.saveMenu.Text = "保存(&S)";
            this.saveMenu.Click += new System.EventHandler(this.saveMenu_Click);
            // 
            // exitMenu
            // 
            this.exitMenu.Name = "exitMenu";
            this.exitMenu.Size = new System.Drawing.Size(142, 22);
            this.exitMenu.Text = "退出(&X)";
            this.exitMenu.Click += new System.EventHandler(this.exitMenu_Click);
            // 
            // 编辑EToolStripMenuItem
            // 
            this.编辑EToolStripMenuItem.Name = "编辑EToolStripMenuItem";
            this.编辑EToolStripMenuItem.Size = new System.Drawing.Size(59, 21);
            this.编辑EToolStripMenuItem.Text = "编辑(&E)";
            // 
            // 帮助HToolStripMenuItem
            // 
            this.帮助HToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abouttMenu});
            this.帮助HToolStripMenuItem.Name = "帮助HToolStripMenuItem";
            this.帮助HToolStripMenuItem.Size = new System.Drawing.Size(61, 21);
            this.帮助HToolStripMenuItem.Text = "帮助(&H)";
            // 
            // abouttMenu
            // 
            this.abouttMenu.Name = "abouttMenu";
            this.abouttMenu.Size = new System.Drawing.Size(152, 22);
            this.abouttMenu.Text = "关于(&A)";
            this.abouttMenu.Click += new System.EventHandler(this.abouttMenu_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.57143F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56.42857F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 662F));
            this.tableLayoutPanel1.Controls.Add(this.toolStrip1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.folderListView, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.noteEditor, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.fileListView, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 25);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.007752F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 93.99225F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(939, 516);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // toolStrip1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.toolStrip1, 3);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newNoteButton,
            this.newFolderButton,
            this.saveButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(939, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // newNoteButton
            // 
            this.newNoteButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.newNoteButton.Image = ((System.Drawing.Image)(resources.GetObject("newNoteButton.Image")));
            this.newNoteButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newNoteButton.Name = "newNoteButton";
            this.newNoteButton.Size = new System.Drawing.Size(60, 22);
            this.newNoteButton.Text = "新建笔记";
            this.newNoteButton.Click += new System.EventHandler(this.newNoteButton_Click);
            // 
            // newFolderButton
            // 
            this.newFolderButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.newFolderButton.Image = ((System.Drawing.Image)(resources.GetObject("newFolderButton.Image")));
            this.newFolderButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newFolderButton.Name = "newFolderButton";
            this.newFolderButton.Size = new System.Drawing.Size(72, 22);
            this.newFolderButton.Text = "新建文件夹";
            this.newFolderButton.Click += new System.EventHandler(this.newFolderButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.saveButton.Image = ((System.Drawing.Image)(resources.GetObject("saveButton.Image")));
            this.saveButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(36, 22);
            this.saveButton.Text = "保存";
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // folderListView
            // 
            this.folderListView.ContextMenuStrip = this.folderContextMenu;
            this.folderListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.folderListView.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.folderListView.Location = new System.Drawing.Point(3, 34);
            this.folderListView.Name = "folderListView";
            this.folderListView.Size = new System.Drawing.Size(114, 479);
            this.folderListView.TabIndex = 1;
            this.folderListView.UseCompatibleStateImageBehavior = false;
            this.folderListView.View = System.Windows.Forms.View.Details;
            this.folderListView.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.folderListView_ItemSelectionChanged);
            // 
            // folderContextMenu
            // 
            this.folderContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteFolderListItem,
            this.renameFolderListItem});
            this.folderContextMenu.Name = "contextMenuStrip1";
            this.folderContextMenu.Size = new System.Drawing.Size(113, 48);
            // 
            // deleteFolderListItem
            // 
            this.deleteFolderListItem.Name = "deleteFolderListItem";
            this.deleteFolderListItem.Size = new System.Drawing.Size(152, 22);
            this.deleteFolderListItem.Text = "删除";
            this.deleteFolderListItem.Click += new System.EventHandler(this.deleteFolderListItem_Click);
            // 
            // renameFolderListItem
            // 
            this.renameFolderListItem.Name = "renameFolderListItem";
            this.renameFolderListItem.Size = new System.Drawing.Size(152, 22);
            this.renameFolderListItem.Text = "重命名";
            this.renameFolderListItem.Click += new System.EventHandler(this.renameFolderListItem_Click);
            // 
            // noteEditor
            // 
            this.noteEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.noteEditor.Location = new System.Drawing.Point(279, 34);
            this.noteEditor.Multiline = true;
            this.noteEditor.Name = "noteEditor";
            this.noteEditor.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.noteEditor.Size = new System.Drawing.Size(657, 479);
            this.noteEditor.TabIndex = 3;
            // 
            // fileListView
            // 
            this.fileListView.ContextMenuStrip = this.fileContextMenu;
            this.fileListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fileListView.Location = new System.Drawing.Point(123, 34);
            this.fileListView.Name = "fileListView";
            this.fileListView.Size = new System.Drawing.Size(150, 479);
            this.fileListView.TabIndex = 4;
            this.fileListView.UseCompatibleStateImageBehavior = false;
            this.fileListView.View = System.Windows.Forms.View.List;
            this.fileListView.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.fileListView_ItemSelectionChanged);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // fileContextMenu
            // 
            this.fileContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteFileListItem,
            this.renameFileListItem});
            this.fileContextMenu.Name = "fileContextMenu";
            this.fileContextMenu.Size = new System.Drawing.Size(113, 48);
            // 
            // deleteFileListItem
            // 
            this.deleteFileListItem.Name = "deleteFileListItem";
            this.deleteFileListItem.Size = new System.Drawing.Size(152, 22);
            this.deleteFileListItem.Text = "删除";
            this.deleteFileListItem.Click += new System.EventHandler(this.deleteFileListItem_Click);
            // 
            // renameFileListItem
            // 
            this.renameFileListItem.Name = "renameFileListItem";
            this.renameFileListItem.Size = new System.Drawing.Size(152, 22);
            this.renameFileListItem.Text = "重命名";
            this.renameFileListItem.Click += new System.EventHandler(this.renameFileListItem_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 541);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWindow";
            this.Text = "BestNote";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.folderContextMenu.ResumeLayout(false);
            this.fileContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 文件FToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newNoteMenu;
        private System.Windows.Forms.ToolStripMenuItem 编辑EToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助HToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abouttMenu;
        private System.Windows.Forms.ToolStripMenuItem exitMenu;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton newNoteButton;
        private System.Windows.Forms.ToolStripButton newFolderButton;
        private System.Windows.Forms.ListView folderListView;
        private System.Windows.Forms.TextBox noteEditor;
        private System.Windows.Forms.ListView fileListView;
        private System.Windows.Forms.ContextMenuStrip folderContextMenu;
        private System.Windows.Forms.ToolStripMenuItem deleteFolderListItem;
        private System.Windows.Forms.ToolStripButton saveButton;
        private System.Windows.Forms.ToolStripMenuItem saveMenu;
        private System.Windows.Forms.ToolStripMenuItem renameFolderListItem;
        private System.Windows.Forms.ContextMenuStrip fileContextMenu;
        private System.Windows.Forms.ToolStripMenuItem deleteFileListItem;
        private System.Windows.Forms.ToolStripMenuItem renameFileListItem;
    }
}

