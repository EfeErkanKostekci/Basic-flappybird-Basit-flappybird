namespace flappybird
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            boruYukarı = new PictureBox();
            kus = new PictureBox();
            boruAsagi = new PictureBox();
            yer = new PictureBox();
            skorTahtasi = new Label();
            oyunSayaci = new System.Windows.Forms.Timer(components);
            oyunSonu = new Label();
            ((System.ComponentModel.ISupportInitialize)boruYukarı).BeginInit();
            ((System.ComponentModel.ISupportInitialize)kus).BeginInit();
            ((System.ComponentModel.ISupportInitialize)boruAsagi).BeginInit();
            ((System.ComponentModel.ISupportInitialize)yer).BeginInit();
            SuspendLayout();
            // 
            // boruYukarı
            // 
            boruYukarı.Image = Properties.Resources.pipedown;
            boruYukarı.Location = new Point(577, 2);
            boruYukarı.Name = "boruYukarı";
            boruYukarı.Size = new Size(125, 249);
            boruYukarı.SizeMode = PictureBoxSizeMode.StretchImage;
            boruYukarı.TabIndex = 0;
            boruYukarı.TabStop = false;
            // 
            // kus
            // 
            kus.BackColor = Color.Transparent;
            kus.Image = Properties.Resources.bird;
            kus.Location = new Point(207, 309);
            kus.Name = "kus";
            kus.Size = new Size(77, 62);
            kus.TabIndex = 1;
            kus.TabStop = false;
            // 
            // boruAsagi
            // 
            boruAsagi.Image = Properties.Resources.pipe;
            boruAsagi.Location = new Point(481, 451);
            boruAsagi.Name = "boruAsagi";
            boruAsagi.Size = new Size(125, 266);
            boruAsagi.SizeMode = PictureBoxSizeMode.StretchImage;
            boruAsagi.TabIndex = 2;
            boruAsagi.TabStop = false;
            // 
            // yer
            // 
            yer.Image = (Image)resources.GetObject("yer.Image");
            yer.Location = new Point(-1, 714);
            yer.Name = "yer";
            yer.Size = new Size(829, 90);
            yer.SizeMode = PictureBoxSizeMode.StretchImage;
            yer.TabIndex = 3;
            yer.TabStop = false;
            // 
            // skorTahtasi
            // 
            skorTahtasi.AutoSize = true;
            skorTahtasi.BackColor = Color.Transparent;
            skorTahtasi.Font = new Font("Ink Free", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            skorTahtasi.Location = new Point(308, 729);
            skorTahtasi.Name = "skorTahtasi";
            skorTahtasi.Size = new Size(220, 75);
            skorTahtasi.TabIndex = 4;
            skorTahtasi.Text = "Score:0";
            // 
            // oyunSayaci
            // 
            oyunSayaci.Enabled = true;
            oyunSayaci.Interval = 20;
            oyunSayaci.Tick += gameTimeEvent;
            // 
            // oyunSonu
            // 
            oyunSonu.AutoSize = true;
            oyunSonu.Font = new Font("Ink Free", 64F, FontStyle.Bold, GraphicsUnit.Point, 0);
            oyunSonu.ForeColor = SystemColors.ControlText;
            oyunSonu.Location = new Point(99, 264);
            oyunSonu.Name = "oyunSonu";
            oyunSonu.Size = new Size(632, 132);
            oyunSonu.TabIndex = 6;
            oyunSonu.Text = "Game Over!!";
            oyunSonu.Visible = false;
            oyunSonu.Click += oyunSonu_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 255, 255);
            ClientSize = new Size(828, 799);
            Controls.Add(oyunSonu);
            Controls.Add(skorTahtasi);
            Controls.Add(yer);
            Controls.Add(boruAsagi);
            Controls.Add(kus);
            Controls.Add(boruYukarı);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "Form1";
            Text = "  ";
            Load += Form1_Load;
            KeyDown += keyDown;
            KeyUp += keyUp;
            ((System.ComponentModel.ISupportInitialize)boruYukarı).EndInit();
            ((System.ComponentModel.ISupportInitialize)kus).EndInit();
            ((System.ComponentModel.ISupportInitialize)boruAsagi).EndInit();
            ((System.ComponentModel.ISupportInitialize)yer).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox boruYukarı;
        private PictureBox kus;
        private PictureBox boruAsagi;
        private PictureBox yer;
        private Label skorTahtasi;
        private System.Windows.Forms.Timer oyunSayaci;
        private Label oyunSonu;
    }
}
