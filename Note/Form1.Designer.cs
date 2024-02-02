namespace Note
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menu = new MenuStrip();
            新規作成ToolStripMenuItem = new ToolStripMenuItem();
            New = new ToolStripMenuItem();
            Read = new ToolStripMenuItem();
            SaveTool = new ToolStripMenuItem();
            Note = new TextBox();
            Save = new SaveFileDialog();
            openFile = new OpenFileDialog();
            menu.SuspendLayout();
            SuspendLayout();
            // 
            // menu
            // 
            menu.Items.AddRange(new ToolStripItem[] { 新規作成ToolStripMenuItem });
            menu.Location = new Point(0, 0);
            menu.Name = "menu";
            menu.Size = new Size(800, 24);
            menu.TabIndex = 0;
            menu.Text = "menuStrip1";
            // 
            // 新規作成ToolStripMenuItem
            // 
            新規作成ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { New, Read, SaveTool });
            新規作成ToolStripMenuItem.Name = "新規作成ToolStripMenuItem";
            新規作成ToolStripMenuItem.Size = new Size(53, 20);
            新規作成ToolStripMenuItem.Text = "ファイル";
            // 
            // New
            // 
            New.Name = "New";
            New.Size = new Size(180, 22);
            New.Text = "新規作成";
            New.Click += New_Click;
            // 
            // Read
            // 
            Read.Name = "Read";
            Read.Size = new Size(180, 22);
            Read.Text = "読み込み";
            Read.Click += Read_Click;
            // 
            // SaveTool
            // 
            SaveTool.Name = "SaveTool";
            SaveTool.Size = new Size(180, 22);
            SaveTool.Text = "保存";
            SaveTool.Click += SaveTool_Click;
            // 
            // Note
            // 
            Note.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Note.Location = new Point(-1, 38);
            Note.Multiline = true;
            Note.Name = "Note";
            Note.ScrollBars = ScrollBars.Both;
            Note.Size = new Size(800, 413);
            Note.TabIndex = 1;
            Note.Text = "サンプルテキスト";
            Note.WordWrap = false;
            Note.ModifiedChanged += Note_ModifiedChanged;
            // 
            // Save
            // 
            Save.Filter = "テキストファイル|*.txt|全てのやつ|*.*";
            Save.FileOk += Save_FileOk;
            // 
            // openFile
            // 
            openFile.FileName = "openFileDialog1";
            openFile.Filter = "テキストファイル|*.txt|全てのやつ|*.*";
            openFile.FileOk += openFile_FileOk;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Note);
            Controls.Add(menu);
            MainMenuStrip = menu;
            Name = "Form1";
            Text = "Form1";
            menu.ResumeLayout(false);
            menu.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menu;
        private TextBox Note;
        private ToolStripMenuItem 新規作成ToolStripMenuItem;
        private ToolStripMenuItem New;
        private ToolStripMenuItem Read;
        private ToolStripMenuItem SaveTool;
        private SaveFileDialog Save;
        private OpenFileDialog openFile;
    }
}
