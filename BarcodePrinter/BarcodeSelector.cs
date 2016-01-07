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
    public partial class BarcodeSelector : DevExpress.XtraEditors.XtraForm
    {

        public string GalvID { get; set; }
        public int type { get; set; }
        public int count { get; set; }
        public BarcodeSelector()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            this.GalvID = txtGalvID.Text.ToString();
            this.type = cbAssemblyType.SelectedIndex;
            this.count = Convert.ToInt16(spinTotalItems.Text);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}