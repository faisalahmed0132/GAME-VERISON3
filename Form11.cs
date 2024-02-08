using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Assingment1MCQGame_AnyaScheinman
{
    public partial class Form11 : Form
    {
        private List<QuizQuestion> questions;
        private int currentQuestionIndex = 0;
        private int score = 0;
        private Color defaultBackgroundColor;

        public Form11()
        {
            InitializeComponent();
            InitializeQuestions();
            ShowQuestion();

            // Save the default background color
            defaultBackgroundColor = lblScore.BackColor;
        }

        private void InitializeQuestions()
        {
            // Add your questions and answer choices here
            questions = new List<QuizQuestion>
{
    new QuizQuestion("ما هي عاصمة العراق؟", new List<string> { "بغداد", "بيروت", "القاهرة", "عمّان" }, "بغداد"),
    new QuizQuestion("ما هي عاصمة المملكة العربية السعودية؟", new List<string> { "الرياض", "جدة", "الدمام", "مكة المكرمة" }, "الرياض"),
    new QuizQuestion("ما هي عاصمة مصر؟", new List<string> { "القاهرة", "الإسكندرية", "الجيزة", "شرم الشيخ" }, "القاهرة"),
    new QuizQuestion("ما هي عاصمة المغرب؟", new List<string> { "الرباط", "الدار البيضاء", "فاس", "مراكش" }, "الرباط"),
    new QuizQuestion("ما هي عاصمة الجزائر؟", new List<string> { "الجزائر", "قسنطينة", "وهران", "تلمسان" }, "الجزائر"),
    new QuizQuestion("ما هي عاصمة تونس؟", new List<string> { "تونس", "صفاقس", "سوسة", "قابس" }, "تونس"),
    new QuizQuestion("ما هي عاصمة لبنان؟", new List<string> { "بيروت", "طرابلس", "صيدا", "جونية" }, "بيروت"),
};

        }

        private void ShowQuestion()
        {
            if (currentQuestionIndex < questions.Count)
            {
                lblScore.Text = questions[currentQuestionIndex].QuestionText;

                // Resetting the background color for each question
                lblScore.BackColor = defaultBackgroundColor;

                List<string> options = questions[currentQuestionIndex].Options;
                btnOption1.Text = options[0];
                btnOption2.Text = options[1];
                btnOption3.Text = options[2];
                btnOption4.Text = options[3];

                timerQuiz.Start();
            }
            
            else
            {
                // Ask the user if they want to play again
                DialogResult result = MessageBox.Show($"Quiz completed!\nYour score: {score} out of {questions.Count}\nDo you want to play again?", "Quiz Result", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (result == DialogResult.Yes)
                {
                    RestartGame();
                }
                else
                {
                    // Close the form and return to Form8
                    this.Hide();
                    Form7 form7 = new Form7();
                    form7.Show();
                }
            }
        }
        private void RestartGame()
        {
            // Reset variables
            currentQuestionIndex = 0;
            score = 0;

            // Show the first question
            ShowQuestion();
        }

        private void CheckAnswer(string selectedOption)
        {
            timerQuiz.Stop();

            if (questions[currentQuestionIndex].CorrectAnswer == selectedOption)
            {
                score++;

                // Optionally, you can set a specific message or perform additional actions
                lblScore1.BackColor = Color.Green; // Set background color to green
                lblScore1.Text = $"احسنت العمل الاجابة صحيحة\nScore: {score}";
            }
            else
            {
                lblScore1.BackColor = Color.Red; // Change label background to red for incorrect answer
                lblScore1.Text = $"خطأ! حاول مرة ثانية\nScore: {score}";
            }

            // Set up a timer to handle color change and delay before showing the score
            System.Windows.Forms.Timer resultTimer = new System.Windows.Forms.Timer();
            resultTimer.Interval = 2000; // 2000 milliseconds (2 seconds)
            resultTimer.Tick += (sender, e) =>
            {
                lblScore1.BackColor = defaultBackgroundColor; // Return to the original color
                lblScore1.Text = $"Score: {score}"; // Show the score
                resultTimer.Stop(); // Stop the timer
            };

            resultTimer.Start(); // Start the timer

            currentQuestionIndex++;
            ShowQuestion();

            this.Refresh();
            Application.DoEvents();
        }




        private void btnOption1_Click(object sender, EventArgs e)
        {
            CheckAnswer(btnOption1.Text);
        }


        private void btnOption2_Click(object sender, EventArgs e)
        {
            CheckAnswer(btnOption2.Text);
        }

        private void btnOption3_Click(object sender, EventArgs e)
        {
            CheckAnswer(btnOption3.Text);
        }

        private void btnOption4_Click(object sender, EventArgs e)
        {
            CheckAnswer(btnOption4.Text);
        }
        private void timerQuiz_TickbackgroundWorker1_ProgressChanged(object sender, EventArgs e)
        {
            // Your code here
        }
        private void lblQuestion_Click(object sender, EventArgs e)
        {
            // Your code here
        }


        private void timerQuiz_Tick(object sender, EventArgs e)
        {
            MessageBox.Show("Time's up! Moving to the next question.", "Time's Up", MessageBoxButtons.OK, MessageBoxIcon.Information);
            lblScore.BackColor = Color.Red; // Change label background to red for running out of time
            currentQuestionIndex++;
            ShowQuestion();

            this.Refresh();
            Application.DoEvents();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();

            // Open Form3
            Form7 f = new Form7();
            f.Show();
        }
    }

    public class QuizQuestion
    {
        public string QuestionText { get; }
        public List<string> Options { get; }
        public string CorrectAnswer { get; }

        public QuizQuestion(string questionText, List<string> options, string correctAnswer)
        {
            QuestionText = questionText;
            Options = options;
            CorrectAnswer = correctAnswer;
        }
    }
}
