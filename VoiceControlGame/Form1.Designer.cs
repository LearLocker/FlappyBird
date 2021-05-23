namespace VoiceControlGame
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.voiceVolume = new System.Windows.Forms.ProgressBar();
            this.inputDevice = new System.Windows.Forms.ComboBox();
            this.controlGameBtn = new System.Windows.Forms.Button();
            this.globalTimer = new System.Windows.Forms.Timer(this.components);
            this.bird = new System.Windows.Forms.PictureBox();
            this.localTimer = new System.Windows.Forms.Timer(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tube = new System.Windows.Forms.PictureBox();
            this.tube3 = new System.Windows.Forms.PictureBox();
            this.tube2 = new System.Windows.Forms.PictureBox();
            this.tube4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.bird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tube)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tube3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tube2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tube4)).BeginInit();
            this.SuspendLayout();
            // 
            // voiceVolume
            // 
            this.voiceVolume.Location = new System.Drawing.Point(-1, 645);
            this.voiceVolume.Maximum = 300;
            this.voiceVolume.Name = "voiceVolume";
            this.voiceVolume.Size = new System.Drawing.Size(473, 30);
            this.voiceVolume.Step = 100;
            this.voiceVolume.TabIndex = 0;
            // 
            // inputDevice
            // 
            this.inputDevice.FormattingEnabled = true;
            this.inputDevice.Location = new System.Drawing.Point(86, 1);
            this.inputDevice.Name = "inputDevice";
            this.inputDevice.Size = new System.Drawing.Size(181, 21);
            this.inputDevice.TabIndex = 1;
            // 
            // controlGameBtn
            // 
            this.controlGameBtn.Location = new System.Drawing.Point(273, 1);
            this.controlGameBtn.Name = "controlGameBtn";
            this.controlGameBtn.Size = new System.Drawing.Size(147, 23);
            this.controlGameBtn.TabIndex = 2;
            this.controlGameBtn.Text = "Start Game";
            this.controlGameBtn.UseVisualStyleBackColor = true;
            this.controlGameBtn.Click += new System.EventHandler(this.controlGameBtn_Click);
            // 
            // globalTimer
            // 
            this.globalTimer.Interval = 5;
            this.globalTimer.Tick += new System.EventHandler(this.globalTimer_Tick);
            // 
            // bird
            // 
            this.bird.BackColor = System.Drawing.Color.Transparent;
            this.bird.Image = ((System.Drawing.Image)(resources.GetObject("bird.Image")));
            this.bird.Location = new System.Drawing.Point(12, 95);
            this.bird.Name = "bird";
            this.bird.Size = new System.Drawing.Size(56, 47);
            this.bird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bird.TabIndex = 3;
            this.bird.TabStop = false;
            // 
            // localTimer
            // 
            this.localTimer.Interval = 5;
            this.localTimer.Tick += new System.EventHandler(this.localTimer_Tick);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(467, 645);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            // 
            // tube
            // 
            this.tube.BackColor = System.Drawing.Color.Transparent;
            this.tube.Image = ((System.Drawing.Image)(resources.GetObject("tube.Image")));
            this.tube.Location = new System.Drawing.Point(170, 327);
            this.tube.Name = "tube";
            this.tube.Size = new System.Drawing.Size(54, 322);
            this.tube.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.tube.TabIndex = 5;
            this.tube.TabStop = false;
            // 
            // tube3
            // 
            this.tube3.BackColor = System.Drawing.Color.Transparent;
            this.tube3.Image = ((System.Drawing.Image)(resources.GetObject("tube3.Image")));
            this.tube3.Location = new System.Drawing.Point(490, 240);
            this.tube3.Name = "tube3";
            this.tube3.Size = new System.Drawing.Size(52, 408);
            this.tube3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.tube3.TabIndex = 5;
            this.tube3.TabStop = false;
            // 
            // tube2
            // 
            this.tube2.BackColor = System.Drawing.Color.Transparent;
            this.tube2.Image = ((System.Drawing.Image)(resources.GetObject("tube2.Image")));
            this.tube2.Location = new System.Drawing.Point(330, 426);
            this.tube2.Name = "tube2";
            this.tube2.Size = new System.Drawing.Size(54, 223);
            this.tube2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.tube2.TabIndex = 5;
            this.tube2.TabStop = false;
            // 
            // tube4
            // 
            this.tube4.BackColor = System.Drawing.Color.Transparent;
            this.tube4.Image = ((System.Drawing.Image)(resources.GetObject("tube4.Image")));
            this.tube4.Location = new System.Drawing.Point(650, 315);
            this.tube4.Name = "tube4";
            this.tube4.Size = new System.Drawing.Size(52, 333);
            this.tube4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.tube4.TabIndex = 5;
            this.tube4.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(567, 670);
            this.Controls.Add(this.tube4);
            this.Controls.Add(this.tube3);
            this.Controls.Add(this.tube2);
            this.Controls.Add(this.tube);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.bird);
            this.Controls.Add(this.controlGameBtn);
            this.Controls.Add(this.inputDevice);
            this.Controls.Add(this.voiceVolume);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tube)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tube3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tube2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tube4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar voiceVolume;
        private System.Windows.Forms.ComboBox inputDevice;
        private System.Windows.Forms.Button controlGameBtn;
        private System.Windows.Forms.Timer globalTimer;
        private System.Windows.Forms.PictureBox bird;
        private System.Windows.Forms.Timer localTimer;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox tube;
        private System.Windows.Forms.PictureBox tube3;
        private System.Windows.Forms.PictureBox tube2;
        private System.Windows.Forms.PictureBox tube4;
    }
}

