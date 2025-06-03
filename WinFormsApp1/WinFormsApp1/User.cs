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
            labelMove.Text = "‚È‚ñ‚à‚µ‚Ä‚È‚¢‚æ";

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
                MessageBox.Show("•¶Žš“ü‚ê‚ëƒJƒX","Œx",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                IDtextBox.Focus();
                return;
            }

            if (MailBox.Text.Trim().Length < 1)
            {
                MessageBox.Show("•¶Žš“ü‚ê‚ëƒJƒX","Œx", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                MailBox.Focus();
                return;
            }

            if (IDtextBox.Text.Contains(","))
            {
                MessageBox.Show("ID‚ÉƒJƒ“ƒ}‚Í“ü‚ê‚ç‚ê‚È‚¢‚æ`", "Œx", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                IDtextBox.Focus();
                return;
            }

            if (MailBox.Text.Contains(","))
            {
                MessageBox.Show("ƒAƒhƒŒƒX‚ÉƒJƒ“ƒ}‚Í“ü‚ê‚ç‚ê‚È‚¢‚æ`", "Œx", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                MailBox.Focus();
                return;
            }

            DialogResult dialogResult = MessageBox.Show("•Û‘¶‚·‚é‚¼`", "Šm”FƒtƒH[ƒ€", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
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
                        sw.Write("ƒtƒŠ[‚¾‚æ");
                    }
                    else
                    {
                        sw.Write("ƒtƒŠ[‚¶‚á‚È‚¢‚æ");
                    }
                    sw.Write(",");
                    sw.Write(combo.Text);
                    sw.WriteLine("");
                }

                MessageBox.Show("•Û‘¶‚µ‚½‚æ`");
                labelMove.Text = "•Û‘¶‚µ‚½‚æ";
            }
            else if (dialogResult == DialogResult.No)
            {
                MessageBox.Show("•Û‘¶‚µ‚Ä‚È‚¢‚æ`");
                labelMove.Text = "•Û‘¶‚µ‚Ä‚È‚¢‚æ`";

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
