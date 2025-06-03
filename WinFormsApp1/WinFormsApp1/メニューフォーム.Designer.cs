namespace WinFormsApp1
{
    partial class Menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            saveForm = new Button();
            ListForm = new Button();
            testQR = new Button();
            SuspendLayout();
            // 
            // saveForm
            // 
            saveForm.Dock = DockStyle.Top;
            saveForm.Location = new Point(0, 0);
            saveForm.Margin = new Padding(4, 5, 4, 5);
            saveForm.Name = "saveForm";
            saveForm.Size = new Size(1143, 75);
            saveForm.TabIndex = 0;
            saveForm.Text = "ユーザー登録";
            saveForm.UseVisualStyleBackColor = true;
            saveForm.Click += saveForm_Click;
            // 
            // ListForm
            // 
            ListForm.Dock = DockStyle.Top;
            ListForm.Location = new Point(0, 75);
            ListForm.Margin = new Padding(4, 5, 4, 5);
            ListForm.Name = "ListForm";
            ListForm.Size = new Size(1143, 75);
            ListForm.TabIndex = 1;
            ListForm.Text = "ユーザーリスト";
            ListForm.UseVisualStyleBackColor = true;
            ListForm.Click += ListForm_Click;
            // 
            // testQR
            // 
            testQR.Dock = DockStyle.Top;
            testQR.Location = new Point(0, 150);
            testQR.Margin = new Padding(4, 5, 4, 5);
            testQR.Name = "testQR";
            testQR.Size = new Size(1143, 75);
            testQR.TabIndex = 2;
            testQR.Text = "QRコード";
            testQR.UseVisualStyleBackColor = true;
            testQR.Click += testQR_Click;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 750);
            Controls.Add(testQR);
            Controls.Add(ListForm);
            Controls.Add(saveForm);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Menu";
            Text = "メニューフォーム";
            ResumeLayout(false);
        }

        #endregion

        private Button saveForm;
        private Button ListForm;
        private Button testQR;
    }
}