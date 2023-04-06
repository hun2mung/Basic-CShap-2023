﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wf03_property
{
    public partial class FrmMain : Form
    {
        Random rnd = new Random(45);

        public FrmMain()
        {
            InitializeComponent();
            //생성자에서 되도록 설정부분 넣지 않는다
        }

        private void Form_Load(object sender, EventArgs e)
        {
            gbxmain.Text = "컨트롤 학습";
            var fonts = FontFamily.Families.ToList(); // 내 OS 폰트명 가져오기
            foreach (var font in fonts)
            {
                CboFontFamily.Items.Add(font.Name);
            }
            //글자크기 min,max 값 지정
            NudFontSize.Minimum = 5; NudFontSize.Maximum = 40;

            //텍스트박스 초기화
            TxtResult.Text = "Hello! I'm Lee Dong Hun";
            ChkBold.Checked = true;

            NudFontSize.Value = 20; // 글자체 크기를 9로 지정

        }

        /// <summary>
        /// 글자
        /// </summary>
        private void ChangeFontStyle()
        {
            if (CboFontFamily.SelectedIndex < 0)
            {
                CboFontFamily.SelectedIndex = 275;  // 디폴트 지정(나눔 고딕).
            }

            FontStyle style = FontStyle.Regular;   // 기본
            if (ChkBold.Checked == true)
            {
                style |= FontStyle.Bold;    // Bit연산 or
            }
            if (ChkItalic.Checked == true)
            {
                style |= FontStyle.Italic;
            }

            decimal fontSize = NudFontSize.Value;

            TxtResult.Font = new Font((string)CboFontFamily.SelectedItem, (float)fontSize, style);

        }

        void ChangeIndent()
        {
            if (RdoNomal.Checked)   // 라디오버튼 추가 이벤트
            {
                TxtResult.Text = TxtResult.Text.Trim();
            }
            else if (RdoIndent.Checked)
            {
                TxtResult.Text = "      " + TxtResult.Text;
            }
        }

        private void fontname_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeFontStyle();
        }

        private void bold_CheckedChanged(object sender, EventArgs e)
        {
            ChangeFontStyle();
        }
        private void italic_CheckedChanged(object sender, EventArgs e)
        {
            ChangeFontStyle();
        }

        private void fontsize_ValueChanged(object sender, EventArgs e)
        {
            ChangeFontStyle();
        }

        private void TrbDummy_Scroll(object sender, EventArgs e)
        {
            PgbDummy.Value = TrbDummy.Value;
        }

        private void BtnModal_Click(object sender, EventArgs e)
        {
            Form frm = new Form()
            {
                Text = "Modal Form",
                Width = 300,
                Height = 200,
                Left = 10,
                Top = 20,
                BackColor = Color.Crimson,
                StartPosition = FormStartPosition.CenterParent
            };
            frm.ShowDialog();   // 모달 방식으로 자식창 띄우기
        }

        private void BtnModaless_Click(object sender, EventArgs e)
        {
            Form frm = new Form()
            {
                Text = "Modaless Form",
                Width = 300,
                Height = 200,
                StartPosition = FormStartPosition.CenterParent,     // Modaless는 CenterParent 안먹힘
                BackColor = Color.Green
            };
            frm.Show();   // 모달리스방식으로 자식창 띄우기
        }

        private void BtnMsgBox_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(TxtResult.Text);    // 기본
            //ddddddMessageBox.Show(TxtResult.Text, caption: "메세지창");   // 캡션
            //MessageBox.Show(TxtResult.Text, "메세지창", MessageBoxButtons.AbortRetryIgnore);   // 버튼추가
            //MessageBox.Show(TxtResult.Text, "메세지창", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Warning);   // 아이콘 추가

            MessageBox.Show(TxtResult.Text, "메세지창", MessageBoxButtons.YesNo, MessageBoxIcon.Warning,
                            MessageBoxDefaultButton.Button2);  // 기본포커스 버튼 설정

            //MessageBox.Show(TxtResult.Text, "메세지창", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, 
            //                MessageBoxDefaultButton.Button2, MessageBoxOptions.RightAlign);   // 오른쪽 정렬


        }

        private void BtnAddRoot_Click(object sender, EventArgs e)
        {
            TrvDummy.Nodes.Add(rnd.Next(45).ToString());

            TreeToList();
        }

        private void BtnAddChild_Click(object sender, EventArgs e)
        {
            if (TrvDummy.SelectedNode != null)
            {
                TrvDummy.SelectedNode.Nodes.Add(rnd.Next(50, 100).ToString());
                TrvDummy.SelectedNode.Expand(); // 트리노드 하위것 펼쳐주기.(반대는 .Collapse)

                TreeToList();

            }
        }
        void TreeToList()
        {
            LsvDummy.Items.Clear(); // 리스트뷰, 트리뷰 모든 아이템 제거.
            foreach (TreeNode item in TrvDummy.Nodes)
            {
                TreeToList(item);
            }
        }

        private void TreeToList(TreeNode item)
        {
            LsvDummy.Items.Add(new ListViewItem(new[] { item.Text, item.FullPath.ToString() }));

            foreach (TreeNode node in item.Nodes)
            {
                TreeToList(node);   // 재귀호출
            }

        }

        private void RdoNomal_CheckedChanged(object sender, EventArgs e)
        {
            ChangeIndent();
        }

        private void RdoIndent_CheckedChanged(object sender, EventArgs e)
        {
            ChangeIndent();
        }

        private void BtnLoad_Click(object sender, EventArgs e)
        {
            PcbDummy.Image = Bitmap.FromFile("cat.jpg");
        }

        private void PcbDummy_Click(object sender, EventArgs e)
        {
            if (PcbDummy.SizeMode == PictureBoxSizeMode.Normal)
            {
                PcbDummy.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
            {
                PcbDummy.SizeMode = PictureBoxSizeMode.Normal;
            }
        }
    }
}
