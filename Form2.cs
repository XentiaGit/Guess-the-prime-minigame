using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guess_The_Prime
{
    public partial class result_form : Form
    {
        int points;

        public result_form(int p, int[] correct_answers, int[] player_answers)
        {
            points = p;
            InitializeComponent();
            score.Text = points.ToString() + "/10";
            scoreProgressBar.Increment(Convert.ToInt32(points / 10.0 * 100));

            String answer;
            for (int i = 1; i <= 10; i++) {

                if (correct_answers[i] == player_answers[i])
                    answer = i.ToString() + " : " + "Your answer is Correct, it is: " + player_answers[i].ToString() + "\n";
                else
                    answer = i.ToString() + " : " + "Your answer is Incorrect, it is: " + player_answers[i].ToString() + " ,Correct answer is: " + correct_answers[i].ToString() + "\n";
                mAnswersList.Items.Add(answer);
            }

            //choses the color of the score label based on the points
            if (points <= 3)
                score.BackColor = Color.Red;

            else if (points > 3 && points <= 6)
                score.BackColor = Color.Orange;

            else
                score.BackColor = Color.Green;
        }

        private void replay_btn_Click(object sender, EventArgs e)
        {
            playing_field field = new playing_field();
            this.Hide();
            field.Show();
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void result_form_Load(object sender, EventArgs e)
        {

        }
    }
}
