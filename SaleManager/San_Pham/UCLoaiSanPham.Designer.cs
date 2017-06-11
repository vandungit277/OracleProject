namespace SaleManager.San_Pham
{
    partial class UCLoaiSanPham
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCLoaiSanPham));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject6 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject7 = new DevExpress.Utils.SerializableAppearanceObject();
            this.btnSua = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.btnXoa = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MALOAIHANG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TENLOAIHANG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SUA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnSuaLoai = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.XOA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnXoaLoai = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gbTuyChon = new System.Windows.Forms.GroupBox();
            this.btnHuy = new DevExpress.XtraEditors.SimpleButton();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.txtTenLoaiSanPham = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.btnSua)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnXoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSuaLoai)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnXoaLoai)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.gbTuyChon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenLoaiSanPham.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSua
            // 
            this.btnSua.AutoHeight = false;
            this.btnSua.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.BottomCenter, ((System.Drawing.Image)(resources.GetObject("btnSua.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, null, true)});
            this.btnSua.Name = "btnSua";
            // 
            // btnXoa
            // 
            this.btnXoa.AutoHeight = false;
            this.btnXoa.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.BottomCenter, ((System.Drawing.Image)(resources.GetObject("btnXoa.Buttons"))), "Cancel", new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, serializableAppearanceObject5, "", null, null, true)});
            this.btnXoa.Name = "btnXoa";
            // 
            // gridControl
            // 
            this.gridControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gridControl.Location = new System.Drawing.Point(0, 222);
            this.gridControl.MainView = this.gridView;
            this.gridControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gridControl.Name = "gridControl";
            this.gridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnSuaLoai,
            this.btnXoaLoai});
            this.gridControl.Size = new System.Drawing.Size(1167, 394);
            this.gridControl.TabIndex = 3;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            this.gridControl.Load += new System.EventHandler(this.gridControl_Load);
            this.gridControl.Click += new System.EventHandler(this.gridControl_Click);
            // 
            // gridView
            // 
            this.gridView.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MALOAIHANG,
            this.TENLOAIHANG,
            this.SUA,
            this.XOA});
            this.gridView.GridControl = this.gridControl;
            this.gridView.Name = "gridView";
            this.gridView.OptionsBehavior.AllowIncrementalSearch = true;
            this.gridView.OptionsCustomization.CustomizationFormSearchBoxVisible = true;
            this.gridView.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.gridView.OptionsFind.AlwaysVisible = true;
            this.gridView.OptionsView.ShowDetailButtons = false;
            this.gridView.OptionsView.ShowGroupPanel = false;
            // 
            // MALOAIHANG
            // 
            this.MALOAIHANG.Caption = "Mã Loại Sản Phẩm";
            this.MALOAIHANG.FieldName = "MALOAIHANG";
            this.MALOAIHANG.Name = "MALOAIHANG";
            this.MALOAIHANG.OptionsColumn.AllowEdit = false;
            this.MALOAIHANG.OptionsColumn.ReadOnly = true;
            this.MALOAIHANG.Visible = true;
            this.MALOAIHANG.VisibleIndex = 0;
            // 
            // TENLOAIHANG
            // 
            this.TENLOAIHANG.Caption = "Tên Loại Sản Phẩm";
            this.TENLOAIHANG.FieldName = "TENLOAIHANG";
            this.TENLOAIHANG.Name = "TENLOAIHANG";
            this.TENLOAIHANG.OptionsColumn.AllowEdit = false;
            this.TENLOAIHANG.OptionsColumn.ReadOnly = true;
            this.TENLOAIHANG.Visible = true;
            this.TENLOAIHANG.VisibleIndex = 1;
            // 
            // SUA
            // 
            this.SUA.Caption = "Sửa";
            this.SUA.ColumnEdit = this.btnSuaLoai;
            this.SUA.Name = "SUA";
            this.SUA.Visible = true;
            this.SUA.VisibleIndex = 2;
            // 
            // btnSuaLoai
            // 
            this.btnSuaLoai.AutoHeight = false;
            this.btnSuaLoai.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.BottomCenter, global::SaleManager.Properties.Resources.edit, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject6, "", null, null, true)});
            this.btnSuaLoai.Name = "btnSuaLoai";
            this.btnSuaLoai.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnSuaLoai.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btnSuaLoai_ButtonClick);
            // 
            // XOA
            // 
            this.XOA.Caption = "Xóa";
            this.XOA.ColumnEdit = this.btnXoaLoai;
            this.XOA.Name = "XOA";
            this.XOA.Visible = true;
            this.XOA.VisibleIndex = 3;
            // 
            // btnXoaLoai
            // 
            this.btnXoaLoai.AutoHeight = false;
            this.btnXoaLoai.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.BottomCenter, global::SaleManager.Properties.Resources.delete, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject7, "", null, null, true)});
            this.btnXoaLoai.Name = "btnXoaLoai";
            this.btnXoaLoai.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnXoaLoai.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btnXoaLoai_ButtonClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.gbTuyChon);
            this.groupBox1.Controls.Add(this.txtTenLoaiSanPham);
            this.groupBox1.Controls.Add(this.labelControl1);
            this.groupBox1.Location = new System.Drawing.Point(3, 4);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(1161, 212);
            this.groupBox1.TabIndex = 84;
            this.groupBox1.TabStop = false;
            // 
            // gbTuyChon
            // 
            this.gbTuyChon.Controls.Add(this.btnHuy);
            this.gbTuyChon.Controls.Add(this.btnThem);
            this.gbTuyChon.Controls.Add(this.btnLuu);
            this.gbTuyChon.Location = new System.Drawing.Point(21, 140);
            this.gbTuyChon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbTuyChon.Name = "gbTuyChon";
            this.gbTuyChon.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbTuyChon.Size = new System.Drawing.Size(329, 64);
            this.gbTuyChon.TabIndex = 72;
            this.gbTuyChon.TabStop = false;
            // 
            // btnHuy
            // 
            this.btnHuy.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnHuy.Appearance.Options.UseFont = true;
            this.btnHuy.Image = ((System.Drawing.Image)(resources.GetObject("btnHuy.Image")));
            this.btnHuy.Location = new System.Drawing.Point(219, 15);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(99, 42);
            this.btnHuy.TabIndex = 9;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnThem
            // 
            this.btnThem.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThem.Appearance.Options.UseFont = true;
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.Location = new System.Drawing.Point(7, 15);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(99, 42);
            this.btnThem.TabIndex = 7;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnLuu.Appearance.Options.UseFont = true;
            this.btnLuu.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.Image")));
            this.btnLuu.Location = new System.Drawing.Point(113, 15);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(99, 42);
            this.btnLuu.TabIndex = 8;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // txtTenLoaiSanPham
            // 
            this.txtTenLoaiSanPham.Location = new System.Drawing.Point(189, 27);
            this.txtTenLoaiSanPham.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTenLoaiSanPham.Name = "txtTenLoaiSanPham";
            this.txtTenLoaiSanPham.Size = new System.Drawing.Size(374, 22);
            this.txtTenLoaiSanPham.TabIndex = 70;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl1.Location = new System.Drawing.Point(21, 30);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(147, 21);
            this.labelControl1.TabIndex = 71;
            this.labelControl1.Text = "Tên Loại Sản Phẩm:";
            // 
            // UCLoaiSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gridControl);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "UCLoaiSanPham";
            this.Size = new System.Drawing.Size(1167, 615);
            this.Load += new System.EventHandler(this.UCLoaiSanPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnSua)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnXoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSuaLoai)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnXoaLoai)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbTuyChon.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtTenLoaiSanPham.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private DevExpress.XtraGrid.Columns.GridColumn MALOAIHANG;
        private DevExpress.XtraGrid.Columns.GridColumn TENLOAIHANG;
        private DevExpress.XtraGrid.Columns.GridColumn SUA;
        private DevExpress.XtraGrid.Columns.GridColumn XOA;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.TextEdit txtTenLoaiSanPham;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.GroupBox gbTuyChon;
        private DevExpress.XtraEditors.SimpleButton btnHuy;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnSua;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnXoa;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnSuaLoai;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnXoaLoai;
    }
}
