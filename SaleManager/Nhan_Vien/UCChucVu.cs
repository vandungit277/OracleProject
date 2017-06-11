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
    public partial class UCChucVu : DevExpress.XtraEditors.XtraUserControl
    {
        #region Khai báo biến
        private readonly ChucVuBUS _chucVu = new ChucVuBUS();
        private bool _loaiLuu;
        private decimal _maChucVu;
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
            txtTenChucVu.Properties.ReadOnly = type;
            txtMoTa.Properties.ReadOnly = type;
            gridControl.Enabled = type;
        }
        private void ClearText()
        {
            txtTenChucVu.Text = "";
            txtMoTa.Text = "";

        }
        #endregion
        #region Load From
        public UCChucVu()
        {
            InitializeComponent();
        }


        private void gridControl_Load_1(object sender, EventArgs e)
        {
            gridControl.DataSource = _chucVu.ViewChucVu();
        }

        private void LoadThongTinHangHoa()
        {
            ClearText();
            if (MACHUCVU != null) _maChucVu = decimal.Parse(gridView.GetFocusedRowCellDisplayText(MACHUCVU));
            if (TENCHUCVU != null) txtTenChucVu.Text = gridView.GetFocusedRowCellDisplayText(TENCHUCVU);
            if (MOTA != null) txtMoTa.Text = gridView.GetFocusedRowCellDisplayText(MOTA);

        }
  

        private void UCChucVu_Load(object sender, EventArgs e)
        {
            SetButton(true);
            SetText(true);
        }

        #endregion
        #region Thêm, Xóa, Sửa
        private void gridControl_Click(object sender, EventArgs e)
        {
            LoadThongTinHangHoa();
        }

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
            gridControl_Load_1(sender, e);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            _loaiLuu = false;
            SetButton(false);
            SetText(false);
            LoadThongTinHangHoa();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            var maChucVu = gridView.GetFocusedRowCellDisplayText(MACHUCVU);
            var tenChucVu = gridView.GetFocusedRowCellDisplayText(TENCHUCVU);
            var dialog = XtraMessageBox.Show($"\nChức Vụ: {tenChucVu}",
                    "XÓA HÀNG HÓA - #" + maChucVu, MessageBoxButtons.YesNo);
            try
            {
                if (dialog == DialogResult.Yes)
                {
                    _chucVu.XoaChucVu(int.Parse(maChucVu));
                }
            }
            catch
            {
                XtraMessageBox.Show("Lỗi xóa!");
            }
            SetButton(true);
            SetText(true);
            ClearText();
            gridControl_Load_1(sender, e);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            var chucVu = new ChucVu
            {
                MACHUCVU = _maChucVu,
                TENCHUCVU = txtTenChucVu.Text,
                MOTA = txtMoTa.Text
            };

            if (_loaiLuu)
            {
                _chucVu.SuaChucVu(chucVu);
            }
            else if (!_loaiLuu)
            {
                _chucVu.SuaChucVu(chucVu);
            }
            SetButton(true);
            SetText(true);
            ClearText();
            gridControl_Load_1(sender, e);
        }
        #endregion
    }

}
