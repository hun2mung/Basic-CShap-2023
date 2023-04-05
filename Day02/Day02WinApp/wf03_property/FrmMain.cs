using System;
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
            TxtResult.Text = ("Hello! I'm Lee Dong Hun", Font.Italic=true);
            ChkBold.Checked = true;

            NudFontSize.Value = 20; // 글자체 크기를 9로 지정
            
        }

        /// <summary>
        /// 글자
        /// </summary>
        private void ChangeFontStyle()
        {
            if (CboFontFamily.SelectedIndex < 0) return;

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

    }
}
