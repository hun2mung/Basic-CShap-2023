namespace wf06_listview
{
    partial class FrmMain
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.LsvFiles = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ImgLargeIcon = new System.Windows.Forms.ImageList(this.components);
            this.ImgSmallIcon = new System.Windows.Forms.ImageList(this.components);
            this.CboView = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // LsvFiles
            // 
            this.LsvFiles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.LsvFiles.HideSelection = false;
            this.LsvFiles.LargeImageList = this.ImgLargeIcon;
            this.LsvFiles.Location = new System.Drawing.Point(12, 12);
            this.LsvFiles.Name = "LsvFiles";
            this.LsvFiles.Size = new System.Drawing.Size(396, 331);
            this.LsvFiles.SmallImageList = this.ImgSmallIcon;
            this.LsvFiles.TabIndex = 1;
            this.LsvFiles.UseCompatibleStateImageBehavior = false;
            this.LsvFiles.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "이름";
            this.columnHeader1.Width = 120;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "수정한 날짜";
            this.columnHeader6.Width = 120;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "유형";
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "크기";
            // 
            // ImgLargeIcon
            // 
            this.ImgLargeIcon.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImgLargeIcon.ImageStream")));
            this.ImgLargeIcon.TransparentColor = System.Drawing.Color.Transparent;
            this.ImgLargeIcon.Images.SetKeyName(0, "file-exe.png");
            this.ImgLargeIcon.Images.SetKeyName(1, "file-normal.png");
            // 
            // ImgSmallIcon
            // 
            this.ImgSmallIcon.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImgSmallIcon.ImageStream")));
            this.ImgSmallIcon.TransparentColor = System.Drawing.Color.Transparent;
            this.ImgSmallIcon.Images.SetKeyName(0, "file-exe.png");
            this.ImgSmallIcon.Images.SetKeyName(1, "file-normal.png");
            // 
            // CboView
            // 
            this.CboView.FormattingEnabled = true;
            this.CboView.Items.AddRange(new object[] {
            "View.Details",
            "View.List",
            "View.Tile",
            "View.SmallIcon",
            "View.LargeIcon"});
            this.CboView.Location = new System.Drawing.Point(414, 12);
            this.CboView.Name = "CboView";
            this.CboView.Size = new System.Drawing.Size(156, 20);
            this.CboView.TabIndex = 3;
            this.CboView.SelectedIndexChanged += new System.EventHandler(this.CboList_SelectedIndexChanged);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 355);
            this.Controls.Add(this.CboView);
            this.Controls.Add(this.LsvFiles);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMain";
            this.Text = "리스트뷰 예제";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView LsvFiles;
        private System.Windows.Forms.ComboBox CboView;
        private System.Windows.Forms.ImageList ImgSmallIcon;
        private System.Windows.Forms.ImageList ImgLargeIcon;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
    }
}

