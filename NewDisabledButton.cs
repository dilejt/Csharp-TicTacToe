using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class NewButton : Button
    {
        private bool turn;

        public void changeDisabledForeColor(bool turn)
        {
            this.turn = turn;
        }

        protected override void OnPaint(PaintEventArgs paint)
        {
            if (base.Enabled)
            {
                base.OnPaint(paint);
            }
            else
            {
                // Calling the base class OnPaint
                base.OnPaint(paint);
                // Formatting text preventively
                StringFormat formatText = new StringFormat(StringFormatFlags.NoClip)
                {
                    LineAlignment = StringAlignment.Center,
                    Alignment = StringAlignment.Center
                };
                // Background
                paint.Graphics.FillRectangle(new SolidBrush(Color.Bisque), paint.ClipRectangle);
                // Draw the text in the button in red
                if (turn)
                {
                    paint.Graphics.DrawString(base.Text, base.Font, new SolidBrush(Color.Red),
                        new RectangleF(0F, 0F, base.Width, base.Height), formatText);
                }
                else
                {
                    paint.Graphics.DrawString(base.Text, base.Font, new SolidBrush(Color.Green),
                        new RectangleF(0F, 0F, base.Width, base.Height), formatText);
                }
                this.Cursor = Cursor.Current;
            }
        }
    }
}
