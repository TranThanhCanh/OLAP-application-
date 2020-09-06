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
    public partial class Lop : DevExpress.XtraEditors.XtraForm
    {

        KetNoi kn;
        DataSet ds;
        SqlDataAdapter da;
        DataColumn[] key = new DataColumn[1];
        public Lop()
        {
            InitializeComponent();
            kn = new KetNoi();
            ds = new DataSet();
        }
        void load_grid()
        {
            string strselect = "select * FROM DIM_LOP";
            da = new SqlDataAdapter(strselect, kn.connsql);
            da.Fill(ds, "DIM_LOP");
            key[0] = ds.Tables["DIM_LOP"].Columns["MALOP"];
            ds.Tables["DIM_LOP"].PrimaryKey = key;
            dtgv_lop.DataSource = ds.Tables["DIM_LOP"];
           Databingding(ds.Tables["DIM_LOP"]);
        }
        void Databingding(DataTable dtb)
        {
            txt_malop.DataBindings.Clear();
            txt_tenlop.DataBindings.Clear();
            txt_siso.DataBindings.Clear();

            txt_malop.DataBindings.Add("Text", dtb, "MALOP");
            txt_tenlop.DataBindings.Add("Text", dtb, "TENLOP");
            txt_siso.DataBindings.Add("Text", dtb, "SISO");

        }
        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textEdit2_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void textEdit3_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void labelControl2_Click(object sender, EventArgs e)
        {

        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }

        private void labelControl3_Click(object sender, EventArgs e)
        {

        }

        private void Lop_Load(object sender, EventArgs e)
        {
            load_grid();
        }
    }
}