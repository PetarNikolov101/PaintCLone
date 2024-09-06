using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace paint
{
    [Serializable]
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.Width = 1200;
            this.Height = 800;
            bm = new Bitmap(pic.Width, pic.Height);
            g = Graphics.FromImage(bm);
            g.Clear(Color.White);
            pic.Image = bm;
        }

        Bitmap bm;
        Graphics g;
        bool paint = false;
        Point px, py;

        Pen p = new Pen(Color.Black, 1);
        Pen eraser = new Pen(Color.White, 10);

        ColorDialog cd = new ColorDialog();
        Color color;

        int index = 1, x, y, sX, sY, cX, cY;

        private void pencil_btn_Click(object sender, EventArgs e)
        {
            index = 1;
        }
        private void fill_btn_Click(object sender, EventArgs e)
        {
            index = 2;
        }
        private void eraser_btn_Click(object sender, EventArgs e)
        {
            index = 3;
        }
        private void circle_btn_Click(object sender, EventArgs e)
        {
            index = 4;
        }
        private void rec_btn_Click(object sender, EventArgs e)
        {
            index = 5;
        }
        private void line_btn_Click(object sender, EventArgs e)
        {
            index = 6;
        }

        private void plus_btn_Click(object sender, EventArgs e)
        {
            if (p.Width < 20)
            {
                p.Width = p.Width + 1;
            }

        }
        private void minus_btn_Click(object sender, EventArgs e)
        {
            if (p.Width > 1)
            {
                p.Width = p.Width - 1;
            }

        }
        private void plus_eraser_btn_Click(object sender, EventArgs e)
        {
            if (eraser.Width < 50)
            {
                eraser.Width = eraser.Width + 1;
            }
        }
        private void minus_eraser_btn_Click(object sender, EventArgs e)
        {
            if (eraser.Width > 1)
            {
                eraser.Width = p.Width - 1;
            }
        }

        static Point set_point(PictureBox pb, Point pt)
        {
            float pX = 1f * pb.Image.Width / pb.Width;
            float pY = 1f * pb.Image.Height / pb.Height;
            return new Point((int)(pt.X * pX), (int)(pt.Y * pY));
        }
        private void pic_MouseClick(object sender, MouseEventArgs e)
        {
            if (index == 2)
            {
                Point point = set_point(pic, e.Location);
                Fill(bm, point.X, point.Y, color);
                pic.Refresh();
            }
        }

        private void pic_MouseDown(object sender, MouseEventArgs e)
        {
            paint = true;
            py = e.Location;
            cX = e.X; cY = e.Y;
        }

        private void pic_MouseMove(object sender, MouseEventArgs e)
        {
            x = e.X; y = e.Y;
            sX = e.X - cX; sY = e.Y - cY;
            if (paint)
            {
                if (index == 1)
                {
                    px = e.Location;
                    g.DrawLine(p, px, py);
                    py = px;
                }
                if (index == 3)
                {
                    px = e.Location;
                    g.DrawLine(eraser, px, py);
                    py = px;
                }
                if (index == 4)
                {
                    pic.Refresh();
                    using (Graphics gTemp = pic.CreateGraphics())
                    {
                        gTemp.DrawEllipse(p, Math.Min(cX, e.X), Math.Min(cY, e.Y), Math.Abs(sX), Math.Abs(sY));
                    }
                }
                if (index == 5)
                {
                    using (Graphics gTemp = pic.CreateGraphics())
                    {
                        gTemp.DrawRectangle(p, Math.Min(cX, e.X), Math.Min(cY, e.Y), Math.Abs(sX), Math.Abs(sY));
                    }
                }

                if (index == 6)
                {
                    using (Graphics gTemp = pic.CreateGraphics())
                    {
                        gTemp.DrawLine(p, cX, cY, x, y);
                    }
                }

                pic.Refresh();
            }
        }
        private void pic_MouseUp(object sender, MouseEventArgs e)
        {
            paint = false;

            sX = x - cX;
            sY = y - cY;

            if (index == 4)
            {
                g.DrawEllipse(p, cX, cY, sX, sY);

            }

            if (index == 5)
            {
                g.DrawRectangle(p, cX, cY, sX, sY);
            }

            if (index == 6)
            {
                g.DrawLine(p, cX, cY, x, y);
            }

            pic.Refresh();
        }
        private void color_btn_Click(object sender, EventArgs e)
        {
            cd.ShowDialog();
            color = cd.Color;
            pick_color.BackColor = cd.Color;
            p.Color = color;
        }

        private void add_node(Bitmap bm, Stack<Point> sp, int x, int y, Color old_color, Color new_color)
        {
            Color cx = bm.GetPixel(x, y);
            if (cx == old_color)
            {
                sp.Push(new Point(x, y));
                bm.SetPixel(x, y, new_color);
            }
        }
        public void Fill(Bitmap bm, int x, int y, Color new_color)
        {
            Color old_color = bm.GetPixel(x, y);
            if (old_color.ToArgb() == new_color.ToArgb()) return;

            Stack<Point> pixel = new Stack<Point>();
            pixel.Push(new Point(x, y));

            bm.SetPixel(x, y, new_color);

            while (pixel.Count > 0)
            {
                Point pt = (Point)pixel.Pop();

                if (pt.X > 0 && pt.Y > 0 && pt.X < bm.Width - 1 && pt.Y < bm.Height - 1)
                {
                    add_node(bm, pixel, pt.X - 1, pt.Y, old_color, new_color);
                    add_node(bm, pixel, pt.X, pt.Y - 1, old_color, new_color);
                    add_node(bm, pixel, pt.X + 1, pt.Y, old_color, new_color);
                    add_node(bm, pixel, pt.X, pt.Y + 1, old_color, new_color);
                }
            }
        }
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PNG Image|*.png|JPEG Image|*.jpg|Bitmap Image|*.bmp";
            saveFileDialog.Title = "Save drawing";
            saveFileDialog.DefaultExt = "png";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = saveFileDialog.FileName;
                System.Drawing.Imaging.ImageFormat format = System.Drawing.Imaging.ImageFormat.Png;

                if (fileName.EndsWith(".jpg"))
                {
                    format = System.Drawing.Imaging.ImageFormat.Jpeg;
                }
                else if (fileName.EndsWith(".bmp"))
                {
                    format = System.Drawing.Imaging.ImageFormat.Bmp;
                }

                bm.Save(fileName, format);
            }
        }
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to start a new drawing?", "New Drawing", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                g.Clear(Color.White);
                pic.Image = bm;
                pic.Refresh();
            }

        }
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.png;*.jpg;*.jpeg;*.bmp|All Files|*.*";
            openFileDialog.Title = "Open an Image";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                bm = new Bitmap(openFileDialog.FileName);
                g = Graphics.FromImage(bm);
                pic.Image = bm;
                pic.Refresh();
            }
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
