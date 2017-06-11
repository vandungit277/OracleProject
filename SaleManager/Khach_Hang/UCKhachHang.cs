using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DataTransferObject;
using Business;

namespace SaleManager.Khach_Hang
{
    public partial class UCKhachHang : DevExpress.XtraEditors.XtraUserControl
    {
        #region Khai báo biến

        private readonly KhachHangBUS _khachHang = new KhachHangBUS();

        private bool _loaiLuu;
        private decimal _maKhachHang;
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
            txtTenKhachHang.Properties.ReadOnly = type;
            txtSoDienThoai.Properties.ReadOnly = type;
            txtDiaChi.Properties.ReadOnly = type;
            txtEmail.Properties.ReadOnly = type;
            gridControl.Enabled = type;
        }
        private void ClearText()
        {
            txtTenKhachHang.Text = "";
            txtSoDienThoai.Text = "";
            txtDiaChi.Text = "";
            txtEmail.Text = "";
        }
        #endregion
        #region Load From
        public UCKhachHang()
        {
            InitializeComponent();
        }

        private void UCKhachHang_Load(object sender, EventArgs e)
        {
            SetButton(true);
            SetText(true);
        }
        private void gridControl_Load(object sender, EventArgs e)
        {
            gridControl.DataSource = _khachHang.ViewKhachHang();
        }

        private void LoadThongTinKhachHang()
        {
            ClearText();
            if (MAKHACHHANG != null) _maKhachHang = decimal.Parse(gridView.GetFocusedRowCellDisplayText(MAKHACHHANG));
            if (TENKHACHHANG != null) txtTenKhachHang.Text = gridView.GetFocusedRowCellDisplayText(TENKHACHHANG);
            if (SODIENTHOAI != null) txtSoDienThoai.Text = gridView.GetFocusedRowCellDisplayText(SODIENTHOAI);
            if (DIACHI != null) txtDiaChi.Text = gridView.GetFocusedRowCellDisplayText(DIACHI);
            if (EMAIL != null) txtEmail.Text = gridView.GetFocusedRowCellDisplayText(EMAIL);

        }




        #endregion

        #region Thêm, Xóa, Sửa
      

        private void btnThem_Click(object sender, EventArgs e)
        {
            _loaiLuu = true;
            SetButton(false);
            SetText(false);
            ClearText();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            SetButton(true);
            SetText(true);
            ClearText();
            gridControl_Load(sender, e);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            _loaiLuu = false;
            SetButton(false);
            SetText(false);
            LoadThongTinKhachHang();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            var maKhachHang = gridView.GetFocusedRowCellDisplayText(MAKHACHHANG);
            var tenKhachHang = gridView.GetFocusedRowCellDisplayText(TENKHACHHANG);

            var dialog = XtraMessageBox.Show($"Khách Hàng: {tenKhachHang}",
                    "XÓA KHÁCH HÀNG- #" + maKhachHang, MessageBoxButtons.YesNo);
            try
            {
                if (dialog == DialogResult.Yes)
                {
                    _khachHang.XoaKhachHang(int.Parse(maKhachHang));
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

        private void gridControl_Click(object sender, EventArgs e)
        {
            LoadThongTinKhachHang();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            var khachHang = new KhachHang
            {
                MAKHACHHANG = _maKhachHang,
                TENKHACHHANG = txtTenKhachHang.Text,
                SODIENTHOAI = txtSoDienThoai.Text,
                DIACHI = txtDiaChi.Text,
                EMAIL = txtEmail.Text
            };
            if (_loaiLuu)
            {
                _khachHang.ThemKhachHang(khachHang);
            }
            else if (!_loaiLuu)
            {
                _khachHang.SuaKhachHang(khachHang);
            }
            SetButton(true);
            SetText(true);
            ClearText();
            gridControl_Load(sender, e);
        }
        #endregion
    }
}
