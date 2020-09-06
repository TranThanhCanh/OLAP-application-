using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace TruongTH_Application
{
    class KetNoi
    {
        private SqlConnection _connsql;

        public SqlConnection connsql
        {
            get { return _connsql; }
            set { _connsql = value; }
        }
        public KetNoi()
        {
            _connsql = new SqlConnection("Data Source=ACER-PC\\CANH;Initial Catalog=DWTRUONGTIEUHOC;User ID=sa; Password=sa2012");
        }
    }
}
