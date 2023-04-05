﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wf02_realwinapp
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 버튼 OK 클릭 이벤트에 대한 처리 메서드 만듦
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
                
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            MessageBox.Show("버튼클릭!!!", "클릭", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            BtnOK.Text = "클릭됨!!!";
            return;
        }

        private void BtnOK_MouseHover(object sender, EventArgs e)
        {
            MessageBox.Show("마우스만 올려도 이벤트 발생!");
        }
    }
}

