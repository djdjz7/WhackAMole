using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using System.Windows.Forms;

namespace WhackAMole
{
    public class MapTile : PictureBox
    {
        public Point Coordinate { get; set; }
    }
}