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

namespace SaleManager.San_Pham
{
    public partial class UCNhaPhanPhoi : DevExpress.XtraEditors.XtraUserControl
    {
        #region Khai báo biến
    
        private readonly NhaPhanPhoiBUS _npp = new NhaPhanPhoiBUS();
 
        private bool _loaiLuu;
        private decimal _maNPP;
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
            txtTenNPP.Properties.ReadOnly = type;
            txtSoDienThoai.Properties.ReadOnly = type;
            txtDiaChi.Properties.ReadOnly = type;         
            gridControl.Enabled = type;
        }
        private void ClearText()
        {
            txtTenNPP.Text = "";
            txtSoDienThoai.Text = "";
            txtDiaChi.Text = "";          
        }
        #endregion

        #region Load From
        public UCNhaPhanPhoi()
        {
            InitializeComponent();
        }

        private void UCNhaPhanPhoi_Load(object sender, EventArgs e)
        {
           
            SetButton(true);
            SetText(true);
        }

        private void gridControl_Load(object sender, EventArgs e)
        {
            gridControl.DataSource = _npp.ViewNhaPhanPhoi();
        }


        private void LoadThongTinNPP()
        {
            ClearText();
            if (MANPP != null) _maNPP = decimal.Parse(gridView.GetFocusedRowCellDisplayText(MANPP));
            if (TENNPP != null) txtTenNPP.Text = gridView.GetFocusedRowCellDisplayText(TENNPP);
            if (SODIENTHOAI != null) txtSoDienThoai.Text = gridView.GetFocusedRowCellDisplayText(SODIENTHOAI);
            if (DIACHI != null) txtDiaChi.Text = gridView.GetFocusedRowCellDisplayText(DIACHI);
          
        }

        #endregion

        #region Thêm, Xóa, Sửa

        

        private void btnXoa_Click(object sender, EventArgs e)
        {
            var maNPP = gridView.GetFocusedRowCellDisplayText(MANPP);
            var tenNPP = gridView.GetFocusedRowCellDisplayText(TENNPP);
           
            var dialog = XtraMessageBox.Show($"Nhà Phân Phối: {tenNPP}" ,
                    "XÓA NHÀ PHÂN PHỐI- #" + maNPP, MessageBoxButtons.YesNo);
            try
            {
                if (dialog == DialogResult.Yes)
                {
                    _npp.XoaNPP(int.Parse(maNPP));
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

        private void btnSua_Click(object sender, EventArgs e)
        {
            _loaiLuu = false;
            SetButton(false);
            SetText(false);
            LoadThongTinNPP();
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
            gridControl_Load(sender, e);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            var nhaPhanPhoi = new NhaPhanPhoi
            {
                MANPP = _maNPP,
                TENNPP = txtTenNPP.Text,
                SODIENTHOAI = txtSoDienThoai.Text,
                DIACHI = txtDiaChi.Text
            };
            if (_loaiLuu)
            {
                _npp.ThemNPP(nhaPhanPhoi);
            }
            else if (!_loaiLuu)
            {
                _npp.SuaNPP(nhaPhanPhoi);
            }
            SetButton(true);
            SetText(true);
            ClearText();
            gridControl_Load(sender, e);
        }

        private void gridControl_Click(object sender, EventArgs e)
        {
            LoadThongTinNPP();
        }
        #endregion
    }
}
