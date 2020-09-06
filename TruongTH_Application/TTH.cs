using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraBars.FluentDesignSystem;

namespace TruongTH_Application
{
    public partial class TTH : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public TTH()
        {
            InitializeComponent();
        }

        private void TTH_Load(object sender, EventArgs e)
        {
            this.fluentDesignFormContainer1.Controls.Clear();
            ucDashboard dv = new ucDashboard();
            dv.Dock = DockStyle.Fill;
            this.fluentDesignFormContainer1.Controls.Add(dv);
            dv.Show();
        }

        private void fluentDesignFormContainer1_Click(object sender, EventArgs e)
        {

        }

        private void accordionControlElement1_Click(object sender, EventArgs e)
        {
           this.fluentDesignFormContainer1.Controls.Clear();
           NienKhoa dv = new NienKhoa();
            dv.TopLevel = false;
            dv.Dock = DockStyle.Fill;
            this.fluentDesignFormContainer1.Controls.Add(dv);
            dv.Show();
        }

        private void accordionControlElement6_Click(object sender, EventArgs e)
        {
            this.fluentDesignFormContainer1.Controls.Clear();
            ucDashboard dv = new ucDashboard();
            dv.Dock = DockStyle.Fill;
            this.fluentDesignFormContainer1.Controls.Add(dv);
            dv.Show();
        }

        private void accordionControlElement2_Click(object sender, EventArgs e)
        {
            this.fluentDesignFormContainer1.Controls.Clear();
            Lop dv = new Lop();
            dv.TopLevel = false;
            dv.Dock = DockStyle.Fill;
            this.fluentDesignFormContainer1.Controls.Add(dv);
            dv.Show();
        }

        private void accordionControlElement3_Click(object sender, EventArgs e)
        {
            this.fluentDesignFormContainer1.Controls.Clear();
            GiaoVien dv = new GiaoVien();
            dv.TopLevel = false;
            dv.Dock = DockStyle.Fill;
            this.fluentDesignFormContainer1.Controls.Add(dv);
            dv.Show();
        }

        private void accordionControlElement5_Click(object sender, EventArgs e)
        {

        }

        private void accordionControlElement8_Click(object sender, EventArgs e)
        {
            this.fluentDesignFormContainer1.Controls.Clear();
            ThongKe tk = new ThongKe();
            tk.TopLevel = false;
            tk.Dock = DockStyle.Fill;
            this.fluentDesignFormContainer1.Controls.Add(tk);
            tk.Show();
        }

        private void accordionControlElement4_Click(object sender, EventArgs e)
        {
            this.fluentDesignFormContainer1.Controls.Clear();
            DienGiaDinh tk = new DienGiaDinh();
            tk.TopLevel = false;
            tk.Dock = DockStyle.Fill;
            this.fluentDesignFormContainer1.Controls.Add(tk);
            tk.Show();
        }
    }
}