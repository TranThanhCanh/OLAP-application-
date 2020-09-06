using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using System.Data.SqlClient;
namespace TruongTH_Application
{
    public partial class NienKhoa : DevExpress.XtraEditors.XtraForm
    {
        KetNoi kn;
        DataSet ds;
        SqlDataAdapter da;
        DataColumn[] key = new DataColumn[1];
        public NienKhoa()
        {
            InitializeComponent();
            kn = new KetNoi();
            ds = new DataSet();
   
        }
        void load_grid()
        {
            string strselect = "select MANK,TENNK FROM DIM_NIENKHOA";
            da = new SqlDataAdapter(strselect, kn.connsql);
            da.Fill(ds, "DIM_NIENKHOA");
            key[0] = ds.Tables["DIM_NIENKHOA"].Columns["MANK"];
            ds.Tables["DIM_NIENKHOA"].PrimaryKey = key;
            dtgv_nk.DataSource = ds.Tables["DIM_NIENKHOA"];
           Databingding(ds.Tables["DIM_NIENKHOA"]);
        }

        private void NienKhoa_Load(object sender, EventArgs e)
        {
            load_grid();
        }
        void Databingding(DataTable dtb)
        {
            txt_mank.DataBindings.Clear();
            txt_tennk.DataBindings.Clear();

            txt_mank.DataBindings.Add("Text", dtb, "MANK");
            txt_tennk.DataBindings.Add("Text", dtb, "TENNK");

        }
        private void labelControl1_Click(object sender, EventArgs e)
        {

        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            luu.Enabled = true;
            txt_mank.Enabled = txt_tennk.Enabled = true;
            txt_mank.Text = "";
            txt_tennk.Text = "";
            txt_mank.Focus();
            sua.Enabled = false;
            xoa.Enabled = false;
        }

        private void sua_ItemClick(object sender, ItemClickEventArgs e)
        {
            luu.Enabled = true;
            txt_tennk.Enabled = true;
            txt_mank.Enabled =false;
            them.Enabled = false;
            xoa.Enabled = false;
        }

        private void luu_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                string strselect = "select * from DIM_NIENKHOA";
                da = new SqlDataAdapter(strselect, kn.connsql);
                ds = new DataSet();
                da.Fill(ds, "DIM_NIENKHOA");
                key[0] = ds.Tables["DIM_NIENKHOA"].Columns[0];
                ds.Tables["DIM_NIENKHOA"].PrimaryKey = key;

                if (txt_mank.Enabled == false)
                {
                    DataRow dr = ds.Tables["DIM_NIENKHOA"].Rows.Find(txt_mank.Text);
                    if (dr != null)
                    {
                        dr["TENNK"] = txt_tennk.Text;
                        SqlCommandBuilder cb = new SqlCommandBuilder(da);
                        da.Update(ds, "DIM_NIENKHOA");
                        dtgv_nk.Refresh();
                    }
                }
                else
                {
                    DataRow newrow = ds.Tables["DIM_NIENKHOA"].NewRow();
                    newrow["MANK"] = txt_mank.Text;
                    newrow["TENNK"] = txt_tennk.Text;
                    ds.Tables["DIM_NIENKHOA"].Rows.Add(newrow);
                    dtgv_nk.Refresh();
                    SqlCommandBuilder cb = new SqlCommandBuilder(da);
                    da.Update(ds, "DIM_NIENKHOA");
                    dtgv_nk.Refresh();

                }
                    MessageBox.Show("Bạn đã thêm thành công");
                  
                
                load_grid();
            }
            catch
            {
                MessageBox.Show("Thất bại");
            }
            luu.Enabled = false;
            sua.Enabled = false;
            xoa.Enabled = false;
            them.Enabled = true;
        }

        private void xoa_ItemClick(object sender, ItemClickEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn thật sự muốn xóa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                try
                {
                    string strselect = "select * from DIM_NIENKHOA";
                    da = new SqlDataAdapter(strselect, kn.connsql);
                    ds = new DataSet();
                    da.Fill(ds, "DIM_NIENKHOA");
                    key[0] = ds.Tables["DIM_NIENKHOA"].Columns[0];
                    ds.Tables["DIM_NIENKHOA"].PrimaryKey = key;

                    DataRow dr = ds.Tables["DIM_NIENKHOA"].Rows.Find(txt_mank.Text);
                    if (dr != null)
                    {
                        dr.Delete();
                        dtgv_nk.Refresh();
                    }
                    SqlCommandBuilder cb = new SqlCommandBuilder(da);
                    da.Update(ds, "DIM_NIENKHOA");
                    MessageBox.Show("Xóa thành công");
                    load_grid();
                }
                catch
                {
                    MessageBox.Show("Dữ liệu đang sử dụng.Không thể xóa");
                }
            }
            luu.Enabled = false;
            sua.Enabled = false;
            xoa.Enabled = false;
            them.Enabled = true;
        }
    }
}