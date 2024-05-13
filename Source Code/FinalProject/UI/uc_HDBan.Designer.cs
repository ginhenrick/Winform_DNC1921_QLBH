namespace FinalProject.UI
{
    partial class uc_HDBan
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uc_HDBan));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.btnThemHD = new DevExpress.XtraBars.BarButtonItem();
            this.btnLuuHD = new DevExpress.XtraBars.BarButtonItem();
            this.btnHuyHD = new DevExpress.XtraBars.BarButtonItem();
            this.btnInHD = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoat = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.gridControlHoaDon = new DevExpress.XtraGrid.GridControl();
            this.gridViewHoaDon = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.cbxMaHoaDon = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnInHoaDon = new DevExpress.XtraEditors.SimpleButton();
            this.btnPreviewHoaDon = new DevExpress.XtraEditors.SimpleButton();
            this.btnExportHD = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).BeginInit();
            this.splitContainerControl1.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).BeginInit();
            this.splitContainerControl1.Panel2.SuspendLayout();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlHoaDon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewHoaDon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxMaHoaDon.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnThemHD,
            this.btnLuuHD,
            this.btnHuyHD,
            this.btnInHD,
            this.btnThoat});
            this.barManager1.MaxItemId = 6;
            this.barManager1.StatusBar = this.bar3;
            // 
            // btnThemHD
            // 
            this.btnThemHD.Caption = "Thêm Hóa Đơn";
            this.btnThemHD.Id = 0;
            this.btnThemHD.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnThemHD.ImageOptions.SvgImage")));
            this.btnThemHD.Name = "btnThemHD";
            // 
            // btnLuuHD
            // 
            this.btnLuuHD.Caption = "Lưu Hóa Đơn";
            this.btnLuuHD.Id = 2;
            this.btnLuuHD.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnLuuHD.ImageOptions.SvgImage")));
            this.btnLuuHD.Name = "btnLuuHD";
            // 
            // btnHuyHD
            // 
            this.btnHuyHD.Caption = "Hủy Hóa Đơn";
            this.btnHuyHD.Id = 3;
            this.btnHuyHD.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnHuyHD.ImageOptions.SvgImage")));
            this.btnHuyHD.Name = "btnHuyHD";
            // 
            // btnInHD
            // 
            this.btnInHD.Caption = "In Hóa Đơn";
            this.btnInHD.Id = 4;
            this.btnInHD.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnInHD.ImageOptions.SvgImage")));
            this.btnInHD.Name = "btnInHD";
            // 
            // btnThoat
            // 
            this.btnThoat.Caption = "Thoát";
            this.btnThoat.Id = 5;
            this.btnThoat.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnThoat.ImageOptions.SvgImage")));
            this.btnThoat.Name = "btnThoat";
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1335, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 950);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1335, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 950);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1335, 0);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 950);
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Horizontal = false;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            // 
            // splitContainerControl1.Panel1
            // 
            this.splitContainerControl1.Panel1.Controls.Add(this.groupControl1);
            this.splitContainerControl1.Panel1.Controls.Add(this.labelControl13);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            // 
            // splitContainerControl1.Panel2
            // 
            this.splitContainerControl1.Panel2.Controls.Add(this.groupControl2);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1335, 950);
            this.splitContainerControl1.SplitterPosition = 106;
            this.splitContainerControl1.TabIndex = 9;
            // 
            // labelControl13
            // 
            this.labelControl13.Appearance.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl13.Appearance.Options.UseFont = true;
            this.labelControl13.Location = new System.Drawing.Point(540, -40);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(199, 33);
            this.labelControl13.TabIndex = 61;
            this.labelControl13.Text = "HÓA ĐƠN BÁN";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnExportHD);
            this.groupControl1.Controls.Add(this.btnPreviewHoaDon);
            this.groupControl1.Controls.Add(this.btnInHoaDon);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.cbxMaHoaDon);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1335, 106);
            this.groupControl1.TabIndex = 62;
            this.groupControl1.Text = "Thao tác Hóa Đơn";
            this.groupControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.groupControl1_Paint);
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.gridControlHoaDon);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 0);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(1335, 832);
            this.groupControl2.TabIndex = 0;
            this.groupControl2.Text = "Dữ liệu hóa đơn";
            // 
            // gridControlHoaDon
            // 
            this.gridControlHoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlHoaDon.Location = new System.Drawing.Point(2, 28);
            this.gridControlHoaDon.MainView = this.gridViewHoaDon;
            this.gridControlHoaDon.MenuManager = this.barManager1;
            this.gridControlHoaDon.Name = "gridControlHoaDon";
            this.gridControlHoaDon.Size = new System.Drawing.Size(1331, 802);
            this.gridControlHoaDon.TabIndex = 0;
            this.gridControlHoaDon.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewHoaDon});
            // 
            // gridViewHoaDon
            // 
            this.gridViewHoaDon.GridControl = this.gridControlHoaDon;
            this.gridViewHoaDon.Name = "gridViewHoaDon";
            // 
            // cbxMaHoaDon
            // 
            this.cbxMaHoaDon.Location = new System.Drawing.Point(123, 54);
            this.cbxMaHoaDon.MenuManager = this.barManager1;
            this.cbxMaHoaDon.Name = "cbxMaHoaDon";
            this.cbxMaHoaDon.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxMaHoaDon.Size = new System.Drawing.Size(298, 22);
            this.cbxMaHoaDon.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(34, 58);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(67, 16);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Mã hóa đơn";
            // 
            // btnInHoaDon
            // 
            this.btnInHoaDon.Location = new System.Drawing.Point(466, 50);
            this.btnInHoaDon.Name = "btnInHoaDon";
            this.btnInHoaDon.Size = new System.Drawing.Size(94, 29);
            this.btnInHoaDon.TabIndex = 2;
            this.btnInHoaDon.Text = "In hóa đơn";
            this.btnInHoaDon.Click += new System.EventHandler(this.btnInHoaDon_Click);
            // 
            // btnPreviewHoaDon
            // 
            this.btnPreviewHoaDon.Location = new System.Drawing.Point(584, 51);
            this.btnPreviewHoaDon.Name = "btnPreviewHoaDon";
            this.btnPreviewHoaDon.Size = new System.Drawing.Size(159, 29);
            this.btnPreviewHoaDon.TabIndex = 3;
            this.btnPreviewHoaDon.Text = "Preview hóa đơn";
            this.btnPreviewHoaDon.Click += new System.EventHandler(this.btnPreviewHoaDon_Click);
            // 
            // btnExportHD
            // 
            this.btnExportHD.Location = new System.Drawing.Point(762, 51);
            this.btnExportHD.Name = "btnExportHD";
            this.btnExportHD.Size = new System.Drawing.Size(159, 29);
            this.btnExportHD.TabIndex = 4;
            this.btnExportHD.Text = "Xuất danh sách hóa đơn";
            this.btnExportHD.Click += new System.EventHandler(this.btnExportHD_Click);
            // 
            // uc_HDBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainerControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "uc_HDBan";
            this.Size = new System.Drawing.Size(1335, 970);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).EndInit();
            this.splitContainerControl1.Panel1.ResumeLayout(false);
            this.splitContainerControl1.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).EndInit();
            this.splitContainerControl1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlHoaDon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewHoaDon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxMaHoaDon.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarButtonItem btnThemHD;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnLuuHD;
        private DevExpress.XtraBars.BarButtonItem btnHuyHD;
        private DevExpress.XtraBars.BarButtonItem btnInHD;
        private DevExpress.XtraBars.BarButtonItem btnThoat;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.LabelControl labelControl13;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnExportHD;
        private DevExpress.XtraEditors.SimpleButton btnPreviewHoaDon;
        private DevExpress.XtraEditors.SimpleButton btnInHoaDon;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.ComboBoxEdit cbxMaHoaDon;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraGrid.GridControl gridControlHoaDon;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewHoaDon;
    }
}
