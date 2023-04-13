using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace wf13_bookrentalshop
{
    public partial class FrmLogin : Form
    {
        private bool IsLogined = false; // 로그인 성공했는지 변수

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            IsLogined = LoginProcess(); // 로그인 성공하면 true
            if (IsLogined)
            {
                this.Close();
            }
            else
            {
                return;
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            //Application.Exit();
            Environment.Exit(0);    // 가장 완벽하게 프로그램 종료
        }

        // 이게 없으면 x버튼이나 Alt+ F4 했을 때 메인 폼 나타남
        private void FrmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (IsLogined != true)       // 로그인 안되었을때 창 닫으면 프로그램 모두 종료
            {
                Environment.Exit(0);
            }
        }

        private void TxtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)     // 엔터키 누르면
            {
                BtnLogin_Click(sender, e);   // 버튼클릭 이벤트 핸들러 호출
            }
        }

        // DB userTbl에서 정보확인 로그인처리
        private bool LoginProcess()
        {
            // Validation Cehck
            if (string.IsNullOrEmpty(TxtUserId.Text))
            {
                MessageBox.Show("유저 아이디를 입력하세요", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrEmpty(TxtPassword.Text))
            {
                MessageBox.Show("유저 패스워드를 입력하세요", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            string strUserId = "";
            string strPassword = "";


            try
            {
                string connectionString = "Server=localhost;Port=3306;Database=bookrentalshop;Uid=root;Pwd=12345;";
                // DB 처리
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    #region < DB쿼리를 위한 구성>

                    string selQuery = @"SELECT userid
                                             , password
                                          FROM usertbl
                                         WHERE userid = @userid
                                           AND password = @password";
                    MySqlCommand selCmd = new MySqlCommand(selQuery, conn);
                    // @userID, @password 파라미터 할당
                    MySqlParameter prmUserID = new MySqlParameter("@userid", TxtUserId.Text);
                    MySqlParameter prmPassword = new MySqlParameter("@password", TxtPassword.Text);
                    selCmd.Parameters.Add(prmUserID);
                    selCmd.Parameters.Add(prmPassword);
                    #endregion

                    MySqlDataReader reader = selCmd.ExecuteReader();    // 실행한 다음에 userid, password 읽어옴
                    if (reader.Read())
                    {
                        strUserId = reader["userid"] != null ? reader["userid"].ToString() : "-";
                        strPassword = reader["Password"] != null ? reader["Password"].ToString() : "--";
                    }
                    else
                    {
                        MessageBox.Show($"로그인정보가 없음", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }   // conn.Close();
                // MessageBox.Show($"{strUserId} / {strPassword}");

            }
            catch (Exception ex)
            {
                MessageBox.Show($"비정상적 오류 {ex.Message}", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        // 유저 아이디 텍스트박스에서 엔터 치면 패스워드 텍박으로 포커스 이동
        private void TxtUserId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                TxtPassword.Focus();
            }
        }
    }
}
