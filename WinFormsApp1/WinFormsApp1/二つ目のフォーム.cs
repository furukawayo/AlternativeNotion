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
    public partial class 二つ目のフォーム : Form
    {
        private BindingList<UserInfo> _dtos = new BindingList<UserInfo>();
        public 二つ目のフォーム()
        {
            InitializeComponent();
            if (System.IO.File.Exists("aaa.csv"))
            {
                string[] lines = System.IO.File.ReadAllLines("aaa.csv");

            foreach (string line in lines)
            {
                string[] b = line.Split(',');
                UserInfo dto = new UserInfo(
                    b[0],
                    b[1],
                    b[2],
                    b[3]);
                _dtos.Add(dto);
            }
        }

            data.DataSource = _dtos;
        }
    }
}
