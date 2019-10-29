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
    public partial class playing_field : Form
    {
        List<int> primes, odds, evens;
        HashSet<int> found, usedNumbers;
        HashSet<Button> usedButtons;
        Button[] btns;
        int win, choice, points = 0, round = 0;
        int[] player_answers = new int[11];
        int[] correct_answers = new int[11];

        /*
            the standard way to take the answer is to convert the text of the button to an integer 
            choice = Convert.ToInt32(btn.Text);
            then compare it with the right solution and increment the points if it matches the right solution
            points = choice == win ? points + 1 : points;
            then we start another round using method fill()
        */

        private void btn3_Click(object sender, EventArgs e)
        {
            choice = Convert.ToInt32(btn3.Text);
            points = choice == win ? points + 1 : points;
            fill();
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            choice = Convert.ToInt32(btn4.Text);
            points = choice == win ? points + 1 : points;
            fill();
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            choice = Convert.ToInt32(btn5.Text);
            points = choice == win ? points + 1 : points;
            fill();
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            choice = Convert.ToInt32(btn6.Text);
            points = choice == win ? points + 1 : points;
            fill();
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            choice = Convert.ToInt32(btn7.Text);
            points = choice == win ? points + 1 : points;
            fill();
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            choice = Convert.ToInt32(btn8.Text);
            points = choice == win ? points + 1 : points;
            fill();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            choice = Convert.ToInt32(btn2.Text);
            points = choice == win ? points + 1 : points;
            fill();
        }

        private void btn1_Click(object sender, EventArgs e)
        {

            choice = Convert.ToInt32(btn1.Text);
            points = choice == win ? points + 1 : points;
            fill();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            choice = Convert.ToInt32(btn0.Text);
            points = choice == win ? points + 1 : points;
            fill();
        }

        public playing_field()
        {
            InitializeComponent();

            MessageBox.Show("This game consist of 10 rounds \nwith each round there is one prime integer \nguess as many as you can :-)");

            primes = new List<int>();
            odds = new List<int>();
            evens = new List<int>();
            found = new HashSet<int>();
            usedNumbers = new HashSet<int>();
            usedButtons = new HashSet<Button>();
            btns = new Button[] {btn0, btn1, btn2,
                                 btn3, btn4, btn5,
                                 btn6, btn7, btn8};

            generate();
            fill();
        }

        private void generate() {

            bool flag;
            for (int i = 2; i < 2500; i++) {
                flag = true;
                foreach(int prime in found)
                    if (i % prime == 0) { flag = false; break; }

                if (flag) {
                    primes.Add(i);
                    found.Add(i);
                    continue;
                }

                if (i % 2 == 0)
                    evens.Add(i);
                else
                    odds.Add(i);
            }
        }

        private void fill()
        {


            int oddCount, evenCount, primeCount;
            int oddMult = 20;
            int evenMult = 50;
            int primeMult = 10;
            oddCount = evenCount = primeCount = 0;

            //saves the player choice to be displayed at the end of the game
            if(round >= 1)
                player_answers[round] = choice;

            round++;
            Random rand, indexRand = new Random();

            if (round > 10)
            {

                result_form form = new result_form(points, correct_answers, player_answers);
                form.Show();
                this.Hide();
                return;
            }

            int index, btnIndex;
            while (oddCount < 5) {

                rand = new Random();
                index = rand.Next((round - 1) * oddMult, round * oddMult);
                btnIndex = indexRand.Next(0, 9);

                if (!usedButtons.Contains(btns[btnIndex]) && !usedNumbers.Contains(odds[index]))
                {
                    oddCount++;
                    btns[btnIndex].Text = odds[index].ToString();
                    usedButtons.Add(btns[btnIndex]);
                    usedNumbers.Add(odds[index]);
                }
            }

            while (evenCount < 3){

                rand = new Random();
                index = rand.Next((round - 1) * evenMult, round * evenMult);
                btnIndex = indexRand.Next(0, 9);

                if (!usedButtons.Contains(btns[btnIndex]) && !usedNumbers.Contains(evens[index]))
                {
                    evenCount++;
                    btns[btnIndex].Text = evens[index].ToString();
                    usedButtons.Add(btns[btnIndex]);
                    usedNumbers.Add(evens[index]);
                }
            }

            while (primeCount < 1)
            {

                rand = new Random();
                index = rand.Next((round - 1) * primeMult, round * primeMult);
                btnIndex = indexRand.Next(0, 9);

                if (!usedButtons.Contains(btns[btnIndex]) && !usedNumbers.Contains(primes[index]))
                {
                    primeCount++;
                    btns[btnIndex].Text = primes[index].ToString();
                    usedButtons.Add(btns[btnIndex]);
                    usedNumbers.Add(primes[index]);
                    win = primes[index];
                    correct_answers[round] = win;
                }
            }
            //we reset the variables for use in later rounds
            usedButtons.Clear();
            choice = 0;

            

        }

        
    }
}
