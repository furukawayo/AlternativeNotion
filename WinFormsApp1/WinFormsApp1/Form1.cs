using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;
using ZXing.QrCode;
using ZXing.QrCode.Internal;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        private BitmapFrame QRcodeCreate(string code)
        {
            var qrCode = new BarcodeWriter
            {
                // バーコードの種類を選択
                Format = BarcodeFormat.QR_CODE,
                // QRコードのオプション設定
                Options = new QrCodeEncodingOptions
                {
                    QrVersion = 5,
                    ErrorCorrection = ErrorCorrectionLevel.M,
                    CharacterSet = "UTF-8",
                    Width = 200,
                    Height = 200,
                    Margin = 5,
                },
            };

            //QRコード生成
            BitmapFrame qrbmp;
            using (var bmp = qrCode.Write(code))
            using (var ms = new MemoryStream())
            {
                bmp.Save(ms, ImageFormat.Bmp);
                qrbmp = BitmapFrame.Create(ms, BitmapCreateOptions.None, BitmapCacheOption.OnLoad);
            }

            return qrbmp;
        }
    }
}
