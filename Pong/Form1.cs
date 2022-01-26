using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pong
{
    public partial class PongGame : Form
    {

        bool rightBarUp, rightBarDown = false;
        bool leftBarUp, leftBarDown = false;
        int speed = 10;
        Random _random = new Random();
        int playerOneScore = 0;
        int playerTwoScore = 0;

        int ballX = 6;
        int ballY = 0;
        
        

        
        public PongGame()
        {
            InitializeComponent();
            SetupGame();
        }

        private void SetupGame()
        {
            

            ballY = 0;
            speed = 10;

            if(playerOneScore > playerTwoScore)
            {
                ballX = 6;
            }
            else
            {
                ballX = -6;
            }

            
            gameTimer.Start();
            ball.Refresh();
            ball.Location = new Point(250, 250);
            this.Controls.Add(scoreBox1);
            this.Controls.Add(scoreBox2);
            scoreBox1.Location = new Point(-10, 67);
            scoreBox2.Location = new Point(478, 56);
            scoreBox1.Tag = "scoreBox11";
            scoreBox2.Tag = "scoreBox22";
            label3.Text = " ";




        }


        private void gameTimerEvent(object sender, EventArgs e)
        {
            ball.Left += ballX;
            ball.Top += ballY;

            label1.Text = "Player 1 Score: " + playerOneScore;
            label2.Text = "Player 2 Score: " + playerTwoScore;





            if (rightBarUp == true && leftBar.Top > 65)
            {
                leftBar.Top -= speed;
            }
            if (rightBarDown == true && leftBar.Top < 356)
            {
                leftBar.Top += speed;
            }


            if (leftBarUp == true && rightBar.Top > 65)
            {
                rightBar.Top -= speed;
            }
            if (leftBarDown == true && rightBar.Top < 356)
            {
                rightBar.Top += speed;
            }



            if(ball.Top < 60 || ball.Top > 440)
            {
                ballY = -ballY;
            }
            

            if (ball.Bounds.IntersectsWith(leftBar.Bounds))
            {
                ballY = _random.Next(5, 8) * -1;
                if(ballY < 0)
                {
                    ballX = _random.Next(5, 8) * 1;
                }
                else
                {
                    ballX = _random.Next(5, 8);
                }
            }
            if (ball.Bounds.IntersectsWith(rightBar.Bounds))
            {
                ballX = _random.Next(5, 8) * -1;
                if (ballX < 0)
                {
                    ballX = _random.Next(5, 8) * -1;
                }
                else
                {
                    ballX = _random.Next(5, 8);
                }
            }

            foreach (Control x in this.Controls) 
            {
                if(x is PictureBox && x.Tag == "scoreBox11")
                {
                    if(ball.Bounds.IntersectsWith(x.Bounds))
                    {
                        this.Controls.Remove(x);
                        playerTwoScore++;
                        label3.Text = "Player Two wins";
                    }
                }

                if (x is PictureBox && x.Tag == "scoreBox22")
                {
                    if (ball.Bounds.IntersectsWith(x.Bounds))
                    {
                        this.Controls.Remove(x);
                        playerOneScore++;
                        label3.Text = "Player One wins";

                    }
                }
            }
            
            if(ball.Left < -100 || ball.Left > 550)
            {
                GameOver();
                System.Threading.Thread.Sleep(1000);
                SetupGame();
            }

            
            
            
            
        }

       

        private void KeyDownEvent(object sender, KeyEventArgs e)
        {
            

            if (e.KeyCode == Keys.W)
            {
                rightBarUp = true;
            }
            if (e.KeyCode == Keys.S)
            {
                rightBarDown = true;
            }


            if (e.KeyCode == Keys.Up)
            {
                leftBarUp = true;
            }
            if (e.KeyCode == Keys.Down)
            {
                leftBarDown = true;
            }

        }

        

        private void KeyUpEvent(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
            {
                rightBarUp = false;
            }
            if (e.KeyCode == Keys.S)
            {
                rightBarDown = false;
            }


            if (e.KeyCode == Keys.Up)
            {
                leftBarUp = false;
            }
            if (e.KeyCode == Keys.Down)
            {
                leftBarDown = false;
            }
        }

        private void GameOver()
        {
            gameTimer.Stop();
            
           
        }

        //




    }
}
