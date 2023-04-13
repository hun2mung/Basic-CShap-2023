using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wf13_bookrentalshop
{
    public partial class FrmMain : Form
    {
        #region<생성자>
        private int childFormNumber = 0;

        public FrmMain()
        {
            InitializeComponent();
        }
        #endregion

        #region < 이벤트 핸들러 >

        private void FrmMain_Load(object sender, EventArgs e)
        {
            FrmLogin frm = new FrmLogin();
            frm.ShowDialog();
        }
        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();     // 전체 프로그랭 종료
        }


        private void MniGenre_Click(object sender, EventArgs e)
        {
            FrmGenre frm = new FrmGenre();
            frm.TopLevel = false;
            this.Controls.Add(frm);
            frm.Show();

        }

        private void MniBookInfo_Click(object sender, EventArgs e)
        {

        }

        private void MniMember_Click(object sender, EventArgs e)
        {

        }

        private void MniRental_Click(object sender, EventArgs e)
        {

        }

        private void MniAbout_Click(object sender, EventArgs e)
        {

        }

        #endregion

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("종료할건가요?", "확인", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                e.Cancel = false;
                Environment.Exit(0);
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}
