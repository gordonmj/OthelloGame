using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {

        private Game game;
        private System.Drawing.Graphics pG1;
        private System.Drawing.Graphics pG2;
        private System.Drawing.Graphics pG3;
        //private System.Drawing.Graphics pG4;
        //private System.Drawing.Graphics pG5;
        private System.Drawing.Graphics pG6;
        //private System.Drawing.Graphics pG7;
        Board board;
        Player leftPlayer;
        Player rightPlayer;
        Player blackPlayer;
        Player whitePlayer;
        DiscStack leftStack;
        DiscStack rightStack;
        bool noMoreMoves = false;
        bool gameStarted = false;
        private bool blackTurn = true;

        public Form1()
        {
            InitializeComponent();
            //this.WindowState = FormWindowState.Normal;
            //this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            //this.Bounds = Screen.PrimaryScreen.Bounds;

            game = new Game();
            board = game.getBoard();
            leftPlayer = game.getPlayer();
            rightPlayer = game.getPlayer();
            if (noMoreMoves)
            {
                //endgame
            }

            //blackTurn = game.takeTurn(blackTurn);
        }

        private void setTurn()
        {
            if (gameStarted)
            {
                if (blackTurn)
                {
                    WhoseTurn.Text = "Black's turn";
                    WhoseTurn.ForeColor = Color.Black;
                }
                else
                {
                    WhoseTurn.Text = "White's turn";
                    WhoseTurn.ForeColor = Color.White;
                }
            }

        }

        //private void panel5_Paint(object sender, PaintEventArgs e)
        //{
        //    pG5 = panel5.CreateGraphics();
        //}

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            pG1 = panel1.CreateGraphics();
            game.board.setUpBoard(panel1, pG1);
            game.board.layoutBoard();
            game.board.initConfig();
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {
            pG6 = panel6.CreateGraphics();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            pG2 = panel2.CreateGraphics();
            leftStack = new DiscStack(panel2);
            leftStack.setUpStack(pG2, panel2);
            leftStack.drawStack(32);
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            pG3 = panel3.CreateGraphics();
            rightStack = new DiscStack(panel3);
            rightStack.setUpStack(pG3, panel3);
            rightStack.drawStack(32);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void placeInitialConfigToolStripMenuItem_Click(object sender, EventArgs e)
        {
            game.board.initConfig();
        }

        private void leftPlayerInfo_Click(object sender, EventArgs e)
        {
        }

        private void rightPlayerInfo_Click(object sender, EventArgs e)
        {

        }

        private void chooseColors()
        {
            blackPlayer = game.assignColor(leftPlayer, rightPlayer);
            if (ReferenceEquals(blackPlayer, leftPlayer))
            {
                whitePlayer = rightPlayer;
                leftPlayerScore.ForeColor = Color.Black;
                LeftDiscsLeft.ForeColor = Color.Black;
                rightPlayerScore.ForeColor = Color.White;
                RightDiscsLeft.ForeColor = Color.White;
                MessageBox.Show("Color chosen randomly: Left is black and right is white.");
                game.blackStack = leftStack;
                game.whiteStack = rightStack;
            }
            else
            {
                leftPlayerScore.ForeColor = Color.White;
                LeftDiscsLeft.ForeColor = Color.White;
                rightPlayerScore.ForeColor = Color.Black;
                RightDiscsLeft.ForeColor = Color.Black;
                whitePlayer = leftPlayer;
                MessageBox.Show("Color chosen randomly: Right is black and left is white.");
                game.blackStack = rightStack;
                game.whiteStack = leftStack;
            }
            game.setPlayer(blackPlayer, whitePlayer);
        }

        private void chooseColorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (gameStarted)
            {
                MessageBox.Show("Already chosen.");
                return;
            }
            chooseColors();
            gameStarted = true;
            setTurn();
        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            int status = game.tryToPlace(e.Location, blackTurn);
            if (status == -1)
            {
                return;
            }
            updateScoreboard(blackPlayer.getScore(), whitePlayer.getScore());
            blackTurn = !blackTurn; //will have to move
            setTurn();
        }

        private void updateScoreboard(int newBlack, int newWhite)
        {
            if (whitePlayer == leftPlayer)
            {
                leftPlayerScore.Text = "Score: " + newWhite;
                LeftDiscsLeft.Text = "Discs left: " + whitePlayer.discsLeft;
                rightPlayerScore.Text = "Score: " + newBlack;
                RightDiscsLeft.Text = "Discs left: " + blackPlayer.discsLeft;
            }
            else
            {
                leftPlayerScore.Text = "Score: " + newBlack;
                LeftDiscsLeft.Text = "Discs left: " + blackPlayer.discsLeft;
                rightPlayerScore.Text = "Score: " + newWhite;
                RightDiscsLeft.Text = "Discs left: " + whitePlayer.discsLeft;
            }

        }

        private void WhoseTurn_Click(object sender, EventArgs e)
        {

        }

        private void switchTurnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            blackTurn = !blackTurn;
            setTurn();
        }

        private void justFlipToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void undoLastMoveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            game.undo();
        }

        private void hintToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int status = game.hint(blackTurn);
            if (status == -1)
            {
                return;
            }
            updateScoreboard(blackPlayer.getScore(), whitePlayer.getScore());
            blackTurn = !blackTurn; //will have to move
            setTurn();
        }
    }
}