using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {

        private Game game;
        
        public Form1()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Normal;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Bounds = Screen.PrimaryScreen.Bounds;
            game = new Game(this, ref panel1, ref panel2, ref panel3, ref panel6);
            game.Start();
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            game.board.layoutBoard(ref panel1);
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            game.board.drawStack(panel2, 32);
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            game.board.drawStack(panel3, 32);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
