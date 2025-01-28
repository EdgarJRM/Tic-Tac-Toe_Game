namespace Tic_Tac_ToeGame
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            btnTic1 = new Button();
            btnTic2 = new Button();
            btnTic6 = new Button();
            btnTic5 = new Button();
            btnTic4 = new Button();
            btnTic9 = new Button();
            btnTic8 = new Button();
            btnTic7 = new Button();
            panel1 = new Panel();
            btnTic3 = new Button();
            groupBox1 = new GroupBox();
            tbx_PlayerO = new TextBox();
            tbx_PlayerX = new TextBox();
            lblPlayerO = new Label();
            lblPlayerX = new Label();
            exit = new Button();
            button11 = new Button();
            newGame = new Button();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(150, -5);
            label1.Name = "label1";
            label1.Size = new Size(267, 45);
            label1.TabIndex = 0;
            label1.Text = "Tic Tac Toe in C#";
            // 
            // btnTic1
            // 
            btnTic1.Font = new Font("Segoe UI", 48F, FontStyle.Bold);
            btnTic1.Location = new Point(0, 0);
            btnTic1.Name = "btnTic1";
            btnTic1.Size = new Size(90, 90);
            btnTic1.TabIndex = 1;
            btnTic1.UseVisualStyleBackColor = true;
            btnTic1.Click += btnTic1_Click_1;
            // 
            // btnTic2
            // 
            btnTic2.Font = new Font("Segoe UI", 48F, FontStyle.Bold);
            btnTic2.Location = new Point(96, 0);
            btnTic2.Name = "btnTic2";
            btnTic2.Size = new Size(90, 90);
            btnTic2.TabIndex = 2;
            btnTic2.UseVisualStyleBackColor = true;
            btnTic2.Click += btnTic2_Click;
            // 
            // btnTic6
            // 
            btnTic6.Font = new Font("Segoe UI", 48F, FontStyle.Bold);
            btnTic6.Location = new Point(192, 96);
            btnTic6.Name = "btnTic6";
            btnTic6.Size = new Size(90, 90);
            btnTic6.TabIndex = 6;
            btnTic6.UseVisualStyleBackColor = true;
            btnTic6.Click += btnTic6_Click;
            // 
            // btnTic5
            // 
            btnTic5.Font = new Font("Segoe UI", 48F, FontStyle.Bold);
            btnTic5.Location = new Point(96, 96);
            btnTic5.Name = "btnTic5";
            btnTic5.Size = new Size(90, 90);
            btnTic5.TabIndex = 5;
            btnTic5.UseVisualStyleBackColor = true;
            btnTic5.Click += btnTic5_Click;
            // 
            // btnTic4
            // 
            btnTic4.Font = new Font("Segoe UI", 48F, FontStyle.Bold);
            btnTic4.Location = new Point(0, 96);
            btnTic4.Name = "btnTic4";
            btnTic4.Size = new Size(90, 90);
            btnTic4.TabIndex = 4;
            btnTic4.UseVisualStyleBackColor = true;
            btnTic4.Click += btnTic4_Click;
            // 
            // btnTic9
            // 
            btnTic9.Font = new Font("Segoe UI", 48F, FontStyle.Bold);
            btnTic9.Location = new Point(192, 192);
            btnTic9.Name = "btnTic9";
            btnTic9.Size = new Size(90, 90);
            btnTic9.TabIndex = 9;
            btnTic9.UseVisualStyleBackColor = true;
            btnTic9.Click += btnTic9_Click;
            // 
            // btnTic8
            // 
            btnTic8.Font = new Font("Segoe UI", 48F, FontStyle.Bold);
            btnTic8.Location = new Point(96, 192);
            btnTic8.Name = "btnTic8";
            btnTic8.Size = new Size(90, 90);
            btnTic8.TabIndex = 8;
            btnTic8.UseVisualStyleBackColor = true;
            btnTic8.Click += btnTic8_Click;
            // 
            // btnTic7
            // 
            btnTic7.Font = new Font("Segoe UI", 48F, FontStyle.Bold);
            btnTic7.Location = new Point(0, 192);
            btnTic7.Name = "btnTic7";
            btnTic7.Size = new Size(90, 90);
            btnTic7.TabIndex = 7;
            btnTic7.UseVisualStyleBackColor = true;
            btnTic7.Click += btnTic7_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(btnTic3);
            panel1.Controls.Add(btnTic9);
            panel1.Controls.Add(btnTic1);
            panel1.Controls.Add(btnTic8);
            panel1.Controls.Add(btnTic2);
            panel1.Controls.Add(btnTic7);
            panel1.Controls.Add(btnTic4);
            panel1.Controls.Add(btnTic6);
            panel1.Controls.Add(btnTic5);
            panel1.Location = new Point(12, 43);
            panel1.Name = "panel1";
            panel1.Size = new Size(282, 282);
            panel1.TabIndex = 10;
            // 
            // btnTic3
            // 
            btnTic3.Font = new Font("Segoe UI", 48F, FontStyle.Bold);
            btnTic3.Location = new Point(192, 0);
            btnTic3.Name = "btnTic3";
            btnTic3.Size = new Size(90, 90);
            btnTic3.TabIndex = 10;
            btnTic3.UseVisualStyleBackColor = true;
            btnTic3.Click += btnTic3_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.HighlightText;
            groupBox1.Controls.Add(tbx_PlayerO);
            groupBox1.Controls.Add(tbx_PlayerX);
            groupBox1.Controls.Add(lblPlayerO);
            groupBox1.Controls.Add(lblPlayerX);
            groupBox1.Controls.Add(exit);
            groupBox1.Controls.Add(button11);
            groupBox1.Controls.Add(newGame);
            groupBox1.Controls.Add(pictureBox2);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(327, 42);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(239, 282);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "Enter the names of the players";
            // 
            // tbx_PlayerO
            // 
            tbx_PlayerO.Location = new Point(124, 114);
            tbx_PlayerO.Name = "tbx_PlayerO";
            tbx_PlayerO.PlaceholderText = "Player 2";
            tbx_PlayerO.Size = new Size(89, 27);
            tbx_PlayerO.TabIndex = 20;
            // 
            // tbx_PlayerX
            // 
            tbx_PlayerX.Location = new Point(19, 114);
            tbx_PlayerX.Name = "tbx_PlayerX";
            tbx_PlayerX.PlaceholderText = "Player 1";
            tbx_PlayerX.Size = new Size(90, 27);
            tbx_PlayerX.TabIndex = 19;
            // 
            // lblPlayerO
            // 
            lblPlayerO.AutoSize = true;
            lblPlayerO.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPlayerO.Location = new Point(156, 140);
            lblPlayerO.Name = "lblPlayerO";
            lblPlayerO.Size = new Size(23, 25);
            lblPlayerO.TabIndex = 18;
            lblPlayerO.Text = "0";
            // 
            // lblPlayerX
            // 
            lblPlayerX.AutoSize = true;
            lblPlayerX.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPlayerX.Location = new Point(50, 140);
            lblPlayerX.Name = "lblPlayerX";
            lblPlayerX.Size = new Size(23, 25);
            lblPlayerX.TabIndex = 17;
            lblPlayerX.Text = "0";
            // 
            // exit
            // 
            exit.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            exit.ForeColor = SystemColors.ControlText;
            exit.Location = new Point(124, 220);
            exit.Name = "exit";
            exit.Size = new Size(90, 50);
            exit.TabIndex = 16;
            exit.Text = "Exit";
            exit.UseVisualStyleBackColor = true;
            exit.Click += exit_Click;
            // 
            // button11
            // 
            button11.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button11.ForeColor = SystemColors.ControlText;
            button11.Location = new Point(19, 220);
            button11.Name = "button11";
            button11.Size = new Size(90, 50);
            button11.TabIndex = 15;
            button11.Text = "Reset";
            button11.UseVisualStyleBackColor = true;
            button11.Click += button11_Click;
            // 
            // newGame
            // 
            newGame.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            newGame.ForeColor = SystemColors.ControlText;
            newGame.Location = new Point(19, 164);
            newGame.Name = "newGame";
            newGame.Size = new Size(195, 50);
            newGame.TabIndex = 14;
            newGame.Text = "New Game";
            newGame.UseVisualStyleBackColor = true;
            newGame.Click += newGame_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(124, 23);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(90, 90);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 13;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.X;
            pictureBox1.Location = new Point(19, 23);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(90, 90);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGreen;
            ClientSize = new Size(581, 342);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(6);
            Name = "Form1";
            Text = "Tic Tac Toe";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnTic1;
        private Button btnTic2;
        private Button btnTic6;
        private Button btnTic5;
        private Button btnTic4;
        private Button btnTic9;
        private Button btnTic8;
        private Button btnTic7;
        private Panel panel1;
        private GroupBox groupBox1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button button11;
        private Button newGame;
        private Button exit;
        private Label lblPlayerO;
        private Label lblPlayerX;
        private Button btnTic3;
        private TextBox tbx_PlayerO;
        private TextBox tbx_PlayerX;
    }
}
