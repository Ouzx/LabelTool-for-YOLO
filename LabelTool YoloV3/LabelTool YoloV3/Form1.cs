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

namespace LabelTool_YoloV3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Resim kaynağını seçtiren buton.
        /// </summary>
        private void btnImgIn_Click(object sender, EventArgs e)
        {
            tbImgIn.Text = GetDirectory(); //Resim kaynağını belirler.

            DirectoryInfo di = new DirectoryInfo(tbImgIn.Text); //İlgili konumdaki bilgileri toplar.
            FileInfo[] fi = di.GetFiles(); //Tüm dosya bilgilerini bir dizide tutar.
            img.Totalty = fi.Length; //Toplamdaki dosya sayısı.
            img.Directory = tbImgIn.Text;

            OpenImage(img.SelectedIMG); //Seçilen klasördeki ilk resimi açar.
        }

        /// <summary>
        /// Etiket listesinin kayıt edileceği konumu belirleyen buton.
        /// </summary>
        private void btnLabelOut_Click(object sender, EventArgs e)
        {
            tbLabelOut.Text = GetDirectory(); // Etiketlerin kayıt edileceği yeri belirler.
        }

        /// <summary>
        /// FolderBrowserDialog kullanarak kullanıcıya klasör seçimi yaptırır.
        /// </summary>
        /// <returns>Seçilen klasörün dosya yolunu döndürür.</returns>
        private string GetDirectory()
        {
            //Dosya gezginini aç.
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            //Masaüstünden başlat.
            fbd.RootFolder = Environment.SpecialFolder.Desktop;
            //Sonucu ilgili değişkene kayıt et ve tb'ye yazdır.
            fbd.ShowDialog();
            return fbd.SelectedPath;
        }

        /// <summary>
        /// Seçilen resim ve toplamdaki resim sayısını belirler. 
        /// Resim kaynağının dosya yolunu da içinde tutar.
        /// </summary>
        private struct IMG
        {
            public int SelectedIMG { get; set; } //Seçilen ve işlem yapılmamış resim. 
            public int Totalty { get; set; } //Seçilen klasörde toplam bulunan resim sayısı.
            public string Directory { get; set; } //Resim kaynağının dosya yolu.
            public static int WIDTH = 800; //En
            public static int HEIGHT = 600; //Boy
        }
        private IMG img = new IMG();

        /// <summary>
        /// 01/10 tarzı seçili dosya/toplam dosya tarzını bastırır.
        /// </summary>
        private void NavInfo()
        {
            FolderInfo.Text = img.SelectedIMG.ToString() + "/" + img.Totalty.ToString();
        }

        /// <summary>
        /// Seçilen indexdeki resmi istenilern çöznürlüğe çevirip PictureBox'a gönderir.
        /// </summary>
        /// <param name="_ID">Resmin index'i</param>
        private void OpenImage(int _ID)
        {
            Bitmap bmp = new Bitmap(new Bitmap(GetPath(_ID)), IMG.WIDTH, IMG.HEIGHT);
            pictureBox1.Image = bmp;
        }

        /// <summary>
        /// //İstenilen sıradaki resimin dosya yolunu verir.
        /// </summary>
        private string GetPath(int _ID)
        {
            DirectoryInfo di = new DirectoryInfo(img.Directory); //İlgili konumdaki bilgileri toplar.
            FileInfo[] fi = di.GetFiles(); //Tüm dosya bilgilerini bir dizide tutar.
            return img.Directory + "\\" + fi[_ID];
        }

        /// <summary>
        /// Çizim olaylarını kontrol eder.
        /// </summary>
        private void timer1_Tick(object sender, EventArgs e)
        {
            NavInfo();
            RectInfo(rectangle);
            DrawRects();

        }

        /// <summary>
        /// Sonraki indexdeki resimi açar.
        /// </summary>
        private void btnNext_Click(object sender, EventArgs e)
        {
            img.SelectedIMG++; //Seçilen indexi bir arttır.
            OpenImage(img.SelectedIMG); //Resmi aç.
        }

        /// <summary>
        /// Bir önceki indexdeki resmi açar.
        /// </summary>
        private void btnPrev_Click(object sender, EventArgs e)
        {
            //Eğer varsa bir önceki resmi aç.
            if (img.SelectedIMG != 0) img.SelectedIMG--;
            OpenImage(img.SelectedIMG);
        }

        /// <summary>
        /// TextBox'daki resim indexine ulaşır.
        /// </summary>
        private void btnImgTo_Click(object sender, EventArgs e)
        {
            int _id = Convert.ToInt32(tbImgTo.Text);
            if (_id <= img.Totalty)
            {
                OpenImage(_id);
                img.SelectedIMG = _id;
            }
        }

        #region PictureBOX
        private Point p1, p2;
        private bool isMouseDown = false;
        private List<Rectangle> rectangles = new List<Rectangle>();
        private Rectangle rectangle;

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            isMouseDown = true;
            p1 = e.Location;
        }
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown)
            {
                p2 = e.Location;
                Refresh();
                
            }
        }
        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            p2 = e.Location;
            rectangles.Add(rectangle); // Çizilen dörtgeni listeye ekle.
            yolos.Add(new YOLO());
            selectedYolo++;
            PrintRect(rectangle);
            isMouseDown = false;
        }
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            if (img.Directory != "")
            {
                rectangle = GetRect(); //Çizilen ölçülere göre bir dörtgen hesapla.
                e.Graphics.DrawRectangle(Pens.Red, rectangle); //Dörtgeni çiz.
                
            }
        }
        #endregion

        /// <summary>
        /// Mouse ile belirlenen ölçü ve konuma göre dörtgen hesaplar.
        /// </summary>
        private Rectangle GetRect()
        {
            Rectangle rect = new Rectangle()
            {
                X = Math.Min(p1.X, p2.X),
                Y = Math.Min(p1.Y, p2.Y),
                Width = Math.Abs(p1.X - p2.X),
                Height = Math.Abs(p1.Y - p2.Y)
            };
            return rect;
        }

        /// <summary>
        /// Dörtgen listesindeki elemanları çizer.
        /// </summary>
        private void DrawRects()
        {
            Graphics g = pictureBox1.CreateGraphics();
            foreach (Rectangle rect in rectangles)
            {
                g.DrawRectangle(Pens.Blue, rect);
            }
            
        }

        /// <summary>
        /// İlgili yolo formatının değişkenlerini içinde tutan data struct.
        /// </summary>
        private struct YOLO
        {
            public int ClassNum { get; set; }
            public double[] LABEL { get; set; } //ETİKET
        }
        List<YOLO> yolos = new List<YOLO>();
        private int selectedYolo = -1;

        /// <summary>
        /// Dörtgenin yolo formatında özelliklerini yazdırır.
        /// </summary>
        private void PrintRect(Rectangle rect)
        {
            YOLO yolo = new YOLO();
            yolo.LABEL = new double[5];
            yolo.LABEL[0] = (rect.X + rect.Width) / 2.0;
            yolo.LABEL[1] = (rect.Y + rect.Height) / 2.0;
            yolo.LABEL[2] = 1.0 / rect.Width;
            yolo.LABEL[3] = 1.0 / rect.Height;
            yolo.LABEL[0] *= yolo.LABEL[2];
            yolo.LABEL[1] *= yolo.LABEL[3];
            yolos[selectedYolo] = yolo;
            string LABEL = yolo.ClassNum + " " + yolo.LABEL[0] + " " + yolo.LABEL[1] + " " + yolo.LABEL[2] + " " + yolo.LABEL[3];

            tbLabelList.Text += LABEL + "\n";
        }        

        /// <summary>
        /// Dörtgenin fiziksel özelliklerini yazdırır.
        /// </summary>
        private void RectInfo(Rectangle rect)
        {
            string topleft = rect.Location.ToString();
            Point bottomrightcorner = rect.Location;
            bottomrightcorner.X += rect.Width;
            bottomrightcorner.Y += rect.Height;


            lblPointStart.Text = "Point Start: " + topleft;
            lblPointEnd.Text = "Point End: " + bottomrightcorner.ToString();
            lblHeight.Text = "HEIGHT: " + rect.Height.ToString();
            lblWidth.Text = "WIDTH: " + rect.Width.ToString();
        }

    }
}
