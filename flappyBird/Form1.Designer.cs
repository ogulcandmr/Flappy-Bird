namespace flappyBird
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.boruUst = new System.Windows.Forms.PictureBox();
            this.boruAlt = new System.Windows.Forms.PictureBox();
            this.skorText = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.yer = new System.Windows.Forms.PictureBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.flappyBird = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.boruUst)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boruAlt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flappyBird)).BeginInit();
            this.SuspendLayout();
            // 
            // boruUst
            // 
            this.boruUst.BackColor = System.Drawing.Color.Transparent;
            this.boruUst.Image = ((System.Drawing.Image)(resources.GetObject("boruUst.Image")));
            this.boruUst.Location = new System.Drawing.Point(544, -274);
            this.boruUst.Name = "boruUst";
            this.boruUst.Size = new System.Drawing.Size(100, 457);
            this.boruUst.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.boruUst.TabIndex = 1;
            this.boruUst.TabStop = false;
            this.boruUst.Click += new System.EventHandler(this.pictureBox2_Click_1);
            // 
            // boruAlt
            // 
            this.boruAlt.BackColor = System.Drawing.Color.Transparent;
            this.boruAlt.Image = ((System.Drawing.Image)(resources.GetObject("boruAlt.Image")));
            this.boruAlt.Location = new System.Drawing.Point(544, 314);
            this.boruAlt.Name = "boruAlt";
            this.boruAlt.Size = new System.Drawing.Size(100, 331);
            this.boruAlt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.boruAlt.TabIndex = 2;
            this.boruAlt.TabStop = false;
            // 
            // skorText
            // 
            this.skorText.AutoSize = true;
            this.skorText.BackColor = System.Drawing.Color.Transparent;
            this.skorText.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.skorText.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.skorText.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.skorText.Location = new System.Drawing.Point(92, 158);
            this.skorText.Name = "skorText";
            this.skorText.Size = new System.Drawing.Size(94, 25);
            this.skorText.TabIndex = 4;
            this.skorText.Text = "SKOR:  ";
            this.skorText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimerEvent);
            // 
            // yer
            // 
            this.yer.BackColor = System.Drawing.Color.Transparent;
            this.yer.Image = ((System.Drawing.Image)(resources.GetObject("yer.Image")));
            this.yer.Location = new System.Drawing.Point(-5, 473);
            this.yer.Name = "yer";
            this.yer.Size = new System.Drawing.Size(730, 96);
            this.yer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.yer.TabIndex = 6;
            this.yer.TabStop = false;
            this.yer.Click += new System.EventHandler(this.yer_Click);
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Transparent;
            this.btnStart.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnStart.BackgroundImage")));
            this.btnStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnStart.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnStart.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnStart.Location = new System.Drawing.Point(293, 193);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(128, 53);
            this.btnStart.TabIndex = 7;
            this.btnStart.Text = "BAŞLA";
            this.btnStart.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.UseWaitCursor = true;
            this.btnStart.Visible = false;
            this.btnStart.Click += new System.EventHandler(this.button1_Click);
            // 
            // flappyBird
            // 
            this.flappyBird.BackColor = System.Drawing.Color.Transparent;
            this.flappyBird.Image = ((System.Drawing.Image)(resources.GetObject("flappyBird.Image")));
            this.flappyBird.Location = new System.Drawing.Point(9, 193);
            this.flappyBird.Margin = new System.Windows.Forms.Padding(0);
            this.flappyBird.Name = "flappyBird";
            this.flappyBird.Size = new System.Drawing.Size(99, 68);
            this.flappyBird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.flappyBird.TabIndex = 5;
            this.flappyBird.TabStop = false;
            this.flappyBird.Click += new System.EventHandler(this.flappyBird_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(699, 598);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.yer);
            this.Controls.Add(this.flappyBird);
            this.Controls.Add(this.skorText);
            this.Controls.Add(this.boruAlt);
            this.Controls.Add(this.boruUst);
            this.Name = "Form1";
            this.Text = "Flappy Bird";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gamekeyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gamekeyisup);
            ((System.ComponentModel.ISupportInitialize)(this.boruUst)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boruAlt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flappyBird)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox boruUst;
        private System.Windows.Forms.PictureBox boruAlt;
        private System.Windows.Forms.Label skorText;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.PictureBox yer;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.PictureBox flappyBird;
    }
}

