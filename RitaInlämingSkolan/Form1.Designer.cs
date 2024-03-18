namespace RitaInlämingSkolan
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            panel3 = new Panel();
            btn_save_file = new Button();
            Btn_load = new Button();
            btn_backa = new Button();
            btn_save_image = new Button();
            btn_clear = new Button();
            btn_triangle = new Button();
            color_picker = new PictureBox();
            btn_line = new Button();
            btn_rect = new Button();
            btn_ellipse = new Button();
            btn_eraser = new Button();
            btn_pensil = new Button();
            btn_fill = new Button();
            btn_color = new Button();
            pic_color = new Button();
            panel7 = new Panel();
            panel2 = new Panel();
            panel4 = new Panel();
            panel5 = new Panel();
            pic = new PictureBox();
            panel6 = new Panel();
            btn_loade_file = new Button();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)color_picker).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.AppWorkspace;
            panel1.Controls.Add(panel3);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(1461, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(615, 936);
            panel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.AppWorkspace;
            panel3.Controls.Add(btn_loade_file);
            panel3.Controls.Add(btn_save_file);
            panel3.Controls.Add(Btn_load);
            panel3.Controls.Add(btn_backa);
            panel3.Controls.Add(btn_save_image);
            panel3.Controls.Add(btn_clear);
            panel3.Controls.Add(btn_triangle);
            panel3.Controls.Add(color_picker);
            panel3.Controls.Add(btn_line);
            panel3.Controls.Add(btn_rect);
            panel3.Controls.Add(btn_ellipse);
            panel3.Controls.Add(btn_eraser);
            panel3.Controls.Add(btn_pensil);
            panel3.Controls.Add(btn_fill);
            panel3.Controls.Add(btn_color);
            panel3.Controls.Add(pic_color);
            panel3.Controls.Add(panel7);
            panel3.Dock = DockStyle.Right;
            panel3.ForeColor = Color.White;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(615, 936);
            panel3.TabIndex = 1;
            // 
            // btn_save_file
            // 
            btn_save_file.Cursor = Cursors.Hand;
            btn_save_file.FlatAppearance.MouseDownBackColor = Color.Navy;
            btn_save_file.FlatAppearance.MouseOverBackColor = Color.Purple;
            btn_save_file.FlatStyle = FlatStyle.Flat;
            btn_save_file.ForeColor = Color.Black;
            btn_save_file.Image = (Image)resources.GetObject("btn_save_file.Image");
            btn_save_file.ImageAlign = ContentAlignment.TopCenter;
            btn_save_file.Location = new Point(366, 352);
            btn_save_file.Name = "btn_save_file";
            btn_save_file.Size = new Size(103, 96);
            btn_save_file.TabIndex = 16;
            btn_save_file.Text = "File";
            btn_save_file.TextAlign = ContentAlignment.BottomCenter;
            btn_save_file.UseVisualStyleBackColor = true;
            btn_save_file.Click += btn_save_file_Click;
            // 
            // Btn_load
            // 
            Btn_load.Cursor = Cursors.Hand;
            Btn_load.FlatAppearance.MouseDownBackColor = Color.Navy;
            Btn_load.FlatAppearance.MouseOverBackColor = Color.Purple;
            Btn_load.FlatStyle = FlatStyle.Flat;
            Btn_load.ForeColor = Color.Black;
            Btn_load.Image = (Image)resources.GetObject("Btn_load.Image");
            Btn_load.ImageAlign = ContentAlignment.TopCenter;
            Btn_load.Location = new Point(475, 454);
            Btn_load.Name = "Btn_load";
            Btn_load.Size = new Size(103, 96);
            Btn_load.TabIndex = 15;
            Btn_load.Text = "Image";
            Btn_load.TextAlign = ContentAlignment.BottomCenter;
            Btn_load.UseVisualStyleBackColor = true;
            Btn_load.Click += Btn_load_Click;
            // 
            // btn_backa
            // 
            btn_backa.Cursor = Cursors.Hand;
            btn_backa.FlatAppearance.MouseDownBackColor = Color.Navy;
            btn_backa.FlatAppearance.MouseOverBackColor = Color.Purple;
            btn_backa.FlatStyle = FlatStyle.Flat;
            btn_backa.ForeColor = Color.Black;
            btn_backa.Image = (Image)resources.GetObject("btn_backa.Image");
            btn_backa.ImageAlign = ContentAlignment.TopCenter;
            btn_backa.Location = new Point(257, 352);
            btn_backa.Name = "btn_backa";
            btn_backa.Size = new Size(103, 96);
            btn_backa.TabIndex = 14;
            btn_backa.Text = "backa";
            btn_backa.TextAlign = ContentAlignment.BottomCenter;
            btn_backa.UseVisualStyleBackColor = true;
            btn_backa.Click += btn_backa_Click;
            // 
            // btn_save_image
            // 
            btn_save_image.Cursor = Cursors.Hand;
            btn_save_image.FlatAppearance.MouseDownBackColor = Color.Navy;
            btn_save_image.FlatAppearance.MouseOverBackColor = Color.Purple;
            btn_save_image.FlatStyle = FlatStyle.Flat;
            btn_save_image.ForeColor = Color.Black;
            btn_save_image.Image = (Image)resources.GetObject("btn_save_image.Image");
            btn_save_image.ImageAlign = ContentAlignment.TopCenter;
            btn_save_image.Location = new Point(475, 352);
            btn_save_image.Name = "btn_save_image";
            btn_save_image.Size = new Size(103, 96);
            btn_save_image.TabIndex = 13;
            btn_save_image.Text = "Image";
            btn_save_image.TextAlign = ContentAlignment.BottomCenter;
            btn_save_image.UseVisualStyleBackColor = true;
            btn_save_image.Click += btn_save_image_Click;
            // 
            // btn_clear
            // 
            btn_clear.Cursor = Cursors.Hand;
            btn_clear.FlatAppearance.MouseDownBackColor = Color.Navy;
            btn_clear.FlatAppearance.MouseOverBackColor = Color.Purple;
            btn_clear.FlatStyle = FlatStyle.Flat;
            btn_clear.ForeColor = Color.Black;
            btn_clear.Image = (Image)resources.GetObject("btn_clear.Image");
            btn_clear.ImageAlign = ContentAlignment.TopCenter;
            btn_clear.Location = new Point(148, 352);
            btn_clear.Name = "btn_clear";
            btn_clear.Size = new Size(103, 96);
            btn_clear.TabIndex = 12;
            btn_clear.Text = "Clear";
            btn_clear.TextAlign = ContentAlignment.BottomCenter;
            btn_clear.UseVisualStyleBackColor = true;
            btn_clear.Click += btn_clear_Click;
            // 
            // btn_triangle
            // 
            btn_triangle.Cursor = Cursors.Hand;
            btn_triangle.FlatAppearance.MouseDownBackColor = Color.Navy;
            btn_triangle.FlatAppearance.MouseOverBackColor = Color.Purple;
            btn_triangle.FlatStyle = FlatStyle.Flat;
            btn_triangle.ForeColor = Color.Black;
            btn_triangle.Image = (Image)resources.GetObject("btn_triangle.Image");
            btn_triangle.ImageAlign = ContentAlignment.TopCenter;
            btn_triangle.Location = new Point(257, 122);
            btn_triangle.Name = "btn_triangle";
            btn_triangle.Size = new Size(103, 96);
            btn_triangle.TabIndex = 10;
            btn_triangle.Text = "Triangle";
            btn_triangle.TextAlign = ContentAlignment.BottomCenter;
            btn_triangle.UseVisualStyleBackColor = true;
            btn_triangle.Click += btn_triangle_Click;
            // 
            // color_picker
            // 
            color_picker.Cursor = Cursors.Hand;
            color_picker.Image = Properties.Resources.olikafärger;
            color_picker.Location = new Point(57, 20);
            color_picker.Name = "color_picker";
            color_picker.Size = new Size(190, 300);
            color_picker.SizeMode = PictureBoxSizeMode.StretchImage;
            color_picker.TabIndex = 9;
            color_picker.TabStop = false;
            color_picker.MouseClick += color_picker_MouseClick;
            // 
            // btn_line
            // 
            btn_line.Cursor = Cursors.Hand;
            btn_line.FlatAppearance.MouseDownBackColor = Color.Navy;
            btn_line.FlatAppearance.MouseOverBackColor = Color.Purple;
            btn_line.FlatStyle = FlatStyle.Flat;
            btn_line.ForeColor = Color.Black;
            btn_line.Image = (Image)resources.GetObject("btn_line.Image");
            btn_line.ImageAlign = ContentAlignment.TopCenter;
            btn_line.Location = new Point(257, 20);
            btn_line.Name = "btn_line";
            btn_line.Size = new Size(103, 96);
            btn_line.TabIndex = 7;
            btn_line.Text = "Line";
            btn_line.TextAlign = ContentAlignment.BottomCenter;
            btn_line.UseVisualStyleBackColor = true;
            btn_line.Click += btn_line_Click;
            // 
            // btn_rect
            // 
            btn_rect.Cursor = Cursors.Hand;
            btn_rect.FlatAppearance.MouseDownBackColor = Color.Navy;
            btn_rect.FlatAppearance.MouseOverBackColor = Color.Purple;
            btn_rect.FlatStyle = FlatStyle.Flat;
            btn_rect.ForeColor = Color.Black;
            btn_rect.Image = (Image)resources.GetObject("btn_rect.Image");
            btn_rect.ImageAlign = ContentAlignment.TopCenter;
            btn_rect.Location = new Point(475, 122);
            btn_rect.Name = "btn_rect";
            btn_rect.Size = new Size(103, 96);
            btn_rect.TabIndex = 6;
            btn_rect.Text = "Reactan";
            btn_rect.TextAlign = ContentAlignment.BottomCenter;
            btn_rect.UseVisualStyleBackColor = true;
            btn_rect.Click += btn_rect_Click;
            // 
            // btn_ellipse
            // 
            btn_ellipse.Cursor = Cursors.Hand;
            btn_ellipse.FlatAppearance.MouseDownBackColor = Color.Navy;
            btn_ellipse.FlatAppearance.MouseOverBackColor = Color.Purple;
            btn_ellipse.FlatStyle = FlatStyle.Flat;
            btn_ellipse.ForeColor = Color.Black;
            btn_ellipse.Image = (Image)resources.GetObject("btn_ellipse.Image");
            btn_ellipse.ImageAlign = ContentAlignment.TopCenter;
            btn_ellipse.Location = new Point(366, 122);
            btn_ellipse.Name = "btn_ellipse";
            btn_ellipse.Size = new Size(103, 96);
            btn_ellipse.TabIndex = 5;
            btn_ellipse.Text = "Circel";
            btn_ellipse.TextAlign = ContentAlignment.BottomCenter;
            btn_ellipse.UseVisualStyleBackColor = true;
            btn_ellipse.Click += btn_ellipse_Click;
            // 
            // btn_eraser
            // 
            btn_eraser.Cursor = Cursors.Hand;
            btn_eraser.FlatAppearance.MouseDownBackColor = Color.Navy;
            btn_eraser.FlatAppearance.MouseOverBackColor = Color.Purple;
            btn_eraser.FlatStyle = FlatStyle.Flat;
            btn_eraser.ForeColor = Color.Black;
            btn_eraser.Image = (Image)resources.GetObject("btn_eraser.Image");
            btn_eraser.ImageAlign = ContentAlignment.TopCenter;
            btn_eraser.Location = new Point(475, 224);
            btn_eraser.Name = "btn_eraser";
            btn_eraser.Size = new Size(103, 96);
            btn_eraser.TabIndex = 4;
            btn_eraser.Text = "Eraser";
            btn_eraser.TextAlign = ContentAlignment.BottomCenter;
            btn_eraser.UseVisualStyleBackColor = true;
            btn_eraser.Click += btn_eraser_Click;
            // 
            // btn_pensil
            // 
            btn_pensil.Cursor = Cursors.Hand;
            btn_pensil.FlatAppearance.MouseDownBackColor = Color.Navy;
            btn_pensil.FlatAppearance.MouseOverBackColor = Color.Purple;
            btn_pensil.FlatStyle = FlatStyle.Flat;
            btn_pensil.ForeColor = Color.Black;
            btn_pensil.Image = (Image)resources.GetObject("btn_pensil.Image");
            btn_pensil.ImageAlign = ContentAlignment.TopCenter;
            btn_pensil.Location = new Point(475, 20);
            btn_pensil.Name = "btn_pensil";
            btn_pensil.Size = new Size(103, 96);
            btn_pensil.TabIndex = 3;
            btn_pensil.Text = "Pencil";
            btn_pensil.TextAlign = ContentAlignment.BottomCenter;
            btn_pensil.UseVisualStyleBackColor = true;
            btn_pensil.Click += btn_pensil_Click;
            // 
            // btn_fill
            // 
            btn_fill.Cursor = Cursors.Hand;
            btn_fill.FlatAppearance.MouseDownBackColor = Color.Navy;
            btn_fill.FlatAppearance.MouseOverBackColor = Color.Purple;
            btn_fill.FlatStyle = FlatStyle.Flat;
            btn_fill.ForeColor = Color.Black;
            btn_fill.Image = (Image)resources.GetObject("btn_fill.Image");
            btn_fill.ImageAlign = ContentAlignment.TopCenter;
            btn_fill.Location = new Point(366, 20);
            btn_fill.Name = "btn_fill";
            btn_fill.Size = new Size(103, 96);
            btn_fill.TabIndex = 2;
            btn_fill.Text = "Fill";
            btn_fill.TextAlign = ContentAlignment.BottomCenter;
            btn_fill.UseVisualStyleBackColor = true;
            btn_fill.Click += btn_fill_Click;
            // 
            // btn_color
            // 
            btn_color.Cursor = Cursors.Hand;
            btn_color.FlatAppearance.MouseDownBackColor = Color.Navy;
            btn_color.FlatAppearance.MouseOverBackColor = Color.Purple;
            btn_color.FlatStyle = FlatStyle.Flat;
            btn_color.ForeColor = Color.Black;
            btn_color.Image = (Image)resources.GetObject("btn_color.Image");
            btn_color.ImageAlign = ContentAlignment.TopCenter;
            btn_color.Location = new Point(366, 224);
            btn_color.Name = "btn_color";
            btn_color.Size = new Size(103, 96);
            btn_color.TabIndex = 1;
            btn_color.Text = "Color";
            btn_color.TextAlign = ContentAlignment.BottomCenter;
            btn_color.UseVisualStyleBackColor = true;
            btn_color.Click += btn_color_Click;
            // 
            // pic_color
            // 
            pic_color.BackColor = Color.White;
            pic_color.Location = new Point(257, 224);
            pic_color.Name = "pic_color";
            pic_color.Size = new Size(103, 96);
            pic_color.TabIndex = 0;
            pic_color.UseVisualStyleBackColor = false;
            // 
            // panel7
            // 
            panel7.BackColor = SystemColors.ActiveCaptionText;
            panel7.Location = new Point(27, 12);
            panel7.Name = "panel7";
            panel7.Size = new Size(576, 321);
            panel7.TabIndex = 11;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.AppWorkspace;
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(21, 936);
            panel2.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.AppWorkspace;
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(21, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(1440, 20);
            panel4.TabIndex = 2;
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.AppWorkspace;
            panel5.Dock = DockStyle.Bottom;
            panel5.Location = new Point(21, 916);
            panel5.Name = "panel5";
            panel5.Size = new Size(1440, 20);
            panel5.TabIndex = 3;
            // 
            // pic
            // 
            pic.BackColor = Color.White;
            pic.Dock = DockStyle.Fill;
            pic.Location = new Point(21, 20);
            pic.Name = "pic";
            pic.Size = new Size(1440, 896);
            pic.TabIndex = 5;
            pic.TabStop = false;
            pic.Paint += pic_Paint;
            pic.MouseClick += pic_MouseClick;
            pic.MouseDown += pic_MouseDown;
            pic.MouseMove += pic_MouseMove;
            pic.MouseUp += pic_MouseUp;
            // 
            // panel6
            // 
            panel6.BackColor = SystemColors.ActiveCaptionText;
            panel6.Location = new Point(1029, 521);
            panel6.Name = "panel6";
            panel6.Size = new Size(586, 347);
            panel6.TabIndex = 8;
            // 
            // btn_loade_file
            // 
            btn_loade_file.Cursor = Cursors.Hand;
            btn_loade_file.FlatAppearance.MouseDownBackColor = Color.Navy;
            btn_loade_file.FlatAppearance.MouseOverBackColor = Color.Purple;
            btn_loade_file.FlatStyle = FlatStyle.Flat;
            btn_loade_file.ForeColor = Color.Black;
            btn_loade_file.Image = (Image)resources.GetObject("btn_loade_file.Image");
            btn_loade_file.ImageAlign = ContentAlignment.TopCenter;
            btn_loade_file.Location = new Point(366, 454);
            btn_loade_file.Name = "btn_loade_file";
            btn_loade_file.Size = new Size(103, 96);
            btn_loade_file.TabIndex = 17;
            btn_loade_file.Text = "File";
            btn_loade_file.TextAlign = ContentAlignment.BottomCenter;
            btn_loade_file.UseVisualStyleBackColor = true;
            btn_loade_file.Click += btn_loade_file_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2076, 936);
            Controls.Add(pic);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panel6);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)color_picker).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private Panel panel2;
        private Panel panel4;
        private Panel panel5;
        private PictureBox pic;
        private Button btn_color;
        private Button pic_color;
        private Button btn_fill;
        private Button btn_pensil;
        private Button btn_ellipse;
        private Button btn_eraser;
        private Button btn_rect;
        private Button btn_line;
        private PictureBox color_picker;
        private Panel panel6;
        private Button btn_triangle;
        private Panel panel7;
        private Button btn_save_image;
        private Button btn_clear;
        private Button btn_backa;
        private Button Btn_load;
        private Button btn_save_file;
        private Button btn_loade_file;
    }
}
