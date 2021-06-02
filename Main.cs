using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Main : Form
    {
        private static int scoreX;
        private static int scoreO;
        public Main()
        {
            InitializeComponent();
            scoreX = 0;
            scoreO = 0;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            int size = this.trackBarSize.Value;
            int turn;
            Cursor cursor;
            if (Convert.ToInt32(labelOScore.Text) == Convert.ToInt32(labelXScore.Text))
            {
                Random random = new Random();
                turn = random.Next(2);
                if(turn == 1)
                    cursor = new Cursor(GetType(), "CursorO.cur");
                else
                    cursor = new Cursor(GetType(), "CursorX.cur");
            }
            else if (Convert.ToInt32(labelOScore.Text) > Convert.ToInt32(labelXScore.Text))
            {
                turn = 0;
                cursor = new Cursor(GetType(), "CursorX.cur");
            }
            else
            {
                turn = 1;
                cursor = new Cursor(GetType(), "CursorO.cur");
            }
                

            Engine engine = new Engine(size);
            FormGameBoard formBoard = new FormGameBoard(engine,cursor,turn);
            formBoard.Changed += new EventHandler(Changed);
            formBoard.Text = "TicTacToe " + size.ToString() + " x " + size.ToString();
            formBoard.Show();
        }

        private void Changed(object sender, EventArgs e)
        {
            if (sender is FormGameBoard fc)
            {
                scoreO += fc.scoreO;
                scoreX += fc.scoreX;
                this.labelOScore.Text = scoreO.ToString();
                this.labelXScore.Text = scoreX.ToString();
            }
        }

        private void trackBarSize_ValueChanged(object sender, EventArgs e)
        {
            this.labelSize.Text = trackBarSize.Value.ToString();
        }
    }
}
