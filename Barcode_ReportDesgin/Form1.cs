using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Barcode_ReportDesgin
{


    public partial class Form1 : Form
    {
        BarcodeLib.Barcode b = new BarcodeLib.Barcode();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbEncodeType.SelectedIndex = 0;
            cbBarcodeAlign.SelectedIndex = 0;
            cbBarcodeAlign.SelectedIndex = 0;
            cbRotateFlip.SelectedIndex = 0;
            cbLabelLocation.SelectedIndex = 0;
            this.cbRotateFlip.DataSource = System.Enum.GetNames(typeof(RotateFlipType));

        }

        public  Bitmap ResizeImage(Image image, int width, int height)
        {
            // var destRect = new Rectangle(0, 0, width, height);
            // var destImage = new Bitmap(width, height);
            Bitmap b = new Bitmap(width, height);
            using (Graphics g = Graphics.FromImage((Image)b))
            {
                g.DrawImage(image, 0, 0, width, height);
            }
            return b;
            // return destImage;
        }


        int barcode_W = 400;
        int barcode_H = 100;
        int barcode_Top = 20;
        int barcode_Left = 20;

        //
        int price_W = 200;
        int price_H = 100;
        int price_Top = 5;
        int price_Left = 5;

        //

        int ItemName_W = 200;
        int ItemName_H = 100;
        int ItemName_Top = 300;
        int ItemName_Left = 50;


        int MarketName_W = 200;
        int MarketName_H = 100;
        int MarketName_Top = 200;
        int MarketName_Left = 50;

        public  Bitmap GengerateFinalImage(Bitmap img_barcode, string Price, string ItemName, string MarketName)
        {
            Pen bluekPen = new Pen(Color.Blue, 2);
            Pen blackPen = new Pen(Color.Black, 1);
            Font font = new Font(FontFamily.GenericSansSerif, 15, FontStyle.Regular);
            Font copyrightfont = new Font(FontFamily.GenericSansSerif, 10, FontStyle.Regular);
            Font ItemNameFont = new Font(FontFamily.GenericSerif, 14, FontStyle.Bold);
            // img_QR.SetResolution(300, 300); 
           
            Bitmap base_img = new Bitmap(415, 415);

            // img_QR = HelperClass.ResizeImage(img_QR, 200, 200); // old 390

           // img_barcode.RotateFlip((RotateFlipType)Enum.Parse(typeof(RotateFlipType), this.cbRotateFlip.SelectedItem.ToString(), true));

           // barcode_H = img_barcode.Height;
           // barcode_W = img_barcode.Width;

            using (var graphics = Graphics.FromImage(base_img))
            {
                // graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
                using (var wrapMode = new System.Drawing.Imaging.ImageAttributes())
                {
                    wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                    // Create rectangle.
                    Rectangle rect = new Rectangle(1, 1, 414, 414);
                    // Draw rectangle to screen.                  
                    graphics.FillRectangle(Brushes.White, rect);
                    graphics.DrawImage(img_barcode, barcode_Left ,barcode_Top ); // old 15
                    StringFormat sf = new StringFormat();
                    sf.LineAlignment = StringAlignment.Center;
                    sf.Alignment = StringAlignment.Center;
                    Rectangle priceRect = new Rectangle(price_Left ,price_Top ,price_W ,price_H);
                    graphics.DrawString(Price, font, Brushes.Red, priceRect, sf);

                    Rectangle ItemNameRect = new Rectangle(ItemName_Left, ItemName_Top, ItemName_W, ItemName_H);
                    graphics.DrawString(ItemName, ItemNameFont , Brushes.Green , ItemNameRect, sf);


                    Rectangle MarketNameRect = new Rectangle(MarketName_Left, MarketName_Top, MarketName_W, MarketName_H);
                   
                    graphics.DrawString(MarketName, ItemNameFont, Brushes.Blue , MarketNameRect,sf);

                    Rectangle OtherInfoRec = new Rectangle(5, 350, 400, 60);
                    string otherInfo = "development company name"; //Code.ToString();
                    graphics.DrawString(otherInfo, font, Brushes.Blue, OtherInfoRec, sf);
                   // graphics.DrawString(Environment.NewLine + Environment.NewLine + Environment.NewLine + CopyRight.ToString(), copyrightfont, Brushes.Black, OtherInfoRec, sf);
                    //graphics.DrawRectangle(blackPen, rect);
                }
            }
            return base_img;

        }

        private void kryptonLabel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_Generate_barcode_Click(object sender, EventArgs e)
        {
           Image barcodeimg= GenerateBarcode();

            string _price = txt_price.Text;
            string _itemName = txt_item_name.Text;
            string _marketName = txt_market_name.Text;
            Bitmap finalimage = GengerateFinalImage((Bitmap)barcodeimg,_price ,_itemName ,_marketName );

            imageBoxEx1.Image = finalimage;
        }


        private  Image  GenerateBarcode()
        {

            int W = Convert.ToInt32(this.txt_bc_w.Text.Trim());
            int H = Convert.ToInt32(this.txt_bc_H.Text.Trim());
            b.Alignment = BarcodeLib.AlignmentPositions.CENTER;

            switch (cbBarcodeAlign.SelectedItem.ToString().Trim().ToLower())
            {
                case "left": b.Alignment = BarcodeLib.AlignmentPositions.LEFT; break;
                case "right": b.Alignment = BarcodeLib.AlignmentPositions.RIGHT; break;
                default: b.Alignment = BarcodeLib.AlignmentPositions.CENTER; break;
            }//switch

            BarcodeLib.TYPE type = BarcodeLib.TYPE.UNSPECIFIED;
            switch (cbEncodeType.SelectedItem.ToString().Trim())
            {
                case "UPC-A": type = BarcodeLib.TYPE.UPCA; break;
                case "UPC-E": type = BarcodeLib.TYPE.UPCE; break;
                case "UPC 2 Digit Ext.": type = BarcodeLib.TYPE.UPC_SUPPLEMENTAL_2DIGIT; break;
                case "UPC 5 Digit Ext.": type = BarcodeLib.TYPE.UPC_SUPPLEMENTAL_5DIGIT; break;
                case "EAN-13": type = BarcodeLib.TYPE.EAN13; break;
                case "JAN-13": type = BarcodeLib.TYPE.JAN13; break;
                case "EAN-8": type = BarcodeLib.TYPE.EAN8; break;
                case "ITF-14": type = BarcodeLib.TYPE.ITF14; break;
                case "Codabar": type = BarcodeLib.TYPE.Codabar; break;
                case "PostNet": type = BarcodeLib.TYPE.PostNet; break;
                case "Bookland/ISBN": type = BarcodeLib.TYPE.BOOKLAND; break;
                case "Code 11": type = BarcodeLib.TYPE.CODE11; break;
                case "Code 39": type = BarcodeLib.TYPE.CODE39; break;
                case "Code 39 Extended": type = BarcodeLib.TYPE.CODE39Extended; break;
                case "Code 39 Mod 43": type = BarcodeLib.TYPE.CODE39_Mod43; break;
                case "Code 93": type = BarcodeLib.TYPE.CODE93; break;
                case "LOGMARS": type = BarcodeLib.TYPE.LOGMARS; break;
                case "MSI": type = BarcodeLib.TYPE.MSI_Mod10; break;
                case "Interleaved 2 of 5": type = BarcodeLib.TYPE.Interleaved2of5; break;
                case "Standard 2 of 5": type = BarcodeLib.TYPE.Standard2of5; break;
                case "Code 128": type = BarcodeLib.TYPE.CODE128; break;
                case "Code 128-A": type = BarcodeLib.TYPE.CODE128A; break;
                case "Code 128-B": type = BarcodeLib.TYPE.CODE128B; break;
                case "Code 128-C": type = BarcodeLib.TYPE.CODE128C; break;
                case "Telepen": type = BarcodeLib.TYPE.TELEPEN; break;
                case "FIM": type = BarcodeLib.TYPE.FIM; break;
                case "Pharmacode": type = BarcodeLib.TYPE.PHARMACODE; break;
                default: MessageBox.Show("Please specify the encoding type."); break;
            }//switch

           // try
          //  {


                b.IncludeLabel = this.chkGenerateLabel.Checked;

               // b.RotateFlipType = (RotateFlipType)Enum.Parse(typeof(RotateFlipType), this.cbRotateFlip.SelectedItem.ToString(), true);

           
            //label alignment and position
                switch (this.cbLabelLocation.SelectedItem.ToString().Trim().ToUpper())
                {
                    case "BOTTOMLEFT": b.LabelPosition = BarcodeLib.LabelPositions.BOTTOMLEFT; break;
                    case "BOTTOMRIGHT": b.LabelPosition = BarcodeLib.LabelPositions.BOTTOMRIGHT; break;
                    case "TOPCENTER": b.LabelPosition = BarcodeLib.LabelPositions.TOPCENTER; break;
                    case "TOPLEFT": b.LabelPosition = BarcodeLib.LabelPositions.TOPLEFT; break;
                    case "TOPRIGHT": b.LabelPosition = BarcodeLib.LabelPositions.TOPRIGHT; break;
                    default: b.LabelPosition = BarcodeLib.LabelPositions.BOTTOMCENTER; break;
                }//switch

                //===== Encoding performed here =====
                Image   img =b.Encode(type, txtData.Text.Trim(), Color.Black, Color.White, W, H);
           

               return img;


           // }
           // catch (Exception ex)
           // {
           //     MessageBox.Show(ex.Message);
           // }
        }

        private void imageBoxEx1_MouseUp(object sender, MouseEventArgs e)
        {

            if (chk_barcode.Checked == true)
            {
                barcode_H = (int)imageBoxEx1.SelectionRegion.Height;
                barcode_W = (int)imageBoxEx1.SelectionRegion.Width;
                barcode_Top = (int)imageBoxEx1.SelectionRegion.Top;
                barcode_Left = (int)imageBoxEx1.SelectionRegion.Left;
                txt_bc_H.Text = Math.Round(imageBoxEx1.SelectionRegion.Height, 0).ToString();
                txt_bc_w.Text = Math.Round(imageBoxEx1.SelectionRegion.Width, 0).ToString();
            }

            if (chk_price.Checked == true)
            {
                price_H = (int)imageBoxEx1.SelectionRegion.Height;
               price_W = (int)imageBoxEx1.SelectionRegion.Width;
                price_Top = (int)imageBoxEx1.SelectionRegion.Top;
                price_Left = (int)imageBoxEx1.SelectionRegion.Left;
               
            }

            if (chk_item_name.Checked == true)
            {
                ItemName_H = (int)imageBoxEx1.SelectionRegion.Height;
                ItemName_W = (int)imageBoxEx1.SelectionRegion.Width;
                ItemName_Top = (int)imageBoxEx1.SelectionRegion.Top;
                ItemName_Left = (int)imageBoxEx1.SelectionRegion.Left;

            }

            if (chk_marketName.Checked == true)
            {
                MarketName_H = (int)imageBoxEx1.SelectionRegion.Height;
                MarketName_W = (int)imageBoxEx1.SelectionRegion.Width;
                MarketName_Top = (int)imageBoxEx1.SelectionRegion.Top;
                MarketName_Left = (int)imageBoxEx1.SelectionRegion.Left;

            }


            Image barcodeimg = GenerateBarcode();

            string _price = txt_price.Text;
            string _itemName = txt_item_name.Text;
            string _marketName = txt_market_name.Text;
            Bitmap finalimage = GengerateFinalImage((Bitmap)barcodeimg, _price, _itemName, _marketName);

            imageBoxEx1.Image = finalimage;

        }

        private void chk_barcode_Click(object sender, EventArgs e)
        {
            if (chk_barcode .Checked ==true )
            {

                RectangleF rec = new RectangleF(barcode_Left, barcode_Top, barcode_W, barcode_H);
                imageBoxEx1.SelectionRegion = rec;

            }
        }

        private void chk_price_Click(object sender, EventArgs e)
        {
            if (chk_price.Checked == true)
            {

                RectangleF rec = new RectangleF(price_Left, price_Top, price_W, price_H);
                imageBoxEx1.SelectionRegion = rec;

            }
        }

        private void chk_item_name_Click(object sender, EventArgs e)
        {

            if (chk_item_name.Checked == true)
            {

                RectangleF rec = new RectangleF(ItemName_Left, ItemName_Top, ItemName_W, ItemName_H);
                imageBoxEx1.SelectionRegion = rec;

            }
        }

        private void chk_marketName_Click(object sender, EventArgs e)
        {
            if (chk_marketName .Checked == true)
            {

                RectangleF rec = new RectangleF(MarketName_Left, MarketName_Top, MarketName_W, MarketName_H);
                imageBoxEx1.SelectionRegion = rec;

            }
        }
    }
}
