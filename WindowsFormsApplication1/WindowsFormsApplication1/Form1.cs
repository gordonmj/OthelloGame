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
        private System.Drawing.Graphics pG4;
        private System.Drawing.Graphics pG5;
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
        private bool flipManual = false;
        public static bool hintOn = false;

        public Form1()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Normal;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Bounds = Screen.PrimaryScreen.Bounds;

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
            leftStack.drawStack(40);
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            pG3 = panel3.CreateGraphics();
            rightStack = new DiscStack(panel3);
            rightStack.setUpStack(pG3, panel3);
            rightStack.drawStack(40);
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
                pG5.FillEllipse(new SolidBrush(Color.White), 0, 0, panel4.Width, panel4.Width);
                pG4.FillEllipse(new SolidBrush(Color.Black), 0, 0, panel4.Width, panel4.Width);
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
                pG4.FillEllipse(new SolidBrush(Color.White), 0, 0, panel4.Width, panel4.Width);
                pG5.FillEllipse(new SolidBrush(Color.Black), 0, 0, panel4.Width, panel4.Width);
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
            if (!gameStarted)
            {
                MessageBox.Show("Choose colors first!");
                return;
            }
            if (flipManual)
            {
                int status = game.flipManual(e.Location);
                if (status == -1)
                {
                    return;
                }
                updateScoreboard(blackPlayer.getScore(), whitePlayer.getScore());
            }
            {
                int status = game.tryToPlace(e.Location, blackTurn);
                if (status == -1)
                {
                    return;
                }
                if (status == 0)
                {
                    MessageBox.Show("Illegal move!");
                    return;
                }

                updateScoreboard(blackPlayer.getScore(), whitePlayer.getScore());
                blackTurn = !blackTurn; //will have to move
                setTurn();
                if (hintOn)
                {
                    game.hint(blackTurn);
                }
                if (blackPlayer.getScore() + whitePlayer.getScore() >= 63)
                {
                    hintToolStripMenuItem_Click(sender, e);
                    hintToolStripMenuItem_Click(sender, e);
                }
            }



        }

        private void updateScoreboard(int newBlack, int newWhite)
        {
            if (whitePlayer == leftPlayer)
            {
                leftPlayerScore.Text = "Sophia's score: " + newWhite;
                LeftDiscsLeft.Text = "Discs left: " + whitePlayer.discsLeft;
                rightPlayerScore.Text = "Alex's score: " + newBlack;
                RightDiscsLeft.Text = "Discs left: " + blackPlayer.discsLeft;
            }
            else
            {
                leftPlayerScore.Text = "Sophia's score: " + newBlack;
                LeftDiscsLeft.Text = "Discs left: " + blackPlayer.discsLeft;
                rightPlayerScore.Text = "Alex's score: " + newWhite;
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
            hintOn = true;
            int status = game.hint(blackTurn);
            if (status == -1)
            {
                return;
            }
            else if (status == 0)
            {
                MessageBox.Show("No moves left for this player.");
                if (noMoreMoves)
                {
                    MessageBox.Show("Game over!");
                    if (leftPlayer.getScore() > rightPlayer.getScore())
                    {
                        MessageBox.Show("The winner is left player "+leftPlayer.getScore()+" to "+rightPlayer.getScore());
                    }
                    else if (leftPlayer.getScore() < rightPlayer.getScore())
                    {
                        MessageBox.Show("The winner is right player " + rightPlayer.getScore() + " to " + leftPlayer.getScore());
                    }
                    else
                    {
                        MessageBox.Show("It's a tie " + rightPlayer.getScore() + " to " + leftPlayer.getScore());
                    }
                    return;
                }
                noMoreMoves = true;
                blackTurn = !blackTurn; //will have to move
                setTurn();
            }
            //updateScoreboard(blackPlayer.getScore(), whitePlayer.getScore());
            //blackTurn = !blackTurn; //will have to move
            //setTurn();
        }

        private void flipManuallyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            flipManual = true;
            WhoseTurn.Text = "Manual flip mode";
        }

        private void flipAutomaticallyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            flipManual = false;
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

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            pG4 = panel4.CreateGraphics();
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {
            pG5 = panel5.CreateGraphics();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Text|*.txt";
            save.Title = "Save the image";
            String textToSave = game.board.boardToString();
            if (save.ShowDialog() == DialogResult.OK)
            {
                System.IO.File.WriteAllText(save.FileName, textToSave);
            }
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!gameStarted)
            {
                MessageBox.Show("Please start the game first by selecting Game > Choose Color");
                return;
            }
            OpenFileDialog oFD = new OpenFileDialog();
            oFD.Filter = "Plaintext Files|*.txt";
            oFD.Title = "Select a Plaintext File";
            if (oFD.ShowDialog() == DialogResult.OK)
            {
                String fileName = oFD.FileName;
                game.board.stringToBoard(fileName,blackPlayer,whitePlayer);
                updateScoreboard(blackPlayer.getScore(), whitePlayer.getScore());
                if (ReferenceEquals(leftPlayer, blackPlayer))
                {
                    leftStack.drawStack(blackPlayer.discsLeft);
                    rightStack.drawStack(whitePlayer.discsLeft);
                }
                else
                {
                    rightStack.drawStack(blackPlayer.discsLeft);
                    leftStack.drawStack(whitePlayer.discsLeft);
                }
            }

        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            game.board.clearBoard();
            game.board.setUpBoard(panel1, pG1);
            game.board.layoutBoard();
            game.board.initConfig();
            blackPlayer.setScore(2);
            whitePlayer.setScore(2);
            blackPlayer.discsLeft = 40;
            whitePlayer.discsLeft = 40;
            blackTurn = true;
            WhoseTurn.Text = "Black's turn";
            WhoseTurn.ForeColor = Color.Black; 
            updateScoreboard(blackPlayer.getScore(), whitePlayer.getScore());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            game.undo();
        }

        private void startGame_Click(object sender, EventArgs e)
        {
            chooseColorsToolStripMenuItem_Click(sender, e);
        }

        private void switchTurn_Click(object sender, EventArgs e)
        {
            switchTurnToolStripMenuItem_Click(sender, e);
        }

        private void hint_Click(object sender, EventArgs e)
        {
            hintToolStripMenuItem_Click(sender, e);
        }

        private void flipMan_Click(object sender, EventArgs e)
        {
            flipManual = true;
            WhoseTurn.Text = "Manual flip mode";
        }

        private void flipAuto_Click(object sender, EventArgs e)
        {
            flipAutomaticallyToolStripMenuItem_Click(sender, e);
        }

        private void saveGame_Click(object sender, EventArgs e)
        {
            saveToolStripMenuItem_Click(sender, e);
        }

        private void loadGame_Click(object sender, EventArgs e)
        {
            loadToolStripMenuItem_Click(sender, e);
        }

        private void resetGame_Click(object sender, EventArgs e)
        {
            resetToolStripMenuItem_Click(sender, e);
        }

        private void hintOff_Click(object sender, EventArgs e)
        {
            hintOn = false;
        }
    }
}