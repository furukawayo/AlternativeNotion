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
                DialogResult dialogResult = MessageBox.Show("�ۑ����ĂȂ���", "�x��", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    Save.ShowDialog();
                    MessageBox.Show("�ۑ�������`");
                    Note.Text = ("");
                }
                else
                {
                    {
                        MessageBox.Show("�ۑ����ĂȂ���`");
                        Note.Text = "";
                    }
                }
            }
            return false;
        }

        //�V�K
        private void New_Click(object sender, EventArgs e)
        {
            /*bool result = IsSave();
            if (result == true) {
                Note.Text = "";

            }*/

            if(Note.Modified == true)
            {
                DialogResult dialogResult = MessageBox.Show("�ۑ����Ă��܂���A�ۑ����܂����H", "�x��", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    Save.ShowDialog();
                    MessageBox.Show("�ۑ�������`");
                    Note.Text = ("");
                }
                else
                {
                    {
                        MessageBox.Show("�ۑ����ĂȂ���`");
                        Note.Text = ("");
                    }
                }
            }
            else
            {
                Note.Text = ("");
            }
        }

        //�ǂݍ��݃{�^��
        private void Read_Click(object sender, EventArgs e)
        {
            openFile.ShowDialog();
        }

        //�ۑ��{�^��
        private void SaveTool_Click(object sender, EventArgs e)
        {
            Save.ShowDialog();
        }

        //�t�@�C���̕ۑ�
        private void Save_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            StreamWriter sw = new StreamWriter(Save.FileName, false);
            sw.Write(Note.Text);
            sw.Close();

            string name = Path.GetFileName(Save.FileName);
            Text = name + "�ǉ������e�L�X�g";
            Note.Modified = true;
        }

        //�t�@�C�����J��
        private void openFile_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            StreamReader sr = new StreamReader(openFile.FileName, false);
            Note.Text = sr.ReadToEnd();
            sr.Close();

            string namea = Path.GetFileName(Save.FileName);
            Text = namea + "�ǉ������e�L�X�g";
        }

        private void Note_ModifiedChanged(object sender, EventArgs e)
        {
            if (Note.Modified == true)
            {
                Text = "�ۑ����ĂȂ���" + Text;
            }
        }
    }
}
