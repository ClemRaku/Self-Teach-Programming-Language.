namespace Super_Tic_Toe
{
    public partial class Form1 : Form
    {
        public enum Player
        {
            X, O
        }
        Player currentPlayer;
        Random random = new Random();
        int playerWinCount = 0;
        int CPUWinCount = 0;
        List<Button> buttons;
        public Form1()
        {
            InitializeComponent();
            Restart_Game();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void CPU_move(object sender, EventArgs e)
        {
            if (buttons.Count > 0)
            {
                int index = random.Next(buttons.Count);
                buttons[index].Enabled = false;
                currentPlayer = Player.O;
                buttons[index].Text = currentPlayer.ToString();
                buttons[index].BackColor = Color.Red;
                buttons.RemoveAt(index);
                Check_Game();
                CPU_Timer.Stop();
            }
        }

        private void Player_Click_Button(object sender, EventArgs e)
        {
            var button = (Button)sender;

            currentPlayer = Player.X;
            button.Text = currentPlayer.ToString();
            button.Enabled = false;
            button.BackColor = Color.Cyan;
            buttons.Remove(button);
            Check_Game();
            CPU_Timer.Start();
        }

        private void Restart_Game(object sender, EventArgs e)
        {
            Restart_Game();
        }

        private void Check_Game()
        {
            if (button1.Text == "X" && button2.Text == "X" && button3.Text == "X"
                || button1.Text == "X" && button4.Text == "X" && button7.Text == "X"
                || button4.Text == "X" && button5.Text == "X" && button6.Text == "X"
                || button2.Text == "X" && button5.Text == "X" && button8.Text == "X"
                || button3.Text == "X" && button6.Text == "X" && button9.Text == "X"
                || button7.Text == "X" && button8.Text == "X" && button9.Text == "X"
                || button1.Text == "X" && button5.Text == "X" && button9.Text == "X"
                || button7.Text == "X" && button5.Text == "X" && button3.Text == "X"
                )
            {
                CPU_Timer.Stop();
                MessageBox.Show("Player Wins", "Clement Says");
                playerWinCount++;
                textBox1.Text = "Player WIns: " + playerWinCount;
                Restart_Game();
            }
            else if (button1.Text == "O" && button2.Text == "O" && button3.Text == "O"
                || button1.Text == "O" && button4.Text == "O" && button7.Text == "O"
                || button4.Text == "O" && button5.Text == "O" && button6.Text == "O"
                || button2.Text == "O" && button5.Text == "O" && button8.Text == "O"
                || button3.Text == "O" && button6.Text == "O" && button9.Text == "O"
                || button7.Text == "O" && button8.Text == "O" && button9.Text == "O"
                || button1.Text == "O" && button5.Text == "O" && button9.Text == "O"
                || button7.Text == "O" && button5.Text == "O" && button3.Text == "O"
                )
            {
                CPU_Timer.Stop();
                MessageBox.Show("CPU Wins", "Clement Says");
                CPUWinCount++;
                textBox2.Text = "Player WIns: " + CPUWinCount;
                Restart_Game();
            }
        }

        private void Restart_Game()
        {
            buttons = new List<Button> { button1, button2, button3, button4, button5, button6, button7, button8, button9 };
            foreach (Button x in buttons)
            {
                x.Enabled = true;
                x.Text = ".";
                x.BackColor = DefaultBackColor;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
