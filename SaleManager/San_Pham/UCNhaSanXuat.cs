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
using DevExpress.XtraEditors;
using DataTransferObject;
using Business;

namespace SaleManager.San_Pham
{
    public partial class UCNhaSanXuat : DevExpress.XtraEditors.XtraUserControl
    {

        #region Khai báo biến

        private readonly NhaSanXuatBUS _nsx = new NhaSanXuatBUS();

        private bool _loaiLuu;
        private decimal _maNSX;
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
            txtTenNSX.Properties.ReadOnly = type;
           
            gridControl.Enabled = type;
        }
        private void ClearText()
        {
            txtTenNSX.Text = "";
          
        }
        #endregion
        #region Load From
        public UCNhaSanXuat()
        {
            InitializeComponent();
        }

        private void UCNhaSanXuat_Load(object sender, EventArgs e)
        {
            SetButton(true);
            SetText(true);
        }
        private void gridControl_Load_1(object sender, EventArgs e)
        {
            gridControl.DataSource = _nsx.ViewNhaSanXuat();
        }
     

        private void LoadThongTinNSX()
        {
            ClearText();
            if (MANSX != null) _maNSX = decimal.Parse(gridView.GetFocusedRowCellDisplayText(MANSX));
            if (TENNSX != null) txtTenNSX.Text = gridView.GetFocusedRowCellDisplayText(TENNSX);
          
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
            gridControl_Load_1(sender, e);
        }

        private void gridControl_Click(object sender, EventArgs e)
        {
            LoadThongTinNSX();
        }

        private void btnSuaLoai_Click(object sender, EventArgs e)
        {
            _loaiLuu = false;
            SetButton(false);
            SetText(false);
            LoadThongTinNSX();

        }

        #endregion

        private void btnXoaLoai_Click(object sender, EventArgs e)
        {
            var maNSX = gridView.GetFocusedRowCellDisplayText(MANSX);
            var tenNSX = gridView.GetFocusedRowCellDisplayText(TENNSX);

            var dialog = XtraMessageBox.Show($"Nhà Sản Xuất: {tenNSX}",
                    "XÓA NHÀ SẢN XUẤT - #" + maNSX, MessageBoxButtons.YesNo);
            try
            {
                if (dialog == DialogResult.Yes)
                {
                    _nsx.XoaNSX(int.Parse(maNSX));
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
            var nhaSanXuat = new NhaSanXuat
            {
                MANSX = _maNSX,
                TENNSX = txtTenNSX.Text,
               
            };
            if (_loaiLuu)
            {
                _nsx.ThemNSX(nhaSanXuat);
            }
            else if (!_loaiLuu)
            {
                _nsx.SuaNSX(nhaSanXuat);
            }
            SetButton(true);
            SetText(true);
            ClearText();
            gridControl_Load_1(sender, e);
        }
    }
}
