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
    public partial class GiaoVien : DevExpress.XtraEditors.XtraForm
    {
        KetNoi kn;
        DataSet ds;
        SqlDataAdapter da;
        DataColumn[] key = new DataColumn[1];
        public GiaoVien()
        {
            InitializeComponent();
            kn = new KetNoi();
            ds = new DataSet();
        }
        void load_grid()
        {
            string strselect = "select MACBGV,TENCBGV,G.MABM,TENBM FROM DIM_GIAOVIEN G,DIM_BOMON B WHERE G.MABM=B.MABM";
            da = new SqlDataAdapter(strselect, kn.connsql);
            da.Fill(ds, "DIM_GIAOVIEN");
            key[0] = ds.Tables["DIM_GIAOVIEN"].Columns["MACBGV"];
            ds.Tables["DIM_GIAOVIEN"].PrimaryKey = key;
            dtgv_gv.DataSource = ds.Tables["DIM_GIAOVIEN"];
            Databingding(ds.Tables["DIM_GIAOVIEN"]);
        }
        void Databingding(DataTable dtb)
        {
            txt_magv.DataBindings.Clear();
            txt_tengv.DataBindings.Clear();
            cbo_bomon.DataBindings.Clear();


            txt_magv.DataBindings.Add("Text", dtb, "MACBGV");
            txt_tengv.DataBindings.Add("Text", dtb, "TENCBGV");
            cbo_bomon.DataBindings.Add("Text", dtb, "TENBM");

        }
        public void loadBM()
        {
            string strselect = "select * from DIM_BOMON";
            da = new SqlDataAdapter(strselect, kn.connsql);
            da.Fill(ds, "DIM_BOMON");
            cbo_bomon.DataSource = ds.Tables["DIM_BOMON"];
            cbo_bomon.DisplayMember = "TENBM";
            cbo_bomon.ValueMember = "MABM";

            cbo_bomon.SelectedItem = cbo_bomon.Items[0];


        }

        private void GiaoVien_Load(object sender, EventArgs e)
        {
            load_grid();
            loadBM();
        }
    }
}