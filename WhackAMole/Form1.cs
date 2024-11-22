using System;
using System.Drawing;
using System.Windows.Forms;
using WhackAMole.Components;

namespace WhackAMole
{
    public partial class Form1 : Form
    {
        private const int MAP_SIZE = 5;

        public Form1()
        {
            InitializeComponent();
            _map = new MapTile[,]
            {
                { mapTile1, mapTile2, mapTile3, mapTile4, mapTile5 },
                { mapTile6, mapTile7, mapTile8, mapTile9, mapTile10 },
                { mapTile11, mapTile12, mapTile13, mapTile14, mapTile15 },
                { mapTile16, mapTile17, mapTile18, mapTile19, mapTile20 },
                { mapTile21, mapTile22, mapTile23, mapTile24, mapTile25 },
            };
        }

        private readonly MapTile[,] _map;
        private Point _lastMoleCoordinate;
        private int _hitCount = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (var tile in _map)
                tile.Reset();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Cursor = new Cursor(ImageResources.HammerUp.GetHicon());
            timer1.Interval = 1000;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            _map[_lastMoleCoordinate.X, _lastMoleCoordinate.Y].Reset();
            var random = new Random();
            var index = random.Next(25);
            _lastMoleCoordinate = new Point(index / 5, index % 5);
            _map[_lastMoleCoordinate.X, _lastMoleCoordinate.Y].Pop();
            LevelLabel.Text = $"第{_hitCount / 10}关";
        }

        private void MapTile_MouseDown(object sender, MouseEventArgs e)
        {
            var tile = sender as MapTile;
            if (tile is null)
                throw new ArgumentException("sender is not a MapTile");
            Cursor = new Cursor(ImageResources.HammerDown.GetHicon());
            if (tile.Hit())
            {
                _hitCount++;
                HitCountNumberLabel.Text = _hitCount.ToString();
                RefreshTimerInterval();
            }
        }

        private void HammerUp(object sender, MouseEventArgs e)
        {
            Cursor = new Cursor(ImageResources.HammerUp.GetHicon());
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void RefreshTimerInterval()
        {
            var interval = _hitCount switch
            {
                < 10 => 1000,
                < 20 => 500,
                < 30 => 100,
                _ => 10,
            };
            if (timer1.Interval != interval)
                timer1.Interval = interval;
        }
    }
}
