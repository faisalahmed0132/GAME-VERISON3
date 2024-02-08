using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assingment1MCQGame_AnyaScheinman
{
    public partial class Form20 : Form
    {
        Dictionary<string, string> landmarks = new Dictionary<string, string>()
{
    {"القدس", "عاصمة فلسطين"},
    {"الحركة المسؤولة عن طوفان الأقصى", "حماس"},
    {"مدينة فلسطينية هامة", "رام الله"},
    {"الحرب بدأت سنة", "1967"},
    {"أحد المعالم الدينية البارزة", "مسجد الاقصى"}
};



        IEnumerator<KeyValuePair<string, string>> landmarksEnumerator;
        private int score; // Assuming the score variable is accessible in the Form20 class

        public Form20()
        {
            InitializeComponent();
            StartGame();
        }

        private void StartGame()
        {
            landmarksEnumerator = landmarks.GetEnumerator();
            DisplayNextQuestion();
        }

        private void DisplayNextQuestion()
        {
            if (landmarksEnumerator.MoveNext())
            {
                KeyValuePair<string, string> landmark = landmarksEnumerator.Current;
                lblQuestion.Text = $"ما هو {landmark.Key}؟";
            }
            else
            {
                MessageBox.Show("تهانينا! لقد أجبت على جميع الأسئلة.");
                ShowQuizResult(); // Call the ShowQuizResult() method when all questions are answered
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string userAnswer = txtAnswer.Text.Trim();
            KeyValuePair<string, string> landmark = landmarksEnumerator.Current;

            if (userAnswer == landmark.Value)
            {
                MessageBox.Show("إجابة صحيحة! أحسنت.");
                score++; // Assuming you want to increment the score for correct answers
            }
            else
            {
                MessageBox.Show($"إجابة خاطئة. {landmark.Key} هو {landmark.Value}.");
            }

            txtAnswer.Clear();
            DisplayNextQuestion();
        }

        private void txtAnswer_TextChanged(object sender, EventArgs e)
        {
            // You can add any necessary logic here for text changed event
        }

        private void ShowQuizResult()
        {
            // Determine the form to show based on the score
            Form nextForm;

            if (score == 3)
            {
                nextForm = new Form25(); // Show Form23 if the score is 3
            }
            else if (score >= 4 && score <= 7)
            {
                nextForm = new Form26(); // Show Form21 if the score is between 4 and 7 (inclusive)
            }
            else
            {
                nextForm = new Form25(); // Default to Form23 for other scores
            }

            // Close the current form and show the determined next form
            this.Hide();
            nextForm.Show();
        }
    }
}
