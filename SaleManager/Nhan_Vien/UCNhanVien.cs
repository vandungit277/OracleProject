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

namespace SaleManager.Nhan_Vien
{
    public partial class UCNhanVien : DevExpress.XtraEditors.XtraUserControl
    {

        #region Khai báo biến
        private readonly NhanVienBUS _nhanVien = new NhanVienBUS();
        private readonly ChucVuBUS _cv = new ChucVuBUS();
        private bool _loaiLuu;
        private decimal _maNhanVien;
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
            txtTenNhanVien.Properties.ReadOnly = type;
            radioGroup1.Properties.ReadOnly = type;
            dateEditNTNS.Properties.ReadOnly = type;
            txtSoDienThoai.Properties.ReadOnly = type;
            luChucVu.Properties.ReadOnly = type;
            txtEmail.Properties.ReadOnly = type;
            txtDiaChi.Properties.ReadOnly = type;
            txtCMND.Properties.ReadOnly = type;
            rdnam.Enabled = !type;
            rdnu.Enabled = !type;

            gridControl.Enabled = type;
        }
        private void ClearText()
        {
            txtTenNhanVien.Text = "";
            dateEditNTNS.Text = "";
            txtSoDienThoai.Text = "";
            radioGroup1.EditValue = "";
            txtEmail.Text = "";
            luChucVu.EditValue = null;
            txtDiaChi.Text = "";
            txtCMND.Text = "";
        }
        #endregion

        #region Load From
        public UCNhanVien()
        {
            InitializeComponent();
        }
        private void UCNhanVien_Load(object sender, EventArgs e)
        {
            LoadChucVu();
            SetButton(true);
            SetText(true);
        }

        private void gridControl_Load(object sender, EventArgs e)
        {
            gridControl.DataSource = _nhanVien.ViewNhanVien();
        }

        private void LoadChucVu()
        {
            luChucVu.Properties.DataSource = _cv.ViewChucVu();
            luChucVu.Properties.ValueMember = "MACHUCVU";
            luChucVu.Properties.DisplayMember = "TENCHUCVU";
        }
       
        private void LoadThongTinNhanVien()
        {
            ClearText();
            if (MANHANVIEN != null) _maNhanVien = decimal.Parse(gridView.GetFocusedRowCellDisplayText(MANHANVIEN));
            if (TENCHUCVU != null) txtTenNhanVien.Text = gridView.GetFocusedRowCellDisplayText(TENCHUCVU);
            if (TENCHUCVU != null) luChucVu.EditValue = luChucVu.Properties.GetKeyValueByDisplayText(gridView.GetFocusedRowCellDisplayText(TENCHUCVU));
            //if (GIOITINH != null) txtTenSanPham.Text = gridView.GetFocusedRowCellDisplayText(GIOITINH);
            if (NTNS != null) dateEditNTNS.Text = gridView.GetFocusedRowCellDisplayText(NTNS);
            if (SODIENTHOAI != null) txtSoDienThoai.Text = gridView.GetFocusedRowCellDisplayText(SODIENTHOAI);
            if (CMND != null) txtCMND.Text = gridView.GetFocusedRowCellDisplayText(CMND);
            if (DIACHI != null) txtDiaChi.Text = gridView.GetFocusedRowCellDisplayText(DIACHI);
            if (EMAIL != null) txtEmail.Text = gridView.GetFocusedRowCellDisplayText(EMAIL);
            //EQUALS SO SÁNH CHUỖI = .text ="NAM"
            var gioiTinh = gridView.GetFocusedRowCellDisplayText(GIOITINH);
            if (gioiTinh.Equals("Nam"))
            {
                rdnam.Checked = true;
                rdnu.Checked = false;
            }
            else
            {
                rdnu.Checked = true;
                rdnam.Checked = false;
            }
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

        private void gridControl_Click(object sender, EventArgs e)
        {
            LoadThongTinNhanVien();
        }


        #endregion

        private void btnSua_Click(object sender, EventArgs e)
        {
            _loaiLuu = false;
            SetButton(false);
            SetText(false);
            LoadThongTinNhanVien();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            var maNhanVien = gridView.GetFocusedRowCellDisplayText(MANHANVIEN);
            var tenNhanVien = gridView.GetFocusedRowCellDisplayText(TENNHANVIEN);
            var tenChucVu = gridView.GetFocusedRowCellDisplayText(TENCHUCVU);
           
            var dialog = XtraMessageBox.Show($"Nhân Viên: {tenNhanVien}" + $"\nChức Vụ: {tenChucVu}",
                    "XÓA HÀNG HÓA - #" + maNhanVien, MessageBoxButtons.YesNo);
            try
            {
                if (dialog == DialogResult.Yes)
                {
                    _nhanVien.XoaNhanVien(int.Parse(maNhanVien));
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

        private void btnLuu_Click(object sender, EventArgs e)
        {
            var nhanVien = new NhanVien
            {
                MANHANVIEN = _maNhanVien,
                TENNHANVIEN = txtTenNhanVien.Text,
                GIOITINH = rdnam.Checked == true ? "Nam" : "Nữ",
                NTNS = dateEditNTNS.DateTime,
                SODIENTHOAI =txtSoDienThoai.Text,
                CMND = txtCMND.Text,
                EMAIL = txtEmail.Text,
                DIACHI = txtDiaChi.Text,
                MACHUCVU = decimal.Parse(luChucVu.EditValue.ToString())
            };
            if (_loaiLuu)
            {                
                _nhanVien.ThemNhanVien(nhanVien);
            }
            else if (!_loaiLuu)
            {
                _nhanVien.SuaNhanVien(nhanVien);
            }
            SetButton(true);
            SetText(true);
            ClearText();
            gridControl_Load(sender, e);
        }
    }
}
