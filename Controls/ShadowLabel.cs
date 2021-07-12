using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GenshinLyrePlayer.Controls
{
    public class ShadowLabel : Label
    {
        private Brush _shadowBrush = Brushes.Black;
        private Color _shadowColor = Color.Black;
        private Point _shadowMargin = Point.Empty;

        //[Browsable(true)]
        [Description("Shadow color"), Category("Shadow")]
        public Color ShadowColor
        { 
            get => _shadowColor;
            set 
            { 
                _shadowColor = value;
                _shadowBrush = (new Pen(value)).Brush;
                Invalidate(); 
            } 
        }
        //[Browsable(true)]
        [Description("Shadow distance from text"), Category("Shadow")]
        public Point ShadowMargin
        {
            get => _shadowMargin;
            set
            {
                _shadowMargin = value;
                Invalidate();
            }
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            var g = e.Graphics;

            var rectangle = DeflateRect(ClientRectangle, Padding);
            rectangle.X += ShadowMargin.X;
            rectangle.Y += ShadowMargin.Y;

            g.DrawString(Text, Font, _shadowBrush, rectangle, StringFormat.GenericDefault);
            

            base.OnPaint(e);
        }

        private Rectangle DeflateRect(Rectangle rect, Padding padding)
        {
            rect.X += padding.Left;
            rect.Y += padding.Top;
            rect.Width -= padding.Horizontal;
            rect.Height -= padding.Vertical;
            return rect;
        }
    }
}
