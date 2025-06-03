using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void saveForm_Click(object sender, EventArgs e)
        {
            User User = new User();
            User.ShowDialog();
        }

        private void ListForm_Click(object sender, EventArgs e)
        {
            二つ目のフォーム f = new 二つ目のフォーム();
            f.ShowDialog();
        }

        private void testQR_Click(object sender, EventArgs e)
        {
            Form1 Form1 = new Form1();
            Form1.ShowDialog();
        }
    }
}
