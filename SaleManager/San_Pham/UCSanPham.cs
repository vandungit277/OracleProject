using DevExpress.XtraEditors;
using Business;
using DevExpress.XtraEditors.Controls;
using DataTransferObject;
using System.Windows.Forms;

namespace SaleManager.San_Pham
{
    public partial class UCSanPham : XtraUserControl
    {
        #region Khai báo biến
        private readonly SanPhamBUS _hangHoa = new SanPhamBUS();
        private readonly NhaSanXuatBUS _nsx = new NhaSanXuatBUS();
        private readonly LoaiHangHoaBUS _loaiHang = new LoaiHangHoaBUS();
        private bool _loaiLuu;
        private decimal _maHangHoa;
        #endregion

        #region Load From
        public UCSanPham()
        {
            InitializeComponent();
        }

        private void UCSanPham_Load(object sender, System.EventArgs e)
        {
            LoadNhaSanXuat();
            LoadLoaiHang();
            SetButton(true);
            SetText(true);
        }

        private void gridControl_Load(object sender, System.EventArgs e)
        {
            gridControl.DataSource = _hangHoa.ViewHangHoa();
        }
        private void LoadNhaSanXuat()
        {
            luNhaSanXuat.Properties.DataSource = _nsx.ViewNhaSanXuat();
            luNhaSanXuat.Properties.ValueMember = "MANSX";
            luNhaSanXuat.Properties.DisplayMember = "TENNSX";
        }
        private void LoadLoaiHang()
        {
            luLoaiHangHoa.Properties.DataSource = _loaiHang.ViewLoaiHang();
            luLoaiHangHoa.Properties.ValueMember = "MALOAIHANG";
            luLoaiHangHoa.Properties.DisplayMember = "TENLOAIHANG";
        }
        private void LoadThongTinHangHoa()
        {
            ClearText();
            if (MAHANGHOA != null) _maHangHoa = decimal.Parse(gridView.GetFocusedRowCellDisplayText(MAHANGHOA));
            if (TENLOAIHANG != null) luLoaiHangHoa.EditValue = luLoaiHangHoa.Properties.GetKeyValueByDisplayText(gridView.GetFocusedRowCellDisplayText(TENLOAIHANG));
            if (TENNSX != null) luNhaSanXuat.EditValue = luNhaSanXuat.Properties.GetKeyValueByDisplayText(gridView.GetFocusedRowCellDisplayText(TENNSX));
            if (TENHANGHOA != null) txtTenSanPham.Text = gridView.GetFocusedRowCellDisplayText(TENHANGHOA);
            if (MOTA != null) txtMoTa.Text = gridView.GetFocusedRowCellDisplayText(MOTA);
            if (SOLUONGTON != null) txtSoLuongTon.Text = gridView.GetFocusedRowCellDisplayText(SOLUONGTON);
            if (GIANHAP != null) txtGiaNhap.Text = gridView.GetFocusedRowCellDisplayText(GIANHAP);
        }
        #endregion

        #region Thêm, Xóa, Sửa
        private void btnThem_Click(object sender, System.EventArgs e)
        {
            _loaiLuu = true;
            SetButton(false);
            SetText(false);
            ClearText();
        }
        private void btnSua_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            _loaiLuu = false;
            SetButton(false);
            SetText(false);
            LoadThongTinHangHoa();            
        }
        private void btnLuu_Click(object sender, System.EventArgs e)
        {
            var hangHoa = new HangHoa {
                MAHANGHOA = _maHangHoa,
                TENHANGHOA = txtTenSanPham.Text,
                MOTA = txtMoTa.Text,
                SOLUONGTON = decimal.Parse(txtSoLuongTon.Text),
                GIANHAP = long.Parse(txtGiaNhap.Text),
                MANSX = decimal.Parse(luNhaSanXuat.EditValue.ToString()),
                MALOAIHANG = decimal.Parse(luLoaiHangHoa.EditValue.ToString())
            };
            if (_loaiLuu)
            {
                _hangHoa.ThemHangHoa(hangHoa);
            }
            else if(!_loaiLuu)
            {
                _hangHoa.SuaHangHoa(hangHoa);
            }
            SetButton(true);
            SetText(true);
            ClearText();
            gridControl_Load(sender, e);
        }
        private void btnXoa_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            var maHangHoa = gridView.GetFocusedRowCellDisplayText(MAHANGHOA);
            var tenHangHoa = gridView.GetFocusedRowCellDisplayText(TENHANGHOA);
            var tenNSX = gridView.GetFocusedRowCellDisplayText(TENNSX);
            var tenLoaiHang = gridView.GetFocusedRowCellDisplayText(TENLOAIHANG);
            var dialog = XtraMessageBox.Show($"Hàng Hóa: {tenHangHoa}" + $"\nLoại Hàng: {tenLoaiHang}" + $"\nNhà Sản Xuất: {tenNSX}",
                    "XÓA HÀNG HÓA - #" + maHangHoa, MessageBoxButtons.YesNo);
            try
            {
                if (dialog == DialogResult.Yes)
                {
                    _hangHoa.XoaHangHoa(int.Parse(maHangHoa));
                }
            }
            catch
            {
                XtraMessageBox.Show("Lỗi xóa!");
            }
            SetButton(true);
            SetText(true);
            ClearText();
            gridControl_Load(sender, e);
        }
        private void btnHuy_Click(object sender, System.EventArgs e)
        {
            SetButton(true);
            SetText(true);
            ClearText();
            gridControl_Load(sender, e);
        }
        private void gridControl_Click(object sender, System.EventArgs e)
        {
            LoadThongTinHangHoa();
        }
        #endregion

        #region Set Button, Text
        /// <summary>
        /// Set ẩn hoặc hiện Button
        /// </summary>
        /// <param name="type">= True btnThem hiện</param>
        private void SetButton(bool type)
        {
            btnThem.Enabled = type;
            btnLuu.Enabled = !type;
            btnHuy.Enabled = !type;
        }
        /// <summary>
        /// Set ẩn hoặc cho sửa các trường thông tin
        /// </summary>
        /// <param name="type">= true không cho sửa</param>
        private void SetText(bool type)
        {
            txtTenSanPham.Properties.ReadOnly = type;
            txtSoLuongTon.Properties.ReadOnly = type;
            txtGiaNhap.Properties.ReadOnly = type;
            txtMoTa.Properties.ReadOnly = type;
            luLoaiHangHoa.Properties.ReadOnly = type;
            luNhaSanXuat.Properties.ReadOnly = type;
            gridControl.Enabled = type;
        }
        private void ClearText()
        {
            txtTenSanPham.Text = "";
            txtSoLuongTon.Text = "";
            txtMoTa.Text = "";
            txtGiaNhap.Text = "";
            luLoaiHangHoa.EditValue = null;
            luNhaSanXuat.EditValue = null;
        }
        #endregion
    }
}
