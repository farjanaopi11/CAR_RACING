namespace Car_Racing
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.AI2 = new System.Windows.Forms.PictureBox();
            this.award = new System.Windows.Forms.PictureBox();
            this.explosion = new System.Windows.Forms.PictureBox();
            this.AI1 = new System.Windows.Forms.PictureBox();
            this.Player = new System.Windows.Forms.PictureBox();
            this.Road2 = new System.Windows.Forms.PictureBox();
            this.Road1 = new System.Windows.Forms.PictureBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AI2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.award)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.explosion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AI1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Road2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Road1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.AI2);
            this.panel1.Controls.Add(this.award);
            this.panel1.Controls.Add(this.explosion);
            this.panel1.Controls.Add(this.AI1);
            this.panel1.Controls.Add(this.Player);
            this.panel1.Controls.Add(this.Road2);
            this.panel1.Controls.Add(this.Road1);
            this.panel1.Location = new System.Drawing.Point(12, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(473, 519);
            this.panel1.TabIndex = 0;
            // 
            // AI2
            // 
            this.AI2.Image = global::Car_Racing.Properties.Resources.carGrey;
            this.AI2.Location = new System.Drawing.Point(347, 60);
            this.AI2.Name = "AI2";
            this.AI2.Size = new System.Drawing.Size(50, 100);
            this.AI2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.AI2.TabIndex = 7;
            this.AI2.TabStop = false;
            this.AI2.Tag = "carRight";
            // 
            // award
            // 
            this.award.Image = global::Car_Racing.Properties.Resources.bronze;
            this.award.Location = new System.Drawing.Point(114, 207);
            this.award.Name = "award";
            this.award.Size = new System.Drawing.Size(250, 100);
            this.award.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.award.TabIndex = 6;
            this.award.TabStop = false;
            // 
            // explosion
            // 
            this.explosion.Image = global::Car_Racing.Properties.Resources.explosion;
            this.explosion.Location = new System.Drawing.Point(58, 372);
            this.explosion.Name = "explosion";
            this.explosion.Size = new System.Drawing.Size(64, 64);
            this.explosion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.explosion.TabIndex = 5;
            this.explosion.TabStop = false;
            // 
            // AI1
            // 
            this.AI1.Image = global::Car_Racing.Properties.Resources.carGreen;
            this.AI1.Location = new System.Drawing.Point(199, 39);
            this.AI1.Name = "AI1";
            this.AI1.Size = new System.Drawing.Size(50, 101);
            this.AI1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.AI1.TabIndex = 4;
            this.AI1.TabStop = false;
            this.AI1.Tag = "carLeft";
            // 
            // Player
            // 
            this.Player.Image = global::Car_Racing.Properties.Resources.carYellow;
            this.Player.Location = new System.Drawing.Point(206, 402);
            this.Player.Name = "Player";
            this.Player.Size = new System.Drawing.Size(50, 99);
            this.Player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Player.TabIndex = 2;
            this.Player.TabStop = false;
            // 
            // Road2
            // 
            this.Road2.Image = global::Car_Racing.Properties.Resources.roadTrack;
            this.Road2.Location = new System.Drawing.Point(0, 0);
            this.Road2.Name = "Road2";
            this.Road2.Size = new System.Drawing.Size(475, 519);
            this.Road2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Road2.TabIndex = 0;
            this.Road2.TabStop = false;
            this.Road2.Click += new System.EventHandler(this.Road1_Click);
            // 
            // Road1
            // 
            this.Road1.Image = global::Car_Racing.Properties.Resources.roadTrack;
            this.Road1.Location = new System.Drawing.Point(0, -519);
            this.Road1.Name = "Road1";
            this.Road1.Size = new System.Drawing.Size(475, 519);
            this.Road1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Road1.TabIndex = 1;
            this.Road1.TabStop = false;
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(201, 566);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(86, 36);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(473, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "Score: 0";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 605);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(473, 182);
            this.label2.TabIndex = 2;
            this.label2.Text = "Press & Right To Move The Car\r\n\r\nDo Not Hit Any Other Car & Survive As Long As Yo" +
    "u Can\r\n";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer
            // 
            this.timer.Interval = 20;
            this.timer.Tick += new System.EventHandler(this.gameTimerEvent);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 773);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Car Racing";
            //this.Load += new System.EventHandler(this.keyisdown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyisup);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AI2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.award)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.explosion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AI1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Road2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Road1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox Road2;
        private System.Windows.Forms.PictureBox Road1;
        private System.Windows.Forms.PictureBox award;
        private System.Windows.Forms.PictureBox explosion;
        private System.Windows.Forms.PictureBox AI1;
        private System.Windows.Forms.PictureBox Player;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.PictureBox AI2;
    }
}

