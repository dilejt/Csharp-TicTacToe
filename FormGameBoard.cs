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
    public partial class FormGameBoard : Form
    {
        private bool turn;
        private readonly TableLayoutPanel tableLayoutPanelBoard;
        public event EventHandler Changed;
        public int scoreX;
        public int scoreO;

        public FormGameBoard(Engine engine, Cursor startCursor, int turn)
        {
            InitializeComponent();
            Engine = engine;
            this.Width = 60 * Engine.size + 16 + (Engine.size - 1) * 4;
            this.Height = 60 * Engine.size + 39 + (Engine.size - 1) * 4;
            this.BackColor = Color.Bisque;
            tableLayoutPanelBoard = new TableLayoutPanel
            {
                ColumnCount = Engine.size,
                RowCount = Engine.size,
                AutoSize = false,
                Size = new Size(63 * Engine.size, 63 * Engine.size),
                Location = new Point(0, 0),
                BackColor = Color.Gray,
                Name = "tableLayoutPanelBoard",
                Cursor = startCursor
            };
            CreateButtons();
            this.Controls.Add(tableLayoutPanelBoard);
            this.turn = Convert.ToBoolean(turn);
        }

        public Engine Engine { get; }

        public void CreateButtons()
        {
            for (int i = 0; i < Engine.size; i++)
            {
                for (int j = 0; j < Engine.size; j++)
                {
                    NewButton button = new NewButton
                    {
                        Anchor = AnchorStyles.None,
                        Size = new Size(60, 60)
                    };
                    Point point = new Point(i, j);
                    button.Location = point;
                    button.TabIndex = i + j;
                    button.Margin = new Padding(0,0,4,4);
                    button.Padding = new Padding(0,0,4,4);
                    button.BackColor = Color.Bisque;
                    button.FlatStyle = FlatStyle.Flat;
                    button.FlatAppearance.BorderSize = 0;
                    button.TextAlign = ContentAlignment.MiddleCenter;
                    button.Font = new Font("Tahoma", 18);
                    button.Name = "button" + i.ToString() +","+ j.ToString();
                    button.Click += new EventHandler(button_Click); // button.Attributes.Add("OnClick","button_Click");
                    tableLayoutPanelBoard.Controls.Add(button);
                }
            }
        }

        private void button_Click(object sender, EventArgs e)
        {
            string tmpString = ((NewButton)sender).Name;
            tmpString = tmpString.Replace("button", "");
            string[] tmpArray = tmpString.Split(',');

            if (turn)
            {
                ((NewButton)sender).changeDisabledForeColor(true);
                ((NewButton)sender).Text = "O";
                tableLayoutPanelBoard.Cursor = new Cursor(GetType(), "CursorX.cur");
                Engine.board[Convert.ToInt32(tmpArray[0]), Convert.ToInt32(tmpArray[1])] = "O";
            }
            else
            {
                ((NewButton)sender).changeDisabledForeColor(false);
                ((NewButton)sender).Text = "X";
                tableLayoutPanelBoard.Cursor = new Cursor(GetType(), "CursorO.cur");
                Engine.board[Convert.ToInt32(tmpArray[0]), Convert.ToInt32(tmpArray[1])] = "X";
            }
            Engine.movesCount++;
            this.turn = !this.turn;
            ((NewButton)sender).Enabled = false;

            switch (Engine.CheckFinish(Convert.ToInt32(tmpArray[0]), Convert.ToInt32(tmpArray[1])))
            {
                case 0:
                    tableLayoutPanelBoard.BackColor = Color.Red;
                    break;
                case 1:
                    showFinishPicure(@"winnerX.jpg");
                    scoreX++;
                    ChangeScore();
                    break;
                case 2:
                    showFinishPicure(@"winnerO.jpg");
                    scoreO++;
                    ChangeScore();
                    break;
                default:
                    break;
            }

        }

        private void showFinishPicure(string url)
        {
            tableLayoutPanelBoard.BackColor = Color.Green;
            PictureBox pictureBox = new PictureBox();
            tableLayoutPanelBoard.Visible = false;
            pictureBox.Dock = DockStyle.Fill;
            pictureBox.ImageLocation = url;
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            this.Controls.Add(pictureBox);
        }

        protected virtual void OnChanged(EventArgs e)
        {
            Changed?.Invoke(this, e);
        }

        private void ChangeScore()
        {
            OnChanged(null);
        }

    }
}
