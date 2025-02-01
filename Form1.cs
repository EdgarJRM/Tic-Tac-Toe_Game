using System;
using System.IO;
using System.Diagnostics.Metrics;
using System.Runtime.Intrinsics.Arm;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Runtime.InteropServices;
using System.Data;

namespace Tic_Tac_ToeGame
{
    public partial class Form1 : Form
    {
        // Path to store game records / Ruta para almacenar los registros del juego
        static string path = "records.txt";

        // Variables to track the winner, turn checker, and score increment / Variables para el ganador, el turno y el incremento de puntaje
        string winner = "Player X";
        Boolean checker;
        int plusone;

        // Disable or enable all buttons / Deshabilitar o habilitar todos los botones
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

        // Function to determine the winner / Función para determinar el ganador
        void win(string letter)
        {
            //Add the score and record the name of the winner / Agrega la puntuación y registra el nombre del ganador
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

            // Display winner message / Mostrar mensaje del ganador
            if (winner == "")
            {
                MessageBox.Show("The winner is Player " + letter, "Tic Tac Toe Game", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"The winner is {winner}", "Tic Tac Toe Game", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            reset(); // Reset the game / Reiniciar el juego
            Enable_False(true); // Disable buttons / Deshabilitar botones
            checker = false; // Makes the game start with the letter X / Hace que el juego comience con la letra X
        }

        // Reset the game board / Reiniciar el tablero del juego
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

        // Check if there is a winning combination / Verificar si hay una combinación ganadora
        void score(string letter)
        {
            if (btnTic1.Text == letter && btnTic2.Text == letter && btnTic3.Text == letter)
            {
                btnTic1.BackColor = Color.PowderBlue;
                btnTic2.BackColor = Color.PowderBlue;
                btnTic3.BackColor = Color.PowderBlue;
                win(letter); // Declare the winner / Declarar el ganador
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



        /// <summary>
        /// Struct / Union used to write to the file
        /// The FileRecord will hold a name or date record
        /// </summary>
        [StructLayout(LayoutKind.Explicit)]
        public struct FileRecord
        {
            [FieldOffset(0)]
            public string nameRecord;

            [FieldOffset(0)]
            public string dateRecord;

            /// <summary>
            /// override ToString to return the value,
            /// since nameRecord and dateRecord are in the same offset
            /// using either one will work
            /// </summary>
            /// <returns></returns>
            public override string ToString()
            {
                return nameRecord;
            }
        }

        public static void SaveRecord(string playerName = "Player X", int score = 0)
        {
            // Save the date
            FileRecord newRecord = new FileRecord { dateRecord = DateTime.Now.ToString() };
            newRecord.nameRecord = $"{newRecord.dateRecord} {playerName} has won {score} games";
            File.AppendAllText(path, newRecord.ToString() + Environment.NewLine); // Save the record to the end of the file.

            MessageBox.Show($"New record set: {newRecord.nameRecord}", "Tic Tac Toe Game", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Display saved records / Mostrar registros guardados
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

        // Event handler for button clicks / Manejador de eventos para clics en botones
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

        // Start a new game / Iniciar un nuevo juego
        private void newGame_Click(object sender, EventArgs e)
        {
            int score = 0;
            string winner = "";
            if (int.Parse(lblPlayerX.Text) > int.Parse(lblPlayerO.Text))
            {
                score = int.Parse(lblPlayerX.Text);
                if (tbx_PlayerX.Text == "")
                {
                    winner = "Player 1";
                }
                else
                {
                    winner = tbx_PlayerX.Text;
                }
                SaveRecord(winner, score);
            }
            else if (int.Parse(lblPlayerX.Text) < int.Parse(lblPlayerO.Text))
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

        // Exit the game and show records / Salir del juego y mostrar registros
        private void exit_Click(object sender, EventArgs e)
        {
            ShowRecords();
            Close();
        }

        // Reset the board or create a new one without altering the score obtained so far / Reinicia el tablero o crea uno nuevo sin alterar la puntuación obtenida hasta el momento
        private void btnReset_Click(object sender, EventArgs e)
        {
            Enable_False(true);
            ShowRecords();
            reset();
            checker = false;
        }
    }
}