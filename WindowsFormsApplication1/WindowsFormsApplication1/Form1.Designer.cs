namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.gameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chooseColorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.switchTurnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoLastMoveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hintToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flipManuallyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flipAutomaticallyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.RightDiscsLeft = new System.Windows.Forms.Label();
            this.LeftDiscsLeft = new System.Windows.Forms.Label();
            this.WhoseTurn = new System.Windows.Forms.Label();
            this.rightPlayerScore = new System.Windows.Forms.Label();
            this.leftPlayerScore = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.startGame = new System.Windows.Forms.Button();
            this.switchTurn = new System.Windows.Forms.Button();
            this.undo = new System.Windows.Forms.Button();
            this.hint = new System.Windows.Forms.Button();
            this.flipMan = new System.Windows.Forms.Button();
            this.flipAuto = new System.Windows.Forms.Button();
            this.saveGame = new System.Windows.Forms.Button();
            this.loadGame = new System.Windows.Forms.Button();
            this.resetGame = new System.Windows.Forms.Button();
            this.menuStrip2.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.Green;
            this.panel1.Location = new System.Drawing.Point(213, -102);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(860, 730);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseClick);
            // 
            // menuStrip2
            // 
            this.menuStrip2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(1387, 24);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // gameToolStripMenuItem
            // 
            this.gameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chooseColorsToolStripMenuItem,
            this.switchTurnToolStripMenuItem,
            this.undoLastMoveToolStripMenuItem,
            this.hintToolStripMenuItem,
            this.flipManuallyToolStripMenuItem,
            this.flipAutomaticallyToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.loadToolStripMenuItem,
            this.resetToolStripMenuItem});
            this.gameToolStripMenuItem.Name = "gameToolStripMenuItem";
            this.gameToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.gameToolStripMenuItem.Text = "Game";
            // 
            // chooseColorsToolStripMenuItem
            // 
            this.chooseColorsToolStripMenuItem.Name = "chooseColorsToolStripMenuItem";
            this.chooseColorsToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.chooseColorsToolStripMenuItem.Text = "Choose colors";
            this.chooseColorsToolStripMenuItem.Click += new System.EventHandler(this.chooseColorsToolStripMenuItem_Click);
            // 
            // switchTurnToolStripMenuItem
            // 
            this.switchTurnToolStripMenuItem.Name = "switchTurnToolStripMenuItem";
            this.switchTurnToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.switchTurnToolStripMenuItem.Text = "Switch turn";
            this.switchTurnToolStripMenuItem.Click += new System.EventHandler(this.switchTurnToolStripMenuItem_Click);
            // 
            // undoLastMoveToolStripMenuItem
            // 
            this.undoLastMoveToolStripMenuItem.Name = "undoLastMoveToolStripMenuItem";
            this.undoLastMoveToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.undoLastMoveToolStripMenuItem.Text = "Undo last move";
            this.undoLastMoveToolStripMenuItem.Click += new System.EventHandler(this.undoLastMoveToolStripMenuItem_Click);
            // 
            // hintToolStripMenuItem
            // 
            this.hintToolStripMenuItem.Name = "hintToolStripMenuItem";
            this.hintToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.hintToolStripMenuItem.Text = "Hint";
            this.hintToolStripMenuItem.Click += new System.EventHandler(this.hintToolStripMenuItem_Click);
            // 
            // flipManuallyToolStripMenuItem
            // 
            this.flipManuallyToolStripMenuItem.Name = "flipManuallyToolStripMenuItem";
            this.flipManuallyToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.flipManuallyToolStripMenuItem.Text = "Flip manually";
            this.flipManuallyToolStripMenuItem.Click += new System.EventHandler(this.flipManuallyToolStripMenuItem_Click);
            // 
            // flipAutomaticallyToolStripMenuItem
            // 
            this.flipAutomaticallyToolStripMenuItem.Name = "flipAutomaticallyToolStripMenuItem";
            this.flipAutomaticallyToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.flipAutomaticallyToolStripMenuItem.Text = "Flip automatically";
            this.flipAutomaticallyToolStripMenuItem.Click += new System.EventHandler(this.flipAutomaticallyToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.loadToolStripMenuItem.Text = "Load old game";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // resetToolStripMenuItem
            // 
            this.resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            this.resetToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.resetToolStripMenuItem.Text = "Reset";
            this.resetToolStripMenuItem.Click += new System.EventHandler(this.resetToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel2.Location = new System.Drawing.Point(103, 20);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(110, 550);
            this.panel2.TabIndex = 2;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panel6
            // 
            this.panel6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel6.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel6.Controls.Add(this.RightDiscsLeft);
            this.panel6.Controls.Add(this.LeftDiscsLeft);
            this.panel6.Controls.Add(this.WhoseTurn);
            this.panel6.Controls.Add(this.rightPlayerScore);
            this.panel6.Controls.Add(this.leftPlayerScore);
            this.panel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel6.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.panel6.Location = new System.Drawing.Point(213, 629);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(854, 118);
            this.panel6.TabIndex = 4;
            this.panel6.Paint += new System.Windows.Forms.PaintEventHandler(this.panel6_Paint);
            // 
            // RightDiscsLeft
            // 
            this.RightDiscsLeft.AutoSize = true;
            this.RightDiscsLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RightDiscsLeft.Location = new System.Drawing.Point(624, 65);
            this.RightDiscsLeft.Name = "RightDiscsLeft";
            this.RightDiscsLeft.Size = new System.Drawing.Size(214, 37);
            this.RightDiscsLeft.TabIndex = 4;
            this.RightDiscsLeft.Text = "Discs left: 40";
            // 
            // LeftDiscsLeft
            // 
            this.LeftDiscsLeft.AutoSize = true;
            this.LeftDiscsLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LeftDiscsLeft.Location = new System.Drawing.Point(4, 63);
            this.LeftDiscsLeft.Name = "LeftDiscsLeft";
            this.LeftDiscsLeft.Size = new System.Drawing.Size(214, 37);
            this.LeftDiscsLeft.TabIndex = 3;
            this.LeftDiscsLeft.Text = "Discs left: 40";
            // 
            // WhoseTurn
            // 
            this.WhoseTurn.AutoSize = true;
            this.WhoseTurn.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WhoseTurn.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.WhoseTurn.Location = new System.Drawing.Point(340, 33);
            this.WhoseTurn.Name = "WhoseTurn";
            this.WhoseTurn.Size = new System.Drawing.Size(203, 39);
            this.WhoseTurn.TabIndex = 2;
            this.WhoseTurn.Text = "Not Started";
            this.WhoseTurn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.WhoseTurn.Click += new System.EventHandler(this.WhoseTurn_Click);
            // 
            // rightPlayerScore
            // 
            this.rightPlayerScore.AutoSize = true;
            this.rightPlayerScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rightPlayerScore.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.rightPlayerScore.Location = new System.Drawing.Point(567, 5);
            this.rightPlayerScore.Name = "rightPlayerScore";
            this.rightPlayerScore.Size = new System.Drawing.Size(268, 42);
            this.rightPlayerScore.TabIndex = 1;
            this.rightPlayerScore.Text = "Bob\'s score: 2";
            this.rightPlayerScore.Click += new System.EventHandler(this.rightPlayerInfo_Click);
            // 
            // leftPlayerScore
            // 
            this.leftPlayerScore.AutoSize = true;
            this.leftPlayerScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leftPlayerScore.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.leftPlayerScore.Location = new System.Drawing.Point(3, 7);
            this.leftPlayerScore.Name = "leftPlayerScore";
            this.leftPlayerScore.Size = new System.Drawing.Size(284, 42);
            this.leftPlayerScore.TabIndex = 0;
            this.leftPlayerScore.Text = "Alice\'s score: 2";
            this.leftPlayerScore.Click += new System.EventHandler(this.leftPlayerInfo_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel3.Location = new System.Drawing.Point(1071, 20);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(110, 550);
            this.panel3.TabIndex = 5;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // panel4
            // 
            this.panel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel4.Location = new System.Drawing.Point(103, 576);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(107, 112);
            this.panel4.TabIndex = 6;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // panel5
            // 
            this.panel5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel5.Location = new System.Drawing.Point(1074, 578);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(107, 123);
            this.panel5.TabIndex = 7;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // startGame
            // 
            this.startGame.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.startGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startGame.ForeColor = System.Drawing.SystemColors.Desktop;
            this.startGame.Location = new System.Drawing.Point(1221, 43);
            this.startGame.Name = "startGame";
            this.startGame.Size = new System.Drawing.Size(154, 39);
            this.startGame.TabIndex = 8;
            this.startGame.Text = "Start Game";
            this.startGame.UseVisualStyleBackColor = true;
            // 
            // switchTurn
            // 
            this.switchTurn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.switchTurn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.switchTurn.ForeColor = System.Drawing.SystemColors.Desktop;
            this.switchTurn.Location = new System.Drawing.Point(1221, 110);
            this.switchTurn.Name = "switchTurn";
            this.switchTurn.Size = new System.Drawing.Size(154, 39);
            this.switchTurn.TabIndex = 9;
            this.switchTurn.Text = "Switch Turns";
            this.switchTurn.UseVisualStyleBackColor = true;
            // 
            // undo
            // 
            this.undo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.undo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.undo.ForeColor = System.Drawing.SystemColors.Desktop;
            this.undo.Location = new System.Drawing.Point(1221, 182);
            this.undo.Name = "undo";
            this.undo.Size = new System.Drawing.Size(154, 39);
            this.undo.TabIndex = 10;
            this.undo.Text = "Undo";
            this.undo.UseVisualStyleBackColor = true;
            this.undo.Click += new System.EventHandler(this.button1_Click);
            // 
            // hint
            // 
            this.hint.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.hint.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hint.ForeColor = System.Drawing.SystemColors.Desktop;
            this.hint.Location = new System.Drawing.Point(1221, 251);
            this.hint.Name = "hint";
            this.hint.Size = new System.Drawing.Size(154, 39);
            this.hint.TabIndex = 11;
            this.hint.Text = "Hint";
            this.hint.UseVisualStyleBackColor = true;
            // 
            // flipMan
            // 
            this.flipMan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.flipMan.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flipMan.ForeColor = System.Drawing.SystemColors.Desktop;
            this.flipMan.Location = new System.Drawing.Point(1221, 319);
            this.flipMan.Name = "flipMan";
            this.flipMan.Size = new System.Drawing.Size(154, 39);
            this.flipMan.TabIndex = 12;
            this.flipMan.Text = "Flip Manually";
            this.flipMan.UseVisualStyleBackColor = true;
            // 
            // flipAuto
            // 
            this.flipAuto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.flipAuto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flipAuto.ForeColor = System.Drawing.SystemColors.Desktop;
            this.flipAuto.Location = new System.Drawing.Point(1221, 384);
            this.flipAuto.Name = "flipAuto";
            this.flipAuto.Size = new System.Drawing.Size(154, 39);
            this.flipAuto.TabIndex = 13;
            this.flipAuto.Text = "Flip Auto";
            this.flipAuto.UseVisualStyleBackColor = true;
            // 
            // saveGame
            // 
            this.saveGame.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.saveGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveGame.ForeColor = System.Drawing.SystemColors.Desktop;
            this.saveGame.Location = new System.Drawing.Point(1221, 453);
            this.saveGame.Name = "saveGame";
            this.saveGame.Size = new System.Drawing.Size(154, 39);
            this.saveGame.TabIndex = 14;
            this.saveGame.Text = "Save Game";
            this.saveGame.UseVisualStyleBackColor = true;
            // 
            // loadGame
            // 
            this.loadGame.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.loadGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadGame.ForeColor = System.Drawing.SystemColors.Desktop;
            this.loadGame.Location = new System.Drawing.Point(1221, 519);
            this.loadGame.Name = "loadGame";
            this.loadGame.Size = new System.Drawing.Size(154, 39);
            this.loadGame.TabIndex = 15;
            this.loadGame.Text = "Load Game";
            this.loadGame.UseVisualStyleBackColor = true;
            // 
            // resetGame
            // 
            this.resetGame.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.resetGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetGame.ForeColor = System.Drawing.SystemColors.Desktop;
            this.resetGame.Location = new System.Drawing.Point(1221, 589);
            this.resetGame.Name = "resetGame";
            this.resetGame.Size = new System.Drawing.Size(154, 39);
            this.resetGame.TabIndex = 16;
            this.resetGame.Text = "Reset Game";
            this.resetGame.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1387, 750);
            this.Controls.Add(this.resetGame);
            this.Controls.Add(this.loadGame);
            this.Controls.Add(this.saveGame);
            this.Controls.Add(this.flipAuto);
            this.Controls.Add(this.flipMan);
            this.Controls.Add(this.hint);
            this.Controls.Add(this.undo);
            this.Controls.Add(this.switchTurn);
            this.Controls.Add(this.startGame);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip2);
            this.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gameToolStripMenuItem;
        private System.Windows.Forms.Label leftPlayerScore;
        private System.Windows.Forms.Label rightPlayerScore;
        private System.Windows.Forms.ToolStripMenuItem chooseColorsToolStripMenuItem;
        private System.Windows.Forms.Label LeftDiscsLeft;
        private System.Windows.Forms.Label WhoseTurn;
        private System.Windows.Forms.Label RightDiscsLeft;
        private System.Windows.Forms.ToolStripMenuItem switchTurnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoLastMoveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hintToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem flipManuallyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem flipAutomaticallyToolStripMenuItem;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem;
        private System.Windows.Forms.Button startGame;
        private System.Windows.Forms.Button switchTurn;
        private System.Windows.Forms.Button undo;
        private System.Windows.Forms.Button hint;
        private System.Windows.Forms.Button flipMan;
        private System.Windows.Forms.Button flipAuto;
        private System.Windows.Forms.Button saveGame;
        private System.Windows.Forms.Button loadGame;
        private System.Windows.Forms.Button resetGame;
    }
}
