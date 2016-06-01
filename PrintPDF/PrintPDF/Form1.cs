using Ghostscript.NET;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrintPDF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBrowsePdf_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            DialogResult result =  fileDialog.ShowDialog();
            if (result == DialogResult.OK) // Test result.
            {
                txtPDFFileLocation.Text = fileDialog.FileName;
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            string _PrinterName = txtPrinter.Text;
            string PdfFileName = txtPDFFileLocation.Text;

            GhostscriptVersionInfo gvi = new GhostscriptVersionInfo(new Version(0, 0, 0), Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "gsdll32.dll"), string.Empty, GhostscriptLicense.GPL);
            Ghostscript.NET.Processor.GhostscriptProcessor processor = new Ghostscript.NET.Processor.GhostscriptProcessor(gvi, true);
            List<string> switches = new List<string>();
            switches.Add("-empty");
            switches.Add("-dPrinted");
            switches.Add("-dBATCH");
            switches.Add("-dNOPAUSE");
            switches.Add("-dNOSAFER");
            switches.Add("-dPDFFitPage");
            switches.Add("-dNumCopies=1");
            switches.Add("-dSubsetFonts=false");
            switches.Add("-sFONTPATH=C:\\Windows\\Fonts");
            switches.Add("-sDEVICE=mswinpr2");
            switches.Add("-f");
            switches.Add(Convert.ToString("-sOutputFile=%printer%") + _PrinterName);
            switches.Add(PdfFileName);
            processor.StartProcessing(switches.ToArray(), null);
        }
    }
}
