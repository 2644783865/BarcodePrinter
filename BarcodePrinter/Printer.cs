using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace BarcodePrinter
{
    public partial class Printer : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Printer()
        {
            InitializeComponent();
        }

        private void barButtonItemGenerateCodes_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            using (var form = new BarcodeSelector())
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    string galvID = form.GalvID;
                    int type = form.type;
                    int count = form.count;

                    using (KYLIEEntities ctx = new KYLIEEntities())
                    {

                       var currentBarcode = ctx.SCAN_BarcodeCount.FirstOrDefault();

                        DocumentCreationAPI.Generate pdf = new DocumentCreationAPI.Generate();

                        switch (type)
                        {
                            case 0:
                                pdf.GeneratePDF("A", currentBarcode.currentID , "D6 Root", 143, count, galvID);
                                break;
                            case 1:
                                pdf.GeneratePDF("A", currentBarcode.currentID , "D9 Root", 2484, count, galvID);
                                break;
                            default:
                                break;
                        }
                        MessageBox.Show(this, string.Format("Barcodes generated in {0}.pdf", galvID), "Success");

                        currentBarcode.currentID  = currentBarcode.currentID  + count;
                        ctx.SaveChanges();

                    }
                }
            }



        }
    }
}
