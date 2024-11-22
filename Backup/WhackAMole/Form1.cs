using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WhackAMole
{
    public partial class Form1 : Form
    {
        private const int MAP_SIZE = 5;

        public Form1()
        {
            InitializeComponent();
            _map = new PictureBox[,]
            {
                { mapTile1, mapTile2, mapTile3, mapTile4, mapTile5 },
                { mapTile6, mapTile7, mapTile8, mapTile9, mapTile10 },
                { mapTile11, mapTile12, mapTile13, mapTile14, mapTile15 },
                { mapTile16, mapTile17, mapTile18, mapTile19, mapTile20 },
                { mapTile21, mapTile22, mapTile23, mapTile24, mapTile25 },
            };
        }

        private readonly PictureBox[,] _map;

        // private int i1;
        private Point lastMoleCoordinate;
        private int hitCount = 0;
        private bool[] molePopped = new bool[25];
        private Bitmap hammerDownImage = (Bitmap)Image.FromFile(@"hammer-down.gif");
        private Bitmap hammerUpImage = (Bitmap)Image.FromFile(@"hammer-up.gif");

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < MAP_SIZE; i++)
            {
                for (int j = 0; j < MAP_SIZE; j++)
                {
                    _map[i, j].Image = imageList1.Images[2];
                }
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            timer2.Interval = 1000;
            timer1.Start(); //触发timer,游戏开始
            timer2.Start();
            // label3.Text = "第" + (i2 - i2 % 10) / 10 + "关";
            if (hitCount >= 10 && hitCount < 20)
            {
                timer1.Interval = 500; //
                timer2.Interval = 500;
                timer1.Start();
                timer2.Start();
                if (hitCount >= 20 && hitCount < 30)
                {
                    timer1.Stop();
                    timer2.Stop();
                    timer1.Interval = 100;
                    timer2.Interval = 100;
                    timer1.Start();
                    timer2.Start();

                    if (hitCount >= 30)
                    {
                        timer1.Stop();
                        timer2.Stop();
                        timer1.Interval = 10;
                        timer2.Interval = 10;
                        timer1.Start();
                        timer2.Start();
                    }
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Cursor = new Cursor(@"c1.cur");
            var random = new Random();
            var index = random.Next(25);
            lastMoleCoordinate = new Point(index / 5, index % 5);
            _map[i1 / 5, i1 % 5].Image = imageList1.Images[3];
            molePopped[i1] = true;
            label3.Text = "第" + (hitCount - hitCount % 10) / 10 + "关";
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            _map[i1].Image = imageList1.Images[2];
            molePopped[i1] = false;
        }

        private void mapTile1_MouseDown(object sender, MouseEventArgs e)
        {
            Cursor = new Cursor(hammerUpImage.GetHicon());

            if (molePopped[i1] && i1 == 0)
            {
                _map[i1].Image = imageList1.Images[4];
                hitCount++;
                label2.Text = hitCount.ToString();
            }
        }

        private void mapTile2_MouseDown(object sender, MouseEventArgs e)
        {
            Cursor = new Cursor(hammerUpImage.GetHicon());

            if (molePopped[i1] && i1 == 1)
            {
                _map[i1].Image = imageList1.Images[4];
                hitCount++;
                label2.Text = hitCount.ToString();
            }
        }

        private void mapTile3_MouseDown(object sender, MouseEventArgs e)
        {
            Cursor = new Cursor(hammerUpImage.GetHicon());

            if (molePopped[i1] && i1 == 2)
            {
                _map[i1].Image = imageList1.Images[4];
                hitCount++;
                label2.Text = hitCount.ToString();
            }
        }

        private void mapTile4_MouseDown(object sender, MouseEventArgs e)
        {
            Cursor = new Cursor(hammerUpImage.GetHicon());

            if (molePopped[i1] && i1 == 3)
            {
                _map[i1].Image = imageList1.Images[4];
                hitCount++;
                label2.Text = hitCount.ToString();
            }
        }

        private void mapTile5_MouseDown(object sender, MouseEventArgs e)
        {
            Cursor = new Cursor(hammerUpImage.GetHicon());

            if (molePopped[i1] && i1 == 4)
            {
                _map[i1].Image = imageList1.Images[4];
                hitCount++;
                label2.Text = hitCount.ToString();
            }
        }

        private void mapTile6_MouseDown(object sender, MouseEventArgs e)
        {
            Cursor = new Cursor(hammerUpImage.GetHicon());

            if (molePopped[i1] && i1 == 5)
            {
                _map[i1].Image = imageList1.Images[4];
                hitCount++;
                label2.Text = hitCount.ToString();
            }
        }

        private void mapTile7_MouseDown(object sender, MouseEventArgs e)
        {
            Cursor = new Cursor(hammerUpImage.GetHicon());

            if (molePopped[i1] && i1 == 6)
            {
                _map[i1].Image = imageList1.Images[4];
                hitCount++;
                label2.Text = hitCount.ToString();
            }
        }

        private void mapTile8_MouseDown(object sender, MouseEventArgs e)
        {
            Cursor = new Cursor(hammerUpImage.GetHicon());

            if (molePopped[i1] && i1 == 7)
            {
                _map[i1].Image = imageList1.Images[4];
                hitCount++;
                label2.Text = hitCount.ToString();
            }
        }

        private void mapTile9_MouseDown(object sender, MouseEventArgs e)
        {
            Cursor = new Cursor(hammerUpImage.GetHicon());

            if (molePopped[i1] && i1 == 8)
            {
                _map[i1].Image = imageList1.Images[4];
                hitCount++;
                label2.Text = hitCount.ToString();
            }
        }

        private void mapTile10_MouseDown(object sender, MouseEventArgs e)
        {
            Cursor = new Cursor(hammerUpImage.GetHicon());

            if (molePopped[i1] && i1 == 9)
            {
                _map[i1].Image = imageList1.Images[4];
                hitCount++;
                label2.Text = hitCount.ToString();
            }
        }

        private void mapTile11_MouseDown(object sender, MouseEventArgs e)
        {
            Cursor = new Cursor(hammerUpImage.GetHicon());

            if (molePopped[i1] && i1 == 10)
            {
                _map[i1].Image = imageList1.Images[4];
                hitCount++;
                label2.Text = hitCount.ToString();
            }
        }

        private void mapTile12_MouseDown(object sender, MouseEventArgs e)
        {
            Cursor = new Cursor(hammerUpImage.GetHicon());

            if (molePopped[i1] && i1 == 11)
            {
                _map[i1].Image = imageList1.Images[4];
                hitCount++;
                label2.Text = hitCount.ToString();
            }
        }

        private void mapTile13_MouseDown(object sender, MouseEventArgs e)
        {
            Cursor = new Cursor(hammerUpImage.GetHicon());

            if (molePopped[i1] && i1 == 12)
            {
                _map[i1].Image = imageList1.Images[4];
                hitCount++;
                label2.Text = hitCount.ToString();
            }
        }

        private void mapTile14_MouseDown(object sender, MouseEventArgs e)
        {
            Cursor = new Cursor(hammerUpImage.GetHicon());

            if (molePopped[i1] && i1 == 13)
            {
                _map[i1].Image = imageList1.Images[4];
                hitCount++;
                label2.Text = hitCount.ToString();
            }
        }

        private void mapTile15_MouseDown(object sender, MouseEventArgs e)
        {
            Cursor = new Cursor(hammerUpImage.GetHicon());

            if (molePopped[i1] && i1 == 14)
            {
                _map[i1].Image = imageList1.Images[4];
                hitCount++;
                label2.Text = hitCount.ToString();
            }
        }

        private void mapTile16_MouseDown(object sender, MouseEventArgs e)
        {
            Cursor = new Cursor(hammerUpImage.GetHicon());

            if (molePopped[i1] && i1 == 15)
            {
                _map[i1].Image = imageList1.Images[4];
                hitCount++;
                label2.Text = hitCount.ToString();
            }
        }

        private void mapTile17_MouseDown(object sender, MouseEventArgs e)
        {
            Cursor = new Cursor(hammerUpImage.GetHicon());

            if (molePopped[i1] && i1 == 16)
            {
                _map[i1].Image = imageList1.Images[4];
                hitCount++;
                label2.Text = hitCount.ToString();
            }
        }

        private void mapTile18_MouseDown(object sender, MouseEventArgs e)
        {
            Cursor = new Cursor(hammerUpImage.GetHicon());

            if (molePopped[i1] && i1 == 17)
            {
                _map[i1].Image = imageList1.Images[4];
                hitCount++;
                label2.Text = hitCount.ToString();
            }
        }

        private void mapTile20_MouseDown(object sender, MouseEventArgs e)
        {
            Cursor = new Cursor(hammerUpImage.GetHicon());

            if (molePopped[i1] && i1 == 19)
            {
                _map[i1].Image = imageList1.Images[4];
                hitCount++;
                label2.Text = hitCount.ToString();
            }
        }

        private void mapTile19_MouseDown(object sender, MouseEventArgs e)
        {
            Cursor = new Cursor(hammerUpImage.GetHicon());

            if (molePopped[i1] && i1 == 18)
            {
                _map[i1].Image = imageList1.Images[4];
                hitCount++;
                label2.Text = hitCount.ToString();
            }
        }

        private void mapTile21_MouseDown(object sender, MouseEventArgs e)
        {
            Cursor = new Cursor(hammerUpImage.GetHicon());

            if (molePopped[i1] && i1 == 20)
            {
                _map[i1].Image = imageList1.Images[4];
                hitCount++;
                label2.Text = hitCount.ToString();
            }
        }

        private void mapTile22_MouseDown(object sender, MouseEventArgs e)
        {
            Cursor = new Cursor(hammerUpImage.GetHicon());

            if (molePopped[i1] && i1 == 21)
            {
                _map[i1].Image = imageList1.Images[4];
                hitCount++;
                label2.Text = hitCount.ToString();
            }
        }

        private void mapTile23_MouseDown(object sender, MouseEventArgs e)
        {
            Cursor = new Cursor(hammerUpImage.GetHicon());

            if (molePopped[i1] && i1 == 22)
            {
                _map[i1].Image = imageList1.Images[4];
                hitCount++;
                label2.Text = hitCount.ToString();
            }
        }

        private void mapTile24_MouseDown(object sender, MouseEventArgs e)
        {
            Cursor = new Cursor(hammerUpImage.GetHicon());

            if (molePopped[i1] && i1 == 23)
            {
                _map[i1].Image = imageList1.Images[4];
                hitCount++;
                label2.Text = hitCount.ToString();
            }
        }

        private void mapTile25_MouseDown(object sender, MouseEventArgs e)
        {
            Cursor = new Cursor(hammerUpImage.GetHicon());

            if (molePopped[i1] && i1 == 24)
            {
                _map[i1].Image = imageList1.Images[4];
                hitCount++;
                label2.Text = hitCount.ToString();
            }
        }

        private void HammerUp(object sender, MouseEventArgs e)
        {
            Cursor = new Cursor(hammerDownImage.GetHicon());
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
