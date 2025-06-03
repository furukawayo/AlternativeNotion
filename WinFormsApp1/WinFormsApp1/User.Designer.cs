namespace WinFormsApp1
{
    partial class User
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
            IDname = new Label();
            IDtextBox = new TextBox();
            MailCheckBox = new CheckBox();
            MailBox = new TextBox();
            Mail = new Label();
            groupBox1 = new GroupBox();
            NotFree = new RadioButton();
            free = new RadioButton();
            label = new Label();
            combo = new ComboBox();
            panel1 = new Panel();
            Close = new Button();
            Save = new Button();
            statusStrip1 = new StatusStrip();
            labelMove = new ToolStripStatusLabel();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // IDname
            // 
            IDname.AutoSize = true;
            IDname.Location = new Point(43, 15);
            IDname.Name = "IDname";
            IDname.Size = new Size(18, 15);
            IDname.TabIndex = 0;
            IDname.Text = "ID";
            // 
            // IDtextBox
            // 
            IDtextBox.Location = new Point(142, 12);
            IDtextBox.Name = "IDtextBox";
            IDtextBox.Size = new Size(100, 23);
            IDtextBox.TabIndex = 1;
            // 
            // MailCheckBox
            // 
            MailCheckBox.AutoSize = true;
            MailCheckBox.Location = new Point(43, 56);
            MailCheckBox.Name = "MailCheckBox";
            MailCheckBox.Size = new Size(96, 19);
            MailCheckBox.TabIndex = 2;
            MailCheckBox.Text = "めーる送信する";
            MailCheckBox.UseVisualStyleBackColor = true;
            MailCheckBox.CheckedChanged += MailCheckBox_CheckedChanged;
            // 
            // MailBox
            // 
            MailBox.Location = new Point(142, 96);
            MailBox.Name = "MailBox";
            MailBox.Size = new Size(100, 23);
            MailBox.TabIndex = 4;
            // 
            // Mail
            // 
            Mail.AutoSize = true;
            Mail.Location = new Point(43, 99);
            Mail.Name = "Mail";
            Mail.Size = new Size(68, 15);
            Mail.TabIndex = 3;
            Mail.Text = "メールアドレス";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(NotFree);
            groupBox1.Controls.Add(free);
            groupBox1.Location = new Point(43, 149);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(237, 72);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "プラン";
            // 
            // NotFree
            // 
            NotFree.AutoSize = true;
            NotFree.Location = new Point(127, 32);
            NotFree.Name = "NotFree";
            NotFree.Size = new Size(49, 19);
            NotFree.TabIndex = 7;
            NotFree.TabStop = true;
            NotFree.Text = "有料";
            NotFree.UseVisualStyleBackColor = true;
            NotFree.CheckedChanged += NotFree_CheckedChanged;
            // 
            // free
            // 
            free.AutoSize = true;
            free.Location = new Point(27, 32);
            free.Name = "free";
            free.Size = new Size(49, 19);
            free.TabIndex = 6;
            free.TabStop = true;
            free.Text = "無料";
            free.UseVisualStyleBackColor = true;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Location = new Point(43, 247);
            label.Name = "label";
            label.Size = new Size(93, 15);
            label.TabIndex = 6;
            label.Text = "無制限で使えます";
            // 
            // combo
            // 
            combo.FormattingEnabled = true;
            combo.Location = new Point(43, 287);
            combo.Name = "combo";
            combo.Size = new Size(121, 23);
            combo.TabIndex = 7;
            // 
            // panel1
            // 
            panel1.Controls.Add(Close);
            panel1.Controls.Add(Save);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 328);
            panel1.Name = "panel1";
            panel1.Size = new Size(468, 31);
            panel1.TabIndex = 8;
            // 
            // Close
            // 
            Close.Dock = DockStyle.Left;
            Close.Location = new Point(75, 0);
            Close.Name = "Close";
            Close.Size = new Size(71, 31);
            Close.TabIndex = 1;
            Close.Text = "閉じる";
            Close.UseVisualStyleBackColor = true;
            Close.Click += Close_Click;
            // 
            // Save
            // 
            Save.Dock = DockStyle.Left;
            Save.Location = new Point(0, 0);
            Save.Name = "Save";
            Save.Size = new Size(75, 31);
            Save.TabIndex = 0;
            Save.Text = "保存";
            Save.UseVisualStyleBackColor = true;
            Save.Click += Save_Click_1;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { labelMove });
            statusStrip1.Location = new Point(0, 359);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(468, 22);
            statusStrip1.TabIndex = 9;
            statusStrip1.Text = "statusStrip1";
            // 
            // labelMove
            // 
            labelMove.Name = "labelMove";
            labelMove.Size = new Size(118, 17);
            labelMove.Text = "toolStripStatusLabel1";
            // 
            // User
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(468, 381);
            Controls.Add(panel1);
            Controls.Add(statusStrip1);
            Controls.Add(combo);
            Controls.Add(label);
            Controls.Add(groupBox1);
            Controls.Add(MailBox);
            Controls.Add(Mail);
            Controls.Add(MailCheckBox);
            Controls.Add(IDtextBox);
            Controls.Add(IDname);
            Name = "User";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ユーザー1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label IDname;
        private TextBox IDtextBox;
        private CheckBox MailCheckBox;
        private TextBox MailBox;
        private Label Mail;
        private GroupBox groupBox1;
        private RadioButton NotFree;
        private RadioButton free;
        private Label label;
        private ComboBox combo;
        private Panel panel1;
        private Button Save;
        private new Button Close;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel labelMove;
    }
}
