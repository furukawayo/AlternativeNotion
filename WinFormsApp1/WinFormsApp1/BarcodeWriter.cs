using ZXing;
using ZXing.QrCode;

namespace WinFormsApp1
{
    internal class BarcodeWriter
    {
        public BarcodeFormat Format { get; set; }
        public QrCodeEncodingOptions Options { get; set; }
    }
}