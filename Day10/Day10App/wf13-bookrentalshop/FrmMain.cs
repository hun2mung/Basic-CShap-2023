using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using wf13_bookrentalshop.Helpers;

namespace wf13_bookrentalshop
{
    public partial class FrmMain : Form
    {
        #region < 각 화면 폼 >
        FrmGenre frmGenre = null;   // 책 장르 관리 객체변수
        FrmBooks frmBooks = null;   // 책 정보 관리

        #endregion

        #region < 생성자 >

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
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog();

            LblUserID.Text = Commons.LoginID;
            LblLoginDataType.Text = "/ " + DateTime.Now.ToString();
        }
        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();     // 전체 프로그랭 종료
        }


        private void MniGenre_Click(object sender, EventArgs e)
        {
            //FrmGenre frm = new FrmGenre();
            //frm.TopLevel = false;
            //this.Controls.Add(frm);
            //frm.Show();

            frmGenre = ShowActiveForm(frmGenre, typeof(FrmGenre)) as FrmGenre;
        }

        private void MniBookInfo_Click(object sender, EventArgs e)
        {
            frmBooks = ShowActiveForm(frmBooks, typeof(FrmBooks)) as FrmBooks;
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

        #endregion


        private Form ShowActiveForm(Form form, Type type)
        {
            if (form == null)   // 한 번도 자식창 안열었으면
            {
                form = (Form)Activator.CreateInstance(type);    // 리플렉션으로 타입에 맞는 창을 새로 생성
                form.MdiParent = this;  // FrmMain이 MDI 부모
                form.WindowState = FormWindowState.Normal;
                form.Show();
            }
            else
            {
                if(form.IsDisposed) // 한번 닫혔다.
                {
                    form = (Form)Activator.CreateInstance(type);    // 리플렉션으로 타입에 맞는 창을 새로 생성
                    form.MdiParent = this;  // FrmMain이 MDI 부모
                    form.WindowState = FormWindowState.Normal;
                    form.Show();
                }
                else
                {
                    // 지금 창이 열려잇으면
                }
                {
                    form.Activate();    // 화면 있으면 그 화면 활성화
                }
            }

            return form;
        }
    }
}
