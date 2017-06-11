using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataTransferObject;
using DevExpress.XtraEditors;
using Business;
namespace SaleManager.San_Pham
{
    public partial class UCLoaiSanPham : DevExpress.XtraEditors.XtraUserControl
    {
        #region Khai báo biến
        private readonly LoaiHangHoaBUS _loaiHang = new LoaiHangHoaBUS();
        private bool _loaiLuu;
        private decimal _maLoaiHang;
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
            txtTenLoaiSanPham.Properties.ReadOnly = type;
         
            gridControl.Enabled = type;
        }
        private void ClearText()
        {
            txtTenLoaiSanPham.Text = "";
            
        }
        #endregion

        #region Load From
        public UCLoaiSanPham()
        {
            InitializeComponent();
        }

        private void UCLoaiSanPham_Load(object sender, System.EventArgs e)
        {
           
            SetButton(true);
            SetText(true);
        }

        private void gridControl_Load(object sender, System.EventArgs e)
        {
            gridControl.DataSource = _loaiHang.ViewLoaiHang();
        }
       
        private void LoadThongTinHangHoa()
        {
            ClearText();
            if (MALOAIHANG != null) _maLoaiHang = decimal.Parse(gridView.GetFocusedRowCellDisplayText(MALOAIHANG));
            if (TENLOAIHANG != null) txtTenLoaiSanPham.Text = gridView.GetFocusedRowCellDisplayText(TENLOAIHANG);
           
        }

        #endregion

                
        private void btnSuaLoai_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            _loaiLuu = false;
            SetButton(false);
            SetText(false);
            LoadThongTinHangHoa();
        }

        private void btnXoaLoai_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

            var maLoaiHang = gridView.GetFocusedRowCellDisplayText(MALOAIHANG);         
            var tenLoaiHang = gridView.GetFocusedRowCellDisplayText(TENLOAIHANG);
            var dialog = XtraMessageBox.Show($"\nLoại Hàng: {tenLoaiHang}",
                    "XÓA HÀNG HÓA - #" + maLoaiHang, MessageBoxButtons.YesNo);
            try
            {
                if (dialog == DialogResult.Yes)
                {
                    _loaiHang.XoaLoaiHang(int.Parse(maLoaiHang));
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
            LoadThongTinHangHoa();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            _loaiLuu = true;
            SetButton(false);
            SetText(false);
            ClearText();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
             var loaiHangHoa = new LoaiHangHoa {
               MALOAIHANG  = _maLoaiHang,
               TENLOAIHANG = txtTenLoaiSanPham.Text             
            };

            if (_loaiLuu)
            {
                _loaiHang.ThemLoaiHang(loaiHangHoa);
            }
            else if(!_loaiLuu)
            {
                _loaiHang.SuaLoaiHang(loaiHangHoa);
            }
            SetButton(true);
            SetText(true);
            ClearText();
            gridControl_Load(sender, e);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            SetButton(true);
            SetText(true);
            ClearText();
            gridControl_Load(sender, e);
        }
    }

    
}
