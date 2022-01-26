
namespace Pong
{
    partial class PongGame
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
            this.ball = new System.Windows.Forms.PictureBox();
            this.rightBar = new System.Windows.Forms.PictureBox();
            this.leftBar = new System.Windows.Forms.PictureBox();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.scoreBox1 = new System.Windows.Forms.PictureBox();
            this.scoreBox2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scoreBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scoreBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // ball
            // 
            this.ball.Image = global::Pong.Properties.Resources.pongBall;
            this.ball.Location = new System.Drawing.Point(233, 243);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(20, 20);
            this.ball.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ball.TabIndex = 4;
            this.ball.TabStop = false;
            // 
            // rightBar
            // 
            this.rightBar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rightBar.Image = global::Pong.Properties.Resources.pongBar;
            this.rightBar.Location = new System.Drawing.Point(452, 212);
            this.rightBar.Name = "rightBar";
            this.rightBar.Size = new System.Drawing.Size(20, 100);
            this.rightBar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rightBar.TabIndex = 3;
            this.rightBar.TabStop = false;
            // 
            // leftBar
            // 
            this.leftBar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.leftBar.Image = global::Pong.Properties.Resources.pongBar;
            this.leftBar.Location = new System.Drawing.Point(12, 212);
            this.leftBar.Name = "leftBar";
            this.leftBar.Size = new System.Drawing.Size(20, 100);
            this.leftBar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.leftBar.TabIndex = 0;
            this.leftBar.TabStop = false;
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimerEvent);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pictureBox1.Location = new System.Drawing.Point(0, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(484, 62);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Khaki;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Khaki;
            this.label2.Location = new System.Drawing.Point(347, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "label2";
            // 
            // scoreBox1
            // 
            this.scoreBox1.Location = new System.Drawing.Point(-4, 67);
            this.scoreBox1.Name = "scoreBox1";
            this.scoreBox1.Size = new System.Drawing.Size(10, 403);
            this.scoreBox1.TabIndex = 8;
            this.scoreBox1.TabStop = false;
            this.scoreBox1.Tag = "scoreBox11";
            this.scoreBox1.Visible = false;
            // 
            // scoreBox2
            // 
            this.scoreBox2.Location = new System.Drawing.Point(478, 56);
            this.scoreBox2.Name = "scoreBox2";
            this.scoreBox2.Size = new System.Drawing.Size(10, 403);
            this.scoreBox2.TabIndex = 9;
            this.scoreBox2.TabStop = false;
            this.scoreBox2.Tag = "scoreBox22";
            this.scoreBox2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Khaki;
            this.label3.Location = new System.Drawing.Point(191, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "label3";
            // 
            // PongGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.scoreBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.leftBar);
            this.Controls.Add(this.rightBar);
            this.Controls.Add(this.ball);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.scoreBox1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "PongGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PongGame by Verevyta";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDownEvent);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyUpEvent);
            ((System.ComponentModel.ISupportInitialize)(this.ball)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scoreBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scoreBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox leftBar;
        private System.Windows.Forms.PictureBox rightBar;
        private System.Windows.Forms.PictureBox ball;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox scoreBox1;
        private System.Windows.Forms.PictureBox scoreBox2;
        private System.Windows.Forms.Label label3;
    }
}

