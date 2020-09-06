namespace TruongTH_Application
{
    partial class NienKhoa
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NienKhoa));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.them = new DevExpress.XtraBars.BarButtonItem();
            this.sua = new DevExpress.XtraBars.BarButtonItem();
            this.luu = new DevExpress.XtraBars.BarButtonItem();
            this.xoa = new DevExpress.XtraBars.BarButtonItem();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.napexcel = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem6 = new DevExpress.XtraBars.BarButtonItem();
            this.naptxt = new DevExpress.XtraBars.BarButtonItem();
            this.thoat = new DevExpress.XtraBars.BarButtonItem();
            this.tablePanel1 = new DevExpress.Utils.Layout.TablePanel();
            this.dtgv_nk = new System.Windows.Forms.DataGridView();
            this.tablePanel2 = new DevExpress.Utils.Layout.TablePanel();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txt_mank = new DevExpress.XtraEditors.TextEdit();
            this.txt_tennk = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).BeginInit();
            this.tablePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_nk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel2)).BeginInit();
            this.tablePanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_mank.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_tennk.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1,
            this.bar2,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.them,
            this.sua,
            this.luu,
            this.xoa,
            this.barButtonItem5,
            this.barButtonItem6,
            this.napexcel,
            this.naptxt,
            this.thoat});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 9;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 1;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.them),
            new DevExpress.XtraBars.LinkPersistInfo(this.sua),
            new DevExpress.XtraBars.LinkPersistInfo(this.luu),
            new DevExpress.XtraBars.LinkPersistInfo(this.xoa),
            new DevExpress.XtraBars.LinkPersistInfo(this.thoat)});
            this.bar1.Text = "Tools";
            // 
            // them
            // 
            this.them.Caption = "barButtonItem1";
            this.them.Id = 0;
            this.them.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image")));
            this.them.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.LargeImage")));
            this.them.Name = "them";
            this.them.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // sua
            // 
            this.sua.Caption = "barButtonItem2";
            this.sua.Enabled = false;
            this.sua.Id = 1;
            this.sua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.Image")));
            this.sua.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.LargeImage")));
            this.sua.Name = "sua";
            this.sua.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.sua_ItemClick);
            // 
            // luu
            // 
            this.luu.Caption = "barButtonItem3";
            this.luu.Id = 2;
            this.luu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.ImageOptions.Image")));
            this.luu.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.ImageOptions.LargeImage")));
            this.luu.Name = "luu";
            this.luu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.luu_ItemClick);
            // 
            // xoa
            // 
            this.xoa.Caption = "barButtonItem4";
            this.xoa.Id = 3;
            this.xoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem4.ImageOptions.Image")));
            this.xoa.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem4.ImageOptions.LargeImage")));
            this.xoa.Name = "xoa";
            this.xoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.xoa_ItemClick);
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.napexcel),
            new DevExpress.XtraBars.LinkPersistInfo(this.naptxt)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // napexcel
            // 
            this.napexcel.Caption = "barButtonItem7";
            this.napexcel.Id = 6;
            this.napexcel.ImageOptions.Image = global::TruongTH_Application.Properties.Resources.excel21;
            this.napexcel.Name = "napexcel";
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.barDockControlTop.Size = new System.Drawing.Size(948, 74);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 554);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.barDockControlBottom.Size = new System.Drawing.Size(948, 23);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 74);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 480);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(948, 74);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 480);
            // 
            // barButtonItem5
            // 
            this.barButtonItem5.Caption = "barButtonItem5";
            this.barButtonItem5.Id = 4;
            this.barButtonItem5.ImageOptions.Image = global::TruongTH_Application.Properties.Resources.excel2;
            this.barButtonItem5.Name = "barButtonItem5";
            // 
            // barButtonItem6
            // 
            this.barButtonItem6.Caption = "barButtonItem6";
            this.barButtonItem6.Id = 5;
            this.barButtonItem6.ImageOptions.Image = global::TruongTH_Application.Properties.Resources.excel11;
            this.barButtonItem6.Name = "barButtonItem6";
            // 
            // naptxt
            // 
            this.naptxt.Caption = "barButtonItem8";
            this.naptxt.Id = 7;
            this.naptxt.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem8.ImageOptions.Image")));
            this.naptxt.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem8.ImageOptions.LargeImage")));
            this.naptxt.Name = "naptxt";
            // 
            // thoat
            // 
            this.thoat.Caption = "barButtonItem9";
            this.thoat.Id = 8;
            this.thoat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem9.ImageOptions.Image")));
            this.thoat.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem9.ImageOptions.LargeImage")));
            this.thoat.Name = "thoat";
            // 
            // tablePanel1
            // 
            this.tablePanel1.AutoScroll = true;
            this.tablePanel1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 55F)});
            this.tablePanel1.Controls.Add(this.tablePanel2);
            this.tablePanel1.Controls.Add(this.dtgv_nk);
            this.tablePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel1.Location = new System.Drawing.Point(0, 74);
            this.tablePanel1.Name = "tablePanel1";
            this.tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 250F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 22F)});
            this.tablePanel1.Size = new System.Drawing.Size(948, 480);
            this.tablePanel1.TabIndex = 4;
            // 
            // dtgv_nk
            // 
            this.dtgv_nk.BackgroundColor = System.Drawing.Color.White;
            this.tablePanel1.SetColumn(this.dtgv_nk, 0);
            this.dtgv_nk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_nk.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgv_nk.GridColor = System.Drawing.Color.White;
            this.dtgv_nk.Location = new System.Drawing.Point(3, 3);
            this.dtgv_nk.Name = "dtgv_nk";
            this.tablePanel1.SetRow(this.dtgv_nk, 0);
            this.dtgv_nk.Size = new System.Drawing.Size(942, 244);
            this.dtgv_nk.TabIndex = 0;
            // 
            // tablePanel2
            // 
            this.tablePanel1.SetColumn(this.tablePanel2, 0);
            this.tablePanel2.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 10F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 20F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 30F)});
            this.tablePanel2.Controls.Add(this.txt_tennk);
            this.tablePanel2.Controls.Add(this.txt_mank);
            this.tablePanel2.Controls.Add(this.labelControl2);
            this.tablePanel2.Controls.Add(this.labelControl1);
            this.tablePanel2.Location = new System.Drawing.Point(3, 295);
            this.tablePanel2.Name = "tablePanel2";
            this.tablePanel1.SetRow(this.tablePanel2, 1);
            this.tablePanel2.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 60F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F)});
            this.tablePanel2.Size = new System.Drawing.Size(942, 140);
            this.tablePanel2.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.tablePanel2.SetColumn(this.labelControl1, 0);
            this.labelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelControl1.Location = new System.Drawing.Point(3, 3);
            this.labelControl1.Name = "labelControl1";
            this.tablePanel2.SetRow(this.labelControl1, 0);
            this.labelControl1.Size = new System.Drawing.Size(151, 54);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Mã niên khóa";
            this.labelControl1.Click += new System.EventHandler(this.labelControl1_Click);
            // 
            // labelControl2
            // 
            this.tablePanel2.SetColumn(this.labelControl2, 0);
            this.labelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelControl2.Location = new System.Drawing.Point(3, 63);
            this.labelControl2.Name = "labelControl2";
            this.tablePanel2.SetRow(this.labelControl2, 1);
            this.labelControl2.Size = new System.Drawing.Size(151, 74);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Niên khóa";
            // 
            // txt_mank
            // 
            this.tablePanel2.SetColumn(this.txt_mank, 1);
            this.txt_mank.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_mank.Enabled = false;
            this.txt_mank.Location = new System.Drawing.Point(160, 3);
            this.txt_mank.MenuManager = this.barManager1;
            this.txt_mank.Name = "txt_mank";
            this.tablePanel2.SetRow(this.txt_mank, 0);
            this.txt_mank.Size = new System.Drawing.Size(308, 54);
            this.txt_mank.TabIndex = 2;
            // 
            // txt_tennk
            // 
            this.tablePanel2.SetColumn(this.txt_tennk, 1);
            this.txt_tennk.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_tennk.Enabled = false;
            this.txt_tennk.Location = new System.Drawing.Point(160, 63);
            this.txt_tennk.MenuManager = this.barManager1;
            this.txt_tennk.Name = "txt_tennk";
            this.tablePanel2.SetRow(this.txt_tennk, 1);
            this.txt_tennk.Size = new System.Drawing.Size(308, 74);
            this.txt_tennk.TabIndex = 3;
            // 
            // NienKhoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 577);
            this.Controls.Add(this.tablePanel1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.IconOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("NienKhoa.IconOptions.LargeImage")));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "NienKhoa";
            this.Text = "NIÊN KHÓA";
            this.Load += new System.EventHandler(this.NienKhoa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).EndInit();
            this.tablePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_nk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel2)).EndInit();
            this.tablePanel2.ResumeLayout(false);
            this.tablePanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_mank.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_tennk.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem them;
        private DevExpress.XtraBars.BarButtonItem sua;
        private DevExpress.XtraBars.BarButtonItem luu;
        private DevExpress.XtraBars.BarButtonItem xoa;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
        private DevExpress.XtraBars.BarButtonItem barButtonItem6;
        private DevExpress.XtraBars.BarButtonItem napexcel;
        private DevExpress.XtraBars.BarButtonItem thoat;
        private DevExpress.XtraBars.BarButtonItem naptxt;
        private DevExpress.Utils.Layout.TablePanel tablePanel1;
        private System.Windows.Forms.DataGridView dtgv_nk;
        private DevExpress.Utils.Layout.TablePanel tablePanel2;
        private DevExpress.XtraEditors.TextEdit txt_tennk;
        private DevExpress.XtraEditors.TextEdit txt_mank;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}