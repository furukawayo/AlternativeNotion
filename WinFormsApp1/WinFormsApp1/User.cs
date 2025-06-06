using System.Diagnostics.Eventing.Reader;
using System.Text;

namespace WinFormsApp1
{
    public partial class User : Form
    {
        public User()
        {
            InitializeComponent();
            a();
            b();
            combo.Items.Add("");
            combo.Items.Add("unko1");
            combo.Items.Add("unko2");
            combo.Items.Add("unko3");
            combo.SelectedIndex = 0;
            combo.DropDownStyle = ComboBoxStyle.DropDownList;
            labelMove.Text = "なんもしてないよ";

        }

        private void MailCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            a();
        }
        private void a()
        {
            if (MailCheckBox.Checked)
            {
                MailBox.Enabled = true;
                Mail.Enabled = true;
            }
            else
            {
                MailBox.Enabled = false;
                Mail.Enabled = false;
            }
        }


        private void NotFree_CheckedChanged(object sender, EventArgs e)
        {
            b();
        }

        private void b()
        {
            label.Visible = NotFree.Checked;
        }
        private void Save_Click_1(object sender, EventArgs e)
        {
            if (IDtextBox.Text.Trim().Length < 1)
            {
                MessageBox.Show("文字入れろカス","警告",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                IDtextBox.Focus();
                return;
            }

            if (MailBox.Text.Trim().Length < 1)
            {
                MessageBox.Show("文字入れろカス","警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                MailBox.Focus();
                return;
            }

            if (IDtextBox.Text.Contains(","))
            {
                MessageBox.Show("IDにカンマは入れられないよ〜", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                IDtextBox.Focus();
                return;
            }

            if (MailBox.Text.Contains(","))
            {
                MessageBox.Show("アドレスにカンマは入れられないよ〜", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                MailBox.Focus();
                return;
            }

            DialogResult dialogResult = MessageBox.Show("保存するぞ〜", "確認フォーム", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {

                using (StreamWriter sw = new StreamWriter("aaa.csv",true, Encoding.UTF8))
                {
                    sw.Write(IDtextBox.Text);
                    sw.Write(",");
                    sw.Write(MailBox.Text);
                    sw.Write(",");
                    if (free.Checked)
                    {
                        sw.Write("フリーだよ");
                    }
                    else
                    {
                        sw.Write("フリーじゃないよ");
                    }
                    sw.Write(",");
                    sw.Write(combo.Text);
                    sw.WriteLine("");
                }

                MessageBox.Show("保存したよ〜");
                labelMove.Text = "保存したよ";
            }
            else if (dialogResult == DialogResult.No)
            {
                MessageBox.Show("保存してないよ〜");
                labelMove.Text = "保存してないよ〜";

            }
            else if (dialogResult == DialogResult.Cancel)
            {
                this.Close();
            }
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
