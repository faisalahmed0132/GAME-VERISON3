using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Assingment1MCQGame_AnyaScheinman
{
    public partial class Form24 : Form
    {
        private List<MyCustomQuestion> questions;
        private int currentQuestionIndex = 0;
        private int score = 0;
        private Color defaultBackgroundColor;

        public Form24()
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
            questions = new List<MyCustomQuestion>
            {
                new MyCustomQuestion("ما هي عاصمة فلسطين؟", new List<string> { "القدس", "غزة", "رام الله", "نابلس" }, "القدس"),
                new MyCustomQuestion("ما هي عاصمة الضفة الغربية؟", new List<string> { "رام الله", "نابلس", "جنين", "بيت لحم" }, "رام الله"),
                new MyCustomQuestion("ما هي عاصمة قطاع غزة؟", new List<string> { "غزة", "رفح", "خان يونس", "دير البلح" }, "غزة"),
                new MyCustomQuestion("ما هي اللغة الرسمية في فلسطين؟", new List<string> { "العربية", "الإنجليزية", "الفرنسية", "الإسبانية" }, "العربية"),
                new MyCustomQuestion("ما هو اسم نهر فلسطين الرئيسي؟", new List<string> { "الأردن", "اليرموك", "الليطاني", "الزرقاء" }, "الأردن"),
                new MyCustomQuestion("ما هو اسم البحر الذي يطل على ساحل فلسطين؟", new List<string> { "البحر الأحمر", "البحر الأبيض المتوسط", "البحر الأسود", "بحر العرب" }, "البحر الأبيض المتوسط"),
                new MyCustomQuestion("ما هو اسم الجبل الذي يُعتبر أعلى قمة في فلسطين؟", new List<string> { "جبل الشيخ", "جبل الكرمل", "جبل الجرمق", "جبل جرزيم" }, "جبل الشيخ"),
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
                ShowQuizResult();
            }
        }

        private void ShowQuizResult()
        {
            // Determine the form to show based on the score
            Form nextForm;

            if (score == 3)
            {
                nextForm = new Form23(); // Show Form7 if the score is 3
            }
            else if (score >= 4 && score <= 7)
            {
                nextForm = new Form21(); // Show Form11 if the score is between 4 and 7 (inclusive)
            }
            else
            {
                nextForm = new Form23(); // Default to Form21 for other scores
            }

            // Close the current form and show the determined next form
            this.Hide();
            nextForm.Show();
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

        private void Form24_Load(object sender, EventArgs e)
        {

        }
    }

    // Change the class name from QuizQuestion to MyCustomQuestion
    public class MyCustomQuestion
    {
        public string QuestionText { get; }
        public List<string> Options { get; }
        public string CorrectAnswer { get; }

        public MyCustomQuestion(string questionText, List<string> options, string correctAnswer)
        {
            QuestionText = questionText;
            Options = options;
            CorrectAnswer = correctAnswer;
        }
    }
}
