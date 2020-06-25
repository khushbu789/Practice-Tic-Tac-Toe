using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
   
    public partial class Form1 : Form
    {
        bool turn = true;
        bool winner = false;
        int count = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button_click(object sender, EventArgs e)
        {
            try
            {
                Button b = (Button)sender;
                if (turn == true)
                {
                    b.Text = "X";
                    turn = false;
                }
                else
                {
                    b.Text = "O";
                    turn = true;
                }
                count = count + 1;
                b.Enabled = false;
                if (count != 9)
                {
                    check_winner();

                }

                else
                {
                    check_winner();

                }
            }
            catch(Exception f) {
                Console.WriteLine(f);
            }

        }
        public void check_winner() {
            //MessageBox.Show("xyz","abc");
            try {
                if ((A1.Text == A2.Text) && (A2.Text == A3.Text) && !A1.Enabled)
                {
                    winner = true;
                    displayWinner();
                }
                if ((B1.Text == B2.Text) && (B2.Text == B3.Text) && !B1.Enabled)
                {
                    winner = true;
                    displayWinner();
                }
                if ((C1.Text == C2.Text) && (C2.Text == C3.Text) && !C1.Enabled)
                {
                    winner = true;
                    displayWinner();
                }
                if ((A1.Text == B2.Text) && (B2.Text == C3.Text) && !A1.Enabled)
                {
                    winner = true;
                    displayWinner();
                }
                if ((A3.Text == B2.Text) && (B2.Text == C1.Text) && !C1.Enabled)
                {
                    winner = true;
                    displayWinner();
                }

                if ((A1.Text == B1.Text) && (B1.Text == C1.Text) && !C1.Enabled)
                {
                    winner = true;
                    displayWinner();
                }
                if ((A2.Text == B2.Text) && (B2.Text == C2.Text) && !C2.Enabled)
                {
                    winner = true;
                    displayWinner();
                }
                if ((A3.Text == B3.Text) && (B3.Text == C3.Text) && !C3.Enabled)
                {
                    winner = true;
                    displayWinner();
                }
                else if(!winner)
                {
                    draw_game();
                }
            }
            catch
                { }
            
        }
        public void draw_game() {
            if (count == 9 && !winner) { 
            MessageBox.Show("It's a draw","Result of Tic Tac Toe");}
        }
        public void disable_button() {
            try
            {
                foreach (Control c in Controls)
                {
                    Button button = (Button)c;
                    button.Enabled = false;
                }

            }
            catch(InvalidCastException e) {
                Console.WriteLine(e);
            }
        }
        public void displayWinner() {
            disable_button();
            if (turn == true)
            {
                MessageBox.Show("O is the Winner!", "Results of Tic Tac Toe");
            }
            else {
                MessageBox.Show("X is the Winner!", "Results of Tic Tac Toe");
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This game is created by Khushbu Shah","Abou the Game");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
            

        private void newGmaeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
           // this.Dispose(false);
        }
    }
}
