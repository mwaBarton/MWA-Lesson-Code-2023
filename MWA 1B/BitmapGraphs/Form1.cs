using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BitmapGraphs
{
    public partial class Form1 : Form
    {
        Bitmap bitmap = new Bitmap(200, 200);
        Graphics g;

        public Form1()
        {
            InitializeComponent();
            g = Graphics.FromImage(bitmap);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < bitmap.Height; i++)
            {
                for (int j =  0; j < bitmap.Width; j++)
                {
                    bitmap.SetPixel(i, j, Color.FromArgb(255, (int)(i / 200.0 * 255), (int)(j / 200.0 * 255)));
                }
            }


            for (int i = 0; i < bitmap.Width; i++)
            {
                bitmap.SetPixel(i, Math.Min((i *i)/100, bitmap.Height - 1), Color.Black);
            }

            g.FillRectangle(new SolidBrush(Color.Black), 10, 100, 200, 50);
            g.DrawString("Hello", new Font("Arial", 50f), new SolidBrush(Color.White), new PointF(10, 100));


            pictureBox1.Image = bitmap;
        }
    }
}
