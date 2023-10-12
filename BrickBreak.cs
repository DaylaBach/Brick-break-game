using BrickBreak.DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrickBreak
{
    public partial class BrickBreak : Form
    {
        Boolean moveLeft;
        Boolean moveRight;
        Boolean isGameOver;
        /*Boolean gamePaused;

        int spacePressed = 0;*/

        int currentLevel = 1;
        int score = 0;
        int ballX;
        int ballY;
        int playerSpeed;

        PictureBox[] brickArray;

        Random rdm = new Random();

        public BrickBreak()
        {
            InitializeComponent();
            PlaceBricks(currentLevel);
            setupGame(currentLevel);
            MainGameTimer.Start();
        }

        public void setupGame(int currentLevel)
        {
            if (currentLevel == 1)
            {
                ballX = 5;
                ballY = 5;
                playerSpeed = 10;
            }
            if (currentLevel == 2)
            {
                ballX = 7;
                ballY = 7;
                playerSpeed = 12;
            }
            if (currentLevel == 3)
            {
                ballX = 8;
                ballY = 8;
                playerSpeed = 15;
            }
            Breaker.Top = 200;
            ViewScore.Text = "Score: " + score.ToString();
            Winner.Hide();
            Trophy.Hide();
            SaveName.Hide();
            textBox1Label.Hide();
            textBox1.Hide();
            gameOverLabel.Hide();
            pausedLabel.Hide();
            nextLevel.Hide();
            RestartLevel.Hide();
        }


        private void keyIsDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Left)
            {
                moveLeft = true;
            }
            if(e.KeyCode == Keys.Right)
            {
                moveRight = true;
            }
            /*if (e.KeyCode.Equals(Keys.Space))
            {
                spacePressed += 1;
                gamePaused = true;
            }
            if (e.KeyCode.Equals(Keys.Space) && spacePressed > 1)
            {
                spacePressed = 0;
                gamePaused = false;
                MainGameTimer.Enabled = true;
            }*/

        }

        private void keyIsUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Left)
            {
                moveLeft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                moveRight = false;
            }
        }

        private void MainGameTimer_Tick(object sender, EventArgs e)
        {
            ViewScore.Text = "Score: " + score;

            if (moveLeft == true && Catcher.Left > 0)
            {
                Catcher.Left -= playerSpeed;
            }
            if (moveRight == true && Catcher.Left < 513)
            {
                Catcher.Left += playerSpeed;
            }

            Breaker.Left += ballX;
            Breaker.Top += ballY;

            if(Breaker.Left < 0 || Breaker.Left > 598)
            {
                ballX = -ballX;
            }
            if(Breaker.Top < 0)
            {
                ballY = -ballY;
            }

            Catching(currentLevel);
            Breaking();

            if(Breaker.Top > 491)
            {
                isGameOver = true;
            }

            if (currentLevel == 1 && score == 18)
            {
                currentLevel += 1;
                MainGameTimer.Stop();
                nextLevel.Show();
            }
            if (currentLevel == 2 && score == 42)
            {
                currentLevel += 1;
                MainGameTimer.Stop();
                nextLevel.Show();
            }

            WinGame();

            gameOver();
        }

        public void WinGame()
        {
            if (currentLevel == 3 && score == 78)
            {
                currentLevel = 1;
                MainGameTimer.Stop();
                Winner.Show();
                Trophy.Show();
                textBox1.Show();
                SaveName.Show();
            }
        }

        public void gameOver()
        {
            if(isGameOver == true)
            {
                gameOverLabel.Show();
                RestartLevel.Show();
                MainGameTimer.Stop();
            }
        }
        
        private void PlaceBricks(int level)
        {
            brickArray = new PictureBox[18];

            int rowBrickCount = 0;

            int top = 20;
            int left = 43;

            for (int i = 0; i < brickArray.Length; i++)
            {
                brickArray[i] = new PictureBox();
                brickArray[i].Height = 20;
                brickArray[i].Width = 80;
                brickArray[i].Tag = "brick";
                brickArray[i].BackColor = Color.White;


                if (rowBrickCount == 6)
                {
                    top = top + 40;
                    left = 43;
                    rowBrickCount = 0;
                }

                if (rowBrickCount < 6)
                {
                    rowBrickCount++;
                    brickArray[i].Left = left;
                    brickArray[i].Top = top;
                    this.Controls.Add(brickArray[i]);
                    left = left + 90;
                }
                if (currentLevel == 3)
                {
                    brickArray[i].BackColor = Color.FromArgb(rdm.Next(256), rdm.Next(256), rdm.Next(256));
                }

            }
            if(currentLevel == 2)
            {
                int a = rdm.Next(1, 3);
                int b = rdm.Next(3, 6);
                int c = rdm.Next(6, 9);
                int d = rdm.Next(9, 12);
                int e = rdm.Next(12, 15);
                int f = rdm.Next(15, 18);
                brickArray[a].BackColor = Color.FromArgb(rdm.Next(256), rdm.Next(256), rdm.Next(256));
                brickArray[b].BackColor = Color.FromArgb(rdm.Next(256), rdm.Next(256), rdm.Next(256));
                brickArray[c].BackColor = Color.FromArgb(rdm.Next(256), rdm.Next(256), rdm.Next(256));
                brickArray[d].BackColor = Color.FromArgb(rdm.Next(256), rdm.Next(256), rdm.Next(256));
                brickArray[e].BackColor = Color.FromArgb(rdm.Next(256), rdm.Next(256), rdm.Next(256));
                brickArray[f].BackColor = Color.FromArgb(rdm.Next(256), rdm.Next(256), rdm.Next(256));
            }
        }

        /*private void PauseGame()
        {
            if(gamePaused == true)
            {
                MainGameTimer.Enabled = false;
                pausedLabel.Show();
            } else 
            {
                pausedLabel.Hide();
            }
        }*/

        private void Catching(int currentLevel)
        {
            if (Breaker.Bounds.IntersectsWith(Catcher.Bounds))
            {
                if (currentLevel == 1)
                {
                    ballY = rdm.Next(7, 12) * -1;

                    if (ballX < 0)
                    {
                        ballX = rdm.Next(7, 12) * -1;
                    }
                    else
                    {
                        ballX = rdm.Next(7, 12);
                    }
                }
                if (currentLevel == 2)
                {
                    ballY = rdm.Next(10, 15) * -1;

                    if (ballX < 0)
                    {
                        ballX = rdm.Next(10, 15) * -1;
                    }
                    else
                    {
                        ballX = rdm.Next(10, 15);
                    }
                }
                if (currentLevel == 3)
                {
                    ballY = rdm.Next(12, 17) * -1;

                    if (ballX < 0)
                    {
                        ballX = rdm.Next(12, 17) * -1;
                    }
                    else
                    {
                        ballX = rdm.Next(12, 17);
                    }
                }
            }
        }

        private void Breaking()
        {
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "brick")
                {
                    
                    if (Breaker.Bounds.IntersectsWith(x.Bounds))
                    {
                        if (x.BackColor != Color.White)
                        {
                            x.BackColor = Color.White;

                            score += 1;

                            ballY = -ballY;
                        }
                        else
                        {
                            score += 1;

                            ballY = -ballY;

                            if (x.BackColor == Color.White)
                            {
                                this.Controls.Remove(x);
                            }
                        }
                    }
                }
            }
        }

        private void nextLevel_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            InitializeComponent();
            PlaceBricks(currentLevel);
            setupGame(currentLevel);
            MainGameTimer.Start();
        }

        private void RestartLevel_Click(object sender, EventArgs e)
        {
            isGameOver = false;
            if (currentLevel == 1)
            {
                score = 0;
            }if (currentLevel == 2)
            {
                score = 18;
            }if (currentLevel == 3)
            {
                score = 42;
            }
            this.Controls.Clear();
            InitializeComponent();
            PlaceBricks(currentLevel);
            setupGame(currentLevel);
            RestartLevel.Hide();
            MainGameTimer.Start();
        }

        private void SaveName_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = SQLServerConnection.Connection.CreateCommand();
            cmd.CommandText = "insert into winner values(@name)";
            cmd.Parameters.AddWithValue("name", textBox1.Text);
            int row = cmd.ExecuteNonQuery();
            textBox1.Hide();
            SaveName.Hide();
            RestartLevel.Show();
        }
    }
}
