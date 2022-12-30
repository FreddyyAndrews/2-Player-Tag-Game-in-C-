namespace Final_Project__Tag
{
    partial class Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form));
            this.p1 = new System.Windows.Forms.PictureBox();
            this.imageListdown = new System.Windows.Forms.ImageList(this.components);
            this.imageListright = new System.Windows.Forms.ImageList(this.components);
            this.imageListleft = new System.Windows.Forms.ImageList(this.components);
            this.imageListback = new System.Windows.Forms.ImageList(this.components);
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.effects = new System.Windows.Forms.ImageList(this.components);
            this.effecttimer = new System.Windows.Forms.Timer(this.components);
            this.beams = new System.Windows.Forms.ImageList(this.components);
            this.beamtimer = new System.Windows.Forms.Timer(this.components);
            this.p2 = new System.Windows.Forms.PictureBox();
            this.p2down = new System.Windows.Forms.ImageList(this.components);
            this.P2up = new System.Windows.Forms.ImageList(this.components);
            this.P2right = new System.Windows.Forms.ImageList(this.components);
            this.P2left = new System.Windows.Forms.ImageList(this.components);
            this.p1score = new System.Windows.Forms.Label();
            this.p2score = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.p1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p2)).BeginInit();
            this.SuspendLayout();
            // 
            // p1
            // 
            this.p1.BackColor = System.Drawing.Color.Transparent;
            this.p1.Location = new System.Drawing.Point(12, 265);
            this.p1.Name = "p1";
            this.p1.Size = new System.Drawing.Size(162, 173);
            this.p1.TabIndex = 0;
            this.p1.TabStop = false;
            this.p1.Click += new System.EventHandler(this.p1_Click);
            // 
            // imageListdown
            // 
            this.imageListdown.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListdown.ImageStream")));
            this.imageListdown.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListdown.Images.SetKeyName(0, "imageonline-co-split-image.jpg");
            this.imageListdown.Images.SetKeyName(1, "imageonline-co-split-image (2).jpg");
            // 
            // imageListright
            // 
            this.imageListright.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListright.ImageStream")));
            this.imageListright.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListright.Images.SetKeyName(0, "imageonline-co-split-image (6).jpg");
            this.imageListright.Images.SetKeyName(1, "imageonline-co-split-image (4).jpg");
            // 
            // imageListleft
            // 
            this.imageListleft.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListleft.ImageStream")));
            this.imageListleft.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListleft.Images.SetKeyName(0, "imageonline-co-split-image (9).jpg");
            this.imageListleft.Images.SetKeyName(1, "imageonline-co-split-image (11).jpg");
            // 
            // imageListback
            // 
            this.imageListback.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListback.ImageStream")));
            this.imageListback.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListback.Images.SetKeyName(0, "imageonline-co-split-image (12).jpg");
            this.imageListback.Images.SetKeyName(1, "imageonline-co-split-image (14).jpg");
            // 
            // timer
            // 
            this.timer.Interval = 10;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // effects
            // 
            this.effects.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("effects.ImageStream")));
            this.effects.TransparentColor = System.Drawing.Color.Transparent;
            this.effects.Images.SetKeyName(0, "powerup.png");
            // 
            // effecttimer
            // 
            this.effecttimer.Interval = 400;
            this.effecttimer.Tick += new System.EventHandler(this.effecttimer_Tick);
            // 
            // beams
            // 
            this.beams.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("beams.ImageStream")));
            this.beams.TransparentColor = System.Drawing.Color.Transparent;
            this.beams.Images.SetKeyName(0, "Red.svg.png");
            // 
            // beamtimer
            // 
            this.beamtimer.Interval = 2;
            this.beamtimer.Tick += new System.EventHandler(this.beamtimer_Tick);
            // 
            // p2
            // 
            this.p2.BackColor = System.Drawing.Color.Transparent;
            this.p2.Location = new System.Drawing.Point(623, 265);
            this.p2.Name = "p2";
            this.p2.Size = new System.Drawing.Size(162, 173);
            this.p2.TabIndex = 1;
            this.p2.TabStop = false;
            // 
            // p2down
            // 
            this.p2down.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("p2down.ImageStream")));
            this.p2down.TransparentColor = System.Drawing.Color.Transparent;
            this.p2down.Images.SetKeyName(0, "P2front2.png");
            this.p2down.Images.SetKeyName(1, "P2front1.png");
            // 
            // P2up
            // 
            this.P2up.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("P2up.ImageStream")));
            this.P2up.TransparentColor = System.Drawing.Color.Transparent;
            this.P2up.Images.SetKeyName(0, "p2back1.png");
            this.P2up.Images.SetKeyName(1, "p2back2.png");
            // 
            // P2right
            // 
            this.P2right.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("P2right.ImageStream")));
            this.P2right.TransparentColor = System.Drawing.Color.Transparent;
            this.P2right.Images.SetKeyName(0, "p2right1.png");
            this.P2right.Images.SetKeyName(1, "p2right2.png");
            // 
            // P2left
            // 
            this.P2left.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("P2left.ImageStream")));
            this.P2left.TransparentColor = System.Drawing.Color.Transparent;
            this.P2left.Images.SetKeyName(0, "p2left1.png");
            this.P2left.Images.SetKeyName(1, "P2left2.png");
            // 
            // p1score
            // 
            this.p1score.AutoSize = true;
            this.p1score.Location = new System.Drawing.Point(9, 9);
            this.p1score.Name = "p1score";
            this.p1score.Size = new System.Drawing.Size(45, 17);
            this.p1score.TabIndex = 2;
            this.p1score.Text = "P1 : 0";
            // 
            // p2score
            // 
            this.p2score.AutoSize = true;
            this.p2score.Location = new System.Drawing.Point(671, 9);
            this.p2score.Name = "p2score";
            this.p2score.Size = new System.Drawing.Size(45, 17);
            this.p2score.TabIndex = 3;
            this.p2score.Text = "P2 : 0";
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 577);
            this.Controls.Add(this.p2score);
            this.Controls.Add(this.p1score);
            this.Controls.Add(this.p2);
            this.Controls.Add(this.p1);
            this.Name = "Form";
            this.Text = "Benzi: Le Chasseur de Coffre au Trésor";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.p1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox p1;
        private System.Windows.Forms.ImageList imageListdown;
        private System.Windows.Forms.ImageList imageListright;
        private System.Windows.Forms.ImageList imageListleft;
        private System.Windows.Forms.ImageList imageListback;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.ImageList effects;
        private System.Windows.Forms.Timer effecttimer;
        private System.Windows.Forms.ImageList beams;
        private System.Windows.Forms.Timer beamtimer;
        private System.Windows.Forms.PictureBox p2;
        private System.Windows.Forms.ImageList p2down;
        private System.Windows.Forms.ImageList P2up;
        private System.Windows.Forms.ImageList P2right;
        private System.Windows.Forms.ImageList P2left;
        private System.Windows.Forms.Label p1score;
        private System.Windows.Forms.Label p2score;
    }
}

