using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Assingment1MCQGame_AnyaScheinman
{
    public partial class Form8 : Form
    {
        private Dictionary<string, string> animalsAndHints;
        private string currentAnimal;
        private List<string> answeredAnimals;
        private int correctCount;
        private int incorrectCount;

        public Form8()
        {
            InitializeComponent();
            InitializeAnimalsAndHints();
            answeredAnimals = new List<string>();
            correctCount = 0;
            incorrectCount = 0;
            StartNewGame();
        }

        private void InitializeAnimalsAndHints()
        {
            animalsAndHints = new Dictionary<string, string>
            {
   {"أسد", "ملك ذو مخالب حادة."},
    {"فيل", "حيوان ضخم يمتلك خرطومًا."},
    {"بطريق", "طائر لا يطير يعيش في البرودة."},
    {"سلحفاة", "حيوان غير سريع ولديه قوقعة."},
    {"فهد", "مفترس ذو بقع كبيرة."},
    {"ثعلب", "ذو فراء ذهبي يعيش في البراري."},
    {"وحيد القرن", "ثدي يمتلك قرنًا."},
    {"كوالا", "ثدي يعيش في أستراليا ويتغذى على أوراق."}
                // Add more animals and hints
            };
        }

        private void StartNewGame()
        {
            Random random = new Random();
            List<string> animalKeys = new List<string>(animalsAndHints.Keys);

            // Filter out already answered animals
            List<string> remainingAnimals = new List<string>(animalKeys);
            remainingAnimals.RemoveAll(answeredAnimals.Contains);

            if (remainingAnimals.Count > 0)
            {
                currentAnimal = remainingAnimals[random.Next(remainingAnimals.Count)];
                lblHint.Text = $" {animalsAndHints[currentAnimal]}";
                lblFeedback.Text = "Try to guess the animal!";
                btnGuess.Enabled = true;
                tbGuess.Text = "";
            }
            else
            {
                ShowEndGameMessage();
            }
        }

        private void btnGuess_Click(object sender, EventArgs e)
        {
            string userGuess = tbGuess.Text.ToLower();

            if (userGuess == currentAnimal && !answeredAnimals.Contains(currentAnimal))
            {
                lblFeedback.Text = "Congratulations! You guessed the animal!";
                btnGuess.Enabled = false;
                answeredAnimals.Add(currentAnimal);
                correctCount++;
            }
            else
            {
                lblFeedback.Text = "Wrong guess. Here's a hint!";
                incorrectCount++;
                MessageBox.Show($"( {animalsAndHints[currentAnimal]}", "Hint");
            }

            if (answeredAnimals.Count == animalsAndHints.Count)
            {
                ShowEndGameMessage();
            }
            else
            {
                StartNewGame();
            }
        }

        private void ShowEndGameMessage()
        {
            MessageBox.Show($"Game end! Your results:\nCorrect: {correctCount}\nIncorrect: {incorrectCount}", "Game Over", MessageBoxButtons.OK);
            this.Close();
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            answeredAnimals.Clear();
            correctCount = 0;
            incorrectCount = 0;
            StartNewGame();
        }

        private void tbGuess_TextChanged(object sender, EventArgs e)
        {
            // Your code for the tbGuess TextChanged event
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            // Your code for the Form8 Load event
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Your code for the label1 Click event
        }

        private void lblHint_Click(object sender, EventArgs e)
        {
            // Your code for the lblHint Click event
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();

            // Open Form8
            Form11 f = new Form11();
            f.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();

            // Open Form3
            Form7 f = new Form7();
            f.Show();
        }
    }
}
