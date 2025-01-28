using System;
using System.IO;
using System.Diagnostics.Metrics;
using System.Runtime.Intrinsics.Arm;
using System.Windows.Forms;

namespace Tic_Tac_ToeGame
{
    public partial class Form1 : Form
    {
        static string path = "records.txt";
        string winner = "Player X";
        Boolean checker;
        int plusone;

        void Enable_False(Boolean start = false)
        {
            btnTic1.Enabled = start;
            btnTic2.Enabled = start;
            btnTic3.Enabled = start;
            btnTic4.Enabled = start;
            btnTic5.Enabled = start;
            btnTic6.Enabled = start;
            btnTic7.Enabled = start;
            btnTic8.Enabled = start;
            btnTic9.Enabled = start;

        }

        void win(string letter)
        {
            if (letter == "X")
            {
                plusone = int.Parse(lblPlayerX.Text);
                lblPlayerX.Text = Convert.ToString(plusone + 1);
                winner = tbx_PlayerX.Text;
            }
            else
            {
                plusone = int.Parse(lblPlayerO.Text);
                lblPlayerO.Text = Convert.ToString(plusone + 1);
                winner = tbx_PlayerO.Text;
            }

            if (winner == "")
            {
                MessageBox.Show("The winner is Player " + letter, "Tic Tac Toe Game", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"The winner is {winner}", "Tic Tac Toe Game", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            reset();
            Enable_False(true);
            checker = false;
        }

        void reset()
        {
            btnTic1.Text = "";
            btnTic2.Text = "";
            btnTic3.Text = "";
            btnTic4.Text = "";
            btnTic5.Text = "";
            btnTic6.Text = "";
            btnTic7.Text = "";
            btnTic8.Text = "";
            btnTic9.Text = "";

            btnTic1.BackColor = Color.WhiteSmoke;
            btnTic2.BackColor = Color.WhiteSmoke;
            btnTic3.BackColor = Color.WhiteSmoke;
            btnTic4.BackColor = Color.WhiteSmoke;
            btnTic5.BackColor = Color.WhiteSmoke;
            btnTic6.BackColor = Color.WhiteSmoke;
            btnTic7.BackColor = Color.WhiteSmoke;
            btnTic8.BackColor = Color.WhiteSmoke;
            btnTic9.BackColor = Color.WhiteSmoke;
        }
        void score(string letter)
        {
            if (btnTic1.Text == letter && btnTic2.Text == letter && btnTic3.Text == letter)
            {
                btnTic1.BackColor = Color.PowderBlue;
                btnTic2.BackColor = Color.PowderBlue;
                btnTic3.BackColor = Color.PowderBlue;
                win(letter);
            }

            if (btnTic1.Text == letter && btnTic4.Text == letter && btnTic7.Text == letter)
            {
                btnTic1.BackColor = Color.PowderBlue;
                btnTic4.BackColor = Color.PowderBlue;
                btnTic7.BackColor = Color.PowderBlue;
                win(letter);
            }
            if (btnTic1.Text == letter && btnTic5.Text == letter && btnTic9.Text == letter)
            {
                btnTic1.BackColor = Color.PowderBlue;
                btnTic5.BackColor = Color.PowderBlue;
                btnTic9.BackColor = Color.PowderBlue;
                win(letter);
            }

            if (btnTic3.Text == letter && btnTic5.Text == letter && btnTic7.Text == letter)
            {
                btnTic3.BackColor = Color.PowderBlue;
                btnTic5.BackColor = Color.PowderBlue;
                btnTic7.BackColor = Color.PowderBlue;
                win(letter);
            }
            if (btnTic2.Text == letter && btnTic5.Text == letter && btnTic8.Text == letter)
            {
                btnTic2.BackColor = Color.PowderBlue;
                btnTic5.BackColor = Color.PowderBlue;
                btnTic8.BackColor = Color.PowderBlue;
                win(letter);
            }
            if (btnTic2.Text == letter && btnTic5.Text == letter && btnTic8.Text == letter)
            {
                btnTic2.BackColor = Color.PowderBlue;
                btnTic5.BackColor = Color.PowderBlue;
                btnTic5.BackColor = Color.PowderBlue;
                win(letter);
            }
            if (btnTic3.Text == letter && btnTic6.Text == letter && btnTic9.Text == letter)
            {
                btnTic9.BackColor = Color.PowderBlue;
                btnTic6.BackColor = Color.PowderBlue;
                btnTic9.BackColor = Color.PowderBlue;
                win(letter);
            }
            if (btnTic4.Text == letter && btnTic5.Text == letter && btnTic6.Text == letter)
            {
                btnTic4.BackColor = Color.PowderBlue;
                btnTic5.BackColor = Color.PowderBlue;
                btnTic6.BackColor = Color.PowderBlue;
                win(letter);
            }
            if (btnTic7.Text == "X" && btnTic8.Text == "X" && btnTic9.Text == "X")
            {
                btnTic7.BackColor = Color.PowderBlue;
                btnTic8.BackColor = Color.PowderBlue;
                btnTic9.BackColor = Color.PowderBlue;
                win(letter);
            }
        }

        public static void SaveRecord(string playerName = "Player X", int score = 0)
        {
            string record = $"{playerName} has won {score} games"; 
            File.AppendAllText(path, record + Environment.NewLine); // Save the record to the end of the file.
            MessageBox.Show($"New record set: {record}", "Tic Tac Toe Game", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void ShowRecords()
        {
            if (File.Exists(path))
            {
                string[] records = File.ReadAllLines(path);

                string records_Saved = "Records saved: \n";
                foreach (var record in records)
                {
                    records_Saved += record + "\n";
                }
                MessageBox.Show(records_Saved, "Records de Tic Tac Toe");
            }
            else
            {
                MessageBox.Show("There are no records saved", "Tic Tac Toe Game", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnTic1_Click_1(object sender, EventArgs e)
        {
            btnTic1.Enabled = false;
            if (checker == false)
            {
                btnTic1.Text = "X";
                checker = true;
                score("X");
            }
            else
            {
                btnTic1.Text = "O";
                checker = false;
                score("O");
            }
        }
        private void btnTic2_Click(object sender, EventArgs e)
        {
            btnTic2.Enabled = false;
            if (checker == false)
            {
                btnTic2.Text = "X";
                checker = true;
                score("X");
            }
            else
            {
                btnTic2.Text = "O";
                checker = false;
                score("O");
            }
        }

        private void btnTic3_Click(object sender, EventArgs e)
        {
            btnTic3.Enabled = false;
            if (checker == false)
            {
                btnTic3.Text = "X";
                checker = true;
                score("X");
            }
            else
            {
                btnTic3.Text = "O";
                checker = false;
                score("O");
            }
        }

        private void btnTic4_Click(object sender, EventArgs e)
        {
            btnTic4.Enabled = false;
            if (checker == false)
            {
                btnTic4.Text = "X";
                checker = true;
                score("X");
            }
            else
            {
                btnTic4.Text = "O";
                checker = false;
                score("O");
            }
        }

        private void btnTic5_Click(object sender, EventArgs e)
        {
            btnTic5.Enabled = false;
            if (checker == false)
            {
                btnTic5.Text = "X";
                checker = true;
                score("X");
            }
            else
            {
                btnTic5.Text = "O";
                checker = false;
                score("O");
            }
        }

        private void btnTic6_Click(object sender, EventArgs e)
        {
            btnTic6.Enabled = false;
            if (checker == false)
            {
                btnTic6.Text = "X";
                checker = true;
                score("X");
            }
            else
            {
                btnTic6.Text = "O";
                checker = false;
                score("O");
            }
        }

        private void btnTic7_Click(object sender, EventArgs e)
        {
            btnTic7.Enabled = false;
            if (checker == false)
            {
                btnTic7.Text = "X";
                checker = true;
                score("X");
            }
            else
            {
                btnTic7.Text = "O";
                checker = false;
                score("O");
            }
        }

        private void btnTic8_Click(object sender, EventArgs e)
        {
            btnTic8.Enabled = false;
            if (checker == false)
            {
                btnTic8.Text = "X";
                checker = true;
                score("X");
            }
            else
            {
                btnTic8.Text = "O";
                checker = false;
                score("O");
            }
        }

        private void btnTic9_Click(object sender, EventArgs e)
        {
            btnTic9.Enabled = false;
            if (checker == false)
            {
                btnTic9.Text = "X";
                checker = true;
                score("X");
            }
            else
            {
                btnTic9.Text = "O";
                checker = false;
                score("O");
            }
        }

        private void newGame_Click(object sender, EventArgs e)
        {
            int score = 0;
            string winner = "";
            if (int.Parse(lblPlayerX.Text)> int.Parse(lblPlayerO.Text))
            {
                score = int.Parse(lblPlayerX.Text);
                if (tbx_PlayerX.Text == "") {
                    winner = "Player 1";
                }
                else
                {
                    winner = tbx_PlayerX.Text;
                }
                SaveRecord(winner, score);
            }
            else if (int.Parse(lblPlayerX.Text) > int.Parse(lblPlayerO.Text))
            {
                score = int.Parse(lblPlayerO.Text);
                if (tbx_PlayerO.Text == "")
                {
                    winner = "Player 2";
                }
                else
                {
                    winner = tbx_PlayerO.Text;
                }
                SaveRecord(winner, score);
            }
            else
            {
                MessageBox.Show("There was no winner, you were tied", "Tic Tac Toe Game", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            lblPlayerX.Text = "0";
            lblPlayerO.Text = "0";
            Enable_False(true);
            reset();
            checker = false;
        }

        private void exit_Click(object sender, EventArgs e)
        {
            ShowRecords();
            Close();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Enable_False(true);
            ShowRecords();
            reset();
            checker = false;
        }
    }
}
