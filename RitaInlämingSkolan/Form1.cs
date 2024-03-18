using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace RitaInlämingSkolan
{
    public partial class Form1 : Form
    {
        private Stack<Bitmap> history = new Stack<Bitmap>(); 
        public Form1()
        {
            InitializeComponent();
            this.Width = 2100;
            this.Height = 1000;
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
        Pen erase = new Pen(Color.White, 10);
        int Index;
        int x, y, sX, sY, cX, cY;

        ColorDialog cd = new ColorDialog();
        Color new_color;

        private void pic_color_Click(object sender, EventArgs e)
        {

        }

        private void pic_MouseDown(object sender, MouseEventArgs e)
        {
            paint = true;
            py = e.Location;

            cX = e.X;
            cY = e.Y;
        }

        private void pic_MouseMove(object sender, MouseEventArgs e)
        {
            if (paint)
            {
                if (Index == 1)
                {
                    px = e.Location;
                    g.DrawLine(p, px, py);
                    py = px;
                }
                if (Index == 2)
                {
                    px = e.Location;
                    g.DrawLine(erase, px, py);
                    py = px;
                }
            }
            pic.Refresh();

            x = e.X;
            y = e.Y;
            sX = e.X - cX;
            sY = e.Y - cY;
        }

        private void pic_MouseUp(object sender, MouseEventArgs e)
        {
            paint = false;

            sX = x - cX;
            sY = y - cY;

            if (Index == 3)
            {
                g.DrawEllipse(p, cX, cY, sX, sY);
            }

            if (Index == 4)
            {
                g.DrawRectangle(p, cX, cY, sX, sY);
            }
            if (Index == 5)
            {
                g.DrawLine(p, cX, cY, x, y);
            }
            else if (Index == 6)
            {
                Point[] points = new Point[3];
                points[0] = new Point(cX, cY);
                points[1] = new Point(cX + sX, cY + sY);
                points[2] = new Point(cX - sX, cY + sY);
                g.DrawPolygon(p, points);
            }

            history.Push((Bitmap)bm.Clone());
        }

        private void pic_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            if (paint)
            {
                if (Index == 3)
                {
                    g.DrawEllipse(p, cX, cY, sX, sY);
                }

                if (Index == 4)
                {
                    g.DrawRectangle(p, cX, cY, sX, sY);
                }
                if (Index == 5)
                {
                    g.DrawLine(p, cX, cY, x, y);
                }
                else if (Index == 6)
                {
                    Point[] points = new Point[3];
                    points[0] = new Point(cX, cY);
                    points[1] = new Point(cX + sX, cY + sY);
                    points[2] = new Point(cX - sX, cY + sY);
                    g.DrawPolygon(p, points);
                }
            }
        }
        private void btn_clear_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            pic.Image = bm;
            Index = 0;
        }

        private void btn_backa_Click(object sender, EventArgs e)
        {
            if (history.Count > 0)
            {
                // Ta bort det senaste steget från historiken
                history.Pop();

                // Återställ den senaste ritningen om historiken inte är tom
                if (history.Count > 0)
                {
                    bm = history.Peek();
                    g = Graphics.FromImage(bm);
                    pic.Image = bm;
                }
                else // Om historiken är tom, rita en tom vit yta
                {
                    g.Clear(Color.White);
                    pic.Image = bm;
                }
            }
        }

        private void btn_pensil_Click(object sender, EventArgs e)
        {
            Index = 1;
        }
        private void btn_eraser_Click(object sender, EventArgs e)
        {
            Index = 2;
        }

        private void btn_ellipse_Click(object sender, EventArgs e)
        {
            Index = 3;
        }

        private void btn_rect_Click(object sender, EventArgs e)
        {
            Index = 4;
        }

        private void btn_line_Click(object sender, EventArgs e)
        {
            Index = 5;
        }

        private void btn_triangle_Click(object sender, EventArgs e)
        {
            Index = 6;
        }

        private void btn_color_Click(object sender, EventArgs e)
        {
            cd.ShowDialog();
            new_color = cd.Color;
            pic_color.BackColor = cd.Color;
            p.Color = cd.Color;
        }

        static Point set_point(PictureBox pb, Point pt)
        {
            float pX = 1f * pb.Image.Width / pb.Width;
            float pY = 1f * pb.Image.Height / pb.Height;
            return new Point((int)(pt.X * pX), (int)(pt.Y * pY));
        }

        private void color_picker_MouseClick(object sender, MouseEventArgs e)
        {
            Point point = set_point(color_picker, e.Location);
            pic_color.BackColor = ((Bitmap)color_picker.Image).GetPixel(point.X, point.Y);
            new_color = pic_color.BackColor;
            p.Color = pic_color.BackColor;
        }
        private void validate(Bitmap bm, Stack<Point> sp, int x, int y, Color old_color, Color new_color)
        {
            Color cx = bm.GetPixel(x, y);
            if (cx == old_color)
            {
                sp.Push(new Point(x, y));
                bm.SetPixel(x, y, new_color);
            }
        }
        public void Fill(Bitmap bm, int x, int y, Color new_clr)
        {
            Color old_color = bm.GetPixel(x, y);
            Stack<Point> pixel = new Stack<Point>();
            pixel.Push(new Point(x, y));
            bm.SetPixel(x, y, new_clr);
            if (old_color == new_clr) return;

            while (pixel.Count > 0)
            {
                Point pt = (Point)pixel.Pop();
                if (pt.X > 0 && pt.Y > 0 && pt.X < bm.Width - 1 && pt.Y < bm.Height - 1)
                {
                    validate(bm, pixel, pt.X - 1, pt.Y, old_color, new_clr);
                    validate(bm, pixel, pt.X, pt.Y - 1, old_color, new_clr);
                    validate(bm, pixel, pt.X + 1, pt.Y, old_color, new_clr);
                    validate(bm, pixel, pt.X, pt.Y + 1, old_color, new_clr);
                }
            }
        }

        private void pic_MouseClick(object sender, MouseEventArgs e)
        {
            if (Index == 7)
            {
                Point point = set_point(pic, e.Location);
                Fill(bm, point.X, point.Y, new_color);
            }
        }

        private void btn_fill_Click(object sender, EventArgs e)
        {
            Index = 7;
        }

        private void btn_save_image_Click(object sender, EventArgs e)
        {
            var sfd = new SaveFileDialog();
            sfd.Filter = "Image Files (*.jpg, *.png, *.bmp)|*.jpg;*.png;*.bmp";
            if (sfd.ShowDialog() == DialogResult.OK)
            {

                Bitmap btm = bm.Clone(new Rectangle(0, 0, pic.Width, pic.Height), bm.PixelFormat);
                btm.Save(sfd.FileName, ImageFormat.Jpeg);
            }
        }

        private void Btn_load_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog();
            ofd.Filter = "Image Files (*.jpg, *.png, *.bmp)|*.jpg;*.png;*.bmp";
            if (ofd.ShowDialog() == DialogResult.OK)
            {

                Bitmap loadedImage = new Bitmap(ofd.FileName);
                g.DrawImage(loadedImage, new Point(0, 0));
                pic.Image = bm;
            }
        }

        private void btn_save_file_Click(object sender, EventArgs e)
        {
            var sfd = new SaveFileDialog();
            sfd.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"; 
            if (sfd.ShowDialog() == DialogResult.OK)
            {

                string filePath = sfd.FileName;

                try
                {

                    using (StreamWriter writer = new StreamWriter(filePath))
                    {
                        
                    }

                    MessageBox.Show("File saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error saving file: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_loade_file_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog();
            ofd.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"; 
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string filePath = ofd.FileName;

                try
                {

                    using (StreamReader reader = new StreamReader(filePath))
                    {
                        
                        string fileContent = reader.ReadToEnd();
  
                        Bitmap textBitmap = new Bitmap(pic.Width, pic.Height);
                        using (Graphics graphics = Graphics.FromImage(textBitmap))
                        {

                            graphics.Clear(Color.White);

                            using (Font font = new Font("Arial", 12))
                            {
                                graphics.DrawString(fileContent, font, Brushes.Black, new PointF(10, 10));
                            }
                        }
                        pic.Image = textBitmap;
                    }

                    MessageBox.Show("File loaded successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading file: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


    }
}
