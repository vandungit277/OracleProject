using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using SaleManager.San_Pham;
using SaleManager.Nhan_Vien;
using SaleManager.Khach_Hang;
using AddTab;
using DevExpress.XtraTab.ViewInfo;
using DevExpress.XtraTab;
using SaleManager.Man_Hinh_Loading;
using DevExpress.XtraSplashScreen;

namespace SaleManager
{
    public partial class Home : RibbonForm
    {
        #region Khai báo biến
        private readonly TabAdd _clsAddTab = new TabAdd();
        #endregion

        #region Load Form Home
        public Home()
        {
            InitializeComponent();
        }
        private void Home_Load(object sender, System.EventArgs e)
        {

        }
        #endregion

        #region Hàm thêm UC
        //Thêm Tab
        private void AddTab(string tabName, UserControl uc)
        {
            pictureEdit1.Hide();
            xtraTabControl1.Show();
            var t = 0;
            for (var index = 0; index < xtraTabControl1.TabPages.Count; index++)
            {
                var tab = xtraTabControl1.TabPages[index];
                if (tab.Text != tabName) continue;
                xtraTabControl1.SelectedTabPage = tab;
                t = 1;
            }
            if (t != 1)
            {
                _clsAddTab.AddTab(xtraTabControl1, "", tabName, uc);
            }
            //Đóng màn hình Loading
            SplashScreenManager.CloseForm();
        }
        //Đóng Tab
        private void xtraTabControl1_CloseButtonClick(object sender, System.EventArgs e)
        {
            // Đóng tab
            var arg = e as ClosePageButtonEventArgs;
            (arg?.Page as XtraTabPage)?.Dispose();
            if (xtraTabControl1.TabPages.Count == 0)
            {
                xtraTabControl1.Hide();
                pictureEdit1.Show();
            }
        }
        #endregion

        #region Mở Form
        private void barButtonItem1_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(ManHinhLoading));
            AddTab("Sản Phẩm", new UCSanPham());
        }

        private void btnLoaiSanPham1_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(ManHinhLoading));
            AddTab("Loại Sản Phẩm", new UCLoaiSanPham());
        }
       

        private void btnchucvu_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(ManHinhLoading));
            AddTab("Chức Vụ", new UCChucVu());
        }
       

        private void btnnhanvien_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(ManHinhLoading));
            AddTab("Nhân Viên", new UCNhanVien());
        }
      
        private void btnNsx_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(ManHinhLoading));
            AddTab("Nhà Sản Xuất", new UCNhaSanXuat());
        }

        private void btnnpp_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(ManHinhLoading));
            AddTab("Nhà Phân Phối", new UCNhaPhanPhoi());
        }
       
        private void btnkhachhang_ItemClick(object sender, ItemClickEventArgs e)
        {

            SplashScreenManager.ShowForm(typeof(ManHinhLoading));
            AddTab("Khách Hàng", new UCKhachHang());
        }
        #endregion
    }
}