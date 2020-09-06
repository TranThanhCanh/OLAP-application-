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
using System.Data.OleDb;

namespace TruongTH_Application
{
    public partial class ThongKe : DevExpress.XtraEditors.XtraForm
    {
        KetNoi kn;
        public ThongKe()
        {
            InitializeComponent();
            kn = new KetNoi();
        }
        void load_grid()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * from FACT_DIEM", kn.connsql);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            
            string filename = "";
            OpenFileDialog dlg = new OpenFileDialog();
            if(dlg.ShowDialog()==DialogResult.OK)
            {
                filename = dlg.FileName;
                MessageBox.Show(filename);
            }
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Excel Files|*.xls;*.xlsx", ValidateNames = true })
            {
                //String filename = @"E:\KH2-NAM3\CSDL_OLAP\Fact.xlsx";
                String connection = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + filename + ";Extended Properties=\"Excel 12.0 Xml;HDR=YES;\"";
                String Command = "Select * from [Sheet1$]";
                OleDbConnection con = new OleDbConnection(connection);
                con.Open();
                OleDbCommand cmd1 = new OleDbCommand(Command, con);
                OleDbDataAdapter db = new OleDbDataAdapter(cmd1);
                DataTable dt = new DataTable();
                db.Fill(dt);
                con.Close();
                ///
                SqlCommand cmd2 = new SqlCommand("dbo.InsertFACT", kn.connsql);
                cmd2.CommandType = CommandType.StoredProcedure;
                SqlParameter tvparam = cmd2.Parameters.AddWithValue("@DT", dt);
                tvparam.SqlDbType = SqlDbType.Structured;
                kn.connsql.Open();
                cmd2.ExecuteNonQuery();
                kn.connsql.Close();
                ////
                dataGridView1.DataSource = "";
                load_grid();

            }
        }

        private void ThongKe_Load(object sender, EventArgs e)
        {
            load_grid();
        }

        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void barButtonItem5_ItemClick(object sender, ItemClickEventArgs e)
        {
            String connection = "Data Source=ACER-PC\\CANH;Initial Catalog=QLTruongTieuHoc;User ID=sa; Password=sa2012";
            SqlConnection con = new SqlConnection(connection);
            con.Open();
            String Command = "Select * from V_FACT_DIEMTB";
            // DataSet dt = new DataSet();
            SqlCommand cmd1 = new SqlCommand(Command, con);
            SqlDataAdapter db = new SqlDataAdapter(cmd1);
            DataTable dt = new DataTable();
            db.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
            con.Close();
            SqlCommand cmd2 = new SqlCommand("dbo.InsertFACT", kn.connsql);
            cmd2.CommandType = CommandType.StoredProcedure;
            SqlParameter tvparam = cmd2.Parameters.AddWithValue("@DT", dt);
            tvparam.SqlDbType = SqlDbType.Structured;
            kn.connsql.Open();
            cmd2.ExecuteNonQuery();
            kn.connsql.Close();
            //////
            dataGridView1.DataSource = "";
            load_grid();
        }

        private void barButtonItem7_ItemClick(object sender, ItemClickEventArgs e)
        {
            
            SqlCommand cmd = new SqlCommand("Delete from FACT_DIEM", kn.connsql);
            kn.connsql.Open();
            cmd.ExecuteNonQuery();
            kn.connsql.Close();
            load_grid();
        }
    }
}