using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wf05_test
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (IDText.Text == "abcd" && PWText.Text == "1234")
            {
                LblResult.Text = "로그인 성공";
                MessageBox.Show("로그인 성공", "로그인", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            }
            else
            {
                LblResult.Text = "로그인 실패";
                MessageBox.Show("로그인 실패", "로그인", MessageBoxButtons.OK);

            }
        }
    }
}
