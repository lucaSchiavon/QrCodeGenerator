using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ZXing;

namespace WinQrCodeCS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGenera_Click(object sender, EventArgs e)
        {
            string Testo = "http://www.iprogrammatori.it";
            IBarcodeWriter GeneraBarcode = new BarcodeWriter() { Format = BarcodeFormat.QR_CODE };
            Bitmap bitmapBarcode;
            var risultato = GeneraBarcode.Write(Testo);
            bitmapBarcode = new Bitmap(risultato);
            PictureBox1.Image = bitmapBarcode;

        }
    }
}
