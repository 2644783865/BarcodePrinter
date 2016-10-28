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
                            case 2:
                                pdf.GeneratePDF("A", currentBarcode.currentID, "D9 4 Exit Multibase Root", 3293, count, galvID);
                                break;
                            case 3:
                                pdf.GeneratePDF("A", currentBarcode.currentID, "12 Bolt Root Section 4 Exit", 366, count, galvID);
                                break;
                            case 4:
                                pdf.GeneratePDF("A", currentBarcode.currentID, "Planted Root", 186, count, galvID);
                                break;
                            case 5:
                                pdf.GeneratePDF("A", currentBarcode.currentID, "8 Bolt Pad", 515, count, galvID);
                                break;
                            case 6:
                                pdf.GeneratePDF("A", currentBarcode.currentID, "12 Bolt Pad", 630, count, galvID);
                                break;
                            case 7:
                                pdf.GeneratePDF("A", currentBarcode.currentID, "Cantilever Root", 1735, count, galvID);
                                break;
                            case 8:
                                pdf.GeneratePDF("A", currentBarcode.currentID, "6 to 8 Hole Spool", 2735, count, galvID);
                                break;
                            case 9:
                                pdf.GeneratePDF("A", currentBarcode.currentID, "8 to 8 Hole Spool", 1554, count, galvID);
                                break;
                            case 10:
                                pdf.GeneratePDF("A", currentBarcode.currentID, "6 to 8 Hole Adapter", 1580, count, galvID);
                                break;
                            case 11:
                                pdf.GeneratePDF("A", currentBarcode.currentID, "T Range headframe", 1807, count, galvID);
                                break;
                            case 12:
                                pdf.GeneratePDF("A", currentBarcode.currentID, "Elara / S Range / Phase 5 headframe", 3394, count, galvID);
                                break;
                            case 13:
                                pdf.GeneratePDF("A", currentBarcode.currentID, "Alpha Flagpole antennas adaptor", 2974, count, galvID);
                                break;
                            case 14:
                                pdf.GeneratePDF("A", currentBarcode.currentID, "Alpha Streetworks Headframe", 3036, count, galvID);
                                break;
                            default:
                                break;
                        }
                        MessageBox.Show(this, string.Format("Barcodes generated in {0}.pdf", galvID), "Success");

                        currentBarcode.currentID  = currentBarcode.currentID  + count;
                        ctx.SaveChanges();

                        this.pdfViewer1.LoadDocument(string.Format("C:\\TEMP\\{0}.pdf", galvID));


                    }
                }
            }



        }

        private void barGenerateJobCode_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (var form = new JobNumber())
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    string jobNumber = form.JobNumberSelected;

                    using (KYLIEEntities ctx = new KYLIEEntities())
                    {
                        int id = ctx.Jobs.Where(w => w.JobNumber == jobNumber).Select(s => s.JobNumber_PK).FirstOrDefault();
                        DocumentCreationAPI.Generate pdf = new DocumentCreationAPI.Generate();

                        pdf.GeneratePoleTemplatePDF("R", jobNumber, id);

                        MessageBox.Show(this, string.Format("Barcode generated in {0}.pdf", jobNumber), "Success");

                        this.pdfViewer1.LoadDocument(string.Format("C:\\TEMP\\{0}.pdf", jobNumber));

                    }
                }
            }
        }
    }
}
