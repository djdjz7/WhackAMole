using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using System.Windows.Forms;

namespace WhackAMole.Components
{
    public class MapTile : PictureBox
    {
        public Point Coordinate { get; set; }
        private bool _popped = false;

        public void Pop()
        {
            this.Image = ImageResources.MolePopped;
            _popped = true;
        }

        public bool Hit()
        {
            if (!_popped)
                return false;
            this.Image = ImageResources.MoleHit;
            return true;
        }

        public void Reset()
        {
            this.Image = ImageResources.MoleHidden;
            _popped = false;
        }
    }
}
