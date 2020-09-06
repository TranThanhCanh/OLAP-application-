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
    public partial class DienGiaDinh : DevExpress.XtraEditors.XtraForm
    {
        KetNoi kn;
        DataSet ds;
        SqlDataAdapter da;
        DataColumn[] key = new DataColumn[1];
        public DienGiaDinh()
        {
            InitializeComponent();
            kn = new KetNoi();
            ds = new DataSet();
        }
        void load_grid()
        {
            string strselect = "select * FROM DIM_GDCS";
            da = new SqlDataAdapter(strselect, kn.connsql);
            da.Fill(ds, "DIM_GDCS");
            key[0] = ds.Tables["DIM_GDCS"].Columns["MAGDCS"];
            ds.Tables["DIM_GDCS"].PrimaryKey = key;
            dtgv_dgd.DataSource = ds.Tables["DIM_GDCS"];
            //Databingding(ds.Tables["DIM_LOP"]);
        }

        private void DienGiaDinh_Load(object sender, EventArgs e)
        {
            load_grid();
        }
    }
}