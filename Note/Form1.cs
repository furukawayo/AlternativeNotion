using System.Text;

namespace Note
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool IsSave()
        {
            if(Note.Modified == true)
            {
                DialogResult dialogResult = MessageBox.Show("保存してないぞ", "警告", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    Save.ShowDialog();
                    MessageBox.Show("保存したよ～");
                    Note.Text = ("");
                }
                else
                {
                    {
                        MessageBox.Show("保存してないよ～");
                        Note.Text = "";
                    }
                }
            }
            return false;
        }

        //新規
        private void New_Click(object sender, EventArgs e)
        {
            /*bool result = IsSave();
            if (result == true) {
                Note.Text = "";

            }*/

            if(Note.Modified == true)
            {
                DialogResult dialogResult = MessageBox.Show("保存していません、保存しますか？", "警告", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    Save.ShowDialog();
                    MessageBox.Show("保存したよ～");
                    Note.Text = ("");
                }
                else
                {
                    {
                        MessageBox.Show("保存してないよ～");
                        Note.Text = ("");
                    }
                }
            }
            else
            {
                Note.Text = ("");
            }
        }

        //読み込みボタン
        private void Read_Click(object sender, EventArgs e)
        {
            openFile.ShowDialog();
        }

        //保存ボタン
        private void SaveTool_Click(object sender, EventArgs e)
        {
            Save.ShowDialog();
        }

        //ファイルの保存
        private void Save_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            StreamWriter sw = new StreamWriter(Save.FileName, false);
            sw.Write(Note.Text);
            sw.Close();

            string name = Path.GetFileName(Save.FileName);
            Text = name + "追加されるテキスト";
            Note.Modified = true;
        }

        //ファイルを開く
        private void openFile_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            StreamReader sr = new StreamReader(openFile.FileName, false);
            Note.Text = sr.ReadToEnd();
            sr.Close();

            string namea = Path.GetFileName(Save.FileName);
            Text = namea + "追加されるテキスト";
        }

        private void Note_ModifiedChanged(object sender, EventArgs e)
        {
            if (Note.Modified == true)
            {
                Text = "保存してないよ" + Text;
            }
        }
    }
}
