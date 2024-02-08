// Form18.cs
using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assingment1MCQGame_AnyaScheinman
{
    public partial class Form18 : Form
    {
            public int Score => score;

        private Random random = new Random();
        private int num1, num2, correctAnswer;
        private int score = 0;
        private int operationCounter = 0;
        private int maxOperations = 10; // Set the maximum number of operations
        private static int totalScore = 0; // تخزين النتائج الإجمالية

        public Form18()
        {
            InitializeComponent();
            ShowRandomProblem();
        }

        private void ShowRandomProblem()
        {
            if (operationCounter < maxOperations)
            {
                num1 = random.Next(1, 11);
                num2 = random.Next(1, 11);

                // Check if the division has no remainder
                while (num1 % num2 != 0)
                {
                    num1 = random.Next(1, 11);
                    num2 = random.Next(1, 11);
                }

                correctAnswer = num1 / num2;

                labelProblem.Text = $"{num1} ÷ {num2} = ?";
                GenerateChoices();
                operationCounter++;
            }
            else
            {
                EndGame();
            }
        }

        private void GenerateChoices()
        {
            int correctChoice = random.Next(0, 3);
            int[] choices = new int[3];

            for (int i = 0; i < 3; i++)
            {
                if (i == correctChoice)
                {
                    choices[i] = correctAnswer;
                }
                else
                {
                    int incorrectChoice = random.Next(1, 21);
                    while (incorrectChoice == correctAnswer || Array.IndexOf(choices, incorrectChoice) != -1)
                    {
                        incorrectChoice = random.Next(1, 21);
                    }
                    choices[i] = incorrectChoice;
                }
            }

            buttonChoice1.Text = choices[0].ToString();
            buttonChoice2.Text = choices[1].ToString();
            buttonChoice3.Text = choices[2].ToString();
        }

        private async void CheckAnswer(int selectedChoice)
        {
            if (selectedChoice == correctAnswer)
            {
                labelScore.Text = "Correct!";
                this.BackColor = Color.Green;

                // Increment the score before updating the UI
                score++;

                // Delay for 2 seconds (2000 milliseconds)
                await Task.Delay(2000);

                // Reset the UI to its original state
                labelScore.Text = $"Score: {score}";
                this.BackColor = SystemColors.Control; // You can set it to your original color
            }
            else
            {
                labelScore.Text = $"Incorrect! The correct answer is {correctAnswer}.";
                this.BackColor = Color.Red;

                // Delay for 2 seconds (2000 milliseconds)
                await Task.Delay(2000);

                // Reset the UI to its original state
                labelScore.Text = $"Score: {score}";
                this.BackColor = SystemColors.Control; // You can set it to your original color
            }

            ShowRandomProblem();
        }

        private void buttonChoice1_Click(object sender, EventArgs e)
        {
            CheckAnswer(int.Parse(buttonChoice1.Text));
        }

        private void buttonChoice2_Click(object sender, EventArgs e)
        {
            CheckAnswer(int.Parse(buttonChoice2.Text));
        }
        private void labelScore_Click(object sender, EventArgs e)
        {
            // Your code for the labelScore_Click event
        }


        private void buttonChoice3_Click(object sender, EventArgs e)
        {
            CheckAnswer(int.Parse(buttonChoice3.Text));
        }
        private void button1_Click(object sender, EventArgs e)
        {
            // Your code for the button1_Click event
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void EndGame()
        {
            DialogResult result = MessageBox.Show($"Game Over!\nYour final score is: {score}\nDo you want to play again?", "Game Over", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                // Restart the game by resetting variables and showing a new problem
                operationCounter = 0;
                score = 0;
                ShowRandomProblem();
            }
            else
            {
                // Close the form if the user chooses not to play again
                this.Hide();
                // Open Form8
                Form15 f = new Form15();
                f.Show();
            }

            totalScore += score; // إضافة نتيجة اللعبة الحالية إلى النتيجة الإجمالية
        }

        // إضافة دالة للحصول على النتيجة الإجمالية
        public static int GetTotalScore()
        {
            return totalScore;
        }
    }
}
