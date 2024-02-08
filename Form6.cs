using System;
using System.Windows.Forms;

namespace Assingment1MCQGame_AnyaScheinman
{
    public partial class Form6 : Form
    {
        private int score = 0;
        private int currentQuestionIndex = 0;
        private int totalQuestions;

        private string[] questions = {
    "هل النجم الذي يعطينا الضوء والحرارة هو الشمس؟",
    "هل الماء يغلي عند درجة حرارة 100 درجة مئوية؟",
    "هل تستغرق الأرض حوالي 24 ساعة للدوران حول نفسها؟",
    "هل السماء تكون زرقاء بسبب وجود الغاز أكسجين؟",
    "هل يأكل النحل اللحم؟",
    "هل تتنفس الأشجار ثاني أكسيد الكربون وتخرج الأكسجين؟",
    "هل يعيش الحمار الوحشي في البحار والمحيطات؟"
};


        private bool[] answers = {
    true,  // النجم الذي يعطينا الضوء والحرارة هو الشمس؟ (صح)
    false, // الماء يغلي عند درجة حرارة 100 درجة مئوية؟ (خطأ)
    true,  // الأرض تستغرق حوالي 24 ساعة للدوران حول نفسها؟ (صح)
    false, // السماء تكون زرقاء بسبب وجود الغاز أكسجين؟ (خطأ)
    false, // النحل يأكل اللحم؟ (خطأ)
    false, // الأشجار تتنفس ثاني أكسيد الكربون وتخرج الأكسجين؟ (خطأ)
};

        public Form6()
        {
            InitializeComponent();
            InitializeGame();
            DisplayQuestion();
        }

        private void InitializeGame()
        {
            totalQuestions = questions.Length;
        }

        private void DisplayQuestion()
        {
            if (currentQuestionIndex < totalQuestions)
            {
                label1.Text = questions[currentQuestionIndex];
                radioButtonTrue.Checked = false;
                radioButtonFalse.Checked = false;
            }
            else
            {
                ShowGameSummary();
            }
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            if (currentQuestionIndex < totalQuestions)
            {
                if (radioButtonTrue.Checked || radioButtonFalse.Checked)
                {
                    bool userAnswer = radioButtonTrue.Checked;

                    if (currentQuestionIndex < answers.Length) // Check if index is within bounds
                    {
                        if (userAnswer == answers[currentQuestionIndex])
                        {
                            MessageBox.Show("Correct!");
                            score++;
                        }
                        else
                        {
                            MessageBox.Show("Incorrect!");
                        }

                        currentQuestionIndex++;

                        if (currentQuestionIndex < totalQuestions)
                        {
                            DisplayQuestion();
                            labelScore.Text = $"Score: {score}"; // Update the score after displaying the question
                        }
                        else
                        {
                            ShowGameSummary();
                        }
                    }
                    else
                    {
                        MessageBox.Show($"Game Over!\nYour final score is: {score}\nCorrect Answers: {score}\nIncorrect Answers: {totalQuestions - score}",
                                            "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Please choose an answer!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }


        private void ShowGameSummary()
        {
            // Display the final score
            MessageBox.Show($"Game Over!\nYour final score is: {score}\nCorrect Answers: {score}\nIncorrect Answers: {totalQuestions - score}",
                            "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }







        private void Form6_Load(object sender, EventArgs e)
        {
        }
       


        private void radioButtonTrue_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.Close();

            // Open Form3
            Form7 f = new Form7();
            f.Show();
        }
    }
}