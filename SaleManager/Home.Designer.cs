using System.ComponentModel;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraTab;
using DevExpress.XtraEditors.Repository;
using System.Windows.Forms;
using DevExpress.XtraEditors.Controls;

namespace SaleManager
{
    partial class Home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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


        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::SaleManager.Man_Hinh_Loading.ManHinhKhoiDong), true, true);
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.skinRibbonGalleryBarItem1 = new DevExpress.XtraBars.SkinRibbonGalleryBarItem();
            this.ribbonGalleryBarItem1 = new DevExpress.XtraBars.RibbonGalleryBarItem();
            this.btnSanPham = new DevExpress.XtraBars.BarButtonItem();
            this.btnLoaiSanPham = new DevExpress.XtraBars.BarButtonItem();
            this.btnchucvu = new DevExpress.XtraBars.BarButtonItem();
            this.btnnhanvien = new DevExpress.XtraBars.BarButtonItem();
            this.btnNsx = new DevExpress.XtraBars.BarButtonItem();
            this.btnnpp = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup8 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.repositoryItemZoomTrackBar1 = new DevExpress.XtraEditors.Repository.RepositoryItemZoomTrackBar();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.ribbonPage3 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.btnkhachhang = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemZoomTrackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // splashScreenManager
            // 
            splashScreenManager.ClosingDelay = 500;
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.skinRibbonGalleryBarItem1,
            this.ribbonGalleryBarItem1,
            this.btnSanPham,
            this.btnLoaiSanPham,
            this.btnchucvu,
            this.btnnhanvien,
            this.btnNsx,
            this.btnnpp,
            this.btnkhachhang});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ribbonControl1.MaxItemId = 35;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.ribbonPage2,
            this.ribbonPage3});
            this.ribbonControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemZoomTrackBar1});
            this.ribbonControl1.ShowToolbarCustomizeItem = false;
            this.ribbonControl1.Size = new System.Drawing.Size(1207, 179);
            this.ribbonControl1.Toolbar.ShowCustomizeItem = false;
            // 
            // skinRibbonGalleryBarItem1
            // 
            this.skinRibbonGalleryBarItem1.Caption = "skinRibbonGalleryBarItem1";
            this.skinRibbonGalleryBarItem1.Id = 18;
            this.skinRibbonGalleryBarItem1.Name = "skinRibbonGalleryBarItem1";
            // 
            // ribbonGalleryBarItem1
            // 
            this.ribbonGalleryBarItem1.Caption = "ribbonGalleryBarItem1";
            this.ribbonGalleryBarItem1.Id = 19;
            this.ribbonGalleryBarItem1.Name = "ribbonGalleryBarItem1";
            // 
            // btnSanPham
            // 
            this.btnSanPham.Caption = "Sản Phẩm";
            this.btnSanPham.Id = 25;
            this.btnSanPham.ImageUri.Uri = "Add";
            this.btnSanPham.Name = "btnSanPham";
            this.btnSanPham.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick_1);
            // 
            // btnLoaiSanPham
            // 
            this.btnLoaiSanPham.Caption = "Loại Sản Phẩm";
            this.btnLoaiSanPham.Id = 26;
            this.btnLoaiSanPham.ImageUri.Uri = "Apply";
            this.btnLoaiSanPham.Name = "btnLoaiSanPham";
            this.btnLoaiSanPham.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLoaiSanPham1_ItemClick);
            // 
            // btnchucvu
            // 
            this.btnchucvu.Caption = "Chức Vụ";
            this.btnchucvu.Id = 29;
            this.btnchucvu.ImageUri.Uri = "Currency";
            this.btnchucvu.Name = "btnchucvu";
            this.btnchucvu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnchucvu_ItemClick);
            // 
            // btnnhanvien
            // 
            this.btnnhanvien.Caption = "Nhân Viên";
            this.btnnhanvien.Id = 31;
            this.btnnhanvien.ImageUri.Uri = "Preview";
            this.btnnhanvien.Name = "btnnhanvien";
            this.btnnhanvien.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnnhanvien_ItemClick);
            // 
            // btnNsx
            // 
            this.btnNsx.Caption = "Nhà Sản Xuất";
            this.btnNsx.Id = 32;
            this.btnNsx.ImageUri.Uri = "Refresh";
            this.btnNsx.Name = "btnNsx";
            this.btnNsx.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNsx_ItemClick);
            // 
            // btnnpp
            // 
            this.btnnpp.Caption = "Nhà Phân Phối";
            this.btnnpp.Id = 33;
            this.btnnpp.ImageUri.Uri = "Replace";
            this.btnnpp.Name = "btnnpp";
            this.btnnpp.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnnpp_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup3,
            this.ribbonPageGroup8});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Sản Phẩm";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnSanPham);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnLoaiSanPham);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Quản Lý Sản Phẩm";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.btnNsx);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnnpp);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "Quản Lý NSX,NPP";
            // 
            // ribbonPageGroup8
            // 
            this.ribbonPageGroup8.ItemLinks.Add(this.skinRibbonGalleryBarItem1);
            this.ribbonPageGroup8.Name = "ribbonPageGroup8";
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2});
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "Nhân Viên";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btnchucvu);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnnhanvien);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Quản Lý Nhân Viên";
            // 
            // repositoryItemZoomTrackBar1
            // 
            this.repositoryItemZoomTrackBar1.Name = "repositoryItemZoomTrackBar1";
            this.repositoryItemZoomTrackBar1.ScrollThumbStyle = DevExpress.XtraEditors.Repository.ScrollThumbStyle.ArrowDownRight;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.pictureEdit1);
            this.panelControl1.Controls.Add(this.xtraTabControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 179);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1207, 516);
            this.panelControl1.TabIndex = 23;
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureEdit1.Location = new System.Drawing.Point(2, 2);
            this.pictureEdit1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureEdit1.MenuManager = this.ribbonControl1;
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit1.Properties.ZoomAccelerationFactor = 1D;
            this.pictureEdit1.Size = new System.Drawing.Size(1203, 512);
            this.pictureEdit1.TabIndex = 21;
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.ClosePageButtonShowMode = DevExpress.XtraTab.ClosePageButtonShowMode.InAllTabPageHeaders;
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.HeaderButtons = DevExpress.XtraTab.TabButtons.Close;
            this.xtraTabControl1.Location = new System.Drawing.Point(2, 2);
            this.xtraTabControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.Size = new System.Drawing.Size(1203, 512);
            this.xtraTabControl1.TabIndex = 19;
            this.xtraTabControl1.CloseButtonClick += new System.EventHandler(this.xtraTabControl1_CloseButtonClick);
            // 
            // ribbonPage3
            // 
            this.ribbonPage3.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup4});
            this.ribbonPage3.Name = "ribbonPage3";
            this.ribbonPage3.Text = "Khách Hàng";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.btnkhachhang);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "Quản Lý Khách Hàng";
            // 
            // btnkhachhang
            // 
            this.btnkhachhang.Caption = "Khách Hàng";
            this.btnkhachhang.Id = 34;
            this.btnkhachhang.ImageUri.Uri = "Filter";
            this.btnkhachhang.Name = "btnkhachhang";
            this.btnkhachhang.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnkhachhang_ItemClick);
            // 
            // Home
            // 
            this.AllowFormGlass = DevExpress.Utils.DefaultBoolean.False;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1207, 695);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.ribbonControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Home";
            this.Ribbon = this.ribbonControl1;
            this.Text = "Phần Mềm Quản Lý Bán Hàng Laptop";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemZoomTrackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RibbonControl ribbonControl1;
        private RibbonPage ribbonPage1;
        private SkinRibbonGalleryBarItem skinRibbonGalleryBarItem1;
        private RibbonPageGroup ribbonPageGroup8;
        private RibbonGalleryBarItem ribbonGalleryBarItem1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private XtraTabControl xtraTabControl1;
        private RepositoryItemZoomTrackBar repositoryItemZoomTrackBar1;
        private BarButtonItem btnSanPham;
        private BarButtonItem btnLoaiSanPham;
        private RibbonPageGroup ribbonPageGroup1;
        private BarButtonItem btnchucvu;
        private BarButtonItem btnnhanvien;
        private RibbonPage ribbonPage2;
        private RibbonPageGroup ribbonPageGroup2;
        private BarButtonItem btnNsx;
        private BarButtonItem btnnpp;
        private RibbonPageGroup ribbonPageGroup3;
        private BarButtonItem btnkhachhang;
        private RibbonPage ribbonPage3;
        private RibbonPageGroup ribbonPageGroup4;
    }
}