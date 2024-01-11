using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QRCoder;

namespace QR_code_generator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void generateQR(string input)
        {
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(input, getMode());
            QRCode qrCode = new QRCode(qrCodeData);
            Bitmap qrCodeImage = qrCode.GetGraphic(20);

            if (cbxLogo.Checked)
                qrCodeImage = getLogoBitmap(qrCodeImage);

            Bitmap resized = new Bitmap(qrCodeImage, pbxQr.Width, pbxQr.Height);

            

            pbxQr.Image = resized;
        }

        private Bitmap getLogoBitmap(Bitmap input)
        {
            Bitmap result = new Bitmap(input.Width, input.Height);
            Bitmap tel = new Bitmap("TEL.png");
            //tel.MakeTransparent(Color.White);
            Graphics g = Graphics.FromImage(result);
            g.DrawImage(input, new Rectangle(0, 0, input.Width, input.Height));
            g.DrawImage(tel, new Rectangle((input.Width - tel.Width) / 2, (input.Height - tel.Height) / 2, tel.Width, tel.Height));
            return result;
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            generateQR(tbInput.Text);
        }

        private QRCodeGenerator.ECCLevel getMode()
        {
            if (rbL.Checked)
                return QRCodeGenerator.ECCLevel.L;
            if (rbM.Checked)
                return QRCodeGenerator.ECCLevel.M;
            if (rbQ.Checked)
                return QRCodeGenerator.ECCLevel.Q;
            return QRCodeGenerator.ECCLevel.H;
                    
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetImage(pbxQr.Image);
        }
    }
}
