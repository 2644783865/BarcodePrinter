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

namespace BarcodePrinter
{
    public partial class JobNumber : DevExpress.XtraEditors.XtraForm
    {
        public string JobNumberSelected { get; set; }
        public JobNumber()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            this.JobNumberSelected = txtJobNumber.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}